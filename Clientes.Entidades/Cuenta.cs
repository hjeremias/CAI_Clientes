using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Entidades
{
    [DataContract]
    public class Cuenta
    {
        public double _nroCuenta;
        private string _desc;
        private double _saldo;
        private string _fechaApertura;
        private int _idCliente;
        private int _id;

        [DataMember(Name ="nroCuenta")]
        public double NroCuenta { get => _nroCuenta; set => _nroCuenta= value; }

        [DataMember(Name = "descripcion")]
        public string Desc { get => _desc; set => _desc = value; }

        [DataMember(Name = "saldo")]
        public double  Saldo { get => _saldo; set => _saldo = value; }

        [DataMember(Name = "fechaApertura")]
        public string FechaApertura { get => _fechaApertura; set => _fechaApertura = value; }

        [DataMember(Name = "idCliente")]
        public int IdCliente { get => _idCliente; set => _idCliente = value; }

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return string.Format("{0} - Apertura: {1} - Saldo: {2}", this.NroCuenta, this.FechaApertura, this.Saldo) 
        }


    }
}
