using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    public class ClaseBase
    {
        public String descripcion = "";
  
        public String getDescripcion() 
        {
            return descripcion;
        }

        public virtual int valor(){
            return 0;
        }
        //*Virtual porque es polimorfica
        //(Este método será reemplazado o cambiado en la Clase derivada)

    }//Fin ClaseBase
}

