using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCurso
{
    public class Empleado
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public double SalarioMensual { get; set; }
    }
}


