using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CamelUp.Forms
{
    public static class General
    {
        /// <summary>
        /// Obtiene una imagen guardada como recurso
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static Image ObtenerRecurso(string nombre) => (Image)Properties.Resources.ResourceManager.GetObject(nombre);

        /// <summary>
        /// Superpone una lista de imagenes una encima de otra
        /// </summary>
        /// <param name="imagenes"></param>
        /// <param name="distanciaEntreImagenes"></param>
        /// <param name="escala"></param>
        /// <returns></returns>
        public static Bitmap GetImagenes(IEnumerable<Image> imagenes, int distanciaEntreImagenes = 240, double escala = 1.0)
        {
            distanciaEntreImagenes = (int)(distanciaEntreImagenes * escala);
            if (imagenes == null || imagenes.Count() == 0)
                throw new ArgumentNullException("imagenes no contiene ninguna imagen");

            Bitmap contenedor = new Bitmap((int)(imagenes.First().Width * escala), (int)((imagenes.First().Height + (imagenes.Count()) * distanciaEntreImagenes) * escala));

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(contenedor))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the images into the target bitmap
                int posY = 0;
                foreach (var image in imagenes)
                {
                    graphics.DrawImage(image, 0, posY, (int)(image.Width * escala), (int)(image.Height * escala));
                    posY += distanciaEntreImagenes;
                }
            }
            //return the resulting bitmap
            return contenedor;
        }
    }
}
