using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Entidades
{
    public class Tarjeta
    {
        private int _Tipo;
        private int _PeriodoVencimiento;
        private double _LimiteCompra;
        private string _NroPlastico;
        private string _usuario;
        private int _idCliente;
        private TipoTarjeta _TipoTarjeta;
        private PeriodoCierre _PerCierre;

        public Tarjeta()
        {
            this._TipoTarjeta = new TipoTarjeta();
            this._PerCierre = new PeriodoCierre();
        }

        public int Tipo { get => _Tipo; set => _Tipo = value; }
        public int PeriodoVencimiento { get => _PeriodoVencimiento; set => _PeriodoVencimiento = value; }
        public double LimiteCompra { get => _LimiteCompra; set => _LimiteCompra = value; }
        public string NroPlastico { get => _NroPlastico; set => _NroPlastico = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }

     public string MostrarTarjeta
        {
           
            get { return (IdCliente + " ) " + Enum.GetName(typeof(TipoTarjeta), Tipo) + " - " + NroPlastico.ToString() + " Límite de crédito " + LimiteCompra.ToString("0.00")); }
        }
      
        
    }
    
}

