using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSingleton
{
    class Singleton_Class
    {
        private String contenido;

        //objeto Singleton
        private static Singleton_Class ObjetoSingleton =
            new Singleton_Class(); 
        
        private Singleton_Class()
        {
            setContenido("Eventos de Usuario\n\n");
        }
        
        public static Singleton_Class getObjetoSingleton()
        {
            return ObjetoSingleton;
        }
       
        public String getContenido()
        {
            return contenido;
        }
       
        public void setContenido(String contenido)
        {
            this.contenido = contenido;
        }
    }      
}
