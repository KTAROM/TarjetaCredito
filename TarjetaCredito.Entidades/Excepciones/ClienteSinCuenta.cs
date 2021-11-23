using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Entidades.Excepciones
{
    public class ClienteSinCuenta:Exception
    {
        
      public ClienteSinCuenta(string message): base(message)
        { }
    }
}
