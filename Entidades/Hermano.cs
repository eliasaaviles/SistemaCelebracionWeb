using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hermano
    {
        [Key]
        public int HermanoId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoOtro { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Hermano (int hermanoId, string nombre,string direccion,string telefonocasa,string telefonocelular,string telefonootro, DateTime fechanacimiento)
        {
            HermanoId = hermanoId;
            Nombre = nombre;
            Direccion = direccion;
            TelefonoCasa = telefonocasa;
            TelefonoCelular = telefonocelular;
            TelefonoOtro = telefonootro;
            FechaNacimiento = fechanacimiento;
        }

        public Hermano()
        {
            HermanoId = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            TelefonoCasa = string.Empty;
            TelefonoCelular = string.Empty;
            TelefonoOtro = string.Empty;
            FechaNacimiento = DateTime.Now;

        }

        public override string ToString()
        {
            return this.Nombre;
        }



    }
}
