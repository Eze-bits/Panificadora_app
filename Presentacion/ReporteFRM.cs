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
    public partial class ReporteFRM : Form
    {
        public ReporteFRM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TP2DataSet2.HAMBURGUESAS' Puede moverla o quitarla según sea necesario.
            this.HAMBURGUESASTableAdapter.Fill(this.TP2DataSet2.HAMBURGUESAS);
            // TODO: esta línea de código carga datos en la tabla 'TP2DataSet3.LACTAL' Puede moverla o quitarla según sea necesario.
            this.LACTALTableAdapter.Fill(this.TP2DataSet3.LACTAL);
            // TODO: esta línea de código carga datos en la tabla 'TP2DataSet4.PANCHOS' Puede moverla o quitarla según sea necesario.
            this.PANCHOSTableAdapter.Fill(this.TP2DataSet4.PANCHOS);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
