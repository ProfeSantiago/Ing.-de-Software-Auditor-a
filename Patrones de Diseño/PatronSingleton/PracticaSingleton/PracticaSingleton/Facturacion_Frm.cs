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
    public partial class Facturacion_Frm : Form
    {
        String elMensaje = Bitacora_Singleton.getObjetoBitacora().getMensaje();

        public Facturacion_Frm()
        {
            InitializeComponent();
        }

        private void Facturacion_Frm_Load(object sender, EventArgs e)
        {
            elMensaje = elMensaje + " Ingreso a Facturación \r\n";
            Bitacora_Singleton.getObjetoBitacora().setMensaje(elMensaje);
        }
    }
}
