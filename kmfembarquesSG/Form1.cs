using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using KMFTools.Seguridad;
using KMFEmbarques.Deliveries;
using KMFEmbarques.DeliveriesDetails;
using KMFEmbarques.Catalogos;

namespace kmfembarquesSG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        DataTable dt;

        private void btn_ruta_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txt_Archivo.Text = openFileDialog.FileName;
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                                cb_sheet.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                    cb_sheet.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El archivo actual está siendo utilizado por otro programa");
                txt_Archivo.Text = "";
            }
        }

        private void cb_sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = tableCollection[cb_sheet.SelectedItem.ToString()];
            dgv_data.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string sConString = cSeguridad.LeerCadenaConexion();
                if(sConString.Length < 37)
                {
                    frmConfig oConfig = new frmConfig();
                    oConfig.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                cLog.ErrorSistema("Form1", "Form1_Load", ex.Message, "");
            }
        }


        private void numeroParteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNP oNP = new frmNP();
            oNP.ShowDialog();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfig oConfig = new frmConfig();
            oConfig.ShowDialog();
        }

        private void deliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeliveries oDeliveries = new frmDeliveries();
            oDeliveries.ShowDialog();
        }

        private void bCargar_Click(object sender, EventArgs e)
        {
            try
            {
                long IdDelivery13 = long.Parse(DateTime.Today.ToString("yyMMdd") + dt.Rows[3][12].ToString().Substring(0, 2) + dt.Rows[3][13].ToString().Substring(3, 2));
                long IdDelivery18 = long.Parse(DateTime.Today.ToString("yyMMdd") + dt.Rows[3][13].ToString().Substring(0, 2) + dt.Rows[3][13].ToString().Substring(3, 2));
                string sFecha = DateTime.Parse(dt.Rows[0][15].ToString()).ToString("yyyy/MM/dd");
                string sHora13 = DateTime.Parse(dt.Rows[3][12].ToString()).ToString("HH:mm");
                string sHora18 = DateTime.Parse(dt.Rows[3][13].ToString()).ToString("HH:mm");
                for (int j = 0; j < 2; j++)
                {
                    cDeliveries.Nuevo(IdDelivery13, sFecha, sHora13);
                    cDeliveries.Nuevo(IdDelivery18, sFecha, sHora18);
                }
                int i = 4;
                while (dt.Rows[i][10].ToString() != "-")
                {
                    int _auxPiezas13 = 0;
                    int _auxPiezas18 = 0;
                    int _auxISAPPT = 0;
                    _auxISAPPT = int.Parse(dt.Rows[i][10].ToString());
                    
                    if (dt.Rows[i][12].ToString() == "-" || dt.Rows[i][12].ToString() == "-")
                    {
                        _auxPiezas13 = 0;
                        _auxPiezas18 = 0;
                    }
                    else
                    {
                        _auxPiezas13 = int.Parse(dt.Rows[i][12].ToString());
                        _auxPiezas18 = int.Parse(dt.Rows[i][13].ToString());
                    }
                    dgv_data.Rows[i].Cells[8].Style.BackColor = Color.Green;
                    dgv_data.Rows[i].Cells[10].Style.BackColor = Color.Green;
                    dgv_data.Rows[i].Cells[12].Style.BackColor = Color.Green;
                    dgv_data.Rows[i].Cells[13].Style.BackColor = Color.Green;
                    cNumerosParte.Nuevo(dt.Rows[i][8].ToString(), _auxISAPPT);
                    cDeliveriesDetails.Nuevo(IdDelivery13, _auxPiezas13, _auxISAPPT);
                    cDeliveriesDetails.Nuevo(IdDelivery18, _auxPiezas18, _auxISAPPT);
                    
                    i++;
                }
                label1.Text = sFecha;
            }
            catch (Exception ex)
            {
                cLog.ErrorSistema("Form1", "Form1_Load", ex.Message, "");
            }
        }

        private void programaDeliveryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProgramaDelivery oPD = new frmProgramaDelivery();
            oPD.ShowDialog();
        }

        private void generarReporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporte oR = new frmReporte();
            oR.ShowDialog();
        }
    }
}
