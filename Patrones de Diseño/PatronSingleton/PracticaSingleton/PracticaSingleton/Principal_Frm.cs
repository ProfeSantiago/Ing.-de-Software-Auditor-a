using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSingleton
{
    public partial class Principal_Frm : Form
    {
        String elMensaje = Bitacora_Singleton.getObjetoBitacora().getMensaje();

        public Principal_Frm()
        {
            InitializeComponent();
        }

        private void Principal_Frm_Load(object sender, EventArgs e)
        {
            elMensaje = elMensaje + " Ingreso al Formulario Principal \r\n";
            Bitacora_Singleton.getObjetoBitacora().setMensaje(elMensaje);
        }

        private void Reporte_Btn_Click(object sender, EventArgs e)
        {
            Reporte_txt.Text = Bitacora_Singleton.getObjetoBitacora().getMensaje();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturacion_Frm FactuForm = new Facturacion_Frm();
            FactuForm.Show();
        }

        private void Artic_Btn_Click(object sender, EventArgs e)
        {
            Articulos_Frm ArtiForm = new Articulos_Frm();
            ArtiForm.Show();
        }

        private void CxC_Btn_Click(object sender, EventArgs e)
        {
            Cxc_Frm CxcForm = new Cxc_Frm();
            CxcForm.Show();
        }
    }
}
