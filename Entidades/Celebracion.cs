using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Celebracion

    {
        [Key]
        public int CelebracionId { get; set; }
        public DateTime Fecha { get; set; }
        public string Tema { get; set; }
        public string NombreHermano { get; set; }
        public int HermanoId { get; set; }
        public int CantoEntrada { get; set; }
        public int CantoFinal { get; set; }

        public virtual ICollection<CelebracionDetalle> Detalle { get; set; }

        public Celebracion()
        {
            this.Detalle = new List<CelebracionDetalle>();

            CelebracionId = 0;
            Tema = " ";
            Fecha = DateTime.Now;
            CantoEntrada = 0;
            CantoFinal = 0;

        }
        public void AgregarDetalle(int celebracionId, string orden, string lectura, string monitor, string canto)
        {
            this.Detalle.Add(new CelebracionDetalle(celebracionId, orden, lectura, monitor, canto));
        }
    }
}
