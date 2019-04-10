using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace CelebracionSistemaWeb2._0
{
    public static class util
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;
            int.TryParse(valor, out retorno);

            return retorno;
        }

            

        public static string RetornarNombre(string nombre)
        {
            Repositorio<Hermano> repositorio = new Repositorio<Hermano>();
            int id = util.ToInt(nombre);
            string descripcion = string.Empty;
            var lista = repositorio.GetList(x => x.HermanoId == id);
            foreach (var item in lista)
            {
                descripcion = item.Nombre;
            }

            return descripcion;
        }
        public static string RetornarNombre2(string nombre)
        {
            Repositorio<Hermano> repositorio = new Repositorio<Hermano>();
            int id = util.ToInt(nombre);
            string descripcion = string.Empty;
            var lista = repositorio.GetList(x => x.HermanoId == id);
            foreach (var item in lista)
            {
                descripcion = item.Nombre;
            }

            return descripcion;
        }




    }
}
