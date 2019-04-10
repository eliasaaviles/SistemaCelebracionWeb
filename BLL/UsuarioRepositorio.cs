using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class UsuarioRepositorio
    {
        public bool Verificar(string usuario, string contrasena)
        {
            bool paso = false;

            Repositorio<Usuario> BLL = new Repositorio<Usuario>();
            Expression<Func<Usuario, bool>> filtrar = x => true;

            filtrar = t => t.NombreUsuario.Equals(usuario) && t.Clave.Equals(contrasena);

            if (BLL.GetList(filtrar).Count() != 0)
            {
                paso = true;
            }

            return paso;
        }
    }
}
