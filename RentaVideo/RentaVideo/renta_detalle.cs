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
    public partial class renta_detalle : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=rentavideos");
        public renta_detalle(String codEncab, String membresia, String empleado, DateTime inicio, DateTime fin)
        {
            InitializeComponent();
            txt_codEncab.Text = codEncab;
            txt_membresia.Text = membresia;
            txt_empleado.Text = empleado;
            Dtp_inicio.Value = inicio;
            Dtp_fin.Value = fin;
            llenarTxtRentaDetalle();
            llenarComboMaterial();
            llenarDataGrid();
        }

        private void Renta_detalle_Load(object sender, EventArgs e)
        {

        }

        void llenarTxtRentaDetalle()
        {
            //llenado de textBox Cod Renta Encabezado
            try
            {
                Txt_codDetalle.Text = "";
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT MAX(ID_DETALLE)+1 FROM `renta_detalle`", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Txt_codDetalle.Text = reader.GetValue(0).ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        
        void llenarComboMaterial()
        {
            //llenado de comboBox MEMBRESIA
            try
            {
                Cbo_material.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT MATERIAL, NOMBRE, PRECIO, GENERO FROM `material` WHERE ESTADO=1", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cbo_material.Refresh();
                    //Cbo_membresia.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                    Cbo_material.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString() + " - " + reader.GetValue(2).ToString() + " - " + reader.GetValue(3).ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        void llenarDataGrid()
        {
            //llenado de DataGrid Renta Detalle
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT * FROM `renta_detalle` WHERE ESTADO=1");
            try
            {
                OdbcDataAdapter eje = new OdbcDataAdapter();
                eje.SelectCommand = cod;
                DataTable datos = new DataTable();
                eje.Fill(datos);
                Dgv_rentaDetalle.DataSource = datos;
                eje.Update(datos);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostar el DataGrid RENTA DETALLE" + e.ToString());
                conn.Close();
            }

        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {            
            //Dividir ComboBox
            string data = Cbo_material.Text;
            string[] words = data.Split(' ');
            //MessageBox.Show("Material: " + words[0] + "", "Prueba");

            conn.Open();
            OdbcCommand codigo1 = new OdbcCommand();
            codigo1.Connection = conn;
            codigo1.CommandText = ("INSERT INTO `renta_detalle`(`ID_ENCABEZADO`, `MATERIAL`, `CANTIDAD`, `DEVOLUCION`, `ESTADO`) "
                + "VALUES (" + txt_codEncab.Text + ", " + words[0] + ", '" + Txt_cantidad.Text + "', '" + "No" + "', " + 1 + ")");
            try
            {
                codigo1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(" Se registro correctamente en RENTA_DETALLE");
                llenarTxtRentaDetalle();
                Cbo_material.Items.Clear();
                Cbo_material.Refresh();
                llenarComboMaterial();
                Txt_cantidad.Clear();
                llenarDataGrid();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(" Error al hacer el INSERT en RENTA_DETALLE. \n\n Error: " + ex.ToString());
                conn.Close();
            }
        }
    }
}
