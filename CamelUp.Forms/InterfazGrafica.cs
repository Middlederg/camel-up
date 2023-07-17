using CamelUp.Core.Model;
using CamelUp.Core.Repository;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CamelUp.Forms
{
    public enum Posicion
    {
        Primero = 1,
        Segundo = 2,
        Resto = 3
    }

    public static class InterfazGrafica
    {
        public static Bitmap ListaCamellos(Camel camello, Posicion pos)
        {
            List<Image> images = new List<Image>();
            images.Add(pos.Equals(Posicion.Primero) ? General.ObtenerRecurso(camello.ToString().ToLower()) : Properties.Resources.transparente);
            images.Add(pos.Equals(Posicion.Segundo) ? General.ObtenerRecurso(camello.ToString().ToLower()) : Properties.Resources.transparente);
            foreach (int num in Enumerable.Range(0, 3))
                images.Add(pos.Equals(Posicion.Resto) ? General.ObtenerRecurso(camello.ToString().ToLower()) : Properties.Resources.transparente);
            return General.GetImagenes(images);
        }
    }
}
