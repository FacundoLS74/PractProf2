namespace proyBarberia.Formularios
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.pnlTurnos = new System.Windows.Forms.Panel();
            this.btnTurnos = new FontAwesome.Sharp.IconButton();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.pnlPremium = new System.Windows.Forms.Panel();
            this.btnPremium = new FontAwesome.Sharp.IconButton();
            this.pnlBarberos = new System.Windows.Forms.Panel();
            this.btnBarberos = new FontAwesome.Sharp.IconButton();
            this.pnlContenedorInformes = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInfMensual = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInfSemanal = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInfDiario = new FontAwesome.Sharp.IconButton();
            this.pnlInformes = new System.Windows.Forms.Panel();
            this.btnInformes = new FontAwesome.Sharp.IconButton();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.informeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlTurnos.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlPremium.SuspendLayout();
            this.pnlBarberos.SuspendLayout();
            this.pnlContenedorInformes.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlInformes.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.pnlHome);
            this.pnlSidebar.Controls.Add(this.pnlTurnos);
            this.pnlSidebar.Controls.Add(this.pnlClientes);
            this.pnlSidebar.Controls.Add(this.pnlPremium);
            this.pnlSidebar.Controls.Add(this.pnlBarberos);
            this.pnlSidebar.Controls.Add(this.pnlContenedorInformes);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.MaximumSize = new System.Drawing.Size(200, 612);
            this.pnlSidebar.MinimumSize = new System.Drawing.Size(62, 580);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 612);
            this.pnlSidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 75);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(197, 75);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "              Menú";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnInicio);
            this.pnlHome.Location = new System.Drawing.Point(3, 84);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(197, 52);
            this.pnlHome.TabIndex = 1;
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnInicio.IconColor = System.Drawing.Color.White;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(197, 52);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "              Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlTurnos
            // 
            this.pnlTurnos.Controls.Add(this.btnTurnos);
            this.pnlTurnos.Location = new System.Drawing.Point(3, 142);
            this.pnlTurnos.Name = "pnlTurnos";
            this.pnlTurnos.Size = new System.Drawing.Size(197, 52);
            this.pnlTurnos.TabIndex = 2;
            // 
            // btnTurnos
            // 
            this.btnTurnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTurnos.FlatAppearance.BorderSize = 0;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnTurnos.IconColor = System.Drawing.Color.White;
            this.btnTurnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTurnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurnos.Location = new System.Drawing.Point(0, 0);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(197, 52);
            this.btnTurnos.TabIndex = 1;
            this.btnTurnos.Text = "              Turnos";
            this.btnTurnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurnos.UseVisualStyleBackColor = true;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.btnClientes);
            this.pnlClientes.Location = new System.Drawing.Point(3, 200);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(197, 52);
            this.pnlClientes.TabIndex = 2;
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(197, 52);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "              Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlPremium
            // 
            this.pnlPremium.Controls.Add(this.btnPremium);
            this.pnlPremium.Location = new System.Drawing.Point(3, 258);
            this.pnlPremium.Name = "pnlPremium";
            this.pnlPremium.Size = new System.Drawing.Size(197, 52);
            this.pnlPremium.TabIndex = 3;
            // 
            // btnPremium
            // 
            this.btnPremium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPremium.FlatAppearance.BorderSize = 0;
            this.btnPremium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremium.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.btnPremium.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(184)))), ((int)(((byte)(16)))));
            this.btnPremium.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPremium.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPremium.Location = new System.Drawing.Point(0, 0);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(197, 52);
            this.btnPremium.TabIndex = 1;
            this.btnPremium.Text = "              Premium";
            this.btnPremium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPremium.UseVisualStyleBackColor = true;
            this.btnPremium.Click += new System.EventHandler(this.btnPremium_Click);
            // 
            // pnlBarberos
            // 
            this.pnlBarberos.Controls.Add(this.btnBarberos);
            this.pnlBarberos.Location = new System.Drawing.Point(3, 316);
            this.pnlBarberos.Name = "pnlBarberos";
            this.pnlBarberos.Size = new System.Drawing.Size(197, 52);
            this.pnlBarberos.TabIndex = 4;
            // 
            // btnBarberos
            // 
            this.btnBarberos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBarberos.FlatAppearance.BorderSize = 0;
            this.btnBarberos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarberos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarberos.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnBarberos.IconColor = System.Drawing.Color.White;
            this.btnBarberos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBarberos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarberos.Location = new System.Drawing.Point(0, 0);
            this.btnBarberos.Name = "btnBarberos";
            this.btnBarberos.Size = new System.Drawing.Size(197, 52);
            this.btnBarberos.TabIndex = 1;
            this.btnBarberos.Text = "              Barberos";
            this.btnBarberos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarberos.UseVisualStyleBackColor = true;
            this.btnBarberos.Click += new System.EventHandler(this.btnBarberos_Click);
            // 
            // pnlContenedorInformes
            // 
            this.pnlContenedorInformes.Controls.Add(this.panel4);
            this.pnlContenedorInformes.Controls.Add(this.panel2);
            this.pnlContenedorInformes.Controls.Add(this.panel3);
            this.pnlContenedorInformes.Controls.Add(this.pnlInformes);
            this.pnlContenedorInformes.Location = new System.Drawing.Point(3, 374);
            this.pnlContenedorInformes.MaximumSize = new System.Drawing.Size(197, 234);
            this.pnlContenedorInformes.MinimumSize = new System.Drawing.Size(197, 52);
            this.pnlContenedorInformes.Name = "pnlContenedorInformes";
            this.pnlContenedorInformes.Size = new System.Drawing.Size(197, 56);
            this.pnlContenedorInformes.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnInfMensual);
            this.panel4.Location = new System.Drawing.Point(0, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 52);
            this.panel4.TabIndex = 6;
            // 
            // btnInfMensual
            // 
            this.btnInfMensual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInfMensual.FlatAppearance.BorderSize = 0;
            this.btnInfMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfMensual.IconChar = FontAwesome.Sharp.IconChar.DotCircle;
            this.btnInfMensual.IconColor = System.Drawing.Color.White;
            this.btnInfMensual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfMensual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfMensual.Location = new System.Drawing.Point(0, 0);
            this.btnInfMensual.Name = "btnInfMensual";
            this.btnInfMensual.Size = new System.Drawing.Size(197, 52);
            this.btnInfMensual.TabIndex = 1;
            this.btnInfMensual.Text = "              Mensual";
            this.btnInfMensual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfMensual.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInfSemanal);
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 52);
            this.panel2.TabIndex = 6;
            // 
            // btnInfSemanal
            // 
            this.btnInfSemanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInfSemanal.FlatAppearance.BorderSize = 0;
            this.btnInfSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfSemanal.IconChar = FontAwesome.Sharp.IconChar.DotCircle;
            this.btnInfSemanal.IconColor = System.Drawing.Color.White;
            this.btnInfSemanal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfSemanal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfSemanal.Location = new System.Drawing.Point(0, 0);
            this.btnInfSemanal.Name = "btnInfSemanal";
            this.btnInfSemanal.Size = new System.Drawing.Size(197, 52);
            this.btnInfSemanal.TabIndex = 1;
            this.btnInfSemanal.Text = "              Semanal";
            this.btnInfSemanal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfSemanal.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnInfDiario);
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 52);
            this.panel3.TabIndex = 5;
            // 
            // btnInfDiario
            // 
            this.btnInfDiario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInfDiario.FlatAppearance.BorderSize = 0;
            this.btnInfDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfDiario.IconChar = FontAwesome.Sharp.IconChar.DotCircle;
            this.btnInfDiario.IconColor = System.Drawing.Color.White;
            this.btnInfDiario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfDiario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfDiario.Location = new System.Drawing.Point(0, 0);
            this.btnInfDiario.Name = "btnInfDiario";
            this.btnInfDiario.Size = new System.Drawing.Size(197, 52);
            this.btnInfDiario.TabIndex = 1;
            this.btnInfDiario.Text = "              Diario\r\n";
            this.btnInfDiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfDiario.UseVisualStyleBackColor = true;
            // 
            // pnlInformes
            // 
            this.pnlInformes.Controls.Add(this.btnInformes);
            this.pnlInformes.Location = new System.Drawing.Point(0, 3);
            this.pnlInformes.Name = "pnlInformes";
            this.pnlInformes.Size = new System.Drawing.Size(197, 52);
            this.pnlInformes.TabIndex = 4;
            // 
            // btnInformes
            // 
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnInformes.IconColor = System.Drawing.Color.White;
            this.btnInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(0, 0);
            this.btnInformes.MaximumSize = new System.Drawing.Size(197, 234);
            this.btnInformes.MinimumSize = new System.Drawing.Size(197, 52);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(197, 52);
            this.btnInformes.TabIndex = 1;
            this.btnInformes.Text = "              Informes 🡇";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // informeTimer
            // 
            this.informeTimer.Interval = 5;
            this.informeTimer.Tick += new System.EventHandler(this.informeTimer_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.btnSalir);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(912, 34);
            this.panel5.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::proyBarberia.Properties.Resources.close;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(867, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 34);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlView
            // 
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(200, 34);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(912, 578);
            this.pnlView.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlSidebar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Giani Barber";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlTurnos.ResumeLayout(false);
            this.pnlClientes.ResumeLayout(false);
            this.pnlPremium.ResumeLayout(false);
            this.pnlBarberos.ResumeLayout(false);
            this.pnlContenedorInformes.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlInformes.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlSidebar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnInicio;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlTurnos;
        private FontAwesome.Sharp.IconButton btnTurnos;
        private System.Windows.Forms.Panel pnlClientes;
        private FontAwesome.Sharp.IconButton btnClientes;
        private System.Windows.Forms.Panel pnlPremium;
        private FontAwesome.Sharp.IconButton btnPremium;
        private System.Windows.Forms.Panel pnlBarberos;
        private FontAwesome.Sharp.IconButton btnBarberos;
        private System.Windows.Forms.Panel pnlInformes;
        private FontAwesome.Sharp.IconButton btnInformes;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel pnlContenedorInformes;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnInfMensual;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnInfSemanal;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnInfDiario;
        private System.Windows.Forms.Timer informeTimer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Button btnSalir;
    }
}