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
    public partial class LoteNuevoFrm : Form
    {
        public LoteNuevoFrm()
        {
            InitializeComponent();
        }

        private void LoteNuevoFrm_Load(object sender, EventArgs e)
        {
            hamctxt.Text = "0";
            hammtxt.Text = "0";
            lactctxt.Text = "0";
            lactgtxt.Text = "0";
            pancctxt.Text = "0";
            pancmtxt.Text = "0";
        }
        public void Limpiartxt() { hamctxt.Clear();
            hammtxt.Clear();
            lactctxt.Clear();
            lactgtxt.Clear();
            pancctxt.Clear();
            pancmtxt.Clear();



        }
        private void generalotebtn_Click(object sender, EventArgs e)
        {
                
                    try
                    {
                        Lote L = new Lote();
                        LotesBLL Nl = new LotesBLL();
                       
                        if (Convert.ToInt32(hamctxt.Text) > 0)
                        {
                            Pan_hamburguesa_comun Phc = new Pan_hamburguesa_comun(Convert.ToInt32(hamctxt.Text));
                            L.agregar_a_lote(Phc);
                        }

                        if (Convert.ToInt32(hammtxt.Text) > 0)
                        {
                            Pan_hamburguesa_maxi Phg = new Pan_hamburguesa_maxi(Convert.ToInt32(hammtxt.Text));
                            L.agregar_a_lote(Phg);
                        }


                        if (Convert.ToInt32(lactctxt.Text) > 0)
                        {
                            Pan_lactal_chico Plc = new Pan_lactal_chico(Convert.ToInt32(lactctxt.Text));
                            L.agregar_a_lote(Plc);
                        }

                        if (Convert.ToInt32(lactgtxt.Text) > 0)

                        {
                            Pan_lactal_grande Plg = new Pan_lactal_grande(Convert.ToInt32(lactgtxt.Text));
                            L.agregar_a_lote(Plg);
                        }

                        if (Convert.ToInt32(pancctxt.Text) > 0)
                        {
                            Pan_pancho_chico Ppc = new Pan_pancho_chico(Convert.ToInt32(pancctxt.Text));
                            L.agregar_a_lote(Ppc);
                        }

                        if (Convert.ToInt32(pancmtxt.Text) > 0)
                        {
                            Pan_pancho_maxi Ppm = new Pan_pancho_maxi(Convert.ToInt32(pancmtxt.Text));
                            L.agregar_a_lote(Ppm);
                        }





                   Nl.graba_lote(L);
                        MessageBox.Show("Lote grabado correctamente");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error al cargar los datos, intente nuevamente");
                                    
                        Limpiartxt();

                    }
            
        }
    }
}
