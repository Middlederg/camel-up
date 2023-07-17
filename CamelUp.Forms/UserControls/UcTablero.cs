using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CamelUp.Core.Model;

namespace CamelUp.Forms.UserControls
{
    public partial class UcTablero : UserControl
    {
        private int anchoCasilla;
        private int altoCasilla;
        private int paddingCasilla;
        private int paddingCamello;

        Juego j = new Juego(new string[] { "play1", "p2" });

        public UcTablero(double escala = 1.0, int anchoCas = 70, int altoCas = 200, int padCas = 10, int padCam = 10)
        {
            InitializeComponent();

            BackColor = Color.Transparent;
            //AutoScroll = true;

            anchoCasilla = (int) Math.Truncate(anchoCas * escala);
            altoCasilla = (int)Math.Truncate(altoCas * escala);
            paddingCasilla = (int)Math.Truncate(padCas * escala);
            paddingCamello = (int)Math.Truncate(padCam * escala);
        }

        private void DibujarTablero(List<Casilla> tablero)
        {
            int posX = 0;

            foreach (Control c in Controls.OfType<Panel>())
                Controls.Remove(c);

            Panel contenedor = new Panel()
            {
                Location = new Point(0, 0),
                Size = new Size(anchoCasilla * tablero.Count + paddingCasilla * 2, altoCasilla + paddingCasilla * 2),
                //BorderStyle = BorderStyle.Fixed3D
            };

            foreach (var casilla in tablero)
            {
                Panel pCas = new Panel()
                {
                    Name = "pCas" + casilla.Numero,
                    Width = anchoCasilla,
                    Height = altoCasilla,
                    BackColor = Color.Transparent,
                    BorderStyle = casilla.Numero == 17 || casilla.Numero == 0 ? BorderStyle.None : BorderStyle.FixedSingle,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Location = new Point(paddingCasilla + posX, paddingCasilla)
                };
                posX += anchoCasilla;

                if(casilla.Camellos.Any())
                {
                    pCas.Controls.Add(
                        new Panel()
                        {
                            Location = new Point(paddingCamello, (5 - casilla.Camellos.Count) * 10),
                            Size = new Size(anchoCasilla - (paddingCamello * 2), altoCasilla),
                            //BorderStyle = BorderStyle.FixedSingle,
                            BackgroundImage = General.GetImagenes(casilla.Camellos.Select(c => General.ObtenerRecurso(c.ToString().ToLower())).Reverse()),
                            BackgroundImageLayout = ImageLayout.Zoom
                        });
                }
                contenedor.Controls.Add(pCas);
            }
            Controls.Add(contenedor);
        }

        public void Redibujar(List<Casilla> tablero)
        {
            DibujarTablero(tablero);
        }

        private void BtnRedibujar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
