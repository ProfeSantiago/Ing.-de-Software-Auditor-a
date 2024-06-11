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
    public partial class Cxc_Frm : Form
    {
        String elMensaje = Bitacora_Singleton.getObjetoBitacora().getMensaje();

        public Cxc_Frm()
        {
            InitializeComponent();
        }

        private void Cxc_Frm_Load(object sender, EventArgs e)
        {
            elMensaje = elMensaje + " Ingreso a Cuentas por Cobrar \r\n";
            Bitacora_Singleton.getObjetoBitacora().setMensaje(elMensaje);
        }
    }
}
