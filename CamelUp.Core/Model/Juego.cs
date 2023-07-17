﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamelUp.Core.Repository;

namespace CamelUp.Core.Model
{
    public class Juego
    {
        public IEnumerable<Camel> Piramide { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public List<Casilla> Tablero { get; set; }
        public List<Tarjeta> TarjetasRonda { get; set; }
        public List<(Camel color,int jug)> ApuestasGanador { get; set; }
        public List<(Camel color, int jug)> ApuestasPerdedor { get; set; }
        public int Turno { get; set; }
        public int JugadorInicial { get; set; }

        public List<string> Log { get; set; }
	
        public Juego(string[] nombres = null)
        {
            Jugadores = new List<Jugador>();
            for (int i = 0; i < (nombres == null ? 2 : nombres.Length); i++)
                Jugadores.Add(new Jugador(i + 1, nombres == null ? "Player " + (i + 1) : nombres[i]));

            ResetGame();
        }
	
        public void ResetGame()
        {
            foreach (var jug in Jugadores)
                jug.Reset();

            //Inicializar tablero
            Tablero = new List<Casilla>();
            for (int i = 0; i < 18; i++)
                Tablero.Add(new Casilla(i));
            
            //Colocar los cinco camellos en la casilla 0
            Tablero[0].Camellos.AddRange(GameRepository.GetCamellos());

            Log = new List<string>();
            Turno = GameRepository.NumAleatorio(0, Jugadores.Count - 1);
            Log.Add(Jugadores[Turno].ToString() + " comienza la partida");

            ApuestasGanador = new List<(Camel color, int jug)>();
            ApuestasPerdedor = new List<(Camel color, int jug)>();
            TarjetasRonda = GameRepository.GetTarjetas().ToList();
            Piramide = GameRepository.GetCamellos();
        }


        /// <summary>
        /// Avanza turno solo cuando no ha terminado la partida
        /// </summary>
        public void AvanzaTurno()
        {
            //Comprobaciones
            if (EsFinPartida())
                FinalPartida();
            else
            {
                if (EsFinalRonda())
                    FinalRonda();
                else
                    Turno = Turno == Jugadores.Count - 1 ? 0 : Turno + 1;
            }
            
        }

        public bool EsFinalRonda() => !Piramide.Any();

        public void FinalRonda()
        {
            TarjetasRonda = GameRepository.GetTarjetas().ToList();
            Piramide = GameRepository.GetCamellos();
            foreach (Jugador jug in Jugadores)
                Log.Add(jug.FinDeRonda(Clasificacion().First(), Clasificacion()[1]));
            JugadorInicial = JugadorInicial == Jugadores.Count - 1 ? 0 : JugadorInicial + 1;
        }

        public bool EsFinPartida() => Tablero[16].Camellos.Any();

        public void FinalPartida()
        {
            FinalRonda();

            Log.Add("Aciertos por el primer clasificado:");
            ContabilizarAciertos(ApuestasGanador, Clasificacion().First());
            Log.Add("Aciertos por el último clasificado:");
            ContabilizarAciertos(ApuestasPerdedor, Clasificacion().Last());
        }

        private void ContabilizarAciertos(List<(Camel color, int jug)> apuestas, Camel camello)
        {
            int aciertos = 0;
            foreach (var (color, jug) in apuestas)
            {
                Jugador jugador = Jugadores.First(x => x.Id == jug);
                if (color.Equals(camello))
                {
                    int ganancia = GameRepository.PuntosApuestaFinal(aciertos);
                    Log.Add(jugador.Nombre + " gana " + ganancia + " apostando por el camello " + camello.ToString());
                    jugador.Dinero += ganancia;
                    aciertos++;
                }
                else
                {
                    Log.Add(jugador.Nombre + " pierde una moneda apostando por el camello " + camello.ToString());
                    jugador.Dinero += -1;
                }
            }
        }

        public Casilla PrimeraCasillaColocable() => Tablero.FirstOrDefault(x => x.LosetaColocable(Jugadores));

        public Jugador ElTurno() => Jugadores[Turno];

        public (Camel camello, int Resultado) LanzarDado(Jugador jug = null)
        {
            if (jug == null) jug = ElTurno();
            Camel camMover = GameRepository.CamelloMover(Piramide);
            int tirada = GameRepository.Tirada();
	        Log.Add(jug.Nombre + " saca un " + tirada + " en el dado " + camMover.ToString());

            jug.NumDadosLanzados++;
            MoverCamello(camMover, tirada);
            Piramide = Piramide.Where(x => !x.Equals(camMover));

            return (camMover, tirada);
        }
	
        public void MoverCamello(Camel camello, int numero)
        {
            var casillaDesde = GetCasilla(camello);
            var camellosSeMueven = casillaDesde.CamelloSale(camello);

            int objetivo = Math.Min(casillaDesde.Numero + numero, 17);
            var casillahasta = GetCasilla(objetivo);
            casillahasta.CamellosEntran(camellosSeMueven);
	        Log.Add(camello.ToString() + " avanza " + numero + " posiciones");
        }

        public Casilla GetCasilla(int numCasilla)
        {
            if (!Tablero.Any(x => x.Numero == numCasilla))
                throw new ArgumentOutOfRangeException("Casilla " + numCasilla + " no encontrada");
            return Tablero.Find(x => x.Numero == numCasilla);
        }

        /// <summary>
        /// Obtiene la casilla en la que está un camello
        /// </summary>
        /// <param name="camello"></param>
        /// <returns></returns>
        public Casilla GetCasilla(Camel camello) => Tablero.First(x => x.Camellos.Contains(camello));

        public void ColocarLoseta(int numCasilla, TileType tipo, Jugador jug = null)
        {
            if (jug == null) jug = ElTurno();
            Casilla c = GetCasilla(numCasilla);
            if (c.LosetaColocable(Jugadores))
                jug.ColocarLoseta(c, tipo);
            else
                throw new ArgumentException("No se puede colocar loseta en la casilla " + numCasilla);
		    Log.Add(jug.Nombre + " coloca una loseta de " + tipo.ToString() + " en la casilla " + numCasilla);
        }

        public Tarjeta GetTarjeta(Camel color) => TarjetasRonda.FirstOrDefault(x => x.Camello.Equals(color));

        public void CogerTarjeta(Camel camello, Jugador jug = null) 
        {
            if (jug == null) jug = ElTurno();
            Tarjeta tarjeta = GetTarjeta(camello);
            if (tarjeta == null)
                throw new ArgumentNullException("No quedan tarjetas del camello " + camello.ToString());
            Log.Add(jug.Nombre + " coge apuesta de ronda: " + tarjeta.ToString());
            jug.ApuestasRonda.Add(tarjeta);
            TarjetasRonda.Remove(tarjeta);
        }
	
        public void ApostarGanador(Camel camello, Jugador jug = null)
        {
            if (jug == null) jug = ElTurno();
            if (!jug.Cartas.Contains(camello))
                throw new ArgumentException(jug.Nombre + " no tiene una carta del camello " + camello.ToString());
            Log.Add(jug.Nombre + " apuesta por un ganador");
	        ApuestasGanador.Add((camello, jug.Id));
            jug.Cartas.Remove(camello);
        }
	
        public void ApostarPerdedor(Camel camello, Jugador jug = null)
        {
            if (jug == null) jug = ElTurno();
            if (!jug.Cartas.Contains(camello))
                throw new ArgumentException(jug.Nombre + " no tiene una carta del camello " + camello.ToString());
            Log.Add(jug.Nombre + " apuesta por un ganador");
            ApuestasPerdedor.Add((camello, jug.Id));
            jug.Cartas.Remove(camello);
        }

        public List<Camel> Clasificacion()
        {
            List<Camel> lista = new List<Camel>();
            lista.AddRange(Tablero.SelectMany(x => x.Camellos));
            lista.Reverse();
            return lista;
        }
    }
}