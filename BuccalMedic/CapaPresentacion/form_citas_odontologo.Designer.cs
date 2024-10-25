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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_atender = new System.Windows.Forms.Button();
            this.cmb_codRC = new System.Windows.Forms.ComboBox();
            this.cmb_pacienteRC = new System.Windows.Forms.ComboBox();
            this.dtp_fechaRC = new System.Windows.Forms.DateTimePicker();
            this.dgv_cita = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cita)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cita
            // 
            this.panel_cita.Controls.Add(this.pictureBox1);
            this.panel_cita.Controls.Add(this.label5);
            this.panel_cita.Controls.Add(this.label4);
            this.panel_cita.Controls.Add(this.label3);
            this.panel_cita.Controls.Add(this.label1);
            this.panel_cita.Controls.Add(this.btn_atender);
            this.panel_cita.Controls.Add(this.cmb_codRC);
            this.panel_cita.Controls.Add(this.cmb_pacienteRC);
            this.panel_cita.Controls.Add(this.dtp_fechaRC);
            this.panel_cita.Controls.Add(this.dgv_cita);
            this.panel_cita.Location = new System.Drawing.Point(26, 13);
            this.panel_cita.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cita.Name = "panel_cita";
            this.panel_cita.Size = new System.Drawing.Size(739, 493);
            this.panel_cita.TabIndex = 1;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.label4.Location = new System.Drawing.Point(47, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Codigo de cita:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(47, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccionar Paciente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Revisar Citas";
            // 
            // btn_atender
            // 
            this.btn_atender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.btn_atender.Location = new System.Drawing.Point(323, 425);
            this.btn_atender.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atender.Name = "btn_atender";
            this.btn_atender.Size = new System.Drawing.Size(67, 30);
            this.btn_atender.TabIndex = 6;
            this.btn_atender.Text = "Atender";
            this.btn_atender.UseVisualStyleBackColor = false;
            // 
            // cmb_codRC
            // 
            this.cmb_codRC.FormattingEnabled = true;
            this.cmb_codRC.Location = new System.Drawing.Point(152, 82);
            this.cmb_codRC.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_codRC.Name = "cmb_codRC";
            this.cmb_codRC.Size = new System.Drawing.Size(107, 21);
            this.cmb_codRC.TabIndex = 5;
            // 
            // cmb_pacienteRC
            // 
            this.cmb_pacienteRC.FormattingEnabled = true;
            this.cmb_pacienteRC.Location = new System.Drawing.Point(166, 118);
            this.cmb_pacienteRC.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_pacienteRC.Name = "cmb_pacienteRC";
            this.cmb_pacienteRC.Size = new System.Drawing.Size(209, 21);
            this.cmb_pacienteRC.TabIndex = 4;
            // 
            // dtp_fechaRC
            // 
            this.dtp_fechaRC.Location = new System.Drawing.Point(414, 82);
            this.dtp_fechaRC.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fechaRC.Name = "dtp_fechaRC";
            this.dtp_fechaRC.Size = new System.Drawing.Size(250, 20);
            this.dtp_fechaRC.TabIndex = 2;
            // 
            // dgv_cita
            // 
            this.dgv_cita.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cita.Location = new System.Drawing.Point(50, 160);
            this.dgv_cita.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_cita.Name = "dgv_cita";
            this.dgv_cita.Size = new System.Drawing.Size(648, 222);
            this.dgv_cita.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.label5.Location = new System.Drawing.Point(294, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Seleccionar fecha:";
            // 
            // form_citas_odontologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.panel_cita);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_atender;
        private System.Windows.Forms.ComboBox cmb_codRC;
        private System.Windows.Forms.ComboBox cmb_pacienteRC;
        private System.Windows.Forms.DateTimePicker dtp_fechaRC;
        private System.Windows.Forms.DataGridView dgv_cita;
        private System.Windows.Forms.Label label5;
    }
}