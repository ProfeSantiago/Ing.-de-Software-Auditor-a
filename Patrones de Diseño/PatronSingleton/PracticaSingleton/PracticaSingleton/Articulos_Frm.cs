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
    public partial class Articulos_Frm : Form
    {
        String elMensaje = Bitacora_Singleton.getObjetoBitacora().getMensaje();

        public Articulos_Frm()
        {
            InitializeComponent();
        }

        private void Articulos_Frm_Load(object sender, EventArgs e)
        {
            elMensaje = elMensaje + " Ingreso al Registro de Articulos \r\n";
            Bitacora_Singleton.getObjetoBitacora().setMensaje(elMensaje);

        }
    }
}
