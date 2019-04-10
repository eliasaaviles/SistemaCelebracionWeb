using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class CelebracionDetalle
    {
        [Key]
        public int CelebracionDetalleId { get; set; }
        public string Orden { get; set; }
        public string Lectura { get; set; }
        public string Monitor { get; set; }
        public string Canto { get; set; }


        public CelebracionDetalle()
        {
            CelebracionDetalleId = 0;
           Orden = "";
            Lectura = "";
            Monitor = "";
            Canto = "";
        }

        public CelebracionDetalle(int celebracionId,  string orden, string lectura, string monitor, string canto)
        {
            CelebracionDetalleId = celebracionId;
            Orden = orden;
            Lectura = lectura;
            Monitor = monitor;
            Canto = canto;

        }

    }
}
