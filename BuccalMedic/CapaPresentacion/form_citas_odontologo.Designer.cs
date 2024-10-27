namespace CapaPresentacion
{
    partial class form_citas_odontologo
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
            this.panel_cita = new System.Windows.Forms.Panel();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_cita = new System.Windows.Forms.DataGridView();
            this.colum_idCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_atender = new System.Windows.Forms.Button();
            this.cmb_dniRC = new System.Windows.Forms.ComboBox();
            this.cmb_pacienteRC = new System.Windows.Forms.ComboBox();
            this.dtp_fechaRC = new System.Windows.Forms.DateTimePicker();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.panel_cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cita)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cita
            // 
            this.panel_cita.Controls.Add(this.btn_refrescar);
            this.panel_cita.Controls.Add(this.btn_regresar);
            this.panel_cita.Controls.Add(this.pictureBox1);
            this.panel_cita.Controls.Add(this.dgv_cita);
            this.panel_cita.Controls.Add(this.label5);
            this.panel_cita.Controls.Add(this.label4);
            this.panel_cita.Controls.Add(this.label3);
            this.panel_cita.Controls.Add(this.label1);
            this.panel_cita.Controls.Add(this.btn_atender);
            this.panel_cita.Controls.Add(this.cmb_dniRC);
            this.panel_cita.Controls.Add(this.cmb_pacienteRC);
            this.panel_cita.Controls.Add(this.dtp_fechaRC);
            this.panel_cita.Location = new System.Drawing.Point(14, 14);
            this.panel_cita.Margin = new System.Windows.Forms.Padding(5);
            this.panel_cita.Name = "panel_cita";
            this.panel_cita.Size = new System.Drawing.Size(764, 493);
            this.panel_cita.TabIndex = 1;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.btn_regresar.Location = new System.Drawing.Point(4, 4);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(67, 30);
            this.btn_regresar.TabIndex = 17;
            this.btn_regresar.Text = "<--";
            this.btn_regresar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.BuccalMedic;
            this.pictureBox1.Location = new System.Drawing.Point(525, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_cita
            // 
            this.dgv_cita.AllowUserToAddRows = false;
            this.dgv_cita.AllowUserToDeleteRows = false;
            this.dgv_cita.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_idCita,
            this.colum_fecha,
            this.colum_dni,
            this.colum_paciente,
            this.colum_tratamiento,
            this.colum_estado});
            this.dgv_cita.Location = new System.Drawing.Point(74, 205);
            this.dgv_cita.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_cita.Name = "dgv_cita";
            this.dgv_cita.ReadOnly = true;
            this.dgv_cita.Size = new System.Drawing.Size(584, 214);
            this.dgv_cita.TabIndex = 15;
            this.dgv_cita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cita_CellClick);
            // 
            // colum_idCita
            // 
            this.colum_idCita.HeaderText = "idCita";
            this.colum_idCita.Name = "colum_idCita";
            this.colum_idCita.ReadOnly = true;
            this.colum_idCita.Width = 60;
            // 
            // colum_fecha
            // 
            this.colum_fecha.HeaderText = "Fecha de cita";
            this.colum_fecha.Name = "colum_fecha";
            this.colum_fecha.ReadOnly = true;
            // 
            // colum_dni
            // 
            this.colum_dni.HeaderText = "DNI";
            this.colum_dni.Name = "colum_dni";
            this.colum_dni.ReadOnly = true;
            this.colum_dni.Width = 80;
            // 
            // colum_paciente
            // 
            this.colum_paciente.HeaderText = "Paciente";
            this.colum_paciente.Name = "colum_paciente";
            this.colum_paciente.ReadOnly = true;
            this.colum_paciente.Width = 120;
            // 
            // colum_tratamiento
            // 
            this.colum_tratamiento.HeaderText = "Tratamiento";
            this.colum_tratamiento.Name = "colum_tratamiento";
            this.colum_tratamiento.ReadOnly = true;
            // 
            // colum_estado
            // 
            this.colum_estado.HeaderText = "Estado";
            this.colum_estado.Name = "colum_estado";
            this.colum_estado.ReadOnly = true;
            this.colum_estado.Width = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.label5.Location = new System.Drawing.Point(431, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Seleccionar fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.label4.Location = new System.Drawing.Point(55, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(210, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccionar Paciente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Revisar Citas";
            // 
            // btn_atender
            // 
            this.btn_atender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.btn_atender.Location = new System.Drawing.Point(333, 429);
            this.btn_atender.Margin = new System.Windows.Forms.Padding(5);
            this.btn_atender.Name = "btn_atender";
            this.btn_atender.Size = new System.Drawing.Size(78, 39);
            this.btn_atender.TabIndex = 6;
            this.btn_atender.Text = "Atender";
            this.btn_atender.UseVisualStyleBackColor = false;
            this.btn_atender.Click += new System.EventHandler(this.btn_atender_Click);
            // 
            // cmb_dniRC
            // 
            this.cmb_dniRC.FormattingEnabled = true;
            this.cmb_dniRC.Location = new System.Drawing.Point(56, 154);
            this.cmb_dniRC.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_dniRC.Name = "cmb_dniRC";
            this.cmb_dniRC.Size = new System.Drawing.Size(124, 25);
            this.cmb_dniRC.TabIndex = 5;
            this.cmb_dniRC.SelectedIndexChanged += new System.EventHandler(this.cmb_dniRC_SelectedIndexChanged);
            // 
            // cmb_pacienteRC
            // 
            this.cmb_pacienteRC.FormattingEnabled = true;
            this.cmb_pacienteRC.Location = new System.Drawing.Point(211, 154);
            this.cmb_pacienteRC.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_pacienteRC.Name = "cmb_pacienteRC";
            this.cmb_pacienteRC.Size = new System.Drawing.Size(200, 25);
            this.cmb_pacienteRC.TabIndex = 4;
            this.cmb_pacienteRC.SelectedIndexChanged += new System.EventHandler(this.cmb_pacienteRC_SelectedIndexChanged);
            // 
            // dtp_fechaRC
            // 
            this.dtp_fechaRC.Location = new System.Drawing.Point(432, 154);
            this.dtp_fechaRC.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_fechaRC.Name = "dtp_fechaRC";
            this.dtp_fechaRC.Size = new System.Drawing.Size(291, 23);
            this.dtp_fechaRC.TabIndex = 2;
            this.dtp_fechaRC.ValueChanged += new System.EventHandler(this.dtp_fechaRC_ValueChanged);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.btn_refrescar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refrescar.Location = new System.Drawing.Point(682, 186);
            this.btn_refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(41, 30);
            this.btn_refrescar.TabIndex = 18;
            this.btn_refrescar.Text = "x";
            this.btn_refrescar.UseVisualStyleBackColor = false;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // form_citas_odontologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.panel_cita);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_citas_odontologo";
            this.Text = "form_citas_odontologo";
            this.panel_cita.ResumeLayout(false);
            this.panel_cita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_atender;
        private System.Windows.Forms.ComboBox cmb_dniRC;
        private System.Windows.Forms.ComboBox cmb_pacienteRC;
        private System.Windows.Forms.DateTimePicker dtp_fechaRC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_cita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_idCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_estado;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_refrescar;
    }
}