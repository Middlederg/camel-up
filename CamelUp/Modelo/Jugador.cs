using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CamelUp.Modelo
{
    public class Jugador
    {
        const short DineroInicial = 3;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Camel Cartas { get; set; }
        public short Dinero { get; set; }
        public Loseta LosetaJugador { get; set; }

        /// <summary>
        /// Número de dados que el jugador ha lanzado en esta ronda
        /// </summary>
        public int NumDadosLanzados { get; set; }
	
	    public Jugador(int id, string nombre)
	    {
            Id = id;
            Nombre = nombre;
		    Enumerable.Range(1, 5).ToList().ForEach( x=>)
		    this.perfil = p;
		
		    this.dinero = DIN_INICIAL;
		    this.turno = turn;
		    this.tarjetasRonda = new List<Tarjeta>();
		    this.dadosLanzados = 0;
	    }

        /// <summary>
        /// Deja el jugador como al inicio de la partida
        /// </summary>
        public void reiniciar()
	    {
		    this.cartas = GameHelper.getCamellos();
		    this.dinero = DIN_INICIAL;
		    this.turno = false;
		    this.tarjetasRonda = new List<Tarjeta>();
		    this.dadosLanzados = 0;
	    }

        /// <summary>
        /// El jugador gana dinero
        /// </summary>
        /// <param name="moned">numero de monedas que gana el jugador</param>
	    public void gana(int moned)
	    {
		    dinero = dinero + moned;
	    }
	
        /// <summary>
        /// El jugador coge una tarjeta de apuesta de ronda
        /// </summary>
        /// <param name="t">Tarjeta a añadir</param>
	    public void addTarjeta(Tarjeta t)
	    {
		    tarjetasRonda.Add(t);
	    }
	
	    public override string ToString()
        {
		    string res = id + " - " + nombre + "";
            return res;
        }

        public bool Equals(Jugador j)
        {
            // If parameter is null return false:
            if ((object)j == null)
            {
                return false;
            }

            // Return false if the fields do not match:
            if (j.id != this.id)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return id ^ id;
        }
    }

}
