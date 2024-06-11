using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    public class AdicionalesDecorator : ClaseBase
    {
        public virtual String getDescripcion() {
            return "";
        }
        //*Virtual porque es polimorfica
        
        
    }
}
