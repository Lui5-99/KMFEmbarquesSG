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
using System.Xml;
using KMFEmbarques.Deliveries;

namespace kmfembarquesSG
{
    public partial class frmReporte : Form
    {
        FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
        string sPath;
        DataTable dt = new DataTable();
        public frmReporte()
        {
            InitializeComponent();
        }

        private void bGenerar_Click(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            //Principal
            XmlElement deliveries = doc.CreateElement(string.Empty, "Deliveries", string.Empty);
            doc.AppendChild(deliveries);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Deliveries
                XmlElement delivery = doc.CreateElement(string.Empty, "Delivery", string.Empty);
                deliveries.AppendChild(delivery);

                //IdDeliveryDeatails
                XmlElement IdDeliveryDetails = doc.CreateElement(string.Empty, "IdDeliveryDetails", string.Empty);
                delivery.AppendChild(IdDeliveryDetails);
                XmlText tIdDeliveryDetails = doc.CreateTextNode(dt.Rows[i][0].ToString());
                IdDeliveryDetails.AppendChild(tIdDeliveryDetails);

                //IdDelivery
                XmlElement IdDelivery = doc.CreateElement(string.Empty, "IdDelivery", string.Empty);
                delivery.AppendChild(IdDelivery);
                XmlText tIdDelivery = doc.CreateTextNode(dt.Rows[i][1].ToString());
                IdDelivery.AppendChild(tIdDelivery);

                //IdNumeroParte
                XmlElement IdNumeroParte = doc.CreateElement(string.Empty, "IdNumeroParte", string.Empty);
                delivery.AppendChild(IdNumeroParte);
                XmlText tIdNumeroParte = doc.CreateTextNode(dt.Rows[i][2].ToString());
                IdNumeroParte.AppendChild(tIdNumeroParte);

                //dFecha
                /*XmlElement dFecha = doc.CreateElement(string.Empty, "dFecha", string.Empty);
                delivery.AppendChild(dFecha);
                XmlText tdFecha = doc.CreateTextNode(dt.Rows[i][3].ToString());
                dFecha.AppendChild(tdFecha);*/

                //dHora
                /*XmlElement dHora = doc.CreateElement(string.Empty, "dHora", string.Empty);
                delivery.AppendChild(dHora);
                XmlText tdHora = doc.CreateTextNode(dt.Rows[i][4].ToString());
                dHora.AppendChild(tdHora);*/

                //iPiezasSolicitadas
                XmlElement iPiezasSolicitadas = doc.CreateElement(string.Empty, "iPiezasSolicitadas", string.Empty);
                delivery.AppendChild(iPiezasSolicitadas);
                XmlText tiPiezasSolicitadas = doc.CreateTextNode(dt.Rows[i][5].ToString());
                iPiezasSolicitadas.AppendChild(tiPiezasSolicitadas);

                //iPiezasEmbarcadas
                /*XmlElement iPiezasEmbarcadas = doc.CreateElement(string.Empty, "iPiezasEmbarcadas", string.Empty);
                delivery.AppendChild(iPiezasEmbarcadas);
                XmlText tiPiezasEmbarcadas = doc.CreateTextNode(dt.Rows[i][6].ToString());
                iPiezasEmbarcadas.AppendChild(tiPiezasEmbarcadas);*/

                //IdStatus
                XmlElement IdStatus = doc.CreateElement(string.Empty, "IdStatus", string.Empty);
                delivery.AppendChild(IdStatus);
                XmlText tIdStatus = doc.CreateTextNode(dt.Rows[i][7].ToString());
                IdStatus.AppendChild(tIdStatus);

                //bActivo
                /*XmlElement bActivo = doc.CreateElement(string.Empty, "bActivo", string.Empty);
                IdDeliveryDetails.AppendChild(bActivo);
                if (dt.Rows[i][8].ToString() == "True")
                {
                    XmlText tbActivo = doc.CreateTextNode("1");
                    bActivo.AppendChild(tbActivo);
                }
                else
                {
                    XmlText tbActivo = doc.CreateTextNode("0");
                    bActivo.AppendChild(tbActivo);
                }*/
            }

            doc.Save(ChooseFolder());
            MessageBox.Show("Se guardó el XML");
        }
        public string ChooseFolder()
        {
            DateTime today = DateTime.Today;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                sPath =  folderBrowserDialog1.SelectedPath + "\\reporte_" + today.ToString("yyyyMMdd_") + DateTime.Now.ToString("HHmm") + ".XML";
            }
            return sPath;
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            dt = cDeliveries.ConsultaInnerJoin();
        }
    }
}
