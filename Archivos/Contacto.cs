using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
   public class Contacto
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string  email { get; set; }

        public Contacto(string n, string d,string t,string e)
        {
            nombre = n;
            direccion = d;
            telefono = t;
            email = e;

        }
        public Contacto()
        {

        }
    }
}
