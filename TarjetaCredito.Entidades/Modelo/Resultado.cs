using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Entidades.Modelo
{
    public class Resultado
    {
        private string _error;
        private int _id;
        private bool _IsOk;
        
        public Resultado()
        {

        }

        public string Error { get => _error; set => _error = value; }
        public int Id { get => _id; set => _id = value; }
        public bool IsOk { get => _IsOk; set => _IsOk = value; }
    }
}
