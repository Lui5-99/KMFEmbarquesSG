namespace kmfembarquesSG
{
    partial class frmDeliveries
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
            this.lbDeliveries = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSeleccionados = new System.Windows.Forms.ListBox();
            this.bPasar = new System.Windows.Forms.Button();
            this.bPasarTodos = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEliminarTodos = new System.Windows.Forms.Button();
            this.btExportar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDeliveries
            // 
            this.lbDeliveries.FormattingEnabled = true;
            this.lbDeliveries.ItemHeight = 16;
            this.lbDeliveries.Location = new System.Drawing.Point(23, 21);
            this.lbDeliveries.Name = "lbDeliveries";
            this.lbDeliveries.Size = new System.Drawing.Size(181, 276);
            this.lbDeliveries.TabIndex = 0;
            this.lbDeliveries.SelectedIndexChanged += new System.EventHandler(this.lbDeliveries_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDeliveries);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 315);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deliveries";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSeleccionados);
            this.groupBox2.Location = new System.Drawing.Point(343, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 315);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionados";
            // 
            // lbSeleccionados
            // 
            this.lbSeleccionados.FormattingEnabled = true;
            this.lbSeleccionados.ItemHeight = 16;
            this.lbSeleccionados.Location = new System.Drawing.Point(22, 21);
            this.lbSeleccionados.Name = "lbSeleccionados";
            this.lbSeleccionados.Size = new System.Drawing.Size(181, 276);
            this.lbSeleccionados.TabIndex = 1;
            this.lbSeleccionados.SelectedIndexChanged += new System.EventHandler(this.lbSeleccionados_SelectedIndexChanged);
            // 
            // bPasar
            // 
            this.bPasar.Location = new System.Drawing.Point(264, 69);
            this.bPasar.Name = "bPasar";
            this.bPasar.Size = new System.Drawing.Size(51, 30);
            this.bPasar.TabIndex = 5;
            this.bPasar.Text = ">";
            this.bPasar.UseVisualStyleBackColor = true;
            this.bPasar.Click += new System.EventHandler(this.bPasar_Click);
            // 
            // bPasarTodos
            // 
            this.bPasarTodos.Location = new System.Drawing.Point(264, 33);
            this.bPasarTodos.Name = "bPasarTodos";
            this.bPasarTodos.Size = new System.Drawing.Size(51, 30);
            this.bPasarTodos.TabIndex = 6;
            this.bPasarTodos.Text = ">>";
            this.bPasarTodos.UseVisualStyleBackColor = true;
            this.bPasarTodos.Click += new System.EventHandler(this.bPasarTodos_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(264, 105);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(51, 30);
            this.bEliminar.TabIndex = 7;
            this.bEliminar.Text = "<";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEliminarTodos
            // 
            this.bEliminarTodos.Location = new System.Drawing.Point(264, 141);
            this.bEliminarTodos.Name = "bEliminarTodos";
            this.bEliminarTodos.Size = new System.Drawing.Size(51, 30);
            this.bEliminarTodos.TabIndex = 8;
            this.bEliminarTodos.Text = "<<";
            this.bEliminarTodos.UseVisualStyleBackColor = true;
            this.bEliminarTodos.Click += new System.EventHandler(this.bEliminarTodos_Click);
            // 
            // btExportar
            // 
            this.btExportar.Location = new System.Drawing.Point(254, 331);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(75, 28);
            this.btExportar.TabIndex = 9;
            this.btExportar.Text = "Exportar";
            this.btExportar.UseVisualStyleBackColor = true;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // frmDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(587, 384);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.bEliminarTodos);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bPasarTodos);
            this.Controls.Add(this.bPasar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeliveries";
            this.ShowIcon = false;
            this.Text = "Selección de deliveries";
            this.Load += new System.EventHandler(this.frmDeliveries_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDeliveries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bPasar;
        private System.Windows.Forms.Button bPasarTodos;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEliminarTodos;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.ListBox lbSeleccionados;
    }
}