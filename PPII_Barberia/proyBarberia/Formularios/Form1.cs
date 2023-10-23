using proyBarberia.Formularios;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;
using System.Linq;
using System.Collections.Generic;
using proyBarberia.Controles;

namespace proyBarberia
{
    public partial class Form1 : Form
    {
        public string DevolverUser()
        {
            string aux = txtUsuario.Text;
            return aux;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadCustomFont()
        {
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("C:\\proyBarberia\\Resources\\30393_Pristina.ttf");

            Font customFont = new Font(privateFonts.Families[0], 12f, FontStyle.Regular);

            lblGianiBarberTitulo.Font = customFont;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            pnlGianiBarber.BackColor = Color.FromArgb(128, 30, 30, 30);
            RedondearEsquinasPanel(pnlGianiBarber, 50);

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "")
                {
                    txtUsuario.Text = "Ingrese el usuario";
                    return;
                }
                txtUsuario.ForeColor = Color.White;
                pnlUsuarioIncorrecto.Visible = false;
            }
            catch
            {
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtContraseña.Text == "")
                {
                    txtContraseña.Text = "Ingrese la contraseña";
                    return;
                }
                txtContraseña.ForeColor = Color.White;
                txtContraseña.PasswordChar = '*';
                pnlContraseniaIncorrecta.Visible = false;
            }
            catch
            {
            }
        }

        

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.SelectAll();
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.SelectAll();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.usuario == txtUsuario.Text && u.contrasenia == txtContraseña.Text).FirstOrDefault(); // Expresiones LANDA - Nos devuelve aquel usuario que tenga un usuario y contraseña igual a lo que escribimos en la caja de texto y que siempre retorne el primero o uno null 

            if (ousuario != null) {
                frmMain form = new frmMain();


                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto/s.", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
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
        private void RedondearEsquinasPanel(Panel panel, int radio)
        {
            // Crear un objeto GraphicsPath para definir el camino gráfico
            GraphicsPath path = new GraphicsPath();

            // Crear un rectángulo con las dimensiones del panel
            Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);

            // Crear el camino gráfico con las esquinas redondeadas
            path.AddArc(rect.X, rect.Y, radio, radio, 180, 90); // Esquina superior izquierda
            path.AddArc(rect.Width - radio, rect.Y, radio, radio, 270, 90); // Esquina superior derecha
            path.AddArc(rect.Width - radio, rect.Height - radio, radio, radio, 0, 90); // Esquina inferior derecha
            path.AddArc(rect.X, rect.Height - radio, radio, radio, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            // Establecer el camino gráfico como la región del panel
            panel.Region = new Region(path);
        }

        
    }
}

