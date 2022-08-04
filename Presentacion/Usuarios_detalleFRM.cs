using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
using Entidades;
using Seguridad;



namespace Presentacion
{
    public partial class Usuarios_detalleFRM : Form
    {
        string user;
        public Usuarios_detalleFRM(Usuario U)      /// Modificacion
        {
            InitializeComponent();
            usuariotxt.Text = U.Nombre_usuario;
            user = U.Nombre_usuario;
            altabtn.Hide();

            this.Text = "Modificar usuario: " + user;
        }
        public Usuarios_detalleFRM()                /// Alta
        {
            InitializeComponent();
            modbtn.Hide();
        }
        UsuarioBLL usBLL = new UsuarioBLL();

        private void altabtn_Click(object sender, EventArgs e)
        {
            try
            {
                Regex re = new Regex("^([A-Z])");
                if ((re.IsMatch(usuariotxt.Text)) == false)
                { MessageBox.Show("Error solo se permite alta de usuario con letras y en mayuscula"); }
                else
                {

                    Usuario Usu = new Usuario(usuariotxt.Text, contxt.Text);

                    if (usBLL.alta_usuario(Usu) == 0)
                    {
                        MessageBox.Show("Usuario dado de alta exitosamente");
                        this.Close();
                    }
                    else
                    { MessageBox.Show("ERROR: Ya existe un usuario con ese nombre"); }
                }

            }
            catch { MessageBox.Show("Error al dar de alta usuario"); }



        }

        private void modbtn_Click(object sender, EventArgs e)      ///          MODIFICACION
        {
            try
            {
                Regex re = new Regex("^([A-Z])");
               
                
                
                { 
                Usuario U = new Usuario();

                U.Nombre_usuario = usuariotxt.Text;
                U.guardar_clave(contxt.Text);

                if ((usBLL.checkear_usuario_nombre(U.Nombre_usuario) == false) | (String.Compare(U.Nombre_usuario, user) == 0))

                {
                    usBLL.modificar_usuario(U, user);
                    MessageBox.Show("Usuario modificado correctamente");
                    this.Close();
                }

                else { MessageBox.Show("Error: el nuevo nombre de usuario ya existe, intente con otro"); }
            }





            }
             catch { MessageBox.Show("Error al modificar usuario"); }



        }
    }
}
