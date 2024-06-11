using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator 
{
    public class HijaBase : ClaseBase
    {
        public HijaBase() {
          descripcion="Core i7 8 GB Ram, " +
           "Tarjetal de Red, BlueTooth \r\n";
         }

         public override int valor() { 
          //*Override porque es polimorfica
          return 300;
         }
    }//Fin HijaBase
}
