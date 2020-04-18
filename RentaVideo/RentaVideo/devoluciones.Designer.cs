namespace CapaVistaFRM
{
    partial class devoluciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.Gpb_encabezado = new System.Windows.Forms.GroupBox();
            this.Dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.txt_membresia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_siguiente = new System.Windows.Forms.Button();
            this.Gpb_encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Devoluciones";
            // 
            // Gpb_encabezado
            // 
            this.Gpb_encabezado.Controls.Add(this.Btn_siguiente);
            this.Gpb_encabezado.Controls.Add(this.Dtp_inicio);
            this.Gpb_encabezado.Controls.Add(this.txt_membresia);
            this.Gpb_encabezado.Controls.Add(this.label6);
            this.Gpb_encabezado.Controls.Add(this.label3);
            this.Gpb_encabezado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_encabezado.Location = new System.Drawing.Point(37, 99);
            this.Gpb_encabezado.Name = "Gpb_encabezado";
            this.Gpb_encabezado.Size = new System.Drawing.Size(626, 105);
            this.Gpb_encabezado.TabIndex = 37;
            this.Gpb_encabezado.TabStop = false;
            this.Gpb_encabezado.Text = "Detalles de la Devolución";
            // 
            // Dtp_inicio
            // 
            this.Dtp_inicio.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_inicio.CustomFormat = "yyyy-MM-dd";
            this.Dtp_inicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_inicio.Location = new System.Drawing.Point(231, 59);
            this.Dtp_inicio.Name = "Dtp_inicio";
            this.Dtp_inicio.Size = new System.Drawing.Size(164, 27);
            this.Dtp_inicio.TabIndex = 27;
            this.Dtp_inicio.Value = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            this.Dtp_inicio.ValueChanged += new System.EventHandler(this.Dtp_inicio_ValueChanged);
            // 
            // txt_membresia
            // 
            this.txt_membresia.Location = new System.Drawing.Point(24, 59);
            this.txt_membresia.Name = "txt_membresia";
            this.txt_membresia.Size = new System.Drawing.Size(162, 27);
            this.txt_membresia.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha de Registro";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente (Membresia)";
            // 
            // Btn_siguiente
            // 
            this.Btn_siguiente.BackColor = System.Drawing.Color.White;
            this.Btn_siguiente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_siguiente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_siguiente.ForeColor = System.Drawing.Color.Black;
            this.Btn_siguiente.Location = new System.Drawing.Point(452, 39);
            this.Btn_siguiente.Name = "Btn_siguiente";
            this.Btn_siguiente.Size = new System.Drawing.Size(143, 47);
            this.Btn_siguiente.TabIndex = 38;
            this.Btn_siguiente.Text = "Siguiente >>";
            this.Btn_siguiente.UseVisualStyleBackColor = false;
            this.Btn_siguiente.Click += new System.EventHandler(this.Btn_siguiente_Click);
            // 
            // devoluciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(709, 237);
            this.Controls.Add(this.Gpb_encabezado);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "devoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.Devoluciones_Load);
            this.Gpb_encabezado.ResumeLayout(false);
            this.Gpb_encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_encabezado;
        private System.Windows.Forms.DateTimePicker Dtp_inicio;
        private System.Windows.Forms.TextBox txt_membresia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_siguiente;
    }
}