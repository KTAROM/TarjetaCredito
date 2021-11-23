using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Entidades
{
    public class Cuenta
    {
        private int _id;
        private int _NroCuenta;
        private string _Descripcion;
        private double _Saldo;
        private DateTime _FechaApertura;
        private DateTime _FechaModificacion;
        private bool _Activo;
        private int _idCliente;

        public int id { get; set; }
        public int Nrocuenta { get; set; }
        public string Descripcion { get; set; }
        public double Saldo { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Activo { get; set; }
        public int idCliente { get; set; }




        public Cuenta()
        {

        }
        public override string ToString()
        {
            return (this._NroCuenta + " " + this._Descripcion + " " + this._Saldo.ToString("0.00") + " " + this._id);

        }

    }
}