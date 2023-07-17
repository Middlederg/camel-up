using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Core.Model
{
    public class Tarjeta
    {
        public Camel Camello { get; set; }
        public int Puntos { get; set; }

        public Tarjeta(Camel camello, int puntos)
        {
            Camello = camello;
            Puntos = puntos;
        }

        public override string ToString() => Camello.ToString() + " (" + Puntos + ")";
       
    }
}
