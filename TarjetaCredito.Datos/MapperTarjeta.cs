using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarjetaCredito.Entidades;
using TarjetaCredito.Entidades.Modelo;

namespace TarjetaCredito.Datos
{
    public class MapperTarjeta
    {
        public MapperTarjeta()
        {

        }

        public Resultado AgregarTarjeta(Tarjeta NuevaTarjeta)
        {
           
           string json= WebHelper.Post("tarjetacredito", Reversomap(NuevaTarjeta));
           Resultado Operacion = JsonConvert.DeserializeObject<Resultado>(json);
            return Operacion;
        }

        private NameValueCollection Reversomap(Tarjeta NuevaTarjeta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("tipo", NuevaTarjeta.Tipo.ToString());
            n.Add("periodoVencimiento", NuevaTarjeta.PeriodoVencimiento.ToString());
            n.Add("limiteCompra", NuevaTarjeta.LimiteCompra.ToString());
            n.Add("nroPlastico", NuevaTarjeta.NroPlastico);
            n.Add("usuario", "836465");
            n.Add("idCliente", NuevaTarjeta.IdCliente.ToString());
            return n;
        }

        public List<Tarjeta> ListarTarjetas()
        {
            string json = WebHelper.Get("/tarjetacredito/836465");
            List<Tarjeta> _LstTarjeta = JsonConvert.DeserializeObject<List<Tarjeta>>(json);
            return _LstTarjeta;
        }
    }

    
}
