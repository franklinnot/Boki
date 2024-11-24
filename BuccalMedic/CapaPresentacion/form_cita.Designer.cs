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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cita));
            this.panel_cita = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_detalle_cita = new System.Windows.Forms.Button();
            this.btn_anular = new System.Windows.Forms.Button();
            this.cmb_dni = new System.Windows.Forms.ComboBox();
            this.cmb_odontologoC = new System.Windows.Forms.ComboBox();
            this.dgv_cita = new System.Windows.Forms.DataGridView();
            this.colum_idCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_odontologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cita
            // 
            this.panel_cita.Controls.Add(this.label6);
            this.panel_cita.Controls.Add(this.pictureBox4);
            this.panel_cita.Controls.Add(this.pictureBox5);
            this.panel_cita.Controls.Add(this.pictureBox6);
            this.panel_cita.Controls.Add(this.pictureBox2);
            this.panel_cita.Controls.Add(this.btn_refrescar);
            this.panel_cita.Controls.Add(this.label4);
            this.panel_cita.Controls.Add(this.label2);
            this.panel_cita.Controls.Add(this.btn_detalle_cita);
            this.panel_cita.Controls.Add(this.btn_anular);
            this.panel_cita.Controls.Add(this.cmb_dni);
            this.panel_cita.Controls.Add(this.cmb_odontologoC);
            this.panel_cita.Controls.Add(this.dgv_cita);
            this.panel_cita.Controls.Add(this.pictureBox3);
            this.panel_cita.Location = new System.Drawing.Point(-1, -2);
            this.panel_cita.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cita.Name = "panel_cita";
            this.panel_cita.Size = new System.Drawing.Size(811, 551);
            this.panel_cita.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 33);
            this.label6.TabIndex = 48;
            this.label6.Text = "REGISTRO DE CITA";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            this.pictureBox4.Location = new System.Drawing.Point(0, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(416, 49);
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(103)))), ((int)(((byte)(196)))));
            this.pictureBox5.Location = new System.Drawing.Point(-22, 43);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(456, 31);
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(52)))), ((int)(((byte)(148)))));
            this.pictureBox6.Location = new System.Drawing.Point(298, 80);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(585, 10);
            this.pictureBox6.TabIndex = 50;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(571, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 50);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.btn_refrescar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refrescar.Location = new System.Drawing.Point(716, 141);
            this.btn_refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(41, 30);
            this.btn_refrescar.TabIndex = 16;
            this.btn_refrescar.Text = "x";
            this.btn_refrescar.UseVisualStyleBackColor = false;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccionar Odontólogo:";
            // 
            // btn_detalle_cita
            // 
            this.btn_detalle_cita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            this.btn_detalle_cita.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalle_cita.ForeColor = System.Drawing.Color.Black;
            this.btn_detalle_cita.Location = new System.Drawing.Point(369, 434);
            this.btn_detalle_cita.Margin = new System.Windows.Forms.Padding(4);
            this.btn_detalle_cita.Name = "btn_detalle_cita";
            this.btn_detalle_cita.Size = new System.Drawing.Size(162, 41);
            this.btn_detalle_cita.TabIndex = 7;
            this.btn_detalle_cita.Text = "Detalle de la cita";
            this.btn_detalle_cita.UseVisualStyleBackColor = false;
            this.btn_detalle_cita.Click += new System.EventHandler(this.btn_detalle_cita_Click);
            // 
            // btn_anular
            // 
            this.btn_anular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(44)))));
            this.btn_anular.Location = new System.Drawing.Point(263, 434);
            this.btn_anular.Margin = new System.Windows.Forms.Padding(4);
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.Size = new System.Drawing.Size(81, 41);
            this.btn_anular.TabIndex = 6;
            this.btn_anular.Text = "Anular";
            this.btn_anular.UseVisualStyleBackColor = false;
            this.btn_anular.Click += new System.EventHandler(this.btn_anular_Click);
            // 
            // cmb_dni
            // 
            this.cmb_dni.FormattingEnabled = true;
            this.cmb_dni.Location = new System.Drawing.Point(50, 145);
            this.cmb_dni.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_dni.Name = "cmb_dni";
            this.cmb_dni.Size = new System.Drawing.Size(151, 25);
            this.cmb_dni.TabIndex = 5;
            this.cmb_dni.SelectedIndexChanged += new System.EventHandler(this.cmb_dni_SelectedIndexChanged);
            // 
            // cmb_odontologoC
            // 
            this.cmb_odontologoC.FormattingEnabled = true;
            this.cmb_odontologoC.Location = new System.Drawing.Point(263, 145);
            this.cmb_odontologoC.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_odontologoC.Name = "cmb_odontologoC";
            this.cmb_odontologoC.Size = new System.Drawing.Size(213, 25);
            this.cmb_odontologoC.TabIndex = 3;
            this.cmb_odontologoC.SelectedIndexChanged += new System.EventHandler(this.cmb_odontologoC_SelectedIndexChanged);
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
            this.colum_dni,
            this.colum_paciente,
            this.colum_tratamiento,
            this.colum_estado});
            this.dgv_cita.Location = new System.Drawing.Point(50, 207);
            this.dgv_cita.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_cita.Name = "dgv_cita";
            this.dgv_cita.ReadOnly = true;
            this.dgv_cita.RowHeadersWidth = 51;
            this.dgv_cita.Size = new System.Drawing.Size(707, 219);
            this.dgv_cita.TabIndex = 1;
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
            // colum_odontologo
            // 
            this.colum_odontologo.HeaderText = "Odontologo";
            this.colum_odontologo.MinimumWidth = 6;
            this.colum_odontologo.Name = "colum_odontologo";
            this.colum_odontologo.ReadOnly = true;
            this.colum_odontologo.Width = 120;
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
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-22, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(866, 421);
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
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
            this.Load += new System.EventHandler(this.form_cita_Load);
            this.panel_cita.ResumeLayout(false);
            this.panel_cita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cita;
        private System.Windows.Forms.Button btn_detalle_cita;
        private System.Windows.Forms.Button btn_anular;
        private System.Windows.Forms.ComboBox cmb_dni;
        private System.Windows.Forms.ComboBox cmb_odontologoC;
        private System.Windows.Forms.DataGridView dgv_cita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_idCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_odontologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_estado;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}