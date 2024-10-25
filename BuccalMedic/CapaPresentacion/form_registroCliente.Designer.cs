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
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.btn_atras = new System.Windows.Forms.Button();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.btn_inhabilitar_cliente = new System.Windows.Forms.Button();
            this.btn_modificar_Cliente = new System.Windows.Forms.Button();
            this.btn_registrar_Cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dni_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_fecha_nacimiento);
            this.groupBox1.Controls.Add(this.txt_Direccion);
            this.groupBox1.Controls.Add(this.cmb_genero);
            this.groupBox1.Controls.Add(this.txt_NombreCliente);
            this.groupBox1.Controls.Add(this.txt_DNI);
            this.groupBox1.Location = new System.Drawing.Point(110, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(454, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Paciente:";
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(17, 121);
            this.dtp_fecha_nacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(198, 20);
            this.dtp_fecha_nacimiento.TabIndex = 25;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(261, 80);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(154, 20);
            this.txt_Direccion.TabIndex = 24;
            // 
            // cmb_genero
            // 
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmb_genero.Location = new System.Drawing.Point(17, 79);
            this.cmb_genero.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(198, 21);
            this.cmb_genero.TabIndex = 21;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(261, 41);
            this.txt_NombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(154, 20);
            this.txt_NombreCliente.TabIndex = 20;
            // 
            // txt_DNI
            // 
            this.txt_DNI.Location = new System.Drawing.Point(17, 41);
            this.txt_DNI.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(198, 20);
            this.txt_DNI.TabIndex = 19;
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(110, 491);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(57, 19);
            this.btn_atras.TabIndex = 4;
            this.btn_atras.Text = "<--";
            this.btn_atras.UseVisualStyleBackColor = true;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni_Cliente,
            this.nombre_Cliente,
            this.column_fecha_nacimiento,
            this.genero_Cliente,
            this.est_Cliente});
            this.dgv_clientes.Location = new System.Drawing.Point(110, 242);
            this.dgv_clientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersVisible = false;
            this.dgv_clientes.RowTemplate.Height = 24;
            this.dgv_clientes.Size = new System.Drawing.Size(565, 235);
            this.dgv_clientes.TabIndex = 5;
            // 
            // btn_inhabilitar_cliente
            // 
            this.btn_inhabilitar_cliente.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_inhabilitar_cliente.Location = new System.Drawing.Point(582, 171);
            this.btn_inhabilitar_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_inhabilitar_cliente.Name = "btn_inhabilitar_cliente";
            this.btn_inhabilitar_cliente.Size = new System.Drawing.Size(93, 35);
            this.btn_inhabilitar_cliente.TabIndex = 17;
            this.btn_inhabilitar_cliente.Text = "Inhabilitar";
            this.btn_inhabilitar_cliente.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_Cliente
            // 
            this.btn_modificar_Cliente.BackColor = System.Drawing.Color.Orange;
            this.btn_modificar_Cliente.Location = new System.Drawing.Point(582, 132);
            this.btn_modificar_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificar_Cliente.Name = "btn_modificar_Cliente";
            this.btn_modificar_Cliente.Size = new System.Drawing.Size(93, 35);
            this.btn_modificar_Cliente.TabIndex = 16;
            this.btn_modificar_Cliente.Text = "Modificar";
            this.btn_modificar_Cliente.UseVisualStyleBackColor = false;
            this.btn_modificar_Cliente.Click += new System.EventHandler(this.btn_modificar_Cliente_Click);
            // 
            // btn_registrar_Cliente
            // 
            this.btn_registrar_Cliente.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_registrar_Cliente.Location = new System.Drawing.Point(582, 91);
            this.btn_registrar_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registrar_Cliente.Name = "btn_registrar_Cliente";
            this.btn_registrar_Cliente.Size = new System.Drawing.Size(93, 35);
            this.btn_registrar_Cliente.TabIndex = 15;
            this.btn_registrar_Cliente.Text = "Registrar";
            this.btn_registrar_Cliente.UseVisualStyleBackColor = false;
            this.btn_registrar_Cliente.Click += new System.EventHandler(this.btn_registrar_Cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pacientes";
            // 
            // dni_Cliente
            // 
            this.dni_Cliente.HeaderText = "DNI";
            this.dni_Cliente.Name = "dni_Cliente";
            this.dni_Cliente.ReadOnly = true;
            this.dni_Cliente.Width = 80;
            // 
            // nombre_Cliente
            // 
            this.nombre_Cliente.HeaderText = "Nombre";
            this.nombre_Cliente.Name = "nombre_Cliente";
            this.nombre_Cliente.ReadOnly = true;
            this.nombre_Cliente.Width = 170;
            // 
            // column_fecha_nacimiento
            // 
            this.column_fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            this.column_fecha_nacimiento.Name = "column_fecha_nacimiento";
            this.column_fecha_nacimiento.ReadOnly = true;
            this.column_fecha_nacimiento.Width = 150;
            // 
            // genero_Cliente
            // 
            this.genero_Cliente.HeaderText = "Género";
            this.genero_Cliente.Name = "genero_Cliente";
            this.genero_Cliente.ReadOnly = true;
            this.genero_Cliente.Width = 80;
            // 
            // est_Cliente
            // 
            this.est_Cliente.HeaderText = "Estado";
            this.est_Cliente.Name = "est_Cliente";
            this.est_Cliente.ReadOnly = true;
            this.est_Cliente.Width = 80;
            // 
            // form_registroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_inhabilitar_cliente);
            this.Controls.Add(this.btn_modificar_Cliente);
            this.Controls.Add(this.btn_registrar_Cliente);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_registroCliente";
            this.Text = "form_registroCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.TextBox txt_DNI;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.Button btn_inhabilitar_cliente;
        private System.Windows.Forms.Button btn_modificar_Cliente;
        private System.Windows.Forms.Button btn_registrar_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn est_Cliente;
    }
}