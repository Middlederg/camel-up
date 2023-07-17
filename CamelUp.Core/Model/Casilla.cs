using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Core.Model
{
    public class Casilla
    {
        public int Numero { get; set; }
        public List<Camel> Camellos { get; set; }

        public Casilla(int numero)
	    {
            if (Numero < 0 || Numero > 17)
                throw new ArgumentOutOfRangeException("Casilla debe estar entre 0 y 17");
            Numero = numero;
            Camellos = new List<Camel>();
	    }

        /// <summary>
        /// Camello sale de la casilla con todos los camellos que tenga encima
        /// </summary>
        /// <param name="camelloMueve"></param>
        /// <returns></returns>
        public IEnumerable<Camel> CamelloSale(Camel camelloMueve)
        {
            if (!Camellos.Contains(camelloMueve)) throw new ArgumentException("El camello " + camelloMueve.ToString() + " no está en la casilla " + Numero);

            if (Numero == 0) //En la casilla 0 solo se mueve un camello
            {
                Camellos.Remove(camelloMueve);
                return new List<Camel>() { camelloMueve };
            }
            //var camellos = Camellos.Where(x => Camellos.IndexOf(c) >= Camellos.IndexOf(x));
            bool encontrado = false;
            var camellos = new List<Camel>();
            foreach (var c in Camellos)
            {
                if (c.Equals(camelloMueve) || encontrado)
                {
                    camellos.Add(c);
                    encontrado = true;
                }
            }
            Camellos.RemoveAll(x=> camellos.Contains(x));
            return camellos;
        }

        /// <summary>
        /// Camellos llegan a la casilla y se ponen encima
        /// </summary>
        /// <param name="c"></param>
        public void CamellosEntran(IEnumerable<Camel> c) => Camellos.AddRange(c);

        public bool LosetaColocable(IEnumerable<Jugador> jugadores)
        {
            //Caso especial 1: la salida y la meta y la casilla inicial no son colocables
            if (Numero == 0 || Numero== 1 || Numero == 17)
                return false;

            //Caso especial 2: La ultima casilla (16) solo miras si hay loseta en la anterior
            if (jugadores.Any(x => x.LosetaJugador.Colocada(Numero) ||
                                  x.LosetaJugador.Colocada(Numero - 1)))
                return false;

            //Si algún jugador tiene colocada su loseta en esta casilla o en las adyacentes, no se puede colocar
            if (jugadores.Any(x =>  x.LosetaJugador.Colocada(Numero) ||
                                    x.LosetaJugador.Colocada(Numero - 1) ||
                                    x.LosetaJugador.Colocada(Numero + 1) ))
                return false;

            //No puede haber camellos para colocar la loseta
            return !Camellos.Any();
        }

        public override string ToString() => "Casilla " + Numero;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return ((Casilla)obj).Numero == Numero;
        }

        public override int GetHashCode() => Numero.GetHashCode();
    }
}
