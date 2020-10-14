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
using KMFEmbarques.Deliveries;
using KMFEmbarques.DeliveriesDetails;

namespace kmfembarquesSG
{
    public partial class frmProgramaDelivery : Form
    {
        DataTable dt;
        DataTable datos = new DataTable();
        DateTime date;
        List<string> horas = new List<string>();
        string hora = "";
        string fecha = "";
        int iPiezasSolicitadas = 0;
        int iSAPPT = 0;
        public frmProgramaDelivery()
        {
            InitializeComponent();
        }

        private void frmProgramaDelivery_Load(object sender, EventArgs e)
        {
            
            date = new DateTime();
            date = DateTime.Now;
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dt = cNumerosParte.ConsultaActivos(true);
            datos.Columns.Add("SAPPT");
            datos.Columns.Add("Cantidad");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbNumeroParte.Items.Add(dt.Rows[i][2]);
            }
            for(int i = 0; i < 24; i++)
            {
                if(i.ToString().Length < 2)
                {
                    hora = "0"+ i + ":00";
                    cbHoras.Items.Add(hora);
                }
                else
                {
                    hora = i + ":00";
                    cbHoras.Items.Add(hora);
                }
                
            }
            hora = "";
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            DataRow row = datos.NewRow();
            string SAPPT = Convert.ToString(cbNumeroParte.Text);
            string cantidad = tCantidad.Text;
            fecha = dtpFecha.Value.ToString("dd/MM/yyyy");
            hora = Convert.ToString(cbHoras.Text);
            row["SAPPT"] = SAPPT;
            row["Cantidad"] = cantidad;
            datos.Rows.Add(row);
            gvDatos.DataSource = datos;
            lbFecha.Text += " " + fecha + " " + hora;
            tCantidad.Text = "";
            cbNumeroParte.Text = "";
            cbHoras.Text = "";
        }

        private void dtpFecha_Enter(object sender, EventArgs e)
        {
            dtpFecha.MinDate = DateTime.Now;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            string _auxIdDelivery = dtpFecha.Value.ToString("yyMMdd") + hora.Substring(0, 2) + hora.Substring(3,2);
            long IdDelivery = long.Parse(_auxIdDelivery);
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                iPiezasSolicitadas = int.Parse(datos.Rows[0][1].ToString());
                iSAPPT = int.Parse(datos.Rows[0][0].ToString());
                cDeliveries.Nuevo(IdDelivery, fecha, hora);
                cDeliveriesDetails.Nuevo(IdDelivery, iPiezasSolicitadas, iSAPPT);
            }
            datos.Clear();
            
        }
    }
}
