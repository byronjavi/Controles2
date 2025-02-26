using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    public class Registro
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;
        private int edad;

        public Registro(string nombre, string apellido, string direccion, string telefono, int edad) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
