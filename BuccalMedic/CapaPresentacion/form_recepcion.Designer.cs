namespace CapaPresentacion
{
    partial class form_recepcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_recepcion));
            this.panel_Recepcion = new System.Windows.Forms.Panel();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.dtp_registroCitas = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tratamiento = new System.Windows.Forms.ComboBox();
            this.cbx_tratamiento = new System.Windows.Forms.CheckBox();
            this.cmb_horario = new System.Windows.Forms.ComboBox();
            this.cmb_odontologo = new System.Windows.Forms.ComboBox();
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.btn_mostrar_citas = new System.Windows.Forms.Button();
            this.btn_nuevo_cliente = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_registrarCita = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel_Recepcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Recepcion
            // 
            this.panel_Recepcion.BackColor = System.Drawing.Color.Transparent;
            this.panel_Recepcion.Controls.Add(this.txt_nombreCliente);
            this.panel_Recepcion.Controls.Add(this.dtp_registroCitas);
            this.panel_Recepcion.Controls.Add(this.pictureBox1);
            this.panel_Recepcion.Controls.Add(this.label1);
            this.panel_Recepcion.Controls.Add(this.cmb_tratamiento);
            this.panel_Recepcion.Controls.Add(this.cbx_tratamiento);
            this.panel_Recepcion.Controls.Add(this.cmb_horario);
            this.panel_Recepcion.Controls.Add(this.cmb_odontologo);
            this.panel_Recepcion.Controls.Add(this.txt_DNI);
            this.panel_Recepcion.Controls.Add(this.btn_mostrar_citas);
            this.panel_Recepcion.Controls.Add(this.btn_nuevo_cliente);
            this.panel_Recepcion.Controls.Add(this.btn_cancelar);
            this.panel_Recepcion.Controls.Add(this.btn_registrarCita);
            this.panel_Recepcion.Controls.Add(this.pictureBox2);
            this.panel_Recepcion.Controls.Add(this.pictureBox3);
            this.panel_Recepcion.Controls.Add(this.pictureBox5);
            this.panel_Recepcion.Controls.Add(this.pictureBox4);
            this.panel_Recepcion.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Recepcion.Location = new System.Drawing.Point(-2, -2);
            this.panel_Recepcion.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Recepcion.Name = "panel_Recepcion";
            this.panel_Recepcion.Size = new System.Drawing.Size(812, 552);
            this.panel_Recepcion.TabIndex = 0;
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.txt_nombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_nombreCliente.Location = new System.Drawing.Point(320, 162);
            this.txt_nombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.ReadOnly = true;
            this.txt_nombreCliente.Size = new System.Drawing.Size(141, 20);
            this.txt_nombreCliente.TabIndex = 40;
            this.txt_nombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_registroCitas
            // 
            this.dtp_registroCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtp_registroCitas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_registroCitas.Location = new System.Drawing.Point(146, 297);
            this.dtp_registroCitas.MinDate = new System.DateTime(2024, 10, 28, 0, 0, 0, 0);
            this.dtp_registroCitas.Name = "dtp_registroCitas";
            this.dtp_registroCitas.Size = new System.Drawing.Size(141, 20);
            this.dtp_registroCitas.TabIndex = 36;
            this.dtp_registroCitas.ValueChanged += new System.EventHandler(this.dtp_registroCitas_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(604, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "REGISTRO DE CITAS";
            // 
            // cmb_tratamiento
            // 
            this.cmb_tratamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.cmb_tratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmb_tratamiento.FormattingEnabled = true;
            this.cmb_tratamiento.Location = new System.Drawing.Point(320, 227);
            this.cmb_tratamiento.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_tratamiento.Name = "cmb_tratamiento";
            this.cmb_tratamiento.Size = new System.Drawing.Size(141, 21);
            this.cmb_tratamiento.TabIndex = 34;
            // 
            // cbx_tratamiento
            // 
            this.cbx_tratamiento.AutoSize = true;
            this.cbx_tratamiento.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_tratamiento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_tratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbx_tratamiento.Location = new System.Drawing.Point(320, 205);
            this.cbx_tratamiento.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_tratamiento.Name = "cbx_tratamiento";
            this.cbx_tratamiento.Size = new System.Drawing.Size(88, 18);
            this.cbx_tratamiento.TabIndex = 33;
            this.cbx_tratamiento.Text = "Tratamiento";
            this.cbx_tratamiento.UseVisualStyleBackColor = false;
            // 
            // cmb_horario
            // 
            this.cmb_horario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.cmb_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmb_horario.FormattingEnabled = true;
            this.cmb_horario.Location = new System.Drawing.Point(320, 297);
            this.cmb_horario.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_horario.Name = "cmb_horario";
            this.cmb_horario.Size = new System.Drawing.Size(141, 21);
            this.cmb_horario.TabIndex = 32;
            // 
            // cmb_odontologo
            // 
            this.cmb_odontologo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.cmb_odontologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmb_odontologo.FormattingEnabled = true;
            this.cmb_odontologo.Location = new System.Drawing.Point(146, 227);
            this.cmb_odontologo.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_odontologo.Name = "cmb_odontologo";
            this.cmb_odontologo.Size = new System.Drawing.Size(141, 21);
            this.cmb_odontologo.TabIndex = 30;
            // 
            // txt_DNI
            // 
            this.txt_DNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.txt_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_DNI.Location = new System.Drawing.Point(146, 162);
            this.txt_DNI.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DNI.MaxLength = 8;
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(141, 20);
            this.txt_DNI.TabIndex = 29;
            this.txt_DNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DNI.TextChanged += new System.EventHandler(this.txt_DNI_TextChanged);
            // 
            // btn_mostrar_citas
            // 
            this.btn_mostrar_citas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(210)))));
            this.btn_mostrar_citas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_mostrar_citas.Location = new System.Drawing.Point(550, 332);
            this.btn_mostrar_citas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mostrar_citas.Name = "btn_mostrar_citas";
            this.btn_mostrar_citas.Size = new System.Drawing.Size(112, 48);
            this.btn_mostrar_citas.TabIndex = 27;
            this.btn_mostrar_citas.Text = "Mostrar \r\nCitas";
            this.btn_mostrar_citas.UseVisualStyleBackColor = false;
            this.btn_mostrar_citas.Click += new System.EventHandler(this.btn_mostrar_citas_Click);
            // 
            // btn_nuevo_cliente
            // 
            this.btn_nuevo_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(103)))), ((int)(((byte)(196)))));
            this.btn_nuevo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_nuevo_cliente.Location = new System.Drawing.Point(550, 261);
            this.btn_nuevo_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nuevo_cliente.Name = "btn_nuevo_cliente";
            this.btn_nuevo_cliente.Size = new System.Drawing.Size(112, 49);
            this.btn_nuevo_cliente.TabIndex = 26;
            this.btn_nuevo_cliente.Text = "Nuevo \r\nCliente";
            this.btn_nuevo_cliente.UseVisualStyleBackColor = false;
            this.btn_nuevo_cliente.Click += new System.EventHandler(this.btn_nuevo_cliente_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(550, 207);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(112, 40);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_registrarCita
            // 
            this.btn_registrarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(229)))));
            this.btn_registrarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_registrarCita.Location = new System.Drawing.Point(550, 141);
            this.btn_registrarCita.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registrarCita.Name = "btn_registrarCita";
            this.btn_registrarCita.Size = new System.Drawing.Size(112, 40);
            this.btn_registrarCita.TabIndex = 24;
            this.btn_registrarCita.Text = "Registrar";
            this.btn_registrarCita.UseVisualStyleBackColor = false;
            this.btn_registrarCita.Click += new System.EventHandler(this.btn_registrarCita_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 141);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(810, 409);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            this.pictureBox3.Location = new System.Drawing.Point(2, 22);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(481, 54);
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(103)))), ((int)(((byte)(196)))));
            this.pictureBox5.Location = new System.Drawing.Point(0, 49);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(496, 40);
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(52)))), ((int)(((byte)(148)))));
            this.pictureBox4.Location = new System.Drawing.Point(211, 93);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(599, 8);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // form_recepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.panel_Recepcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_recepcion";
            this.Text = "Recepcion";
            this.panel_Recepcion.ResumeLayout(false);
            this.panel_Recepcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Recepcion;
        private System.Windows.Forms.ComboBox cmb_tratamiento;
        private System.Windows.Forms.CheckBox cbx_tratamiento;
        private System.Windows.Forms.ComboBox cmb_horario;
        private System.Windows.Forms.ComboBox cmb_odontologo;
        private System.Windows.Forms.TextBox txt_DNI;
        private System.Windows.Forms.Button btn_mostrar_citas;
        private System.Windows.Forms.Button btn_nuevo_cliente;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_registrarCita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_registroCitas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_nombreCliente;
    }
}