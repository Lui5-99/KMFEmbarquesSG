namespace kmfembarquesSG
{
    partial class frmNP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNP));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.tSap = new System.Windows.Forms.TextBox();
            this.tCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btNuevo = new System.Windows.Forms.Button();
            this.gvDatos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumeroParteCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSAPPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bACtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.tSap);
            this.groupBox1.Controls.Add(this.tCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btGuardar.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btGuardar, "btGuardar");
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.chkActivo, "chkActivo");
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // tSap
            // 
            resources.ApplyResources(this.tSap, "tSap");
            this.tSap.Name = "tSap";
            // 
            // tCliente
            // 
            resources.ApplyResources(this.tCliente, "tCliente");
            this.tCliente.Name = "tCliente";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btNuevo);
            this.groupBox2.Controls.Add(this.gvDatos);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btNuevo
            // 
            this.btNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btNuevo.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btNuevo, "btNuevo");
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // gvDatos
            // 
            this.gvDatos.AllowUserToAddRows = false;
            this.gvDatos.AllowUserToDeleteRows = false;
            this.gvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.cNumeroParteCliente,
            this.iSAPPT,
            this.bACtivo});
            resources.ApplyResources(this.gvDatos, "gvDatos");
            this.gvDatos.Name = "gvDatos";
            this.gvDatos.ReadOnly = true;
            this.gvDatos.RowTemplate.Height = 24;
            this.gvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDatos_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdNumeroParte";
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // cNumeroParteCliente
            // 
            this.cNumeroParteCliente.DataPropertyName = "cNumeroParteCliente";
            resources.ApplyResources(this.cNumeroParteCliente, "cNumeroParteCliente");
            this.cNumeroParteCliente.Name = "cNumeroParteCliente";
            this.cNumeroParteCliente.ReadOnly = true;
            // 
            // iSAPPT
            // 
            this.iSAPPT.DataPropertyName = "iSAPPT";
            resources.ApplyResources(this.iSAPPT, "iSAPPT");
            this.iSAPPT.Name = "iSAPPT";
            this.iSAPPT.ReadOnly = true;
            // 
            // bACtivo
            // 
            this.bACtivo.DataPropertyName = "bActivo";
            resources.ApplyResources(this.bACtivo, "bACtivo");
            this.bACtivo.Name = "bACtivo";
            this.bACtivo.ReadOnly = true;
            // 
            // frmNP
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNP";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmNP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox tSap;
        private System.Windows.Forms.TextBox tCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvDatos;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroParteCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSAPPT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bACtivo;
    }
}