using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Entidades.Exceptions
{
    public class NoInsertoClienteException : Exception
    {
        public NoInsertoClienteException(string msg) : base("No se pudo insertar cliente. " + msg) { }
    }
}
