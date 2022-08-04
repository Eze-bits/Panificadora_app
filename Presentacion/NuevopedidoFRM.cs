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
    public partial class NuevopedidoFRM : Form
    {
        public NuevopedidoFRM()
        {
            InitializeComponent();
        }
        ClienteBLL cli = new ClienteBLL();
        List<Cliente> Clientelista;

        private void nuevopedidoFRM_Load(object sender, EventArgs e)
        {

            Clientelista = cli.Retorna_cliente();

            foreach (Cliente C in cli.Retorna_cliente())
            {

                combocliente.Items.Add("DNI: " + Convert.ToString(C.DNI) + "; " + C.Apellido + "," + C.Nombre);
            }



        }

        private void npedidobtn_Click(object sender, EventArgs e)
        {
            int ind;
            ind = combocliente.SelectedIndex;

            Pedido_detalleFRM  P = new Pedido_detalleFRM(Clientelista[ind]);
        
            P.Show();
            this.Close();
        }
    }
}
