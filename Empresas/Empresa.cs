using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas
{
    public class Empresa
    {
        public string sector { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public Empresa(string sector,string nombre,
            string direccion,string telefono,string email)
        {
            this.sector = sector;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;

        }
    }
}
