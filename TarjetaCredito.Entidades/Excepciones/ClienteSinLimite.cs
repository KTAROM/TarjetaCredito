using System;
using System.Runtime.Serialization;

namespace TarjetaCredito.Negocio
{
    [Serializable]
    public class ClienteSinLimite : Exception
    {
      
        public ClienteSinLimite(string message) : base(message)
        {
        }

    }
}