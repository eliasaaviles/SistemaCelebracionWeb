using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Canto
    {
        [Key]
        public int CantoId { get; set; }
        public string Nombre { get; set; }

        public Canto()
        {
            CantoId = 0;
            Nombre = string.Empty;

        }
        public Canto(int cantoid, string nombre)
        {
            CantoId = cantoid;
            Nombre = nombre;
        }
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
