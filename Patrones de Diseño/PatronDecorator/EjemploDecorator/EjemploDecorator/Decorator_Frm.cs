using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDecorator
{
    public partial class Decorator_Frm : Form
    {
        HijaBase ConfigBasica = new HijaBase();
        TarjetaGrafica Grafica;
        UnidadBlueRay BlueRay;

        public Decorator_Frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Grafica = new TarjetaGrafica(ConfigBasica);
            BlueRay = new UnidadBlueRay(ConfigBasica);
            Config_ListView.Items.Add(ConfigBasica.getDescripcion());
            Total_Txt.Text = ConfigBasica.valor().ToString();
        }

        private void Agrega_Brn_Click(object sender, EventArgs e)
        {
            if (Tarjeta_Check.Checked){
                Config_ListView.Items.Clear();
                Config_ListView.Items.Add(Grafica.getDescripcion());
                Total_Txt.Text = Grafica.valor().ToString();
            }

            if (Unidad_Check.Checked)
            {
                Config_ListView.Items.Clear();
                Config_ListView.Items.Add(BlueRay.getDescripcion());
                Total_Txt.Text = BlueRay.valor().ToString();
            }            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
