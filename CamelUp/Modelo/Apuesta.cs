using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Modelo
{
    public class Apuesta
    {
        private Jugador jug;
        private Camel cam;

        public Apuesta(Jugador j, Camel c)
        {
            this.jug = j;
            this.cam = c;
        }

        public Jugador Jug
        {
            get
            {
                return jug;
            }
            set
            {
                jug = value;
            }
        }

        public Camel Camel
        {
            get
            {
                return cam;
            }
            set
            {
                cam = value;
            }
        }

        public override string ToString()
        {
            string res = jug.Nombre + " apuesta por el camello ";
            res += cam.Nombre;
            return res;
        }
    }
}
