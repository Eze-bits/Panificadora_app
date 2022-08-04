using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;

using Entidades;

namespace Presentacion
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesFrm C = new ClientesFrm();
            C.MdiParent = this;
            C.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        
        private void Lotes_Click(object sender, EventArgs e)
        {

            



        }

        private void crearLoteNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LotesBLL  Nl= new LotesBLL(); 
            Lote L=new Lote();

            if (Nl.checkear_lote(L)==true)
            { MessageBox.Show("Ya existe un lote del dia creado"); }

            else
            {
                
                
                LoteNuevoFrm C = new LoteNuevoFrm();
                C.MdiParent = this;
                C.Show();
            }
        
            
            }

        private void verYModificarStock_Click(object sender, EventArgs e)
        {
             LotesBLL Nl= new LotesBLL();

          if( Nl.retorna_lotes_cargados()==true)
            {
                Lote_detalleFRM L = new Lote_detalleFRM();
                L.MdiParent = this;
                L.Show();
            }
        
        else
            { MessageBox.Show("No existen lotes cargados en la base de datos.\nAgregue nuevos lotes seleccionando"+
                '"'+" Crear nuevo Lote"+'"');}
        
        
       
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosFRM usu = new UsuariosFRM();
            usu.MdiParent = this;
            usu.Show();
        }

        private void Menu_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevopedidoFRM N = new NuevopedidoFRM();
            N.MdiParent = this;
            N.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutenticacionFRM F = new AutenticacionFRM();
            F.Show();

        }

        private void modificarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_pedidoFRM M = new Listar_pedidoFRM();
            M.MdiParent = this;
            M.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesFrm C = new ClientesFrm();
            C.MdiParent = this;
            C.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteFRM F = new ReporteFRM();
            F.MdiParent = this;
            F.Show();
        }
    }
}
