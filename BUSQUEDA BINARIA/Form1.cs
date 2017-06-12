using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUSQUEDA_BINARIA
{
    public partial class Form1 : Form
    {
        Vector vec = new Vector();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            vec.busquedaBin(Convert.ToInt16(txtBuscar.Text));
            txtResultado.Text += "Se hicieron "+vec.comp+" comparaciones"+Environment.NewLine;
            txtResultado.Text += "Esta en la posicion "+vec.mitad + Environment.NewLine;
            //txtResultado.Text+="El numero esta en la posicion: "+vec.busquedaBinaria1(Convert.ToInt16(txtBuscar.Text))+Environment.NewLine;
        }
    }
}
