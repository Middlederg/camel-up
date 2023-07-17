using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Modelo
{

    public class Loseta
    {
        private int? NumeroCasilla { get; set; }
        public TileType Tipo { get; set; }

        public bool Colocada() => NumeroCasilla.HasValue;
      
        public int Resultado()
        {
            if (NumeroCasilla == null) throw new ArgumentNullException("La Loseta está sin colocar");
            return Tipo.Equals(TileType.Avanzar) ? 1 : -1;
        }

        public override string ToString()
        {
            if (NumeroCasilla == null) return "Loseta sin colocar";
            return Tipo.ToString();
        }
    }
}
