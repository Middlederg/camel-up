using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CamelUp.Core.Model;
using CamelUp.Forms.UserControls;

namespace CamelUp.Forms.Views
{
    public partial class FrmMainWindow : Form
    {
        private Juego j;
        private UcPiramide piramide;
        
        public FrmMainWindow(string[] nombres = null)
        {
            InitializeComponent();

            j = new Juego(nombres ?? new string[] { "Jorge", "Maider" });
            UcTablero tablero = new UcTablero() { Dock = DockStyle.Fill };
            TlpContenedor.Controls.Add(tablero, 0, 1);
            TlpContenedor.SetColumnSpan(tablero, TlpContenedor.ColumnCount);
            tablero.Redibujar(j.Tablero);

            piramide = new UcPiramide() { Dock = DockStyle.Fill, Margin = new Padding(20, 0, 0, 0 ) };
            piramide.Controls[0].Controls.OfType<PictureBox>().ToList().ForEach(x=> x.Click += Piramide_Click);
            TlpContenedor.Controls.Add(piramide, 0, 2);

            //TlpContenedor.Controls.Add(new UcApuesta(new Tarjeta(Camel.Azul, 3)), 0, 3);
            var apuestas = new UcApuestas(j.TarjetasRonda) { Dock = DockStyle.Fill};
            TlpContenedor.Controls.Add(new UcApuestas(j.TarjetasRonda), 1, 2);
            TlpContenedor.SetColumnSpan(apuestas, 2);
        }

        private void Piramide_Click(object sender, EventArgs e)
        {
            var (camello, Resultado) = j.LanzarDado();
            piramide.DadoLanzado(camello, Resultado);
            TlpContenedor.Controls.OfType<UserControls.UcTablero>().First().Redibujar(j.Tablero);

            if (j.EsFinalRonda() && !j.EsFinPartida())
            {
                new FrmFinDeRonda(j.Jugadores, j.Clasificacion().First(), j.Clasificacion()[1]).ShowDialog();
                piramide.FinDeRonda();
            }

            j.AvanzaTurno();
        }

        private void BtnClose_Click(object sender, EventArgs e) => Application.Exit();
        private void BtnMax_Click(object sender, EventArgs e) => WindowState = FormWindowState.Maximized;
        private void BtnMin_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void TituloDocleClik(object sender, EventArgs e) => WindowState = WindowState.Equals(FormWindowState.Maximized) ? 
            FormWindowState.Normal : FormWindowState.Maximized;
    }
}
