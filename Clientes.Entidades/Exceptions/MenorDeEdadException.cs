using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Entidades.Exceptions
{
    public class MenorDeEdadException : Exception
    {
        public MenorDeEdadException () : base("La persona debe ser mayor de edad") { }
    }
}
