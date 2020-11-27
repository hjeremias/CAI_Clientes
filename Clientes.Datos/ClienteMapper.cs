using Clientes.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Datos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/cliente/894683");

            List<Cliente> clientes =  JsonConvert.DeserializeObject<List<Cliente>>(json);

            return clientes;
        }

        public ResultadoTransaccion InsertarCliente(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("DNI", cliente.Dni.ToString());
            n.Add("Apellido", cliente.Apellido);
            n.Add("Nombre", cliente.Nombre);
            n.Add("FechaNacimiento", cliente.FechaNac);
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);

            string json = WebHelper.Post("/api/v1/cliente", n);

            ResultadoTransaccion result = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);

            return result;
        }

    }
}
