namespace CapaPresentacion
{
    partial class form_evaluaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_evaluaciones));
            this.panel_evaluaciones = new System.Windows.Forms.Panel();
            this.evaluaciones_btn_regresar = new System.Windows.Forms.Button();
            this.evaluacion_btn_Limpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.evaluaciones_dgv = new System.Windows.Forms.DataGridView();
            this.IdConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluacion_codigocita = new System.Windows.Forms.ComboBox();
            this.evaluacion_cmbox_paciente = new System.Windows.Forms.ComboBox();
            this.evaluacion_dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_evaluaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaciones_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_evaluaciones
            // 
            this.panel_evaluaciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_evaluaciones.BackColor = System.Drawing.Color.White;
            this.panel_evaluaciones.Controls.Add(this.evaluaciones_btn_regresar);
            this.panel_evaluaciones.Controls.Add(this.evaluacion_btn_Limpiar);
            this.panel_evaluaciones.Controls.Add(this.pictureBox1);
            this.panel_evaluaciones.Controls.Add(this.evaluaciones_dgv);
            this.panel_evaluaciones.Controls.Add(this.evaluacion_codigocita);
            this.panel_evaluaciones.Controls.Add(this.evaluacion_cmbox_paciente);
            this.panel_evaluaciones.Controls.Add(this.evaluacion_dtp_fecha);
            this.panel_evaluaciones.Controls.Add(this.label4);
            this.panel_evaluaciones.Controls.Add(this.label3);
            this.panel_evaluaciones.Controls.Add(this.label2);
            this.panel_evaluaciones.Controls.Add(this.label1);
            this.panel_evaluaciones.Controls.Add(this.pictureBox2);
            this.panel_evaluaciones.Location = new System.Drawing.Point(-3, -2);
            this.panel_evaluaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_evaluaciones.Name = "panel_evaluaciones";
            this.panel_evaluaciones.Size = new System.Drawing.Size(608, 438);
            this.panel_evaluaciones.TabIndex = 2;
            // 
            // evaluaciones_btn_regresar
            // 
            this.evaluaciones_btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.evaluaciones_btn_regresar.Location = new System.Drawing.Point(13, 375);
            this.evaluaciones_btn_regresar.Name = "evaluaciones_btn_regresar";
            this.evaluaciones_btn_regresar.Size = new System.Drawing.Size(67, 36);
            this.evaluaciones_btn_regresar.TabIndex = 17;
            this.evaluaciones_btn_regresar.Text = "<--";
            this.evaluaciones_btn_regresar.UseVisualStyleBackColor = false;
            // 
            // evaluacion_btn_Limpiar
            // 
            this.evaluacion_btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.evaluacion_btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluacion_btn_Limpiar.Location = new System.Drawing.Point(496, 370);
            this.evaluacion_btn_Limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.evaluacion_btn_Limpiar.Name = "evaluacion_btn_Limpiar";
            this.evaluacion_btn_Limpiar.Size = new System.Drawing.Size(100, 41);
            this.evaluacion_btn_Limpiar.TabIndex = 12;
            this.evaluacion_btn_Limpiar.Text = "Limpiar";
            this.evaluacion_btn_Limpiar.UseVisualStyleBackColor = false;
            this.evaluacion_btn_Limpiar.Click += new System.EventHandler(this.evaluacion_btn_Limpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 36);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // evaluaciones_dgv
            // 
            this.evaluaciones_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evaluaciones_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdConsulta,
            this.Paciente,
            this.Fecha_Registro});
            this.evaluaciones_dgv.Location = new System.Drawing.Point(220, 123);
            this.evaluaciones_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.evaluaciones_dgv.Name = "evaluaciones_dgv";
            this.evaluaciones_dgv.RowHeadersWidth = 51;
            this.evaluaciones_dgv.RowTemplate.Height = 24;
            this.evaluaciones_dgv.Size = new System.Drawing.Size(376, 220);
            this.evaluaciones_dgv.TabIndex = 7;
            // 
            // IdConsulta
            // 
            this.IdConsulta.HeaderText = "IdConsulta";
            this.IdConsulta.MinimumWidth = 6;
            this.IdConsulta.Name = "IdConsulta";
            this.IdConsulta.Width = 125;
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.MinimumWidth = 6;
            this.Paciente.Name = "Paciente";
            this.Paciente.Width = 125;
            // 
            // Fecha_Registro
            // 
            this.Fecha_Registro.HeaderText = "Fecha_Registro";
            this.Fecha_Registro.MinimumWidth = 6;
            this.Fecha_Registro.Name = "Fecha_Registro";
            this.Fecha_Registro.Width = 125;
            // 
            // evaluacion_codigocita
            // 
            this.evaluacion_codigocita.FormattingEnabled = true;
            this.evaluacion_codigocita.Location = new System.Drawing.Point(42, 284);
            this.evaluacion_codigocita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.evaluacion_codigocita.Name = "evaluacion_codigocita";
            this.evaluacion_codigocita.Size = new System.Drawing.Size(92, 21);
            this.evaluacion_codigocita.TabIndex = 6;
            this.evaluacion_codigocita.SelectedIndexChanged += new System.EventHandler(this.evaluacion_codigocita_SelectedIndexChanged);
            // 
            // evaluacion_cmbox_paciente
            // 
            this.evaluacion_cmbox_paciente.FormattingEnabled = true;
            this.evaluacion_cmbox_paciente.Location = new System.Drawing.Point(42, 206);
            this.evaluacion_cmbox_paciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.evaluacion_cmbox_paciente.Name = "evaluacion_cmbox_paciente";
            this.evaluacion_cmbox_paciente.Size = new System.Drawing.Size(151, 21);
            this.evaluacion_cmbox_paciente.TabIndex = 5;
            this.evaluacion_cmbox_paciente.SelectedIndexChanged += new System.EventHandler(this.evaluacion_cmbox_paciente_SelectedIndexChanged);
            // 
            // evaluacion_dtp_fecha
            // 
            this.evaluacion_dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.evaluacion_dtp_fecha.Location = new System.Drawing.Point(42, 137);
            this.evaluacion_dtp_fecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.evaluacion_dtp_fecha.Name = "evaluacion_dtp_fecha";
            this.evaluacion_dtp_fecha.Size = new System.Drawing.Size(151, 20);
            this.evaluacion_dtp_fecha.TabIndex = 4;
            this.evaluacion_dtp_fecha.ValueChanged += new System.EventHandler(this.evaluacion_dtp_fecha_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código de cita:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selecciona Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecciona Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "EVALUACIONES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(605, 84);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // form_evaluaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 433);
            this.Controls.Add(this.panel_evaluaciones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form_evaluaciones";
            this.Text = "form_evaluaciones";
            this.Load += new System.EventHandler(this.form_evaluaciones_Load);
            this.panel_evaluaciones.ResumeLayout(false);
            this.panel_evaluaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaciones_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_evaluaciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView evaluaciones_dgv;
        private System.Windows.Forms.ComboBox evaluacion_codigocita;
        private System.Windows.Forms.ComboBox evaluacion_cmbox_paciente;
        private System.Windows.Forms.DateTimePicker evaluacion_dtp_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Registro;
        private System.Windows.Forms.Button evaluaciones_btn_regresar;
        private System.Windows.Forms.Button evaluacion_btn_Limpiar;
    }
}