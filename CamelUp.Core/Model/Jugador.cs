using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CamelUp.Core.Repository;

namespace CamelUp.Core.Model
{
    public class Jugador
    {
        const int DineroInicial = 3;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Camel> Cartas { get; set; }
        public int Dinero { get; set; }
        public Loseta LosetaJugador { get; set; }
        public List<Tarjeta> ApuestasRonda { get; set; }

        /// <summary>
        /// Número de dados que el jugador ha lanzado en esta ronda
        /// </summary>
        public int NumDadosLanzados { get; set; }
	
	    public Jugador(int id, string nombre)
	    {
            Id = id;
            Nombre = nombre;
            Reset();
	    }

        public void Reset()
	    {
            Cartas = GameRepository.GetCamellos().ToList();
            Dinero = DineroInicial;
            LosetaJugador = new Loseta();
            InicioRonda();
	    }

        public void InicioRonda()
        {
            ApuestasRonda = new List<Tarjeta>();
            NumDadosLanzados = 0;
        }

        /// <summary>
        ///  Devuelve las monedas que ganaría el jugador sis e terminase la ronda
        /// </summary>
        /// <param name="primero">Camello en primera posición</param>
        /// <param name="segundo">Camello en segunda posición</param>
        /// <returns></returns>
        public int MonedasEnRonda(Camel primero, Camel segundo)
        {
            return NumDadosLanzados + 
            ApuestasRonda.Where(x => x.Equals(primero)).Sum(x => x.Puntos) +                //Puntos por acertar camello ganador
            ApuestasRonda.Where(x => x.Equals(segundo)).Count() +                           //Puntos por acertar segundo
            ApuestasRonda.Where(x => !x.Equals(primero) && !x.Equals(segundo)).Count();     //Puntos por fallar
        }


        /// <summary>
        /// Finaliza la ronda para el jugador.
        /// Coge las monedas que le correspondan (devuelve mensaje con lo que haya ganado).
        /// Quita las tarjetas de apuesta de ronda y las de dados lanzados
        /// </summary>
        /// <param name="primero"></param>
        /// <param name="segundo"></param>
        /// <returns></returns>
        public string FinDeRonda(Camel primero, Camel segundo)
        {
            int monedas = MonedasEnRonda(primero, segundo);
            Dinero += monedas;
            InicioRonda();
            return Nombre + " consigue " + monedas + " monedas";
        }

        public IEnumerable<string> DesgloseRonda(Camel primero, Camel segundo)
        {
            if (NumDadosLanzados > 0)
                yield return NumDadosLanzados + " monedas por dados lanzados";

            foreach (var apuesta in ApuestasRonda)
            {
                if (apuesta.Camello.Equals(primero))
                    yield return apuesta.Puntos + " monedas por apostar por el camello " + apuesta.Camello.ToString();
                if (apuesta.Camello.Equals(segundo))
                    yield return "1 moneda por apostar por el camello " + apuesta.Camello.ToString();
                if (!apuesta.Camello.Equals(primero) && !apuesta.Camello.Equals(segundo))
                    yield return "Pierde una moneda por apostar por el camello " + apuesta.Camello.ToString();
            }
        }

        public void ColocarLoseta(Casilla cas, TileType tipo) => LosetaJugador.Colocar(cas, tipo);

        public override string ToString() => Nombre;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return ((Jugador)obj).Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }

}
