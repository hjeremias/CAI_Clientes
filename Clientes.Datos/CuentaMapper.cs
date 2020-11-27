using Clientes.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Datos
{
    public class CuentaMapper
    {
        public List<Cuenta> TraerCuentas()
        {
            string json = WebHelper.Get("/api/v1/cuenta");

            List<Cuenta> cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(json);

            return cuentas;
        }

        public ResultadoTransaccion InsertarCuenta(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("NroCuenta", cuenta.NroCuenta.ToString());
            n.Add("Descripcion", cuenta.Desc);
            n.Add("Saldo", cuenta.Saldo.ToString());
            n.Add("FechaApertura", cuenta.FechaApertura);
            n.Add("idCliente", cuenta.IdCliente.ToString());
            n.Add("id", cuenta.Id.ToString());

            string json = WebHelper.Post("/api/v1/cuenta", n);

            ResultadoTransaccion res = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);

            return res;
        }
    }
}
