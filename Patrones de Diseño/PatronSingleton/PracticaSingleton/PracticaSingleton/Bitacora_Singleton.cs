using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSingleton
{
    class Bitacora_Singleton
    {
        private String Mensaje;

        private static Bitacora_Singleton ObjetoBitacora = 
            new Bitacora_Singleton();

        private Bitacora_Singleton()
        {
            //setMensaje(" Bitacora de movimientos \r\n");

        }//Fin Constructor privado

        public static Bitacora_Singleton getObjetoBitacora()
        {
            return ObjetoBitacora;
        }

        public void setMensaje(String elMensaje){
            Mensaje = elMensaje;
        }

        public String getMensaje()
        {
            return Mensaje;
        }


    }
}
