namespace CapaPresentacion
{
    partial class form_registroCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_atras = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.dtp_registroCliente = new System.Windows.Forms.DateTimePicker();
            this.btn_inhabilitar_cliente = new System.Windows.Forms.Button();
            this.btn_modificar_Cliente = new System.Windows.Forms.Button();
            this.btn_registrar_Cliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_registroCliente);
            this.groupBox1.Controls.Add(this.txt_Direccion);
            this.groupBox1.Controls.Add(this.txt_Telefono);
            this.groupBox1.Controls.Add(this.cmb_genero);
            this.groupBox1.Controls.Add(this.txt_NombreCliente);
            this.groupBox1.Controls.Add(this.txt_DNI);
            this.groupBox1.Location = new System.Drawing.Point(59, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Paciente:";
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(36, 473);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 4;
            this.btn_atras.Text = "<--";
            this.btn_atras.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Cliente,
            this.dni_Cliente,
            this.nombre_Cliente,
            this.tel_Cliente,
            this.genero_Cliente,
            this.est_Cliente});
            this.dataGridView1.Location = new System.Drawing.Point(135, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(603, 219);
            this.dataGridView1.TabIndex = 5;
            // 
            // id_Cliente
            // 
            this.id_Cliente.HeaderText = "ID";
            this.id_Cliente.Name = "id_Cliente";
            this.id_Cliente.ReadOnly = true;
            // 
            // dni_Cliente
            // 
            this.dni_Cliente.HeaderText = "DNI";
            this.dni_Cliente.Name = "dni_Cliente";
            this.dni_Cliente.ReadOnly = true;
            // 
            // nombre_Cliente
            // 
            this.nombre_Cliente.HeaderText = "Nombre";
            this.nombre_Cliente.Name = "nombre_Cliente";
            this.nombre_Cliente.ReadOnly = true;
            // 
            // tel_Cliente
            // 
            this.tel_Cliente.HeaderText = "Teléfono";
            this.tel_Cliente.Name = "tel_Cliente";
            this.tel_Cliente.ReadOnly = true;
            // 
            // genero_Cliente
            // 
            this.genero_Cliente.HeaderText = "Género";
            this.genero_Cliente.Name = "genero_Cliente";
            this.genero_Cliente.ReadOnly = true;
            // 
            // est_Cliente
            // 
            this.est_Cliente.HeaderText = "Estado";
            this.est_Cliente.Name = "est_Cliente";
            this.est_Cliente.ReadOnly = true;
            // 
            // txt_DNI
            // 
            this.txt_DNI.Location = new System.Drawing.Point(23, 51);
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(156, 22);
            this.txt_DNI.TabIndex = 19;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(325, 51);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(121, 22);
            this.txt_NombreCliente.TabIndex = 20;
            // 
            // cmb_genero
            // 
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Location = new System.Drawing.Point(23, 97);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(156, 24);
            this.cmb_genero.TabIndex = 21;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(325, 101);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(121, 22);
            this.txt_Telefono.TabIndex = 22;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(325, 145);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(121, 22);
            this.txt_Direccion.TabIndex = 24;
            // 
            // dtp_registroCliente
            // 
            this.dtp_registroCliente.Location = new System.Drawing.Point(23, 149);
            this.dtp_registroCliente.Name = "dtp_registroCliente";
            this.dtp_registroCliente.Size = new System.Drawing.Size(262, 22);
            this.dtp_registroCliente.TabIndex = 25;
            // 
            // btn_inhabilitar_cliente
            // 
            this.btn_inhabilitar_cliente.Location = new System.Drawing.Point(588, 188);
            this.btn_inhabilitar_cliente.Name = "btn_inhabilitar_cliente";
            this.btn_inhabilitar_cliente.Size = new System.Drawing.Size(124, 29);
            this.btn_inhabilitar_cliente.TabIndex = 17;
            this.btn_inhabilitar_cliente.Text = "Inhabilitar";
            this.btn_inhabilitar_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_modificar_Cliente
            // 
            this.btn_modificar_Cliente.Location = new System.Drawing.Point(588, 140);
            this.btn_modificar_Cliente.Name = "btn_modificar_Cliente";
            this.btn_modificar_Cliente.Size = new System.Drawing.Size(124, 29);
            this.btn_modificar_Cliente.TabIndex = 16;
            this.btn_modificar_Cliente.Text = "Modificar";
            this.btn_modificar_Cliente.UseVisualStyleBackColor = true;
            // 
            // btn_registrar_Cliente
            // 
            this.btn_registrar_Cliente.Location = new System.Drawing.Point(588, 90);
            this.btn_registrar_Cliente.Name = "btn_registrar_Cliente";
            this.btn_registrar_Cliente.Size = new System.Drawing.Size(124, 29);
            this.btn_registrar_Cliente.TabIndex = 15;
            this.btn_registrar_Cliente.Text = "Registrar";
            this.btn_registrar_Cliente.UseVisualStyleBackColor = true;
            // 
            // form_registroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.btn_inhabilitar_cliente);
            this.Controls.Add(this.btn_modificar_Cliente);
            this.Controls.Add(this.btn_registrar_Cliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_registroCliente";
            this.Text = "form_registroCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn est_Cliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.TextBox txt_DNI;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.DateTimePicker dtp_registroCliente;
        private System.Windows.Forms.Button btn_inhabilitar_cliente;
        private System.Windows.Forms.Button btn_modificar_Cliente;
        private System.Windows.Forms.Button btn_registrar_Cliente;
    }
}