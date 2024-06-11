using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    public class UnidadBlueRay : AdicionalesDecorator
    {
        ClaseBase ConfiguracionBase;

        public UnidadBlueRay(ClaseBase ConfiguracionBase)
        {
            this.ConfiguracionBase = ConfiguracionBase;
        }

        public override String getDescripcion()
        {
            return ConfiguracionBase.getDescripcion() + ", Unidad Quemadora BlueRay \r\n";
        }

        public override int valor(){
            return 80 + ConfiguracionBase.valor();
        }
    
    }//Fin UnidadBlueRay
}
