namespace kmfembarquesSG
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ruta = new System.Windows.Forms.Button();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.txt_Archivo = new System.Windows.Forms.TextBox();
            this.cb_sheet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numeroParteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bCargar = new System.Windows.Forms.Button();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ruta
            // 
            this.btn_ruta.Location = new System.Drawing.Point(934, 415);
            this.btn_ruta.Name = "btn_ruta";
            this.btn_ruta.Size = new System.Drawing.Size(82, 23);
            this.btn_ruta.TabIndex = 0;
            this.btn_ruta.Text = "Examinar";
            this.btn_ruta.UseVisualStyleBackColor = true;
            this.btn_ruta.Click += new System.EventHandler(this.btn_ruta_Click);
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(12, 92);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowTemplate.Height = 24;
            this.dgv_data.Size = new System.Drawing.Size(1004, 288);
            this.dgv_data.TabIndex = 2;
            // 
            // txt_Archivo
            // 
            this.txt_Archivo.Location = new System.Drawing.Point(153, 416);
            this.txt_Archivo.Name = "txt_Archivo";
            this.txt_Archivo.Size = new System.Drawing.Size(775, 22);
            this.txt_Archivo.TabIndex = 3;
            // 
            // cb_sheet
            // 
            this.cb_sheet.FormattingEnabled = true;
            this.cb_sheet.Location = new System.Drawing.Point(153, 467);
            this.cb_sheet.Name = "cb_sheet";
            this.cb_sheet.Size = new System.Drawing.Size(159, 24);
            this.cb_sheet.TabIndex = 4;
            this.cb_sheet.SelectedIndexChanged += new System.EventHandler(this.cb_sheet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hojas de excel:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeroParteToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.deliveriesToolStripMenuItem,
            this.programaDeliveryToolStripMenuItem,
            this.generarReporteToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // numeroParteToolStripMenuItem
            // 
            this.numeroParteToolStripMenuItem.Name = "numeroParteToolStripMenuItem";
            this.numeroParteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.numeroParteToolStripMenuItem.Text = "NumeroParte";
            this.numeroParteToolStripMenuItem.Click += new System.EventHandler(this.numeroParteToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // deliveriesToolStripMenuItem
            // 
            this.deliveriesToolStripMenuItem.Name = "deliveriesToolStripMenuItem";
            this.deliveriesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deliveriesToolStripMenuItem.Text = "Deliveries";
            this.deliveriesToolStripMenuItem.Click += new System.EventHandler(this.deliveriesToolStripMenuItem_Click);
            // 
            // programaDeliveryToolStripMenuItem
            // 
            this.programaDeliveryToolStripMenuItem.Name = "programaDeliveryToolStripMenuItem";
            this.programaDeliveryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.programaDeliveryToolStripMenuItem.Text = "Programa delivery";
            this.programaDeliveryToolStripMenuItem.Click += new System.EventHandler(this.programaDeliveryToolStripMenuItem_Click);
            // 
            // bCargar
            // 
            this.bCargar.Location = new System.Drawing.Point(495, 523);
            this.bCargar.Name = "bCargar";
            this.bCargar.Size = new System.Drawing.Size(82, 33);
            this.bCargar.TabIndex = 9;
            this.bCargar.Text = "Cargar";
            this.bCargar.UseVisualStyleBackColor = true;
            this.bCargar.Click += new System.EventHandler(this.bCargar_Click);
            // 
            // generarReporteToolStripMenuItem
            // 
            this.generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            this.generarReporteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.generarReporteToolStripMenuItem.Text = "Generar reporte";
            this.generarReporteToolStripMenuItem.Click += new System.EventHandler(this.generarReporteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 587);
            this.Controls.Add(this.bCargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_sheet);
            this.Controls.Add(this.txt_Archivo);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_ruta);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KMF Pokayoke Embarques";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ruta;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.TextBox txt_Archivo;
        private System.Windows.Forms.ComboBox cb_sheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeroParteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveriesToolStripMenuItem;
        private System.Windows.Forms.Button bCargar;
        private System.Windows.Forms.ToolStripMenuItem programaDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
    }
}

