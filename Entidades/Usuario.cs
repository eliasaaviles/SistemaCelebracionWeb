using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
       public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public bool Tipousuario { get; set; }

        public Usuario(int idUsuario, string nombre, string clave, string nombreUsuario, string email, bool tipousuario)
        {
            this.IdUsuario = idUsuario;
            this.Nombre = nombre;
            this.Email = email;
            this.Clave = clave;
            this.NombreUsuario = nombreUsuario;
            this.Tipousuario = Tipousuario;
        }

        public Usuario()
        {
            this.IdUsuario = 0;
            this.Nombre = string.Empty;
            this.Clave = string.Empty;
            this.Email = string.Empty;
            this.NombreUsuario = string.Empty;
            this.Tipousuario = false;
        }
    }
}
