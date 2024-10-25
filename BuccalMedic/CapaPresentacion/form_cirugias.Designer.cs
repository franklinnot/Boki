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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cirugias));
            this.panel_cirugias = new System.Windows.Forms.Panel();
            this.cirugia_btn_Consultar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cirugias_dgv = new System.Windows.Forms.DataGridView();
            this.cirugia_codigocita = new System.Windows.Forms.ComboBox();
            this.cirugia_cmbox_paciente = new System.Windows.Forms.ComboBox();
            this.cirugia_dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_cirugias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cirugias_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cirugias
            // 
            this.panel_cirugias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_cirugias.BackColor = System.Drawing.Color.White;
            this.panel_cirugias.Controls.Add(this.cirugia_btn_Consultar);
            this.panel_cirugias.Controls.Add(this.pictureBox1);
            this.panel_cirugias.Controls.Add(this.cirugias_dgv);
            this.panel_cirugias.Controls.Add(this.cirugia_codigocita);
            this.panel_cirugias.Controls.Add(this.cirugia_cmbox_paciente);
            this.panel_cirugias.Controls.Add(this.cirugia_dtp_fecha);
            this.panel_cirugias.Controls.Add(this.label4);
            this.panel_cirugias.Controls.Add(this.label3);
            this.panel_cirugias.Controls.Add(this.label2);
            this.panel_cirugias.Controls.Add(this.label1);
            this.panel_cirugias.Controls.Add(this.pictureBox2);
            this.panel_cirugias.Location = new System.Drawing.Point(-4, -3);
            this.panel_cirugias.Name = "panel_cirugias";
            this.panel_cirugias.Size = new System.Drawing.Size(810, 539);
            this.panel_cirugias.TabIndex = 1;
            // 
            // cirugia_btn_Consultar
            // 
            this.cirugia_btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.cirugia_btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cirugia_btn_Consultar.Location = new System.Drawing.Point(83, 419);
            this.cirugia_btn_Consultar.Name = "cirugia_btn_Consultar";
            this.cirugia_btn_Consultar.Size = new System.Drawing.Size(133, 51);
            this.cirugia_btn_Consultar.TabIndex = 11;
            this.cirugia_btn_Consultar.Text = "Consultar";
            this.cirugia_btn_Consultar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(622, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 44);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cirugias_dgv
            // 
            this.cirugias_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cirugias_dgv.Location = new System.Drawing.Point(294, 151);
            this.cirugias_dgv.Name = "cirugias_dgv";
            this.cirugias_dgv.RowHeadersWidth = 51;
            this.cirugias_dgv.RowTemplate.Height = 24;
            this.cirugias_dgv.Size = new System.Drawing.Size(502, 271);
            this.cirugias_dgv.TabIndex = 7;
            // 
            // cirugia_codigocita
            // 
            this.cirugia_codigocita.FormattingEnabled = true;
            this.cirugia_codigocita.Location = new System.Drawing.Point(56, 349);
            this.cirugia_codigocita.Name = "cirugia_codigocita";
            this.cirugia_codigocita.Size = new System.Drawing.Size(121, 24);
            this.cirugia_codigocita.TabIndex = 6;
            // 
            // cirugia_cmbox_paciente
            // 
            this.cirugia_cmbox_paciente.FormattingEnabled = true;
            this.cirugia_cmbox_paciente.Location = new System.Drawing.Point(56, 254);
            this.cirugia_cmbox_paciente.Name = "cirugia_cmbox_paciente";
            this.cirugia_cmbox_paciente.Size = new System.Drawing.Size(200, 24);
            this.cirugia_cmbox_paciente.TabIndex = 5;
            // 
            // cirugia_dtp_fecha
            // 
            this.cirugia_dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cirugia_dtp_fecha.Location = new System.Drawing.Point(56, 169);
            this.cirugia_dtp_fecha.Name = "cirugia_dtp_fecha";
            this.cirugia_dtp_fecha.Size = new System.Drawing.Size(200, 22);
            this.cirugia_dtp_fecha.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(285, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIRUGÍAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(807, 103);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // form_cirugias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel_cirugias);
            this.Name = "form_cirugias";
            this.Text = "Cirugías";
            this.Load += new System.EventHandler(this.form_evaluaciones_Load);
            this.panel_cirugias.ResumeLayout(false);
            this.panel_cirugias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cirugias_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cirugias;
        private System.Windows.Forms.Button cirugia_btn_Consultar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView cirugias_dgv;
        private System.Windows.Forms.ComboBox cirugia_codigocita;
        private System.Windows.Forms.ComboBox cirugia_cmbox_paciente;
        private System.Windows.Forms.DateTimePicker cirugia_dtp_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}