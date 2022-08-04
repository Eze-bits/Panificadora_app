using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class UserControlBaja : UserControl
    {
        public UserControlBaja()
        {
            InitializeComponent();
        }

        private void Altabtn_Click(object sender, EventArgs e)
        {
            ClientesFrm C = new ClientesFrm();
           
            C.Show();
        }

        private void bajacbtn_Click(object sender, EventArgs e)
        {
            

            }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void UserControlBaja_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
    
}
