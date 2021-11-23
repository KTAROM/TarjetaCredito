using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Entidades
{
    [DataContract]
    public abstract class Persona
    {

        protected string _nombre;
        [DataMember]
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

    }
}