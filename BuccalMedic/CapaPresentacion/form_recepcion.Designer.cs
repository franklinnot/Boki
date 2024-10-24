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
            this.SuspendLayout();
            // 
            // cmb_tratamiento
            // 
            this.cmb_tratamiento.FormattingEnabled = true;
            this.cmb_tratamiento.Location = new System.Drawing.Point(202, 320);
            this.cmb_tratamiento.Name = "cmb_tratamiento";
            this.cmb_tratamiento.Size = new System.Drawing.Size(121, 24);
            this.cmb_tratamiento.TabIndex = 23;
            // 
            // cbx_tratamiento
            // 
            this.cbx_tratamiento.AutoSize = true;
            this.cbx_tratamiento.Location = new System.Drawing.Point(202, 294);
            this.cbx_tratamiento.Name = "cbx_tratamiento";
            this.cbx_tratamiento.Size = new System.Drawing.Size(98, 20);
            this.cbx_tratamiento.TabIndex = 22;
            this.cbx_tratamiento.Text = "Tratamiento";
            this.cbx_tratamiento.UseVisualStyleBackColor = true;
            // 
            // cmb_horario
            // 
            this.cmb_horario.FormattingEnabled = true;
            this.cmb_horario.Location = new System.Drawing.Point(202, 247);
            this.cmb_horario.Name = "cmb_horario";
            this.cmb_horario.Size = new System.Drawing.Size(121, 24);
            this.cmb_horario.TabIndex = 21;
            // 
            // cmb_fecha
            // 
            this.cmb_fecha.FormattingEnabled = true;
            this.cmb_fecha.Location = new System.Drawing.Point(202, 189);
            this.cmb_fecha.Name = "cmb_fecha";
            this.cmb_fecha.Size = new System.Drawing.Size(121, 24);
            this.cmb_fecha.TabIndex = 20;
            // 
            // cmb_odontologo
            // 
            this.cmb_odontologo.FormattingEnabled = true;
            this.cmb_odontologo.Location = new System.Drawing.Point(202, 138);
            this.cmb_odontologo.Name = "cmb_odontologo";
            this.cmb_odontologo.Size = new System.Drawing.Size(121, 24);
            this.cmb_odontologo.TabIndex = 19;
            // 
            // txt_DNI
            // 
            this.txt_DNI.Location = new System.Drawing.Point(202, 76);
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(121, 22);
            this.txt_DNI.TabIndex = 18;
            // 
            // lbl_nombreR
            // 
            this.lbl_nombreR.AutoSize = true;
            this.lbl_nombreR.Location = new System.Drawing.Point(329, 79);
            this.lbl_nombreR.Name = "lbl_nombreR";
            this.lbl_nombreR.Size = new System.Drawing.Size(44, 16);
            this.lbl_nombreR.TabIndex = 17;
            this.lbl_nombreR.Text = "label2";
            // 
            // btn_mostrar_citas
            // 
            this.btn_mostrar_citas.Location = new System.Drawing.Point(446, 277);
            this.btn_mostrar_citas.Name = "btn_mostrar_citas";
            this.btn_mostrar_citas.Size = new System.Drawing.Size(124, 29);
            this.btn_mostrar_citas.TabIndex = 15;
            this.btn_mostrar_citas.Text = "Mostrar Citas";
            this.btn_mostrar_citas.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo_cliente
            // 
            this.btn_nuevo_cliente.Location = new System.Drawing.Point(446, 219);
            this.btn_nuevo_cliente.Name = "btn_nuevo_cliente";
            this.btn_nuevo_cliente.Size = new System.Drawing.Size(124, 29);
            this.btn_nuevo_cliente.TabIndex = 14;
            this.btn_nuevo_cliente.Text = "Nuevo Cliente";
            this.btn_nuevo_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(446, 171);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(124, 29);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_registrarCita
            // 
            this.btn_registrarCita.Location = new System.Drawing.Point(446, 121);
            this.btn_registrarCita.Name = "btn_registrarCita";
            this.btn_registrarCita.Size = new System.Drawing.Size(124, 29);
            this.btn_registrarCita.TabIndex = 12;
            this.btn_registrarCita.Text = "Registrar";
            this.btn_registrarCita.UseVisualStyleBackColor = true;
            // 
            // form_recepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_tratamiento);
            this.Controls.Add(this.cbx_tratamiento);
            this.Controls.Add(this.cmb_horario);
            this.Controls.Add(this.cmb_fecha);
            this.Controls.Add(this.cmb_odontologo);
            this.Controls.Add(this.txt_DNI);
            this.Controls.Add(this.lbl_nombreR);
            this.Controls.Add(this.btn_mostrar_citas);
            this.Controls.Add(this.btn_nuevo_cliente);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_registrarCita);
            this.Name = "form_recepcion";
            this.Text = "Recepcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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