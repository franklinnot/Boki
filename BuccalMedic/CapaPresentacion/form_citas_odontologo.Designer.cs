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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_citas_odontologo));
            this.panel_cita = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.dgv_cita = new System.Windows.Forms.DataGridView();
            this.colum_idCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_atender = new System.Windows.Forms.Button();
            this.cmb_dniRC = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cita
            // 
            this.panel_cita.Controls.Add(this.pictureBox3);
            this.panel_cita.Controls.Add(this.label2);
            this.panel_cita.Controls.Add(this.pictureBox4);
            this.panel_cita.Controls.Add(this.pictureBox5);
            this.panel_cita.Controls.Add(this.pictureBox6);
            this.panel_cita.Controls.Add(this.btn_refrescar);
            this.panel_cita.Controls.Add(this.dgv_cita);
            this.panel_cita.Controls.Add(this.label4);
            this.panel_cita.Controls.Add(this.btn_atender);
            this.panel_cita.Controls.Add(this.cmb_dniRC);
            this.panel_cita.Controls.Add(this.pictureBox2);
            this.panel_cita.Location = new System.Drawing.Point(-5, -7);
            this.panel_cita.Margin = new System.Windows.Forms.Padding(5);
            this.panel_cita.Name = "panel_cita";
            this.panel_cita.Size = new System.Drawing.Size(817, 553);
            this.panel_cita.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(553, 23);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(243, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "REVISIÓN DE CITAS";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            this.pictureBox4.Location = new System.Drawing.Point(-230, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(641, 66);
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(103)))), ((int)(((byte)(196)))));
            this.pictureBox5.Location = new System.Drawing.Point(-233, 50);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(662, 49);
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(52)))), ((int)(((byte)(148)))));
            this.pictureBox6.Location = new System.Drawing.Point(321, 105);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(496, 10);
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.btn_refrescar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refrescar.Location = new System.Drawing.Point(214, 149);
            this.btn_refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(41, 30);
            this.btn_refrescar.TabIndex = 18;
            this.btn_refrescar.Text = "x";
            this.btn_refrescar.UseVisualStyleBackColor = false;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
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
            this.dgv_cita.Location = new System.Drawing.Point(56, 225);
            this.dgv_cita.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_cita.Name = "dgv_cita";
            this.dgv_cita.ReadOnly = true;
            this.dgv_cita.RowHeadersWidth = 51;
            this.dgv_cita.Size = new System.Drawing.Size(667, 194);
            this.dgv_cita.TabIndex = 15;
            this.dgv_cita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cita_CellClick);
            // 
            // colum_idCita
            // 
            this.colum_idCita.HeaderText = "idCita";
            this.colum_idCita.MinimumWidth = 6;
            this.colum_idCita.Name = "colum_idCita";
            this.colum_idCita.ReadOnly = true;
            this.colum_idCita.Width = 60;
            // 
            // colum_fecha
            // 
            this.colum_fecha.HeaderText = "Fecha de cita";
            this.colum_fecha.MinimumWidth = 6;
            this.colum_fecha.Name = "colum_fecha";
            this.colum_fecha.ReadOnly = true;
            this.colum_fecha.Width = 125;
            // 
            // colum_dni
            // 
            this.colum_dni.HeaderText = "DNI";
            this.colum_dni.MinimumWidth = 6;
            this.colum_dni.Name = "colum_dni";
            this.colum_dni.ReadOnly = true;
            this.colum_dni.Width = 80;
            // 
            // colum_paciente
            // 
            this.colum_paciente.HeaderText = "Paciente";
            this.colum_paciente.MinimumWidth = 6;
            this.colum_paciente.Name = "colum_paciente";
            this.colum_paciente.ReadOnly = true;
            this.colum_paciente.Width = 120;
            // 
            // colum_tratamiento
            // 
            this.colum_tratamiento.HeaderText = "Tratamiento";
            this.colum_tratamiento.MinimumWidth = 6;
            this.colum_tratamiento.Name = "colum_tratamiento";
            this.colum_tratamiento.ReadOnly = true;
            this.colum_tratamiento.Width = 125;
            // 
            // colum_estado
            // 
            this.colum_estado.HeaderText = "Estado";
            this.colum_estado.MinimumWidth = 6;
            this.colum_estado.Name = "colum_estado";
            this.colum_estado.ReadOnly = true;
            this.colum_estado.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "DNI:";
            // 
            // btn_atender
            // 
            this.btn_atender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            this.btn_atender.Location = new System.Drawing.Point(349, 448);
            this.btn_atender.Margin = new System.Windows.Forms.Padding(5);
            this.btn_atender.Name = "btn_atender";
            this.btn_atender.Size = new System.Drawing.Size(104, 39);
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
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(814, 560);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // form_citas_odontologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.panel_cita);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "form_citas_odontologo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_citas_odontologo";
            this.panel_cita.ResumeLayout(false);
            this.panel_cita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_atender;
        private System.Windows.Forms.ComboBox cmb_dniRC;
        private System.Windows.Forms.DataGridView dgv_cita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_idCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_estado;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}