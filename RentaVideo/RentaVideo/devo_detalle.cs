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
    public partial class devo_detalle : Form
    {
        String memG, fechaG;
        OdbcConnection conn = new OdbcConnection("Dsn=rentavideos");
        public devo_detalle(String membresia, String inicio)
        {
            InitializeComponent();
            txt_codDetalle.Clear();
            llenarDataGrid(membresia, inicio);
            memG = membresia;
            fechaG = inicio;
        }
        
        private void Consulta_renta_Load(object sender, EventArgs e)
        {
            
        }

        void llenarDataGrid(String mem, String fecha)
        {
            //llenado de DataGrid Renta Detalle
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT * FROM `renta_detalle` WHERE ID_ENCABEZADO = "
                + "(SELECT ID_ENCABEZADO FROM `renta_encabezado` WHERE MEMBRESIA= "+ mem 
                + " AND FECHA_INICIO=' " + fecha + "' AND DEVOLUCION='No' AND ESTADO=1);");
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
            if (txt_codDetalle.Text == "")
            {
                MessageBox.Show("Favor llenar campo", "VERIFICAR", MessageBoxButtons.OK);
            }
            else
            {                
                conn.Open();
                OdbcCommand codigo1 = new OdbcCommand();
                codigo1.Connection = conn;
                codigo1.CommandText = ("UPDATE `renta_detalle` SET `DEVOLUCION`='Si' WHERE " +
                    "ID_DETALLE= '" + txt_codDetalle.Text + "' ");
                try
                {
                    codigo1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(" Devolución realizada correctamente UP");
                    txt_codDetalle.Clear();
                    llenarDataGrid(memG, fechaG);
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(" Error al hacer el UPDATE en RENTA_DETALLE. \n\n Error: " + ex.ToString());
                    conn.Close();
                }
            }            
        }
    }
}
