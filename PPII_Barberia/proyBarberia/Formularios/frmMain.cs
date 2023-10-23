using proyBarberia.Controles;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace proyBarberia.Formularios
{
    public partial class frmMain : Form
    {
        private SqlConnection conexion;
        
        // Variables para el funcionamiento del movimiento del menú
        bool sidebarExpand;
        bool informeCollapse;

        // Asignación de los controles para meterlos en el panel
        ctrInicio ctrInicioNew = new ctrInicio();
        ctrTurnos ctrTurnosNew = new ctrTurnos();
        ctrClientes ctrClientesNew = new ctrClientes();
        ctrClientePremium ctrClientesPremiumNew = new ctrClientePremium();
        ctrBarberos ctrBarberosNew = new ctrBarberos();
        public frmMain(SqlConnection connection)
        {
            InitializeComponent();
            conexion = connection;
            this.FormClosed += frmMain_FormClosed; //establece la conexión entre el evento FormClosed del formulario y el método
                                                   //frmMain_FormClosed, lo que permite que el código en frmMain_FormClosed
                                                   //se ejecute cuando se cierre el formulario.
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
                conexion.Dispose();
            }
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlView.Controls.Add(ctrInicioNew);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // Hay que settear el tamaño minimo y maximo del panel sidebar
            if (sidebarExpand)
            {
                pnlSidebar.Width -= 10;
                if (pnlSidebar.Width == pnlSidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                pnlSidebar.Width += 10;
                if (pnlSidebar.Width == pnlSidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void informeTimer_Tick(object sender, EventArgs e)
        {
            if (informeCollapse)
            {
                pnlContenedorInformes.Height += 10;
                if (pnlContenedorInformes.Height == pnlContenedorInformes.MaximumSize.Height)
                {
                    informeCollapse = false;
                    informeTimer.Stop();
                }
            }
            else
            {
                pnlContenedorInformes.Height -= 10;
                if (pnlContenedorInformes.Height == pnlContenedorInformes.MinimumSize.Height)
                {
                    informeCollapse = true;
                    informeTimer.Stop();
                }

            }
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            informeTimer.Start();
        }

        // BOTONES DEL COSTADO IZQUIERDO DEL MENU

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(ctrInicioNew);
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(ctrTurnosNew);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(ctrClientesNew);
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(ctrClientesPremiumNew);
        }

        private void btnBarberos_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(ctrBarberosNew);
        }
    }

}
