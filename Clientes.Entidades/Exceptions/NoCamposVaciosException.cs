using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Entidades.Exceptions
{
    public class NoCamposVaciosException : Exception
    {
        public NoCamposVaciosException() : base("Existen campos vacíos") { }
    }
}
