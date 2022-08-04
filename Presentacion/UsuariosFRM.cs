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
using Seguridad;

namespace Presentacion
{
    public partial class UsuariosFRM : Form
    {
        public UsuariosFRM()
        {
            InitializeComponent();
        }

        UsuarioBLL usuB = new UsuarioBLL();

        private void Altabtn_Click(object sender, EventArgs e)
        {

            Usuarios_detalleFRM usu = new Usuarios_detalleFRM();
            usu.ShowDialog();
            mostrar_usuarios();

        }

        public void mostrar_usuarios()
        {

            grilla_usuarios.DataSource = null;

            grilla_usuarios.DataSource = usuB.obtener_lista_usuarios();
        }

        private void Modificacionbtn_Click(object sender, EventArgs e)
        {
       try
            {

                string usuario = Convert.ToString(grilla_usuarios.Rows[grilla_usuarios.CurrentRow.Index].Cells[0].Value);

                
                Usuario U = new Usuario(usuario);

                Usuarios_detalleFRM usu = new Usuarios_detalleFRM(U);

                usu.ShowDialog();
                mostrar_usuarios();
            }
        catch { MessageBox.Show("Error: La lista de usuarios esta vacia"); }


        }

        private void UsuariosFRM_Load(object sender, EventArgs e)
        {
            mostrar_usuarios();
        }

        private void Bajabtn_Click(object sender, EventArgs e)
        {


            try
            {
                string user = Convert.ToString(((Usuario)grilla_usuarios.SelectedRows[0].DataBoundItem).Nombre_usuario);

                var respuesta = MessageBox.Show("¿Confirma la eliminacion del Usuario: " + user + " ?", "Eliminar",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    usuB.baja_usuario(user);
                    MessageBox.Show("Usuario eliminado exitosamente");
                    mostrar_usuarios();
                }

               
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Error: la lista de usuarios esta vacia"); }
            catch { MessageBox.Show("Error al eliminar usuario"); }


        }
    }
}
