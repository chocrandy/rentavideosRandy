namespace CapaVistaFRM
{
    partial class renta_detalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(renta_detalle));
            this.label1 = new System.Windows.Forms.Label();
            this.Gpb_detalle = new System.Windows.Forms.GroupBox();
            this.Txt_codDetalle = new System.Windows.Forms.TextBox();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.Txt_cantidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Cbo_material = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.Dgv_rentaDetalle = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Gpb_encabezado = new System.Windows.Forms.GroupBox();
            this.Dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.Dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.txt_membresia = new System.Windows.Forms.TextBox();
            this.txt_codEncab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gpb_detalle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rentaDetalle)).BeginInit();
            this.Gpb_encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detalle de Renta";
            // 
            // Gpb_detalle
            // 
            this.Gpb_detalle.Controls.Add(this.Txt_codDetalle);
            this.Gpb_detalle.Controls.Add(this.Btn_aceptar);
            this.Gpb_detalle.Controls.Add(this.Txt_cantidad);
            this.Gpb_detalle.Controls.Add(this.label12);
            this.Gpb_detalle.Controls.Add(this.Cbo_material);
            this.Gpb_detalle.Controls.Add(this.label10);
            this.Gpb_detalle.Controls.Add(this.label9);
            this.Gpb_detalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_detalle.Location = new System.Drawing.Point(15, 175);
            this.Gpb_detalle.Name = "Gpb_detalle";
            this.Gpb_detalle.Size = new System.Drawing.Size(880, 102);
            this.Gpb_detalle.TabIndex = 4;
            this.Gpb_detalle.TabStop = false;
            this.Gpb_detalle.Text = "Detalle";
            // 
            // Txt_codDetalle
            // 
            this.Txt_codDetalle.Enabled = false;
            this.Txt_codDetalle.Location = new System.Drawing.Point(20, 60);
            this.Txt_codDetalle.Name = "Txt_codDetalle";
            this.Txt_codDetalle.Size = new System.Drawing.Size(157, 27);
            this.Txt_codDetalle.TabIndex = 26;
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.BackColor = System.Drawing.Color.White;
            this.Btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_aceptar.ForeColor = System.Drawing.Color.Black;
            this.Btn_aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_aceptar.Image")));
            this.Btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_aceptar.Location = new System.Drawing.Point(782, 22);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(87, 67);
            this.Btn_aceptar.TabIndex = 36;
            this.Btn_aceptar.Text = "Aceptar";
            this.Btn_aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_aceptar.UseVisualStyleBackColor = false;
            this.Btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Location = new System.Drawing.Point(574, 60);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.Size = new System.Drawing.Size(169, 27);
            this.Txt_cantidad.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(570, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Cantidad:";
            // 
            // Cbo_material
            // 
            this.Cbo_material.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_material.FormattingEnabled = true;
            this.Cbo_material.Location = new System.Drawing.Point(208, 60);
            this.Cbo_material.Name = "Cbo_material";
            this.Cbo_material.Size = new System.Drawing.Size(349, 29);
            this.Cbo_material.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(204, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Material:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cod. Detalle:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_quitar);
            this.groupBox1.Controls.Add(this.Dgv_rentaDetalle);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 194);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Renta";
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.BackColor = System.Drawing.Color.White;
            this.Btn_quitar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_quitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_quitar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_quitar.ForeColor = System.Drawing.Color.Black;
            this.Btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_quitar.Image")));
            this.Btn_quitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_quitar.Location = new System.Drawing.Point(801, 75);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(71, 53);
            this.Btn_quitar.TabIndex = 37;
            this.Btn_quitar.Text = "Quitar";
            this.Btn_quitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_quitar.UseVisualStyleBackColor = false;
            // 
            // Dgv_rentaDetalle
            // 
            this.Dgv_rentaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_rentaDetalle.Location = new System.Drawing.Point(27, 31);
            this.Dgv_rentaDetalle.Name = "Dgv_rentaDetalle";
            this.Dgv_rentaDetalle.Size = new System.Drawing.Size(748, 147);
            this.Dgv_rentaDetalle.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(118, 515);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Mora:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(351, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "Sub Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(198, 513);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 32);
            this.label14.TabIndex = 31;
            this.label14.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(619, 515);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 23);
            this.label16.TabIndex = 29;
            this.label16.Text = "TOTAL:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(464, 513);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 32);
            this.label15.TabIndex = 34;
            this.label15.Text = "0.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(703, 513);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 32);
            this.label18.TabIndex = 35;
            this.label18.Text = "0.00";
            // 
            // Gpb_encabezado
            // 
            this.Gpb_encabezado.Controls.Add(this.Dtp_fin);
            this.Gpb_encabezado.Controls.Add(this.Dtp_inicio);
            this.Gpb_encabezado.Controls.Add(this.txt_empleado);
            this.Gpb_encabezado.Controls.Add(this.txt_membresia);
            this.Gpb_encabezado.Controls.Add(this.txt_codEncab);
            this.Gpb_encabezado.Controls.Add(this.label6);
            this.Gpb_encabezado.Controls.Add(this.label5);
            this.Gpb_encabezado.Controls.Add(this.label4);
            this.Gpb_encabezado.Controls.Add(this.label3);
            this.Gpb_encabezado.Controls.Add(this.label2);
            this.Gpb_encabezado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_encabezado.Location = new System.Drawing.Point(12, 54);
            this.Gpb_encabezado.Name = "Gpb_encabezado";
            this.Gpb_encabezado.Size = new System.Drawing.Size(886, 105);
            this.Gpb_encabezado.TabIndex = 36;
            this.Gpb_encabezado.TabStop = false;
            this.Gpb_encabezado.Text = "Detalles de la Renta";
            // 
            // Dtp_fin
            // 
            this.Dtp_fin.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fin.CustomFormat = "yyyy-MM-dd";
            this.Dtp_fin.Enabled = false;
            this.Dtp_fin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fin.Location = new System.Drawing.Point(708, 62);
            this.Dtp_fin.Name = "Dtp_fin";
            this.Dtp_fin.Size = new System.Drawing.Size(164, 27);
            this.Dtp_fin.TabIndex = 27;
            this.Dtp_fin.Value = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            // 
            // Dtp_inicio
            // 
            this.Dtp_inicio.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_inicio.CustomFormat = "yyyy-MM-dd";
            this.Dtp_inicio.Enabled = false;
            this.Dtp_inicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_inicio.Location = new System.Drawing.Point(529, 62);
            this.Dtp_inicio.Name = "Dtp_inicio";
            this.Dtp_inicio.Size = new System.Drawing.Size(164, 27);
            this.Dtp_inicio.TabIndex = 26;
            this.Dtp_inicio.Value = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            // 
            // txt_empleado
            // 
            this.txt_empleado.Enabled = false;
            this.txt_empleado.Location = new System.Drawing.Point(366, 62);
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.Size = new System.Drawing.Size(151, 27);
            this.txt_empleado.TabIndex = 23;
            // 
            // txt_membresia
            // 
            this.txt_membresia.Enabled = false;
            this.txt_membresia.Location = new System.Drawing.Point(183, 62);
            this.txt_membresia.Name = "txt_membresia";
            this.txt_membresia.Size = new System.Drawing.Size(162, 27);
            this.txt_membresia.TabIndex = 22;
            // 
            // txt_codEncab
            // 
            this.txt_codEncab.Enabled = false;
            this.txt_codEncab.Location = new System.Drawing.Point(20, 62);
            this.txt_codEncab.Name = "txt_codEncab";
            this.txt_codEncab.Size = new System.Drawing.Size(145, 27);
            this.txt_codEncab.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(704, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha de Devolución:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha de Renta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente (Membresia)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cod. Encabezado";
            // 
            // renta_detalle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(913, 564);
            this.Controls.Add(this.Gpb_encabezado);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gpb_detalle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "renta_detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Renta";
            this.Load += new System.EventHandler(this.Renta_detalle_Load);
            this.Gpb_detalle.ResumeLayout(false);
            this.Gpb_detalle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rentaDetalle)).EndInit();
            this.Gpb_encabezado.ResumeLayout(false);
            this.Gpb_encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_detalle;
        private System.Windows.Forms.TextBox Txt_cantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Cbo_material;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgv_rentaDetalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.Button Btn_quitar;
        private System.Windows.Forms.GroupBox Gpb_encabezado;
        private System.Windows.Forms.TextBox txt_empleado;
        private System.Windows.Forms.TextBox txt_membresia;
        private System.Windows.Forms.TextBox txt_codEncab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_codDetalle;
        private System.Windows.Forms.DateTimePicker Dtp_fin;
        private System.Windows.Forms.DateTimePicker Dtp_inicio;
    }
}