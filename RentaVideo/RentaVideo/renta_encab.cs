using RentaVideo;
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
    public partial class renta_encab : Form
    {
        private formato frm_renta_Detalle;

        OdbcConnection conn = new OdbcConnection("Dsn=rentavideos");
        public renta_encab()
        {
            InitializeComponent();
            llenarComboMembresia();
            llenarComboEmpleado();
        }

        private void frm_renta_Detalle_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_renta_Detalle = null; }

        private void Renta_encab_Load(object sender, EventArgs e)
        {
                
        }

        void llenarComboMembresia()
        {
            //llenado de comboBox MEMBRESIA
            try
            {
                Cbo_membresia.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT MEMBRESIA FROM `cliente` WHERE ESTADO = 1", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cbo_membresia.Refresh();
                    //Cbo_membresia.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                    Cbo_membresia.Items.Add(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        void llenarComboEmpleado()
        {
            //llenado de comboBox EMPLEADO
            try
            {
                Cbo_empleado.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT EMPLEADO FROM `empleado` WHERE ESTADO = 1", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cbo_empleado.Refresh();
                    Cbo_empleado.Items.Add(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void Btn_siguiente_Click(object sender, EventArgs e)
        {
            //RENTA_DETALLE
            if (frm_renta_Detalle == null)
            {
                frm_renta_Detalle = new formato();                
                frm_renta_Detalle.FormClosed += new FormClosedEventHandler(frm_renta_Detalle_FormClosed);
                frm_renta_Detalle.Show();
            }
            else
            {
                frm_renta_Detalle.Activate();
            }
        }
    }
}
