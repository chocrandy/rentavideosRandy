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
    public partial class consulta_renta : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=rentavideos");
        public consulta_renta()
        {
            InitializeComponent();
            txt_codEncab.Clear();
        }

        private void Consulta_renta_Load(object sender, EventArgs e)
        {
            
        }

        void llenarDataGrid()
        {
            //llenado de DataGrid Renta Detalle
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT * FROM `renta_detalle` WHERE ID_ENCABEZADO = " 
                + txt_codEncab.Text + " AND ESTADO = 1 ");
            try
            {
                OdbcDataAdapter eje = new OdbcDataAdapter();
                eje.SelectCommand = cod;
                DataTable datos = new DataTable();
                eje.Fill(datos);
                Dgv_renta.DataSource = datos;
                eje.Update(datos);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostar el DataGrid RENTA DETALLE" + e.ToString());
                conn.Close();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txt_codEncab.Text == "")
            {
                MessageBox.Show("Favor llenar campo", "VERIFICAR", MessageBoxButtons.OK);
            }
            else
            {
                llenarDataGrid();
            }            
        }
    }
}
