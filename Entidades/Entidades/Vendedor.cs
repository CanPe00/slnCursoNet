using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Vendedor : Persona
    {
        public Vendedor(string nombre, string apellido, string email, string telefono, string direccion) : base(nombre, apellido, email, telefono, direccion)
        {
        }
    }
}
