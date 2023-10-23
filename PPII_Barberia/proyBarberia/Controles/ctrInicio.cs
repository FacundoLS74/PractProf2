using proyBarberia.Formularios;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace proyBarberia.Controles
{
    public partial class ctrInicio : UserControl
    {
        public ctrInicio()
        {
            InitializeComponent();
        }

        private void ctrInicio_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            string fechaCompleta = DateTime.Now.ToLongDateString();

            string[] palabras = fechaCompleta.Split(' ');
            for (int i = 1; i < palabras.Length; i++)
            {
                palabras[i] = palabras[i].ToLower();
            }

            palabras[0] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(palabras[0].ToLower());
            string fechaFormateada = string.Join(" ", palabras);

            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = fechaFormateada;
        }
    }
}
