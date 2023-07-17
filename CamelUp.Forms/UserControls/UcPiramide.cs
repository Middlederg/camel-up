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
    public partial class UcPiramide : UserControl
    {
        public UcPiramide()
        {
            InitializeComponent();

            FinDeRonda();
        }

        public void DadoLanzado(Camel camello, int resultado)
        {
            var label = TlpPrincipal.Controls.OfType<Label>().First(x => (Int32.Parse(x.Tag.ToString())) == ((int)camello));
            label.Text = resultado.ToString();
        }

        public void FinDeRonda() => TlpPrincipal.Controls.OfType<Label>().ToList().ForEach(x => x.Text = string.Empty);
    }
}
