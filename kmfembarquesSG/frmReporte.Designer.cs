namespace kmfembarquesSG
{
    partial class frmReporte
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
            this.bGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGenerar
            // 
            this.bGenerar.Location = new System.Drawing.Point(161, 84);
            this.bGenerar.Name = "bGenerar";
            this.bGenerar.Size = new System.Drawing.Size(148, 26);
            this.bGenerar.TabIndex = 0;
            this.bGenerar.Text = "Generar reporte ";
            this.bGenerar.UseVisualStyleBackColor = true;
            this.bGenerar.Click += new System.EventHandler(this.bGenerar_Click);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 194);
            this.Controls.Add(this.bGenerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporte";
            this.ShowIcon = false;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGenerar;
    }
}