namespace kmfembarquesSG
{
    partial class frmProgramaDelivery
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
            this.cbHoras = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.tCantidad = new System.Windows.Forms.TextBox();
            this.cbNumeroParte = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvDatos = new System.Windows.Forms.DataGridView();
            this.bGuardar = new System.Windows.Forms.Button();
            this.lbFecha = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHoras);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Location = new System.Drawing.Point(44, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programación";
            // 
            // cbHoras
            // 
            this.cbHoras.FormattingEnabled = true;
            this.cbHoras.Location = new System.Drawing.Point(210, 41);
            this.cbHoras.Name = "cbHoras";
            this.cbHoras.Size = new System.Drawing.Size(62, 24);
            this.cbHoras.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(16, 41);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(168, 22);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.Enter += new System.EventHandler(this.dtpFecha_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bAgregar);
            this.groupBox3.Controls.Add(this.tCantidad);
            this.groupBox3.Controls.Add(this.cbNumeroParte);
            this.groupBox3.Location = new System.Drawing.Point(44, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 109);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Número de parte y cantidad";
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(220, 80);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(43, 23);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.Text = "+";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // tCantidad
            // 
            this.tCantidad.Location = new System.Drawing.Point(210, 36);
            this.tCantidad.Name = "tCantidad";
            this.tCantidad.Size = new System.Drawing.Size(62, 22);
            this.tCantidad.TabIndex = 1;
            // 
            // cbNumeroParte
            // 
            this.cbNumeroParte.FormattingEnabled = true;
            this.cbNumeroParte.Location = new System.Drawing.Point(16, 34);
            this.cbNumeroParte.Name = "cbNumeroParte";
            this.cbNumeroParte.Size = new System.Drawing.Size(168, 24);
            this.cbNumeroParte.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvDatos);
            this.groupBox2.Location = new System.Drawing.Point(363, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Número de Parte";
            // 
            // gvDatos
            // 
            this.gvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatos.Location = new System.Drawing.Point(25, 30);
            this.gvDatos.Name = "gvDatos";
            this.gvDatos.RowHeadersWidth = 51;
            this.gvDatos.RowTemplate.Height = 24;
            this.gvDatos.Size = new System.Drawing.Size(325, 176);
            this.gvDatos.TabIndex = 0;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(564, 323);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(106, 23);
            this.bGuardar.TabIndex = 2;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(510, 37);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(99, 17);
            this.lbFecha.TabIndex = 3;
            this.lbFecha.Text = "Fecha y hora: ";
            // 
            // frmProgramaDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 364);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProgramaDelivery";
            this.ShowIcon = false;
            this.Text = "Programa delivery";
            this.Load += new System.EventHandler(this.frmProgramaDelivery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.TextBox tCantidad;
        private System.Windows.Forms.ComboBox cbNumeroParte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.DataGridView gvDatos;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.ComboBox cbHoras;
    }
}