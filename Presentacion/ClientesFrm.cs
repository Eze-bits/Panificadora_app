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
using System.IO;
using BLL;
using Entidades;


namespace Presentacion
{
    public partial class ClientesFrm : Form
    {
        Cliente C = new Cliente();
        ClienteBLL N = new ClienteBLL();

        public ClientesFrm()
        {
            InitializeComponent();
           
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

            cargar_grilla();
        }
        List<Cliente> Lista_clientes = new List<Cliente>();

        public void cargar_grilla()
        {
            Lista_clientes = N.Retorna_cliente();
            XmlTextWriter Clitxtwr = new XmlTextWriter("Clientes.xml", System.Text.Encoding.UTF8);
            Clitxtwr.Formatting = Formatting.Indented;
            Clitxtwr.Indentation = 2;
            Clitxtwr.WriteStartDocument(true);
            Clitxtwr.WriteStartElement("Clientes");
            Clitxtwr.WriteEndElement();
            Clitxtwr.WriteEndDocument();



            Clitxtwr.Close();

            XDocument xmlClientes = XDocument.Load("Clientes.xml");




            foreach (Cliente C in Lista_clientes)
            {



                xmlClientes.Element("Clientes").Add(new XElement("Cliente",
                                            new XElement("Nro_cliente", C.Nro_cliente),
                                            new XElement("Nombre", C.Nombre),
                                            new XElement("Apellido", C.Apellido),
                                            new XElement("Email", C.Email),
                                            new XElement("Calle", C.Calle),
                                            new XElement("Nro_casa", C.Nro_casa),
                                            new XElement("Localidad", C.Localidad),
                                            new XElement("Telefono_particular", C.Telefono_particular),
                                            new XElement("DNI", C.DNI)));
            }
            xmlClientes.Save("Clientes.xml");

            grillaclientes.DataSource = null;
            grillaclientes.DataSource = Lista_clientes;
        }




        private void Bajabtn_Click(object sender, EventArgs e)                     ///BORRAR CLIENTE
        {


            try
            {
                int nrocliente = Convert.ToInt32(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);
                var resultado = MessageBox.Show("¿Confirma la baja de cliente nro: " + nrocliente + " ?", "Baja",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)

                {




                    N.borra_cliente(nrocliente);
                    cargar_grilla();
                    MessageBox.Show("Cliente eliminado exitosamente");
                }

            }

            catch
            { MessageBox.Show("Error: Lista de clientes vacia"); }


        }

        private void grillaclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grillaclientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grillaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void Modificacionbtn_Click(object sender, EventArgs e)
        {

             try
            {
                int nrocliente = Convert.ToInt32(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);


                var C_query =

                    from Cliente in XElement.Load("Clientes.XML").Descendants("Cliente")
                    where (int)Cliente.Element("Nro_cliente") == nrocliente


                    select new Cliente
                    {
                        Nro_cliente = Convert.ToInt32(Cliente.Element("Nro_cliente").Value),
                        Nombre = Cliente.Element("Nombre").Value,
                        Apellido = Cliente.Element("Apellido").Value,
                        Email = Cliente.Element("Email").Value,
                        Calle = Cliente.Element("Calle").Value,
                        Nro_casa = Convert.ToInt32(Cliente.Element("Nro_casa").Value),
                        Localidad = Cliente.Element("Localidad").Value,
                        Telefono_particular = Convert.ToInt32(Cliente.Element("Telefono_particular").Value),
                        DNI = Convert.ToInt32(Cliente.Element("DNI").Value),

                    };

                Cliente C = new Cliente();




                foreach (var xCli in C_query)
                {

                    C.Nro_cliente = xCli.Nro_cliente;
                    C.Nombre = xCli.Nombre;
                    C.Apellido = xCli.Apellido;
                    C.Email = xCli.Email;
                    C.Calle = xCli.Calle;
                    C.Nro_casa = xCli.Nro_casa;
                    C.Localidad = xCli.Localidad;
                    C.DNI = xCli.DNI;

                }



                Clientes_detalleFrm Cli = new Clientes_detalleFrm(C);
                Cli.ShowDialog();
                cargar_grilla();
            }


             catch { MessageBox.Show("Error: Lista de clientes vacia"); }
        }

        private void ClientesFrm_Enter(object sender, EventArgs e)
        {

        }

        private void Altabtn_Click(object sender, EventArgs e)
        {
           
          try  {
                Clientes_detalleFrm Cli = new Clientes_detalleFrm();

                Cli.ShowDialog();

                cargar_grilla();
            }

            catch { MessageBox.Show("Error al dar de alta a cliente"); }

        }

        private void userControlAlta1_Load(object sender, EventArgs e)
        {
         
        }

        private void Altabtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Clientes_detalleFrm Cli = new Clientes_detalleFrm();

                Cli.ShowDialog();

                cargar_grilla();
            }

            catch { MessageBox.Show("Error al dar de alta a cliente"); }
        }

        private void userControlBaja1_Click(object sender, EventArgs e)
        {
            try
            {
                int nrocliente = Convert.ToInt32(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);
                var resultado = MessageBox.Show("¿Confirma la baja de cliente nro: " + nrocliente + " ?", "Baja",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)

                {




                    N.borra_cliente(nrocliente);
                    cargar_grilla();
                    MessageBox.Show("Cliente eliminado exitosamente");
                }

            }

            catch
            { MessageBox.Show("Error: Lista de clientes vacia"); }
        }
    }
}
