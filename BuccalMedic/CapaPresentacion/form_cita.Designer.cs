namespace CapaPresentacion
{
    partial class form_cita
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_detalle_cita = new System.Windows.Forms.Button();
            this.btn_anular = new System.Windows.Forms.Button();
            this.cmb_codC = new System.Windows.Forms.ComboBox();
            this.cmb_pacienteC = new System.Windows.Forms.ComboBox();
            this.cmb_odontologoC = new System.Windows.Forms.ComboBox();
            this.dtp_fechaC = new System.Windows.Forms.DateTimePicker();
            this.dgv_cita = new System.Windows.Forms.DataGridView();
            this.colum_idCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_odontologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cita)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cita
            // 
            this.panel_cita.Controls.Add(this.button1);
            this.panel_cita.Controls.Add(this.pictureBox1);
            this.panel_cita.Controls.Add(this.label5);
            this.panel_cita.Controls.Add(this.label4);
            this.panel_cita.Controls.Add(this.label3);
            this.panel_cita.Controls.Add(this.label2);
            this.panel_cita.Controls.Add(this.label1);
            this.panel_cita.Controls.Add(this.btn_detalle_cita);
            this.panel_cita.Controls.Add(this.btn_anular);
            this.panel_cita.Controls.Add(this.cmb_codC);
            this.panel_cita.Controls.Add(this.cmb_pacienteC);
            this.panel_cita.Controls.Add(this.cmb_odontologoC);
            this.panel_cita.Controls.Add(this.dtp_fechaC);
            this.panel_cita.Controls.Add(this.dgv_cita);
            this.panel_cita.Location = new System.Drawing.Point(25, 13);
            this.panel_cita.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cita.Name = "panel_cita";
            this.panel_cita.Size = new System.Drawing.Size(739, 480);
            this.panel_cita.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.button1.Location = new System.Drawing.Point(4, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "<--";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logoBucalMedic;
            this.pictureBox1.Location = new System.Drawing.Point(499, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.label5.Location = new System.Drawing.Point(294, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Seleccionar fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.label4.Location = new System.Drawing.Point(47, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Codigo de cita:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(294, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccionar Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(47, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccionar Odontólogo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cita";
            // 
            // btn_detalle_cita
            // 
            this.btn_detalle_cita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.btn_detalle_cita.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalle_cita.ForeColor = System.Drawing.Color.Black;
            this.btn_detalle_cita.Location = new System.Drawing.Point(389, 417);
            this.btn_detalle_cita.Margin = new System.Windows.Forms.Padding(4);
            this.btn_detalle_cita.Name = "btn_detalle_cita";
            this.btn_detalle_cita.Size = new System.Drawing.Size(117, 30);
            this.btn_detalle_cita.TabIndex = 7;
            this.btn_detalle_cita.Text = "Detalle de la cita";
            this.btn_detalle_cita.UseVisualStyleBackColor = false;
            // 
            // btn_anular
            // 
            this.btn_anular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.btn_anular.Location = new System.Drawing.Point(268, 417);
            this.btn_anular.Margin = new System.Windows.Forms.Padding(4);
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.Size = new System.Drawing.Size(67, 30);
            this.btn_anular.TabIndex = 6;
            this.btn_anular.Text = "Anular";
            this.btn_anular.UseVisualStyleBackColor = false;
            this.btn_anular.Click += new System.EventHandler(this.btn_anular_Click);
            // 
            // cmb_codC
            // 
            this.cmb_codC.FormattingEnabled = true;
            this.cmb_codC.Location = new System.Drawing.Point(152, 82);
            this.cmb_codC.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_codC.Name = "cmb_codC";
            this.cmb_codC.Size = new System.Drawing.Size(107, 25);
            this.cmb_codC.TabIndex = 5;
            // 
            // cmb_pacienteC
            // 
            this.cmb_pacienteC.FormattingEnabled = true;
            this.cmb_pacienteC.Location = new System.Drawing.Point(297, 135);
            this.cmb_pacienteC.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_pacienteC.Name = "cmb_pacienteC";
            this.cmb_pacienteC.Size = new System.Drawing.Size(209, 25);
            this.cmb_pacienteC.TabIndex = 4;
            // 
            // cmb_odontologoC
            // 
            this.cmb_odontologoC.FormattingEnabled = true;
            this.cmb_odontologoC.Location = new System.Drawing.Point(50, 135);
            this.cmb_odontologoC.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_odontologoC.Name = "cmb_odontologoC";
            this.cmb_odontologoC.Size = new System.Drawing.Size(209, 25);
            this.cmb_odontologoC.TabIndex = 3;
            // 
            // dtp_fechaC
            // 
            this.dtp_fechaC.Location = new System.Drawing.Point(414, 82);
            this.dtp_fechaC.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fechaC.Name = "dtp_fechaC";
            this.dtp_fechaC.Size = new System.Drawing.Size(250, 23);
            this.dtp_fechaC.TabIndex = 2;
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
            this.colum_odontologo,
            this.colum_paciente,
            this.colum_tratamiento,
            this.colum_estado});
            this.dgv_cita.Location = new System.Drawing.Point(20, 187);
            this.dgv_cita.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_cita.Name = "dgv_cita";
            this.dgv_cita.ReadOnly = true;
            this.dgv_cita.Size = new System.Drawing.Size(700, 222);
            this.dgv_cita.TabIndex = 1;
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
            // colum_odontologo
            // 
            this.colum_odontologo.HeaderText = "Odontologo";
            this.colum_odontologo.Name = "colum_odontologo";
            this.colum_odontologo.ReadOnly = true;
            this.colum_odontologo.Width = 150;
            // 
            // colum_paciente
            // 
            this.colum_paciente.HeaderText = "Paciente";
            this.colum_paciente.Name = "colum_paciente";
            this.colum_paciente.ReadOnly = true;
            this.colum_paciente.Width = 150;
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
            // form_cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.panel_cita);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_cita";
            this.Text = "form_cita";
            this.panel_cita.ResumeLayout(false);
            this.panel_cita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_detalle_cita;
        private System.Windows.Forms.Button btn_anular;
        private System.Windows.Forms.ComboBox cmb_codC;
        private System.Windows.Forms.ComboBox cmb_pacienteC;
        private System.Windows.Forms.ComboBox cmb_odontologoC;
        private System.Windows.Forms.DateTimePicker dtp_fechaC;
        private System.Windows.Forms.DataGridView dgv_cita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_idCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_odontologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_estado;
    }
}