using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CamelUp.Core.Repository;
using CamelUp.Core.Model;

namespace CamelUp.Forms.UserControls
{
    public partial class UcApuesta : UserControl
    {
        public UcApuesta(Tarjeta apuesta)
        {
            InitializeComponent();

            //pGeneral.Controls.Add(img)
            pBoxPrimero.Image = InterfazGrafica.ListaCamellos(apuesta.Camello, Posicion.Primero);
            pBoxSegundo.Image = InterfazGrafica.ListaCamellos(apuesta.Camello, Posicion.Segundo);
            pBoxResto.Image = InterfazGrafica.ListaCamellos(apuesta.Camello, Posicion.Resto);
            LblPuntos.Text = apuesta.Puntos.ToString();
        }
    }
}
