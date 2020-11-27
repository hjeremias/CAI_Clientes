using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Entidades.Exceptions
{
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException () : base("El DNI ingresado es inválido") { }
    }
}
