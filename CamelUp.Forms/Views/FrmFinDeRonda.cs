using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CamelUp.Core.Model;

namespace CamelUp.Forms.Views
{
    public partial class FrmFinDeRonda : Form
    {
        IEnumerable<Jugador> jugadores;
        Camel primero;
        Camel segundo;
        public FrmFinDeRonda(IEnumerable<Jugador> jugs, Camel pri, Camel segun)
        {
            InitializeComponent();

            jugadores = jugs;
            primero = pri;
            segundo = segun;

            foreach (Jugador jug in jugadores)
            {
                LbxJugadores.Items.Add(jug.ToString() + " (" + jug.MonedasEnRonda(primero, segundo) + ")");
            }

            LbxJugadores.SelectedIndex = 0;
        }

        private void BtnOk_Click(object sender, EventArgs e) => Close();

        private void LbxJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblJugador.Text = string.Empty;
            foreach (var str in jugadores.ElementAt(LbxJugadores.SelectedIndex).DesgloseRonda(primero, segundo))
                LblJugador.Text += "- " + str + Environment.NewLine;
        }
    }
}
