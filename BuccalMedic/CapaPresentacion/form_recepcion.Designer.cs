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
            this.panel_Recepcion = new System.Windows.Forms.Panel();
            this.cmb_tratamiento = new System.Windows.Forms.ComboBox();
            this.cbx_tratamiento = new System.Windows.Forms.CheckBox();
            this.cmb_horario = new System.Windows.Forms.ComboBox();
            this.cmb_fecha = new System.Windows.Forms.ComboBox();
            this.cmb_odontologo = new System.Windows.Forms.ComboBox();
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.lbl_nombreR = new System.Windows.Forms.Label();
            this.btn_mostrar_citas = new System.Windows.Forms.Button();
            this.btn_nuevo_cliente = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_registrarCita = new System.Windows.Forms.Button();
            this.panel_Recepcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Recepcion
            // 
            this.panel_Recepcion.Controls.Add(this.cmb_tratamiento);
            this.panel_Recepcion.Controls.Add(this.cbx_tratamiento);
            this.panel_Recepcion.Controls.Add(this.cmb_horario);
            this.panel_Recepcion.Controls.Add(this.cmb_fecha);
            this.panel_Recepcion.Controls.Add(this.cmb_odontologo);
            this.panel_Recepcion.Controls.Add(this.txt_DNI);
            this.panel_Recepcion.Controls.Add(this.lbl_nombreR);
            this.panel_Recepcion.Controls.Add(this.btn_mostrar_citas);
            this.panel_Recepcion.Controls.Add(this.btn_nuevo_cliente);
            this.panel_Recepcion.Controls.Add(this.btn_cancelar);
            this.panel_Recepcion.Controls.Add(this.btn_registrarCita);
            this.panel_Recepcion.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Recepcion.Location = new System.Drawing.Point(130, 174);
            this.panel_Recepcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Recepcion.Name = "panel_Recepcion";
            this.panel_Recepcion.Size = new System.Drawing.Size(546, 306);
            this.panel_Recepcion.TabIndex = 0;
            // 
            // cmb_tratamiento
            // 
            this.cmb_tratamiento.BackColor = System.Drawing.Color.Lavender;
            this.cmb_tratamiento.FormattingEnabled = true;
            this.cmb_tratamiento.Location = new System.Drawing.Point(208, 206);
            this.cmb_tratamiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_tratamiento.Name = "cmb_tratamiento";
            this.cmb_tratamiento.Size = new System.Drawing.Size(114, 25);
            this.cmb_tratamiento.TabIndex = 34;
            // 
            // cbx_tratamiento
            // 
            this.cbx_tratamiento.AutoSize = true;
            this.cbx_tratamiento.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_tratamiento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_tratamiento.Location = new System.Drawing.Point(213, 176);
            this.cbx_tratamiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_tratamiento.Name = "cbx_tratamiento";
            this.cbx_tratamiento.Size = new System.Drawing.Size(109, 22);
            this.cbx_tratamiento.TabIndex = 33;
            this.cbx_tratamiento.Text = "Tratamiento";
            this.cbx_tratamiento.UseVisualStyleBackColor = false;
            // 
            // cmb_horario
            // 
            this.cmb_horario.BackColor = System.Drawing.Color.Lavender;
            this.cmb_horario.FormattingEnabled = true;
            this.cmb_horario.Location = new System.Drawing.Point(208, 126);
            this.cmb_horario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_horario.Name = "cmb_horario";
            this.cmb_horario.Size = new System.Drawing.Size(114, 25);
            this.cmb_horario.TabIndex = 32;
            // 
            // cmb_fecha
            // 
            this.cmb_fecha.BackColor = System.Drawing.Color.Lavender;
            this.cmb_fecha.FormattingEnabled = true;
            this.cmb_fecha.Location = new System.Drawing.Point(34, 206);
            this.cmb_fecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_fecha.Name = "cmb_fecha";
            this.cmb_fecha.Size = new System.Drawing.Size(114, 25);
            this.cmb_fecha.TabIndex = 31;
            // 
            // cmb_odontologo
            // 
            this.cmb_odontologo.BackColor = System.Drawing.Color.Lavender;
            this.cmb_odontologo.FormattingEnabled = true;
            this.cmb_odontologo.Location = new System.Drawing.Point(34, 126);
            this.cmb_odontologo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_odontologo.Name = "cmb_odontologo";
            this.cmb_odontologo.Size = new System.Drawing.Size(114, 25);
            this.cmb_odontologo.TabIndex = 30;
            // 
            // txt_DNI
            // 
            this.txt_DNI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_DNI.Location = new System.Drawing.Point(67, 53);
            this.txt_DNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(121, 24);
            this.txt_DNI.TabIndex = 29;
            this.txt_DNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DNI.TextChanged += new System.EventHandler(this.txt_DNI_TextChanged);
            // 
            // lbl_nombreR
            // 
            this.lbl_nombreR.AutoSize = true;
            this.lbl_nombreR.Location = new System.Drawing.Point(205, 56);
            this.lbl_nombreR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombreR.Name = "lbl_nombreR";
            this.lbl_nombreR.Size = new System.Drawing.Size(45, 17);
            this.lbl_nombreR.TabIndex = 28;
            this.lbl_nombreR.Text = "label2";
            // 
            // btn_mostrar_citas
            // 
            this.btn_mostrar_citas.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_mostrar_citas.Location = new System.Drawing.Point(383, 228);
            this.btn_mostrar_citas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_mostrar_citas.Name = "btn_mostrar_citas";
            this.btn_mostrar_citas.Size = new System.Drawing.Size(112, 48);
            this.btn_mostrar_citas.TabIndex = 27;
            this.btn_mostrar_citas.Text = "Mostrar \r\nCitas";
            this.btn_mostrar_citas.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo_cliente
            // 
            this.btn_nuevo_cliente.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_nuevo_cliente.Location = new System.Drawing.Point(383, 162);
            this.btn_nuevo_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_nuevo_cliente.Name = "btn_nuevo_cliente";
            this.btn_nuevo_cliente.Size = new System.Drawing.Size(112, 49);
            this.btn_nuevo_cliente.TabIndex = 26;
            this.btn_nuevo_cliente.Text = "Nuevo \r\nCliente";
            this.btn_nuevo_cliente.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.Location = new System.Drawing.Point(383, 101);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(112, 40);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_registrarCita
            // 
            this.btn_registrarCita.BackColor = System.Drawing.Color.Lime;
            this.btn_registrarCita.Location = new System.Drawing.Point(383, 44);
            this.btn_registrarCita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_registrarCita.Name = "btn_registrarCita";
            this.btn_registrarCita.Size = new System.Drawing.Size(112, 40);
            this.btn_registrarCita.TabIndex = 24;
            this.btn_registrarCita.Text = "Registrar";
            this.btn_registrarCita.UseVisualStyleBackColor = false;
            // 
            // form_recepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.panel_Recepcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_recepcion";
            this.Text = "Recepcion";
            this.Load += new System.EventHandler(this.form_recepcion_Load);
            this.panel_Recepcion.ResumeLayout(false);
            this.panel_Recepcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Recepcion;
        private System.Windows.Forms.ComboBox cmb_tratamiento;
        private System.Windows.Forms.CheckBox cbx_tratamiento;
        private System.Windows.Forms.ComboBox cmb_horario;
        private System.Windows.Forms.ComboBox cmb_fecha;
        private System.Windows.Forms.ComboBox cmb_odontologo;
        private System.Windows.Forms.TextBox txt_DNI;
        private System.Windows.Forms.Label lbl_nombreR;
        private System.Windows.Forms.Button btn_mostrar_citas;
        private System.Windows.Forms.Button btn_nuevo_cliente;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_registrarCita;
    }
}