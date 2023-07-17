using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CamelUp.Core.Model;
using CamelUp.Core.Repository;

namespace CamelUp.Forms.UserControls
{
    public partial class UcApuestas : UserControl
    {
        private int ancho = 150 / 2;
        private int alto = 180 / 2;
        private int padding = 20 / 2;

        public UcApuestas(List<Tarjeta> tarjetas)
        {
            InitializeComponent();

            Dibujar(tarjetas);
        }

        private void Dibujar(List<Tarjeta> tarjetas)
        {
            foreach (Control c in Controls.OfType<Panel>())
                Controls.Remove(c);

            Panel contenedor = new Panel()
            {
                Location = new Point(0, 0),
                Size = new Size(ancho * 5 + padding * 2, alto * 5 + padding * 2),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0)
            };

            int indx = 0;
            foreach (Camel camel in GameRepository.GetCamellos())
            {
                foreach (var tarjeta in tarjetas.Where(x=> x.Camello.Equals(camel)).OrderByDescending(x=> x.Puntos))
                {
                    UcApuesta pApuesta = new UcApuesta(tarjeta)
                    {
                        Name = "pTarjeta" + camel.ToString() + tarjeta.Puntos,
                        Width = ancho,
                        Height = alto,
                        BackColor = Color.Transparent,
                        Location = new Point(padding + (indx * ancho), padding)
                    };
                    indx++;
                    contenedor.Controls.Add(pApuesta);
                }
            }
            Controls.Add(contenedor);
        }

        public void Redibujar(List<Tarjeta> tarjetas)
        {
            Dibujar(tarjetas);
        }
    }
}
