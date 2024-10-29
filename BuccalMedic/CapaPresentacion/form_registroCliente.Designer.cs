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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_registroCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.dni_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_inhabilitar_cliente = new System.Windows.Forms.Button();
            this.btn_modificar_Cliente = new System.Windows.Forms.Button();
            this.btn_registrar_Cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_mantenedorCliente = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.panel_mantenedorCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_buscarCliente);
            this.groupBox1.Controls.Add(this.dtp_fecha_nacimiento);
            this.groupBox1.Controls.Add(this.cmb_genero);
            this.groupBox1.Controls.Add(this.txt_NombreCliente);
            this.groupBox1.Controls.Add(this.txt_DNI);
            this.groupBox1.Location = new System.Drawing.Point(85, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(734, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Paciente:";
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.BackColor = System.Drawing.Color.Navy;
            this.btn_buscarCliente.ForeColor = System.Drawing.Color.White;
            this.btn_buscarCliente.Location = new System.Drawing.Point(65, 132);
            this.btn_buscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(97, 34);
            this.btn_buscarCliente.TabIndex = 19;
            this.btn_buscarCliente.Text = "Buscar";
            this.btn_buscarCliente.UseVisualStyleBackColor = false;
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.dtp_fecha_nacimiento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(396, 90);
            this.dtp_fecha_nacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(263, 22);
            this.dtp_fecha_nacimiento.TabIndex = 25;
            // 
            // cmb_genero
            // 
            this.cmb_genero.BackColor = System.Drawing.Color.AliceBlue;
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmb_genero.Location = new System.Drawing.Point(65, 89);
            this.cmb_genero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(253, 24);
            this.cmb_genero.TabIndex = 21;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_NombreCliente.Location = new System.Drawing.Point(396, 43);
            this.txt_NombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(263, 22);
            this.txt_NombreCliente.TabIndex = 20;
            // 
            // txt_DNI
            // 
            this.txt_DNI.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_DNI.Location = new System.Drawing.Point(65, 43);
            this.txt_DNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DNI.MaxLength = 8;
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(253, 22);
            this.txt_DNI.TabIndex = 19;
            this.txt_DNI.TextChanged += new System.EventHandler(this.txt_DNI_TextChanged);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni_Cliente,
            this.nombre_Cliente,
            this.column_fecha_nacimiento,
            this.genero_Cliente,
            this.est_Cliente});
            this.dgv_clientes.Location = new System.Drawing.Point(85, 286);
            this.dgv_clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersVisible = false;
            this.dgv_clientes.RowHeadersWidth = 51;
            this.dgv_clientes.RowTemplate.Height = 24;
            this.dgv_clientes.Size = new System.Drawing.Size(900, 330);
            this.dgv_clientes.TabIndex = 5;
            // 
            // dni_Cliente
            // 
            this.dni_Cliente.HeaderText = "DNI";
            this.dni_Cliente.MinimumWidth = 6;
            this.dni_Cliente.Name = "dni_Cliente";
            this.dni_Cliente.ReadOnly = true;
            this.dni_Cliente.Width = 80;
            // 
            // nombre_Cliente
            // 
            this.nombre_Cliente.HeaderText = "Nombre";
            this.nombre_Cliente.MinimumWidth = 6;
            this.nombre_Cliente.Name = "nombre_Cliente";
            this.nombre_Cliente.ReadOnly = true;
            this.nombre_Cliente.Width = 200;
            // 
            // column_fecha_nacimiento
            // 
            this.column_fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            this.column_fecha_nacimiento.MinimumWidth = 6;
            this.column_fecha_nacimiento.Name = "column_fecha_nacimiento";
            this.column_fecha_nacimiento.ReadOnly = true;
            this.column_fecha_nacimiento.Width = 150;
            // 
            // genero_Cliente
            // 
            this.genero_Cliente.HeaderText = "Género";
            this.genero_Cliente.MinimumWidth = 6;
            this.genero_Cliente.Name = "genero_Cliente";
            this.genero_Cliente.ReadOnly = true;
            this.genero_Cliente.Width = 85;
            // 
            // est_Cliente
            // 
            this.est_Cliente.HeaderText = "Estado";
            this.est_Cliente.MinimumWidth = 6;
            this.est_Cliente.Name = "est_Cliente";
            this.est_Cliente.ReadOnly = true;
            this.est_Cliente.Width = 150;
            // 
            // btn_inhabilitar_cliente
            // 
            this.btn_inhabilitar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(44)))));
            this.btn_inhabilitar_cliente.Location = new System.Drawing.Point(861, 195);
            this.btn_inhabilitar_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inhabilitar_cliente.Name = "btn_inhabilitar_cliente";
            this.btn_inhabilitar_cliente.Size = new System.Drawing.Size(124, 43);
            this.btn_inhabilitar_cliente.TabIndex = 17;
            this.btn_inhabilitar_cliente.Text = "Inhabilitar";
            this.btn_inhabilitar_cliente.UseVisualStyleBackColor = false;
            this.btn_inhabilitar_cliente.Click += new System.EventHandler(this.btn_inhabilitar_cliente_Click);
            // 
            // btn_modificar_Cliente
            // 
            this.btn_modificar_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            this.btn_modificar_Cliente.Location = new System.Drawing.Point(861, 147);
            this.btn_modificar_Cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar_Cliente.Name = "btn_modificar_Cliente";
            this.btn_modificar_Cliente.Size = new System.Drawing.Size(124, 43);
            this.btn_modificar_Cliente.TabIndex = 16;
            this.btn_modificar_Cliente.Text = "Modificar";
            this.btn_modificar_Cliente.UseVisualStyleBackColor = false;
            this.btn_modificar_Cliente.Click += new System.EventHandler(this.btn_modificar_Cliente_Click);
            // 
            // btn_registrar_Cliente
            // 
            this.btn_registrar_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(229)))));
            this.btn_registrar_Cliente.Location = new System.Drawing.Point(861, 97);
            this.btn_registrar_Cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_registrar_Cliente.Name = "btn_registrar_Cliente";
            this.btn_registrar_Cliente.Size = new System.Drawing.Size(124, 43);
            this.btn_registrar_Cliente.TabIndex = 15;
            this.btn_registrar_Cliente.Text = "Registrar";
            this.btn_registrar_Cliente.UseVisualStyleBackColor = false;
            this.btn_registrar_Cliente.Click += new System.EventHandler(this.btn_registrar_Cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "PACIENTES";
            // 
            // panel_mantenedorCliente
            // 
            this.panel_mantenedorCliente.Controls.Add(this.pictureBox2);
            this.panel_mantenedorCliente.Controls.Add(this.label1);
            this.panel_mantenedorCliente.Controls.Add(this.btn_inhabilitar_cliente);
            this.panel_mantenedorCliente.Controls.Add(this.btn_modificar_Cliente);
            this.panel_mantenedorCliente.Controls.Add(this.btn_registrar_Cliente);
            this.panel_mantenedorCliente.Controls.Add(this.dgv_clientes);
            this.panel_mantenedorCliente.Controls.Add(this.groupBox1);
            this.panel_mantenedorCliente.Controls.Add(this.pictureBox1);
            this.panel_mantenedorCliente.Location = new System.Drawing.Point(-3, -4);
            this.panel_mantenedorCliente.Margin = new System.Windows.Forms.Padding(4);
            this.panel_mantenedorCliente.Name = "panel_mantenedorCliente";
            this.panel_mantenedorCliente.Size = new System.Drawing.Size(1081, 677);
            this.panel_mantenedorCliente.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1078, 674);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 51);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // form_registroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 666);
            this.Controls.Add(this.panel_mantenedorCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_registroCliente";
            this.Text = "form_registroCliente";
            this.Load += new System.EventHandler(this.form_registroCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.panel_mantenedorCliente.ResumeLayout(false);
            this.panel_mantenedorCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.TextBox txt_DNI;
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
        private System.Windows.Forms.Panel panel_mantenedorCliente;
        private System.Windows.Forms.Button btn_buscarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}