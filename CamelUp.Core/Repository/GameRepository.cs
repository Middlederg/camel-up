using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CamelUp.Core.Model;

namespace CamelUp.Core.Repository
{
    public static class GameRepository
    {
        private static Random r = new Random(DateTime.Now.Millisecond);

        /// <summary>
        /// Numero aleatorio entre dos números, incluidos ambos
        /// </summary>
        /// <param name="inf">Número inferior</param>
        /// <param name="sup">Número superior</param>
        /// <returns></returns>
        public static int NumAleatorio(int inf, int sup) => r.Next(inf, sup + 1);

        public static T ElementoAleatorio<T>(IEnumerable<T> lista)
        {
            if (lista == null || !lista.Any()) return default(T);
            return lista.ElementAt(NumAleatorio(0, lista.Count() - 1));
        }

        public static int Tirada() => NumAleatorio(1, 3);

        public static Camel CamelloMover(IEnumerable<Camel> camellosPorMover) => ElementoAleatorio(camellosPorMover);

        public static IEnumerable<Camel> GetCamellos()
        {
            foreach (var camel in Enumerable.Range(1, 5))
                yield return (Camel)camel;
        }

        public static IEnumerable<Tarjeta> GetTarjetas()
        {
            foreach (var camel in Enumerable.Range(1, 5))
                foreach (var num in new int[] { 2, 3, 5})
                    yield return new Tarjeta((Camel)camel, num);
        }

        public static int PuntosApuestaFinal(int ordenAcierto)
        {
            switch (ordenAcierto)
            {
                case 0: return 8;
                case 1: return 5;
                case 2: return 3;
                case 3: return 2;
                default: return 1;
            }
        }
    }
}
