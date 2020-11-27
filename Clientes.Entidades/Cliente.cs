using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Entidades
{
    [DataContract]
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private long _dni;
        private string _fechaNac;

        [DataMember (Name = "nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember (Name = "apellido")]
        public string Apellido { get => _apellido; set => _apellido = value; }

        [DataMember (Name = "dni")]
        public long Dni { get => _dni; set => _dni= value; }

        [DataMember(Name = "fechaNacimiento")]
        public string FechaNac { get => _fechaNac; set => _fechaNac = value; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - DNI: {2}", this.Apellido, this.Nombre, this.Dni);
        }
    }
}
