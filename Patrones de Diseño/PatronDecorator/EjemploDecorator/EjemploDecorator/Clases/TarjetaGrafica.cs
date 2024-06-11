using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    public class TarjetaGrafica : AdicionalesDecorator
    {

        ClaseBase ConfiguracionBase;

        public TarjetaGrafica(ClaseBase ConfiguracionBase)
        {
            this.ConfiguracionBase = ConfiguracionBase;
        }

        public override String getDescripcion()
        {
            return ConfiguracionBase.getDescripcion() + ", Tarjeta Grafica NVidia \r\n";
        }

        public override int valor(){
            return 100 + ConfiguracionBase.valor();
        }

    }//Fin TarjetaGrafica
}

