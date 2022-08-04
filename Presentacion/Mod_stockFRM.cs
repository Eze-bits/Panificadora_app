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
    public partial class Mod_stockFRM : Form
    {
        Lote L;
        LotesBLL Lb = new LotesBLL();

        public Mod_stockFRM(Lote Lo)
        {
            InitializeComponent();

            lotetxt.Text = Convert.ToString(Lo.Nro_lote);
            hamctxt.Text = "0";
            hammtxt.Text = "0";
            lactctxt.Text = "0";
            lactgtxt.Text = "0";
            pancctxt.Text = "0";
            pancmtxt.Text = "0";
            L = Lo;


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

            if (hamctxt.Text == "0") { hamctxt.ReadOnly = true; }
            if (hammtxt.Text == "0") { hammtxt.ReadOnly = true; }
            if (lactctxt.Text == "0") { lactctxt.ReadOnly = true; }
            if (lactgtxt.Text == "0") { lactgtxt.ReadOnly = true; }
            if (pancctxt.Text == "0") { pancctxt.ReadOnly = true; }
            if (pancmtxt.Text == "0") { pancmtxt.ReadOnly = true; }



        }

        private void generalotebtn_Click(object sender, EventArgs e)
        {



        }

        private void grabalotebtn_Click(object sender, EventArgs e)    /// MODIFICACION DE LOTE
        {

          


            Pan_hamburguesa_comun Phc = new Pan_hamburguesa_comun(Convert.ToInt32(hamctxt.Text));
            L.modificar_stock_lote(Phc);


            Pan_hamburguesa_maxi Phg = new Pan_hamburguesa_maxi(Convert.ToInt32(hammtxt.Text));
            L.modificar_stock_lote(Phg);


            Pan_lactal_chico Plc = new Pan_lactal_chico(Convert.ToInt32(lactctxt.Text));
            L.modificar_stock_lote(Plc);


            Pan_lactal_grande Plg = new Pan_lactal_grande(Convert.ToInt32(lactgtxt.Text));
            L.modificar_stock_lote(Plg);


            Pan_pancho_chico Ppc = new Pan_pancho_chico(Convert.ToInt32(pancctxt.Text));
            L.modificar_stock_lote(Ppc);

            Pan_pancho_maxi Ppm = new Pan_pancho_maxi(Convert.ToInt32(pancmtxt.Text));
            L.modificar_stock_lote(Ppm);



            Lb.modificar_stock(L);
            MessageBox.Show("Stock de lote modificado correctamente");
            this.Close();
        }

        private void Mod_stockFRM_Load(object sender, EventArgs e)
        {
        }
    }
}
