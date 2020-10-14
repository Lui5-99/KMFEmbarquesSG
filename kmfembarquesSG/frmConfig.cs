using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMFTools.Seguridad;

namespace kmfembarquesSG
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                slMensaje.Text = "";
                cSeguridad.GuardarCadenaConexion(tServer.Text, tDB.Text, tUser.Text, tPwd.Text);
                MessageBox.Show("Se guardó correctamente!");
            }
            catch(Exception ex)
            {
                slMensaje.Text = "Hubo un error. Contacta a soporte técnico.";
                cLog.ErrorSistema("frmConfig", "btGuardar_Click", ex.Message, "");
            }
        }
    }
}
