namespace CapaPresentacion
{
    partial class form_detalleCita
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
            this.lbl_idCita = new System.Windows.Forms.Label();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_fechaCita = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_odontologo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_tratamiento = new System.Windows.Forms.Label();
            this.panel_detalleCita = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_detalleCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_idCita
            // 
            this.lbl_idCita.AutoSize = true;
            this.lbl_idCita.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idCita.Location = new System.Drawing.Point(104, 14);
            this.lbl_idCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idCita.Name = "lbl_idCita";
            this.lbl_idCita.Size = new System.Drawing.Size(192, 17);
            this.lbl_idCita.TabIndex = 0;
            this.lbl_idCita.Text = "DETALLE DE LA CITA - COD01";
            // 
            // lbl_DNI
            // 
            this.lbl_DNI.AutoSize = true;
            this.lbl_DNI.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DNI.Location = new System.Drawing.Point(22, 34);
            this.lbl_DNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(34, 17);
            this.lbl_DNI.TabIndex = 1;
            this.lbl_DNI.Text = "DNI:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_telefono);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.lbl_DNI);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(359, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Paciente:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(22, 63);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(133, 17);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombres Completos:";
            // 
            // lbl_fechaCita
            // 
            this.lbl_fechaCita.AutoSize = true;
            this.lbl_fechaCita.Location = new System.Drawing.Point(23, 84);
            this.lbl_fechaCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechaCita.Name = "lbl_fechaCita";
            this.lbl_fechaCita.Size = new System.Drawing.Size(87, 17);
            this.lbl_fechaCita.TabIndex = 3;
            this.lbl_fechaCita.Text = "Fecha de cita:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(22, 95);
            this.lbl_telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(130, 17);
            this.lbl_telefono.TabIndex = 4;
            this.lbl_telefono.Text = "Numero de telefono:";
            // 
            // lbl_odontologo
            // 
            this.lbl_odontologo.AutoSize = true;
            this.lbl_odontologo.Location = new System.Drawing.Point(23, 52);
            this.lbl_odontologo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_odontologo.Name = "lbl_odontologo";
            this.lbl_odontologo.Size = new System.Drawing.Size(83, 17);
            this.lbl_odontologo.TabIndex = 5;
            this.lbl_odontologo.Text = "Odontologo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_tratamiento);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 278);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(359, 114);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tratamiento:";
            // 
            // lbl_tratamiento
            // 
            this.lbl_tratamiento.AutoSize = true;
            this.lbl_tratamiento.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tratamiento.Location = new System.Drawing.Point(18, 44);
            this.lbl_tratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tratamiento.Name = "lbl_tratamiento";
            this.lbl_tratamiento.Size = new System.Drawing.Size(84, 17);
            this.lbl_tratamiento.TabIndex = 5;
            this.lbl_tratamiento.Text = "Tratamientos";
            // 
            // panel_detalleCita
            // 
            this.panel_detalleCita.Controls.Add(this.groupBox2);
            this.panel_detalleCita.Controls.Add(this.lbl_fechaCita);
            this.panel_detalleCita.Controls.Add(this.lbl_odontologo);
            this.panel_detalleCita.Controls.Add(this.groupBox1);
            this.panel_detalleCita.Controls.Add(this.lbl_idCita);
            this.panel_detalleCita.Location = new System.Drawing.Point(13, 13);
            this.panel_detalleCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_detalleCita.Name = "panel_detalleCita";
            this.panel_detalleCita.Size = new System.Drawing.Size(406, 421);
            this.panel_detalleCita.TabIndex = 6;
            // 
            // form_detalleCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 458);
            this.Controls.Add(this.panel_detalleCita);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_detalleCita";
            this.Text = "form_detalleCita";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_detalleCita.ResumeLayout(false);
            this.panel_detalleCita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_idCita;
        private System.Windows.Forms.Label lbl_DNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_fechaCita;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_odontologo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_tratamiento;
        private System.Windows.Forms.Panel panel_detalleCita;
    }
}