using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Entidades
{

    [DataContract]
    public class Cliente : Persona
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private long _DNI;
        private string _email;
        private DateTime _fechaNac;
        private Cuenta _cuenta;
        private string _telefono;
        private bool _activo;


        [DataMember(Name = "Id")]
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        [DataMember(Name = "nombre")]
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        [DataMember(Name = "apellido")]
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        [DataMember(Name = "direccion")]
        public string Direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }

        public string Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
        [DataMember(Name = "DNI")]
        public long DNI
        {
            get { return this._DNI; }
            set { this._DNI = value; }
        }
        [DataMember(Name = "FechaNacimiento")]
        public DateTime FechaNac
        {
            get { return this._fechaNac; }
            set { this._fechaNac = value; }
        }
        public Cuenta Cuenta
        {
            get { return this._cuenta; }
            set { this._cuenta = value; }
        }
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public Cliente()
        {

        }
        public Cliente(string Nombre, string Apellido, string Telefono, string Direccion, string Email, DateTime FechaNac, long DNI)
        {

            this._nombre = Nombre;
            this._apellido = Apellido;
            this._telefono = Telefono;
            this._direccion = Direccion;
            this._email = Email;
            this._fechaNac = FechaNac;
            this._DNI = DNI;
        }
        public override string ToString()
        {
            return (this._id + " " + this._DNI + " " + this._nombre + " " + this._apellido);
        }

        public string DisplayCombo
        {
            get { return (this._apellido + " " + this._nombre); }
        }

    }
}