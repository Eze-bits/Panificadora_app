using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using BLL;
using Entidades;

namespace Presentacion
{

    public partial class Clientes_detalleFrm : Form
    {
        public Clientes_detalleFrm(Cliente C)
        {
            InitializeComponent();

            Altabtn.Hide();

            nroclientetxt.Text = Convert.ToString(C.Nro_cliente);
            nombretxt.Text = C.Nombre;
            apellidotxt.Text = C.Apellido;
            emailtxt.Text = C.Email;
            calletxt.Text = C.Calle;
            nrocalletxt.Text = Convert.ToString(C.Nro_casa);
            localidadtxt.Text = C.Localidad;
            telefonotxt.Text = Convert.ToString(C.Telefono_particular);
            DNItxt.Text = Convert.ToString(C.DNI);



        }

        public Clientes_detalleFrm() { InitializeComponent(); Altabtn.Hide(); }






        private void Clientes_detalle_Load(object sender, EventArgs e)
        {




        }

        private void Modbtn_Click(object sender, EventArgs e)               //Modificar Cliente
        {

            try
            {




                Cliente C = new Cliente(Convert.ToInt32(nroclientetxt.Text), nombretxt.Text, apellidotxt.Text, emailtxt.Text,
calletxt.Text, Convert.ToInt32(nrocalletxt.Text), localidadtxt.Text, Convert.ToInt32(telefonotxt.Text),
Convert.ToInt32(DNItxt.Text));
                ClienteBLL N = new ClienteBLL();





                N.modifica_cliente(C);
                MessageBox.Show("Cliente modificado exitosamente");

                this.Close();
            }
            catch { MessageBox.Show("Error al modificar cliente"); }
        }

        private void Altabtn_Click(object sender, EventArgs e)                  ///ALTA DE CLIENTE
        {
            //   try
            {
                ClienteBLL N = new ClienteBLL();

                Cliente C = new Cliente();

                C.Nombre = nombretxt.Text;
                C.Apellido = apellidotxt.Text;
                C.Email = emailtxt.Text;
                C.Calle = calletxt.Text;
                C.Nro_casa = Convert.ToInt32(nrocalletxt.Text);
                C.Localidad = localidadtxt.Text;
                C.Telefono_particular = Convert.ToInt32(telefonotxt.Text);
                C.DNI = Convert.ToInt32(DNItxt.Text);

                N.graba_cliente(C);
                MessageBox.Show("Cliente guardado correctamente");
                this.Close();
            }
            //  catch { MessageBox.Show("Error al guardar cliente"); }

        }
    }
}
