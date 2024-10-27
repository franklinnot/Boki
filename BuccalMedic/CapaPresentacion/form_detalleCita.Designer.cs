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
            this.lbl_odontologo = new System.Windows.Forms.Label();
            this.grb_tratamiento = new System.Windows.Forms.GroupBox();
            this.lbl_recomendacionT = new System.Windows.Forms.Label();
            this.lbl_procedimiento = new System.Windows.Forms.Label();
            this.lbl_tratamiento = new System.Windows.Forms.Label();
            this.panel_detalleCita = new System.Windows.Forms.Panel();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.grb_diagnostico = new System.Windows.Forms.GroupBox();
            this.lbl_recomendacionD = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lsv_tratamientos = new System.Windows.Forms.ListView();
            this.colum1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.grb_tratamiento.SuspendLayout();
            this.panel_detalleCita.SuspendLayout();
            this.grb_diagnostico.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_idCita
            // 
            this.lbl_idCita.AutoSize = true;
            this.lbl_idCita.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idCita.Location = new System.Drawing.Point(14, 15);
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
            this.lbl_DNI.Location = new System.Drawing.Point(14, 28);
            this.lbl_DNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(34, 17);
            this.lbl_DNI.TabIndex = 1;
            this.lbl_DNI.Text = "DNI:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.lbl_DNI);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(368, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Paciente:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(14, 47);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(133, 17);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombres Completos:";
            // 
            // lbl_fechaCita
            // 
            this.lbl_fechaCita.AutoSize = true;
            this.lbl_fechaCita.Location = new System.Drawing.Point(23, 42);
            this.lbl_fechaCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechaCita.Name = "lbl_fechaCita";
            this.lbl_fechaCita.Size = new System.Drawing.Size(87, 17);
            this.lbl_fechaCita.TabIndex = 3;
            this.lbl_fechaCita.Text = "Fecha de cita:";
            // 
            // lbl_odontologo
            // 
            this.lbl_odontologo.AutoSize = true;
            this.lbl_odontologo.Location = new System.Drawing.Point(23, 66);
            this.lbl_odontologo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_odontologo.Name = "lbl_odontologo";
            this.lbl_odontologo.Size = new System.Drawing.Size(83, 17);
            this.lbl_odontologo.TabIndex = 5;
            this.lbl_odontologo.Text = "Odontologo:";
            // 
            // grb_tratamiento
            // 
            this.grb_tratamiento.Controls.Add(this.lbl_recomendacionT);
            this.grb_tratamiento.Controls.Add(this.lbl_procedimiento);
            this.grb_tratamiento.Controls.Add(this.lbl_tratamiento);
            this.grb_tratamiento.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_tratamiento.Location = new System.Drawing.Point(17, 184);
            this.grb_tratamiento.Margin = new System.Windows.Forms.Padding(4);
            this.grb_tratamiento.Name = "grb_tratamiento";
            this.grb_tratamiento.Padding = new System.Windows.Forms.Padding(4);
            this.grb_tratamiento.Size = new System.Drawing.Size(368, 233);
            this.grb_tratamiento.TabIndex = 5;
            this.grb_tratamiento.TabStop = false;
            this.grb_tratamiento.Text = "Tratamiento:";
            // 
            // lbl_recomendacionT
            // 
            this.lbl_recomendacionT.AutoSize = true;
            this.lbl_recomendacionT.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recomendacionT.Location = new System.Drawing.Point(14, 151);
            this.lbl_recomendacionT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recomendacionT.Name = "lbl_recomendacionT";
            this.lbl_recomendacionT.Size = new System.Drawing.Size(117, 17);
            this.lbl_recomendacionT.TabIndex = 8;
            this.lbl_recomendacionT.Text = "Recomendaciones:";
            // 
            // lbl_procedimiento
            // 
            this.lbl_procedimiento.AutoSize = true;
            this.lbl_procedimiento.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_procedimiento.Location = new System.Drawing.Point(14, 87);
            this.lbl_procedimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_procedimiento.Name = "lbl_procedimiento";
            this.lbl_procedimiento.Size = new System.Drawing.Size(168, 17);
            this.lbl_procedimiento.TabIndex = 7;
            this.lbl_procedimiento.Text = "Procedimientos Realizados:";
            // 
            // lbl_tratamiento
            // 
            this.lbl_tratamiento.AutoSize = true;
            this.lbl_tratamiento.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tratamiento.Location = new System.Drawing.Point(12, 29);
            this.lbl_tratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tratamiento.Name = "lbl_tratamiento";
            this.lbl_tratamiento.Size = new System.Drawing.Size(81, 17);
            this.lbl_tratamiento.TabIndex = 5;
            this.lbl_tratamiento.Text = "Tratamiento:";
            // 
            // panel_detalleCita
            // 
            this.panel_detalleCita.Controls.Add(this.lbl_estado);
            this.panel_detalleCita.Controls.Add(this.grb_diagnostico);
            this.panel_detalleCita.Controls.Add(this.grb_tratamiento);
            this.panel_detalleCita.Controls.Add(this.lbl_fechaCita);
            this.panel_detalleCita.Controls.Add(this.lbl_odontologo);
            this.panel_detalleCita.Controls.Add(this.groupBox1);
            this.panel_detalleCita.Controls.Add(this.lbl_idCita);
            this.panel_detalleCita.Location = new System.Drawing.Point(13, 13);
            this.panel_detalleCita.Margin = new System.Windows.Forms.Padding(4);
            this.panel_detalleCita.Name = "panel_detalleCita";
            this.panel_detalleCita.Size = new System.Drawing.Size(406, 432);
            this.panel_detalleCita.TabIndex = 6;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(326, 15);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(59, 17);
            this.lbl_estado.TabIndex = 7;
            this.lbl_estado.Text = "ESTADO";
            // 
            // grb_diagnostico
            // 
            this.grb_diagnostico.Controls.Add(this.lsv_tratamientos);
            this.grb_diagnostico.Controls.Add(this.lbl_recomendacionD);
            this.grb_diagnostico.Controls.Add(this.lbl_resultado);
            this.grb_diagnostico.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_diagnostico.Location = new System.Drawing.Point(17, 184);
            this.grb_diagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.grb_diagnostico.Name = "grb_diagnostico";
            this.grb_diagnostico.Padding = new System.Windows.Forms.Padding(4);
            this.grb_diagnostico.Size = new System.Drawing.Size(368, 233);
            this.grb_diagnostico.TabIndex = 6;
            this.grb_diagnostico.TabStop = false;
            this.grb_diagnostico.Text = "Diagnostico";
            // 
            // lbl_recomendacionD
            // 
            this.lbl_recomendacionD.AutoSize = true;
            this.lbl_recomendacionD.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recomendacionD.Location = new System.Drawing.Point(8, 120);
            this.lbl_recomendacionD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recomendacionD.Name = "lbl_recomendacionD";
            this.lbl_recomendacionD.Size = new System.Drawing.Size(117, 17);
            this.lbl_recomendacionD.TabIndex = 6;
            this.lbl_recomendacionD.Text = "Recomendaciones:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(8, 29);
            this.lbl_resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(75, 17);
            this.lbl_resultado.TabIndex = 5;
            this.lbl_resultado.Text = "Resultados:";
            // 
            // lsv_tratamientos
            // 
            this.lsv_tratamientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colum1});
            this.lsv_tratamientos.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_tratamientos.GridLines = true;
            this.lsv_tratamientos.HideSelection = false;
            this.lsv_tratamientos.Location = new System.Drawing.Point(201, 29);
            this.lsv_tratamientos.Name = "lsv_tratamientos";
            this.lsv_tratamientos.Size = new System.Drawing.Size(148, 197);
            this.lsv_tratamientos.TabIndex = 7;
            this.lsv_tratamientos.UseCompatibleStateImageBehavior = false;
            this.lsv_tratamientos.View = System.Windows.Forms.View.Details;
            // 
            // colum1
            // 
            this.colum1.Text = "Tratamientos:";
            this.colum1.Width = 139;
            // 
            // form_detalleCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 458);
            this.Controls.Add(this.panel_detalleCita);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_detalleCita";
            this.Text = "form_detalleCita";
            this.Load += new System.EventHandler(this.form_detalleCita_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_tratamiento.ResumeLayout(false);
            this.grb_tratamiento.PerformLayout();
            this.panel_detalleCita.ResumeLayout(false);
            this.panel_detalleCita.PerformLayout();
            this.grb_diagnostico.ResumeLayout(false);
            this.grb_diagnostico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_idCita;
        private System.Windows.Forms.Label lbl_DNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_fechaCita;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_odontologo;
        private System.Windows.Forms.GroupBox grb_tratamiento;
        private System.Windows.Forms.Label lbl_tratamiento;
        private System.Windows.Forms.Panel panel_detalleCita;
        private System.Windows.Forms.GroupBox grb_diagnostico;
        private System.Windows.Forms.Label lbl_recomendacionD;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_recomendacionT;
        private System.Windows.Forms.Label lbl_procedimiento;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ListView lsv_tratamientos;
        private System.Windows.Forms.ColumnHeader colum1;
    }
}