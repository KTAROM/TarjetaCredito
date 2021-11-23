using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarjetaCredito.Datos;
using TarjetaCredito.Entidades;
using TarjetaCredito.Entidades.Excepciones;
using TarjetaCredito.Entidades.Modelo;

namespace TarjetaCredito.Negocio
{
    public class TarjetaNegocio
    {
        private List<Tarjeta> _lstTarjetas;
        private List<Cliente> _lstClientes;
        private MapperCliente _MapCliente;
        private MapperTarjeta _MapTarjeta;

        public TarjetaNegocio()
        {
            this._lstTarjetas = new List<Tarjeta>();
            this._lstClientes = new List<Cliente>();
            this._MapCliente = new MapperCliente();
            this._MapTarjeta = new MapperTarjeta();
        }

        public List<Cliente> ListarClientes()
        {
            this._lstClientes = _MapCliente.TraerTodos();
            return _lstClientes;

        }

        public string GenerarNro(Tarjeta tarjeta)
        {
            string NroPlastico;
            string prefijo;
            Random random = new Random();
            int ultimos3dígitos = random.Next(100, 999);
            if (tarjeta.Tipo == 1)
            { prefijo = "42008100"; }
            else
            {
                if (tarjeta.Tipo == 2)
                {
                    prefijo = "89004500";
                    ultimos3dígitos = tarjeta.IdCliente;
                }

                else { prefijo = "12007590"; }
            }


            NroPlastico = prefijo + ultimos3dígitos.ToString();
            return NroPlastico;
        }

        public bool ComprobarLimit(string limite)
        {
            int importe = int.Parse(limite);
            if (importe < 1000 || importe > 50000)
            {
                return false;
            }
            else { return true; }
        }

        public Resultado AltaTarjeta(Tarjeta NuevaTarjeta)
        {
            Resultado Operacion = null;
            if (ComprobarPlastico(NuevaTarjeta) != null)
            {
                Operacion = _MapTarjeta.AgregarTarjeta(NuevaTarjeta);
            }

            return Operacion;
        }

        private bool ComprobarPlastico(Tarjeta NuevaTarjeta)
        {
            if (NuevaTarjeta.NroPlastico.Count() == 16)
            {
                return true;
            }
            else
            {
                if (NuevaTarjeta.NroPlastico.Count() == 15 && NuevaTarjeta.Tipo == 3)
                {
                    return true;
                }
                else { return false; }
            }
        }

        private bool ComprobarCuenta(Tarjeta NuevaTarjeta)
        {
            Cliente ClienteSeleccionado = null;
            foreach (Cliente c in _lstClientes)
            {
                if (c.Id == NuevaTarjeta.IdCliente)
                {
                    ClienteSeleccionado = c;
                }
            }

            if (ClienteSeleccionado != null && ClienteSeleccionado.Cuenta != null)
            { return true; }
            else
            { throw new ClienteSinCuenta("El cliente no tiene cuenta"); }

            if (NuevaTarjeta.LimiteCompra < ClienteSeleccionado.Cuenta.Saldo * 18)
            {
                return true;
            }
            else
            {
                throw new ClienteSinLimite("El cliente no posee saldo");
            }
        }
        public List<Tarjeta> TraerTarjetas()
        {
            _lstTarjetas = _MapTarjeta.ListarTarjetas();
            return _lstTarjetas;
        }
        public int CantidadPlastico()
        {
            return _lstTarjetas.Count();
        }

        public double LimitePromedio()
        {
            double suma = 0;
            double promedio;
            foreach (Tarjeta tar in _lstTarjetas)
            {
                suma += tar.LimiteCompra;
            }

            promedio = suma / CantidadPlastico();
            return promedio;
        }

        public List<string> Display
        {
            get
            {
                List<string> Datos = new List<string>();

                foreach (Tarjeta tar in TraerTarjetas())
                {
                    foreach (Cliente cli in ListarClientes())
                    {
                        if (cli.Id == tar.IdCliente)
                        {
                            Datos.Add(tar.MostrarTarjeta + " " + cli.Nombre);
                        }
                    }
                }


                return Datos;
            }

        }

        
    }
}
