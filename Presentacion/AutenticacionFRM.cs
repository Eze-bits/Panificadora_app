using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad;
using Entidades;
using BLL;


namespace Presentacion
{
    public partial class AutenticacionFRM : Form
    {
        public AutenticacionFRM()
        {
            InitializeComponent();

        
        
        }
        UsuarioBLL UsBLL = new UsuarioBLL();
    
        private void button1_Click(object sender, EventArgs e)
        {
            
                        string passMD5;
                        Encriptacion E = new Encriptacion();
                        if (UsBLL.validar_usuario(usuariotxt.Text).Count > 0)
                        {

                            passMD5 = UsBLL.validar_usuario(usuariotxt.Text)[1];

                            if (string.Compare(passMD5, E.Encriptar(passtxt.Text)) == 0)
                            {
                                Menu_principal M = new Menu_principal();
                                this.Hide();
                                M.Show();
                            }

                            else
                            {
                                MessageBox.Show("Error= contraseña incorrecta");
                            }

                        }
                        else
                        { MessageBox.Show("Error= Usuario inexistente"); }
                
            
            
            
            
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
