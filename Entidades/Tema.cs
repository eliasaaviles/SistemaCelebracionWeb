using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Tema
    {

        [Key]
        public int TemaId { get; set; }
        public string Descripcion { get; set; }

        public Tema()
        {
            TemaId = 0;
            Descripcion = string.Empty;
        }

        public Tema(int temaid, string descripcion)
        {
            TemaId = temaid;
            Descripcion = descripcion;
        }
    }
}
