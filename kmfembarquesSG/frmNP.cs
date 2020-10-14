using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMFEmbarques.Catalogos;
using KMFTools.Seguridad;

namespace kmfembarquesSG
{

    public partial class frmNP : Form
    {
        private bool bNuevo = true;
        private string sNumeroParte = "";
        private string sNumeroParteClienteE = "";
        private string sSAPPT = "";
        private string sActivo = "";
        private bool bActivoE = false;
        public frmNP()
        {
            InitializeComponent();
        }

        private void gvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bNuevo = false;
            //Llenas forma leyendo el registro del grid
            sNumeroParte = gvDatos.CurrentRow.Cells[0].Value.ToString();
            sNumeroParteClienteE = gvDatos.CurrentRow.Cells[1].Value.ToString();
            sSAPPT = gvDatos.CurrentRow.Cells[2].Value.ToString();
            sActivo = gvDatos.CurrentRow.Cells[3].Value.ToString();
            bActivoE = Boolean.Parse(sActivo);
            tCliente.Text = sNumeroParteClienteE;
            tSap.Text = (sSAPPT);
            if(bActivoE)
            {
                chkActivo.Checked = true;
                
            }
            else
            {
                chkActivo.Checked = false;
            }
        }

        private void frmNP_Load(object sender, EventArgs e)
        {
            //Llenar Grid y limpiar forma
            try
            {
                gvDatos.DataSource = cNumerosParte.ConsultaGeneral();
                Limpiar();
            }
            catch(Exception ex)
            {
                cLog.ErrorSistema("frmNP", "frmNP_Load", ex.Message, "");
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                int iSAPPT;
                string sNumeroParteCliente;
                int iNumeroParte;
                if (bNuevo)
                {
                    sNumeroParteCliente = tCliente.Text;
                    iSAPPT = int.Parse(tSap.Text);
                    cNumerosParte.Nuevo(sNumeroParteCliente, iSAPPT);
                    Limpiar();
                }
                else
                {
                    iNumeroParte = int.Parse(sNumeroParte);
                    sNumeroParteClienteE = tCliente.Text;
                    sSAPPT = tSap.Text;
                    iSAPPT = int.Parse(sSAPPT);
                    //Editar e Inactivar
                    cNumerosParte.Editar(iNumeroParte, sNumeroParteClienteE, iSAPPT, chkActivo.Checked);
                    Limpiar();
                }
                gvDatos.DataSource = cNumerosParte.ConsultaGeneral();
            }
            catch(Exception ex)
            {
                cLog.ErrorSistema("frmNP", "frmNP_Load", ex.Message, "");
            }

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            bNuevo = true;
            try
            {
                gvDatos.DataSource = cNumerosParte.ConsultaGeneral();
            }
            catch(Exception ex)
            {
                cLog.ErrorSistema("frmNP", "frmNP_Load", ex.Message, "");
            }
            
        }
        private void Limpiar()
        {
            tCliente.Text = "";
            tSap.Text = "";
            chkActivo.Checked = true;
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
