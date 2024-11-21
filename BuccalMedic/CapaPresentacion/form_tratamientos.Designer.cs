namespace CapaPresentacion
{
    partial class form_tratamientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tratamientos));
            this.panel_tratamientos = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tratamiento_btn_Modificar = new System.Windows.Forms.Button();
            this.tratamiento_btn_Inhabilitar = new System.Windows.Forms.Button();
            this.tratamiento_tbx_Descripcion = new System.Windows.Forms.TextBox();
            this.tratamiento_tbx_Nombre_Tratamiento = new System.Windows.Forms.TextBox();
            this.tratamiento_btn_Registrar = new System.Windows.Forms.Button();
            this.tratamientos_dgv = new System.Windows.Forms.DataGridView();
            this.idTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_tratamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientos_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_tratamientos
            // 
            this.panel_tratamientos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_tratamientos.BackColor = System.Drawing.Color.White;
            this.panel_tratamientos.Controls.Add(this.txt_precio);
            this.panel_tratamientos.Controls.Add(this.label1);
            this.panel_tratamientos.Controls.Add(this.label5);
            this.panel_tratamientos.Controls.Add(this.pictureBox2);
            this.panel_tratamientos.Controls.Add(this.tratamiento_btn_Modificar);
            this.panel_tratamientos.Controls.Add(this.tratamiento_btn_Inhabilitar);
            this.panel_tratamientos.Controls.Add(this.tratamiento_tbx_Descripcion);
            this.panel_tratamientos.Controls.Add(this.tratamiento_tbx_Nombre_Tratamiento);
            this.panel_tratamientos.Controls.Add(this.tratamiento_btn_Registrar);
            this.panel_tratamientos.Controls.Add(this.tratamientos_dgv);
            this.panel_tratamientos.Controls.Add(this.label4);
            this.panel_tratamientos.Controls.Add(this.label3);
            this.panel_tratamientos.Controls.Add(this.label2);
            this.panel_tratamientos.Controls.Add(this.pictureBox3);
            this.panel_tratamientos.Location = new System.Drawing.Point(-3, -2);
            this.panel_tratamientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_tratamientos.Name = "panel_tratamientos";
            this.panel_tratamientos.Size = new System.Drawing.Size(608, 438);
            this.panel_tratamientos.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 36);
            this.label5.TabIndex = 22;
            this.label5.Text = "TRATAMIENTOS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 41);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // tratamiento_btn_Modificar
            // 
            this.tratamiento_btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            this.tratamiento_btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tratamiento_btn_Modificar.Location = new System.Drawing.Point(445, 310);
            this.tratamiento_btn_Modificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tratamiento_btn_Modificar.Name = "tratamiento_btn_Modificar";
            this.tratamiento_btn_Modificar.Size = new System.Drawing.Size(100, 31);
            this.tratamiento_btn_Modificar.TabIndex = 15;
            this.tratamiento_btn_Modificar.Text = "Modificar";
            this.tratamiento_btn_Modificar.UseVisualStyleBackColor = false;
            this.tratamiento_btn_Modificar.Click += new System.EventHandler(this.tratamiento_btn_Modificar_Click);
            // 
            // tratamiento_btn_Inhabilitar
            // 
            this.tratamiento_btn_Inhabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(44)))));
            this.tratamiento_btn_Inhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tratamiento_btn_Inhabilitar.Location = new System.Drawing.Point(445, 355);
            this.tratamiento_btn_Inhabilitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tratamiento_btn_Inhabilitar.Name = "tratamiento_btn_Inhabilitar";
            this.tratamiento_btn_Inhabilitar.Size = new System.Drawing.Size(100, 31);
            this.tratamiento_btn_Inhabilitar.TabIndex = 14;
            this.tratamiento_btn_Inhabilitar.Text = "Inhabilitar";
            this.tratamiento_btn_Inhabilitar.UseVisualStyleBackColor = false;
            this.tratamiento_btn_Inhabilitar.Click += new System.EventHandler(this.tratamiento_btn_Inhabilitar_Click);
            // 
            // tratamiento_tbx_Descripcion
            // 
            this.tratamiento_tbx_Descripcion.BackColor = System.Drawing.Color.AliceBlue;
            this.tratamiento_tbx_Descripcion.Location = new System.Drawing.Point(251, 112);
            this.tratamiento_tbx_Descripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tratamiento_tbx_Descripcion.Name = "tratamiento_tbx_Descripcion";
            this.tratamiento_tbx_Descripcion.Size = new System.Drawing.Size(168, 20);
            this.tratamiento_tbx_Descripcion.TabIndex = 13;
            // 
            // tratamiento_tbx_Nombre_Tratamiento
            // 
            this.tratamiento_tbx_Nombre_Tratamiento.BackColor = System.Drawing.Color.AliceBlue;
            this.tratamiento_tbx_Nombre_Tratamiento.Location = new System.Drawing.Point(42, 112);
            this.tratamiento_tbx_Nombre_Tratamiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tratamiento_tbx_Nombre_Tratamiento.Name = "tratamiento_tbx_Nombre_Tratamiento";
            this.tratamiento_tbx_Nombre_Tratamiento.Size = new System.Drawing.Size(195, 20);
            this.tratamiento_tbx_Nombre_Tratamiento.TabIndex = 12;
            // 
            // tratamiento_btn_Registrar
            // 
            this.tratamiento_btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(229)))));
            this.tratamiento_btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tratamiento_btn_Registrar.Location = new System.Drawing.Point(445, 147);
            this.tratamiento_btn_Registrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tratamiento_btn_Registrar.Name = "tratamiento_btn_Registrar";
            this.tratamiento_btn_Registrar.Size = new System.Drawing.Size(100, 31);
            this.tratamiento_btn_Registrar.TabIndex = 11;
            this.tratamiento_btn_Registrar.Text = "Registrar";
            this.tratamiento_btn_Registrar.UseVisualStyleBackColor = false;
            this.tratamiento_btn_Registrar.Click += new System.EventHandler(this.tratamiento_btn_Registrar_Click);
            // 
            // tratamientos_dgv
            // 
            this.tratamientos_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tratamientos_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTratamiento,
            this.Nombre,
            this.Descripcion,
            this.Precio});
            this.tratamientos_dgv.Location = new System.Drawing.Point(42, 254);
            this.tratamientos_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tratamientos_dgv.Name = "tratamientos_dgv";
            this.tratamientos_dgv.RowHeadersWidth = 51;
            this.tratamientos_dgv.RowTemplate.Height = 24;
            this.tratamientos_dgv.Size = new System.Drawing.Size(377, 150);
            this.tratamientos_dgv.TabIndex = 7;
            this.tratamientos_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tratamientos_dgv_CellContentClick);
            // 
            // idTratamiento
            // 
            this.idTratamiento.HeaderText = "idTratamiento";
            this.idTratamiento.MinimumWidth = 6;
            this.idTratamiento.Name = "idTratamiento";
            this.idTratamiento.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "TRATAMIENTOS DISPONIBLES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Tratamiento";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1264, 632);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Precio";
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_precio.Location = new System.Drawing.Point(42, 164);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(2);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(168, 20);
            this.txt_precio.TabIndex = 24;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // form_tratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 433);
            this.Controls.Add(this.panel_tratamientos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form_tratamientos";
            this.Text = "form_tratamientos";
            this.Load += new System.EventHandler(this.form_tratamientos_Load);
            this.panel_tratamientos.ResumeLayout(false);
            this.panel_tratamientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientos_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_tratamientos;
        private System.Windows.Forms.Button tratamiento_btn_Modificar;
        private System.Windows.Forms.Button tratamiento_btn_Inhabilitar;
        private System.Windows.Forms.TextBox tratamiento_tbx_Descripcion;
        private System.Windows.Forms.TextBox tratamiento_tbx_Nombre_Tratamiento;
        private System.Windows.Forms.Button tratamiento_btn_Registrar;
        private System.Windows.Forms.DataGridView tratamientos_dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}