namespace proyBarberia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlUsuarioIncorrecto = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlContraseniaIncorrecta = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlGianiBarber = new System.Windows.Forms.Panel();
            this.lblGianiBarberTitulo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlUsuarioIncorrecto.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlContraseniaIncorrecta.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.pnlGianiBarber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.pnlSuperior);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 45);
            this.panel1.TabIndex = 0;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlSuperior.Controls.Add(this.panel2);
            this.pnlSuperior.Controls.Add(this.btnSalir);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(790, 45);
            this.pnlSuperior.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 45);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::proyBarberia.Properties.Resources.calendar;
            this.pictureBox5.Location = new System.Drawing.Point(5, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::proyBarberia.Properties.Resources.clock;
            this.pictureBox4.Location = new System.Drawing.Point(448, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblHora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHora.Location = new System.Drawing.Point(486, 8);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(69, 29);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Time";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblFecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFecha.Location = new System.Drawing.Point(44, 8);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 29);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Date";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::proyBarberia.Properties.Resources.close;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(745, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 45);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido, ingrese al sistema.";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Lucida Sans", 15F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(8, 6);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(379, 24);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Text = "Ingrese el usuario";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtUsuario);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 41);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(8, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(379, 1);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnlUsuarioIncorrecto);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Location = new System.Drawing.Point(70, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 66);
            this.panel6.TabIndex = 7;
            // 
            // pnlUsuarioIncorrecto
            // 
            this.pnlUsuarioIncorrecto.Controls.Add(this.label3);
            this.pnlUsuarioIncorrecto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuarioIncorrecto.Location = new System.Drawing.Point(0, 41);
            this.pnlUsuarioIncorrecto.Name = "pnlUsuarioIncorrecto";
            this.pnlUsuarioIncorrecto.Size = new System.Drawing.Size(390, 21);
            this.pnlUsuarioIncorrecto.TabIndex = 6;
            this.pnlUsuarioIncorrecto.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario incorrecto.";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnlContraseniaIncorrecta);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Location = new System.Drawing.Point(70, 194);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(390, 66);
            this.panel7.TabIndex = 10;
            // 
            // pnlContraseniaIncorrecta
            // 
            this.pnlContraseniaIncorrecta.Controls.Add(this.label4);
            this.pnlContraseniaIncorrecta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContraseniaIncorrecta.Location = new System.Drawing.Point(0, 41);
            this.pnlContraseniaIncorrecta.Name = "pnlContraseniaIncorrecta";
            this.pnlContraseniaIncorrecta.Size = new System.Drawing.Size(390, 21);
            this.pnlContraseniaIncorrecta.TabIndex = 6;
            this.pnlContraseniaIncorrecta.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña incorrecta.";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtContraseña);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(390, 41);
            this.panel9.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Lucida Sans", 15F);
            this.txtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.Location = new System.Drawing.Point(8, 6);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(379, 24);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.Text = "Ingrese la contraseña";
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_Click);
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Location = new System.Drawing.Point(8, 35);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(379, 1);
            this.panel10.TabIndex = 6;
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(193)))));
            this.btnIngresar.FlatAppearance.BorderSize = 2;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(193)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIngresar.Location = new System.Drawing.Point(141, 288);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(220, 45);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.btnIngresar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(309, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 375);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyBarberia.Properties.Resources.logoUser2;
            this.pictureBox1.Location = new System.Drawing.Point(25, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyBarberia.Properties.Resources.padlock;
            this.pictureBox2.Location = new System.Drawing.Point(25, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.pnlLogo.BackgroundImage = global::proyBarberia.Properties.Resources.imagenbarberia3;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Controls.Add(this.pnlGianiBarber);
            this.pnlLogo.Controls.Add(this.pictureBox3);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(1, 46);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(308, 375);
            this.pnlLogo.TabIndex = 1;
            // 
            // pnlGianiBarber
            // 
            this.pnlGianiBarber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlGianiBarber.Controls.Add(this.lblGianiBarberTitulo);
            this.pnlGianiBarber.Location = new System.Drawing.Point(38, 25);
            this.pnlGianiBarber.Name = "pnlGianiBarber";
            this.pnlGianiBarber.Size = new System.Drawing.Size(244, 58);
            this.pnlGianiBarber.TabIndex = 13;
            // 
            // lblGianiBarberTitulo
            // 
            this.lblGianiBarberTitulo.AutoSize = true;
            this.lblGianiBarberTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblGianiBarberTitulo.Font = new System.Drawing.Font("Pristina", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGianiBarberTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGianiBarberTitulo.Location = new System.Drawing.Point(20, 6);
            this.lblGianiBarberTitulo.Name = "lblGianiBarberTitulo";
            this.lblGianiBarberTitulo.Size = new System.Drawing.Size(206, 52);
            this.lblGianiBarberTitulo.TabIndex = 12;
            this.lblGianiBarberTitulo.Text = "Giani Barber";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::proyBarberia.Properties.Resources.logoBarberia1;
            this.pictureBox3.Location = new System.Drawing.Point(38, 89);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(244, 244);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(792, 422);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Giani Barber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.pnlUsuarioIncorrecto.ResumeLayout(false);
            this.pnlUsuarioIncorrecto.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.pnlContraseniaIncorrecta.ResumeLayout(false);
            this.pnlContraseniaIncorrecta.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlGianiBarber.ResumeLayout(false);
            this.pnlGianiBarber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlUsuarioIncorrecto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlContraseniaIncorrecta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblGianiBarberTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlGianiBarber;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

