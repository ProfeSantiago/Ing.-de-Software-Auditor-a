using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploSingleton
{
    public partial class Singleton_Frm : Form
    {
        String contenido = Singleton_Class.getObjetoSingleton().getContenido();

        public Singleton_Frm()
        {
            InitializeComponent();
        }

        private void Singleton_Frm_Load(object sender, EventArgs e)
        {
            contenido = contenido + "Hola";
            Singleton_Class.getObjetoSingleton().setContenido(contenido);
        }
    }
}
