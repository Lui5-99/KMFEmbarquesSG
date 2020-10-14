using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMFEmbarques.Deliveries;

namespace kmfembarquesSG
{
    public partial class frmDeliveries : Form
    {
        DataTable dt;
        public List<string> lSeleccionados = new List<string>();
        public frmDeliveries()
        {
            InitializeComponent();
        }

        private void frmDeliveries_Load(object sender, EventArgs e)
        {
            dt = cDeliveries.ConsultaStatus(1);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                lbDeliveries.Items.Add(dt.Rows[i][0].ToString());
            }
        }


        private void bPasarTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lSeleccionados.Add(dt.Rows[i][0].ToString());
                lbSeleccionados.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void bPasar_Click(object sender, EventArgs e)
        {
            try
            {
                lbSeleccionados.Items.Add(lSeleccionados.Last().ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Selecciona un delivery");
            }
        }

        private void lbDeliveries_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lSeleccionados.Add(lbDeliveries.Text);
            
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lbSeleccionados.Items.Clear();
                for (int i = 0; i < lSeleccionados.Count; i++)
                {
                    lbSeleccionados.Items.Add(lSeleccionados[i].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Selecciona un delivery");
            }
        }

        private void bEliminarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                lSeleccionados.Clear();
                lbSeleccionados.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay deliveries para eliminar");
            }
        }

        private void lbSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            lSeleccionados.Remove(lbSeleccionados.Text);
            
        }

        private void btExportar_Click(object sender, EventArgs e)
        {

        }
    }
}
