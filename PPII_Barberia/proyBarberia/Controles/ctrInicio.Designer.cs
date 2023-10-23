namespace proyBarberia.Controles
{
    partial class ctrInicio
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUsuarioActual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al sistema de";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::proyBarberia.Properties.Resources.clock;
            this.pictureBox4.Location = new System.Drawing.Point(72, 397);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblHora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHora.Location = new System.Drawing.Point(178, 411);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(180, 76);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Time";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::proyBarberia.Properties.Resources.calendar;
            this.pictureBox5.Location = new System.Drawing.Point(72, 259);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lblFecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFecha.Location = new System.Drawing.Point(178, 287);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(113, 51);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.AutoSize = true;
            this.lblUsuarioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblUsuarioActual.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUsuarioActual.Location = new System.Drawing.Point(59, 126);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(611, 76);
            this.lblUsuarioActual.TabIndex = 8;
            this.lblUsuarioActual.Text = "Giani Barber Studio";
            // 
            // ctrInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lblUsuarioActual);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label1);
            this.Name = "ctrInicio";
            this.Size = new System.Drawing.Size(912, 578);
            this.Load += new System.EventHandler(this.ctrInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUsuarioActual;
    }
}
