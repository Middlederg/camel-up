using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Core.Model
{
    public class Loseta
    {
        private int? numeroCasilla;
        public TileType Tipo { get; set; }

        public (bool EstaColocada, int Numerocasilla) Colocada() => (numeroCasilla.HasValue, numeroCasilla ?? - 1);

        public bool Colocada(int numCas) => numeroCasilla.HasValue && numeroCasilla.Value == numCas;
      
        public int Resultado()
        {
            if (numeroCasilla == null) throw new ArgumentNullException("La Loseta está sin colocar");
            return Tipo.Equals(TileType.Avance) ? 1 : -1;
        }

        public void Colocar(Casilla casilla, TileType tipo)
        {
            numeroCasilla = casilla.Numero;
            Tipo = tipo;
        }

        public override string ToString()
        {
            if (numeroCasilla == null) return "Loseta sin colocar";
            return Tipo.ToString();
        }
    }
}
