using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarjetaCredito.Entidades;

namespace TarjetaCredito.Datos
{
    public class MapperCliente
    {

        public MapperCliente()
        {

        }
        //Deserializa Json a lista cliente
        private List<Cliente> TraerClientes(string json)
        {
            List<Cliente> lstCliente = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lstCliente;
        }
        //Trae archivo url
        public List<Cliente> TraerTodos()
        {
            string json = WebHelper.Get("cliente/836465");
            List<Cliente> lstCliente = TraerClientes(json);
            return lstCliente;

        }
    }
}



