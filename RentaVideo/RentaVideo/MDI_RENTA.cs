using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using CapaDatos;

namespace CapaVistaFRM
{
    public partial class MDI_RENTA : Form
    {
        private mantenimiento_material frm_mantenimiento_material;
        private mantenimiento_cliente frm_mantenimiento_cliente;
        private mantenimiento_empleado frm_mantenimiento_empleado;
        private mantenimiento_mora frm_mantenimiento_mora;
        private mantenimiento_categoria frm_mantenimiento_categoria;
        private mantenimiento_bono frm_mantenimiento_bono;
        private renta_encab frm_renta_encab;

        //sentencia sn = new sentencia();
        String usuarioActivo = "rchocm";

        public MDI_RENTA()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }
        
        //==========Funciones para evitar que se habrá 2 veces la misma ventana==========          
        private void frm_mantenimiento_material_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_material = null; }
        private void frm_mantenimiento_cliente_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_cliente = null; }
        private void frm_mantenimiento_empleado_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_empleado = null; } 
        private void frm_mantenimiento_mora_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_mora = null; }
        private void frm_mantenimiento_categoria_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_categoria = null; }
        private void frm_mantenimiento_bono_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_bono = null; }
        private void frm_renta_encab_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_renta_encab = null; }
        //====================Funciones de declaración de Eventos====================

        private void ConciliaciónBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
        }

        private void BalanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ActualizaciónDePólizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ConsultarConciliaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MovimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void RevisiónDePresupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
        }
        
        private void MDI_FRM_Load(object sender, EventArgs e)
        {
            /*
            frm_login login = new frm_login();
            login.ShowDialog();
            Lbl_usuario.Text = login.obtenerNombreUsuario();
            usuarioActivo = Lbl_usuario.Text;            */
        } 

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(Lbl_usuario.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog();
        }

        private void Btn_prueba_Click(object sender, EventArgs e)
        {
            //                      Usuario        Mensaje a guardar     Tabla
            //sn.insertarBitacora(Lbl_usuario.Text, "Probó la Bitacora", "General");
        }

        private void MódulosToolStripMenuItem_Click(object sender, EventArgs e)
        {                        
            
        }

        private void BancosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void ChequeraToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            
        }

        private void CuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
        }

        private void ClasificadorDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
        }

        private void MonedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MonedasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CLIENTE
            if (frm_mantenimiento_cliente == null)
            {
                frm_mantenimiento_cliente = new mantenimiento_cliente(usuarioActivo);
                frm_mantenimiento_cliente.MdiParent = this;
                frm_mantenimiento_cliente.FormClosed += new FormClosedEventHandler(frm_mantenimiento_cliente_FormClosed);
                frm_mantenimiento_cliente.Show();
            }
            else
            {
                frm_mantenimiento_cliente.Activate();
            }
        }

        private void EmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EMPLEADO
            if (frm_mantenimiento_empleado == null)
            {
                frm_mantenimiento_empleado = new mantenimiento_empleado(usuarioActivo);
                frm_mantenimiento_empleado.MdiParent = this;
                frm_mantenimiento_empleado.FormClosed += new FormClosedEventHandler(frm_mantenimiento_empleado_FormClosed);
                frm_mantenimiento_empleado.Show();
            }
            else
            {
                frm_mantenimiento_empleado.Activate();
            }
        }

        private void CategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CATEGORIA
            if (frm_mantenimiento_categoria == null)
            {
                frm_mantenimiento_categoria = new mantenimiento_categoria(usuarioActivo);
                frm_mantenimiento_categoria.MdiParent = this;
                frm_mantenimiento_categoria.FormClosed += new FormClosedEventHandler(frm_mantenimiento_categoria_FormClosed);
                frm_mantenimiento_categoria.Show();
            }
            else
            {
                frm_mantenimiento_categoria.Activate();
            }
        }

        private void MoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MORA
            if (frm_mantenimiento_mora == null)
            {
                frm_mantenimiento_mora = new mantenimiento_mora(usuarioActivo);
                frm_mantenimiento_mora.MdiParent = this;
                frm_mantenimiento_mora.FormClosed += new FormClosedEventHandler(frm_mantenimiento_mora_FormClosed);
                frm_mantenimiento_mora.Show();
            }
            else
            {
                frm_mantenimiento_mora.Activate();
            }
        }

        private void MaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MATERIAL
            if (frm_mantenimiento_material == null)
            {
                frm_mantenimiento_material = new mantenimiento_material(usuarioActivo);
                frm_mantenimiento_material.MdiParent = this;
                frm_mantenimiento_material.FormClosed += new FormClosedEventHandler(frm_mantenimiento_material_FormClosed);
                frm_mantenimiento_material.Show();
            }
            else
            {
                frm_mantenimiento_material.Activate();
            }
        }

        private void BonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BONO
            if (frm_mantenimiento_bono == null)
            {
                frm_mantenimiento_bono = new mantenimiento_bono(usuarioActivo);
                frm_mantenimiento_bono.MdiParent = this;
                frm_mantenimiento_bono.FormClosed += new FormClosedEventHandler(frm_mantenimiento_bono_FormClosed);
                frm_mantenimiento_bono.Show();
            }
            else
            {
                frm_mantenimiento_bono.Activate();
            }
        }

        private void RentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RENTA
            if (frm_renta_encab == null)
            {
                frm_renta_encab = new renta_encab();
                frm_renta_encab.MdiParent = this;
                frm_renta_encab.FormClosed += new FormClosedEventHandler(frm_renta_encab_FormClosed);
                frm_renta_encab.Show();
            }
            else
            {
                frm_renta_encab.Activate();
            }
        }
    }
}
