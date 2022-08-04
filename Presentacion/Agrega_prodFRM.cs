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
using System.Text.RegularExpressions;


namespace Presentacion
{
    public partial class Agrega_prodFRM : Form
    {

        Lote L;
        LotesBLL Lb = new LotesBLL();

        public Agrega_prodFRM(Lote Lo)
        {
            InitializeComponent();
            L = Lo;
            lotetxt.Text = Convert.ToString(L.Nro_lote);
            hamctxt.Text = "0";
            hammtxt.Text = "0";
            lactctxt.Text = "0";
            lactgtxt.Text = "0";
            pancctxt.Text = "0";
            pancmtxt.Text = "0";

            foreach (Panificados P in L.retorna_panificados())
            {
                if (P.Descripcion == "Pan hamburguesa comun")
                { hamctxt.Text = Convert.ToString(P.Unidades); }

                if (P.Descripcion == "Pan hamburguesa maxi")
                { hammtxt.Text = Convert.ToString(P.Unidades); }

                if (P.Descripcion == "Pan lactal chico")
                { lactctxt.Text = Convert.ToString(P.Unidades); }

                if (P.Descripcion == "Pan lactal grande")
                { lactgtxt.Text = Convert.ToString(P.Unidades); }

                if (P.Descripcion == "Pan pancho chico")
                { pancctxt.Text = Convert.ToString(P.Unidades); }

                if (P.Descripcion == "Pan pancho maxi")
                { pancmtxt.Text = Convert.ToString(P.Unidades); }

            }
            if (hamctxt.Text != "0") { hamctxt.ReadOnly = true; }
            if (hammtxt.Text != "0") { hammtxt.ReadOnly = true; }
            if (lactctxt.Text != "0") { lactctxt.ReadOnly = true; }
            if (lactgtxt.Text != "0") { lactgtxt.ReadOnly = true; }
            if (pancctxt.Text != "0") { pancctxt.ReadOnly = true; }
            if (pancmtxt.Text != "0") { pancmtxt.ReadOnly = true; }


        }

        private void grabalotebtn_Click(object sender, EventArgs e)
        {
            Regex re = new Regex("^([0]+[1-9]|[1-9])");
            Lote Lm = new Lote();
            Lm.Nro_lote = L.Nro_lote;
            Lm.Fecha_de_vencimiento = L.Fecha_de_vencimiento;

            try
            {
                if (hamctxt.ReadOnly == false)
                {
                    if ((re.IsMatch(hamctxt.Text)) == false)
                    { throw new Valor_ceroException(); }

                    Pan_hamburguesa_comun Phc = new Pan_hamburguesa_comun(L.Nro_lote, Convert.ToInt32(hamctxt.Text));
                    Lm.agregar_a_lote(Phc);
                }

                if (hammtxt.ReadOnly == false)
                {
                    if ((re.IsMatch(hamctxt.Text)) == false) { throw new Valor_ceroException(); }
                    Pan_hamburguesa_maxi Phg = new Pan_hamburguesa_maxi(L.Nro_lote, Convert.ToInt32(hammtxt.Text));
                    Lm.agregar_a_lote(Phg);
                }

                if (lactctxt.ReadOnly == false)
                {
                    if ((re.IsMatch(lactctxt.Text) == false)) { throw new Valor_ceroException(); }
                    Pan_lactal_chico Plc = new Pan_lactal_chico(L.Nro_lote, Convert.ToInt32(lactctxt.Text));
                    Lm.agregar_a_lote(Plc);
                }

                if (lactgtxt.ReadOnly == false)
                {
                    if ((re.IsMatch(lactgtxt.Text)) == false) { throw new Valor_ceroException(); }
                    Pan_lactal_grande Plg = new Pan_lactal_grande(L.Nro_lote, Convert.ToInt32(lactgtxt.Text));
                    Lm.agregar_a_lote(Plg);
                }

                if (pancctxt.ReadOnly == false)
                {
                    if ((re.IsMatch(pancctxt.Text)) == false) { throw new Valor_ceroException(); }
                    Pan_pancho_chico Ppc = new Pan_pancho_chico(L.Nro_lote, Convert.ToInt32(pancctxt.Text));
                    Lm.agregar_a_lote(Ppc);
                }

                if (pancmtxt.ReadOnly == false)


                {
                    if ((re.IsMatch(pancmtxt.Text)) == false) { throw new Valor_ceroException(); }
                    Pan_pancho_maxi Ppm = new Pan_pancho_maxi(L.Nro_lote, Convert.ToInt32(pancmtxt.Text));
                    Lm.agregar_a_lote(Ppm);
                }

                Lb.agregar_productos_lote(Lm);

                MessageBox.Show("Productos agregados correctamente al lote");
                this.Close();
            }

            catch (Valor_ceroException) { MessageBox.Show("Error: los valores no pueden ser cero"); }
            catch { }





        }
    }
}
