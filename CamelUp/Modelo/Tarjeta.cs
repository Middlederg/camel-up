using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Modelo
{
    public class Tarjeta
    {
        public Camel Camello { get; set; }
        public short Puntos { get; set; }

        public Tarjeta(Camel camello, short puntos)
        {
            Camello = camello;
            Puntos = puntos;
        }

        public override string ToString() => Puntos + " " + Camello.ToString();
       
    }
}
