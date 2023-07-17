using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace CamelUp.Modelo
{
    public static class GameHelper
    {
        private static Random r = new Random(DateTime.Now.Millisecond);

        /// <summary>
        /// Numero aleatorio entre dos números, incluidos ambos
        /// </summary>
        /// <param name="inf">Número inferior</param>
        /// <param name="sup">Número superior</param>
        /// <returns></returns>
        public static int NumAleatorio(int inf, int sup) => r.Next(inf, sup + 1);

        public static List<Camel> GetCamellos()
        {

        }
    }
}
