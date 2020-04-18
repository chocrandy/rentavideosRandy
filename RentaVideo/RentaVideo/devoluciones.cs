using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CapaVistaFRM
{
    public partial class devoluciones : Form
    {
        private devo_detalle frm_devo_detalle;

        OdbcConnection conn = new OdbcConnection("Dsn=rentavideos");
        public devoluciones()
        {
            InitializeComponent();
        }

        private void Devoluciones_Load(object sender, EventArgs e)
        {

        }

        private void frm_devo_detalle_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_devo_detalle = null; }
        //devo_detalle

        private void Dtp_inicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_siguiente_Click(object sender, EventArgs e)
        {
            if (txt_membresia.Text == "")
            {
                MessageBox.Show("Debe llenar todo los campos. ", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {                
                //RENTA_DETALLE
                if (frm_devo_detalle == null)
                {
                    frm_devo_detalle = new devo_detalle(txt_membresia.Text, Dtp_inicio.Text);
                    frm_devo_detalle.FormClosed += new FormClosedEventHandler(frm_devo_detalle_FormClosed);
                    frm_devo_detalle.Show();
                }
                else
                {
                    frm_devo_detalle.Activate();
                }
            }
        }

        //SELECT ID_ENCABEZADO FROM `renta_encabezado` WHERE MEMBRESIA=2341 AND FECHA_INICIO='2020-04-17' AND ESTADO=1;
    }
}
