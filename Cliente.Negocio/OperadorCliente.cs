using Clientes.Datos;
using Clientes.Entidades;
using Clientes.Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Negocio
{
    public class OperadorCliente
    {
        ClienteMapper _clienteMapper;

        public OperadorCliente()
        {
            _clienteMapper = new ClienteMapper();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = this._clienteMapper.TraerTodos();                    
            return clientes;
        }

        public int InsertarCliente(Cliente cliente)
        {
            ResultadoTransaccion res = this._clienteMapper.InsertarCliente(cliente);

            if (!res.IsOk)
                throw new NoInsertoClienteException(res.Error);
            else return res.Id;
        }
    }
}
