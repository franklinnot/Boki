namespace CapaPresentacion
{
    partial class form_cirugias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cirugias));
            this.panel_cirugias = new System.Windows.Forms.Panel();
            this.cirugia_btn_Limpiar = new System.Windows.Forms.Button();
            this.cirugias_dgv = new System.Windows.Forms.DataGridView();
            this.IdCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cirugia_codigocita = new System.Windows.Forms.ComboBox();
            this.cirugia_cmbox_paciente = new System.Windows.Forms.ComboBox();
            this.cirugia_dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_cirugias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirugias_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cirugias
            // 
            this.panel_cirugias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_cirugias.BackColor = System.Drawing.Color.White;
            this.panel_cirugias.Controls.Add(this.label5);
            this.panel_cirugias.Controls.Add(this.pictureBox1);
            this.panel_cirugias.Controls.Add(this.label1);
            this.panel_cirugias.Controls.Add(this.cirugia_btn_Limpiar);
            this.panel_cirugias.Controls.Add(this.cirugias_dgv);
            this.panel_cirugias.Controls.Add(this.cirugia_codigocita);
            this.panel_cirugias.Controls.Add(this.cirugia_cmbox_paciente);
            this.panel_cirugias.Controls.Add(this.cirugia_dtp_fecha);
            this.panel_cirugias.Controls.Add(this.label4);
            this.panel_cirugias.Controls.Add(this.label3);
            this.panel_cirugias.Controls.Add(this.label2);
            this.panel_cirugias.Controls.Add(this.pictureBox3);
            this.panel_cirugias.Location = new System.Drawing.Point(-4, -3);
            this.panel_cirugias.Name = "panel_cirugias";
            this.panel_cirugias.Size = new System.Drawing.Size(810, 539);
            this.panel_cirugias.TabIndex = 2;
            // 
            // cirugia_btn_Limpiar
            // 
            this.cirugia_btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.cirugia_btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cirugia_btn_Limpiar.Location = new System.Drawing.Point(642, 464);
            this.cirugia_btn_Limpiar.Name = "cirugia_btn_Limpiar";
            this.cirugia_btn_Limpiar.Size = new System.Drawing.Size(133, 45);
            this.cirugia_btn_Limpiar.TabIndex = 11;
            this.cirugia_btn_Limpiar.Text = "Limpiar";
            this.cirugia_btn_Limpiar.UseVisualStyleBackColor = false;
            this.cirugia_btn_Limpiar.Click += new System.EventHandler(this.cirugia_btn_Limpiar_Click);
            // 
            // cirugias_dgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(169)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cirugias_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cirugias_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cirugias_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCita,
            this.Nombre,
            this.Fecha});
            this.cirugias_dgv.Location = new System.Drawing.Point(285, 128);
            this.cirugias_dgv.Name = "cirugias_dgv";
            this.cirugias_dgv.RowHeadersWidth = 51;
            this.cirugias_dgv.RowTemplate.Height = 24;
            this.cirugias_dgv.Size = new System.Drawing.Size(490, 271);
            this.cirugias_dgv.TabIndex = 7;
            // 
            // IdCita
            // 
            this.IdCita.HeaderText = "IdCita";
            this.IdCita.MinimumWidth = 6;
            this.IdCita.Name = "IdCita";
            this.IdCita.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // cirugia_codigocita
            // 
            this.cirugia_codigocita.FormattingEnabled = true;
            this.cirugia_codigocita.Location = new System.Drawing.Point(56, 349);
            this.cirugia_codigocita.Name = "cirugia_codigocita";
            this.cirugia_codigocita.Size = new System.Drawing.Size(121, 24);
            this.cirugia_codigocita.TabIndex = 6;
            this.cirugia_codigocita.SelectedIndexChanged += new System.EventHandler(this.cirugia_codigocita_SelectedIndexChanged);
            // 
            // cirugia_cmbox_paciente
            // 
            this.cirugia_cmbox_paciente.FormattingEnabled = true;
            this.cirugia_cmbox_paciente.Location = new System.Drawing.Point(56, 254);
            this.cirugia_cmbox_paciente.Name = "cirugia_cmbox_paciente";
            this.cirugia_cmbox_paciente.Size = new System.Drawing.Size(200, 24);
            this.cirugia_cmbox_paciente.TabIndex = 5;
            this.cirugia_cmbox_paciente.SelectedIndexChanged += new System.EventHandler(this.cirugia_cmbox_paciente_SelectedIndexChanged);
            // 
            // cirugia_dtp_fecha
            // 
            this.cirugia_dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cirugia_dtp_fecha.Location = new System.Drawing.Point(56, 169);
            this.cirugia_dtp_fecha.Name = "cirugia_dtp_fecha";
            this.cirugia_dtp_fecha.Size = new System.Drawing.Size(200, 22);
            this.cirugia_dtp_fecha.TabIndex = 4;
            this.cirugia_dtp_fecha.ValueChanged += new System.EventHandler(this.cirugia_dtp_fecha_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código de cita:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selecciona Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecciona Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Historial de tratamientos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 44);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "CIRUGÍAS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-149, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(978, 585);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // form_cirugias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel_cirugias);
            this.Name = "form_cirugias";
            this.Text = "form_cirugias";
            this.Load += new System.EventHandler(this.form_cirugias_Load);
            this.panel_cirugias.ResumeLayout(false);
            this.panel_cirugias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirugias_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cirugias;
        private System.Windows.Forms.Button cirugia_btn_Limpiar;
        private System.Windows.Forms.DataGridView cirugias_dgv;
        private System.Windows.Forms.ComboBox cirugia_codigocita;
        private System.Windows.Forms.ComboBox cirugia_cmbox_paciente;
        private System.Windows.Forms.DateTimePicker cirugia_dtp_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}