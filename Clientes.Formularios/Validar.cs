using Clientes.Entidades;
using Clientes.Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Formularios
{
    static class Validar
    {
        public static Cliente Cliente(string apellido, string nombre, string stringDNI, DateTime fechaNac)
        {
            Cliente cliente = new Cliente();
            long dni;

            if (string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre))
                throw new NoCamposVaciosException();
            if (long.TryParse(stringDNI, out dni))
                dni = Convert.ToInt64(stringDNI);
            else throw new DniInvalidoException();

            if (fechaNac.AddYears(18) > DateTime.Today)
                throw new MenorDeEdadException();

            cliente.Apellido = apellido;
            cliente.Nombre = nombre;
            cliente.Dni = dni;
            cliente.FechaNac = fechaNac.ToString("yyyy-MM-dd");

            return cliente;
        }


    }
}
