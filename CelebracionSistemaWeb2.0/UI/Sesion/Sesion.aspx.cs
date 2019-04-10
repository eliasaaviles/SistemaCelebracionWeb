using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace CelebracionSistemaWeb2._0.UI.Sesion
{
    public partial class Sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InicioSesionBtn_Click(object sender, EventArgs e)
        {
            UsuarioRepositorio repositorio = new UsuarioRepositorio();

            Expression<Func<Usuario, bool>> filtrar = x => true;


            Usuario user = new Usuario();



            if (repositorio.Verificar(UsuarioInput.Text, ContrasenaInput.Text))
            {
             
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Ha iniciado Sesion Correctamente!!!');", addScriptTags: true);
               
                FormsAuthentication.SetAuthCookie(user.NombreUsuario, true);
                
                Response.Redirect("~/Default.aspx");


            }
            else
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Contraseña o usuario no valido!!!');", addScriptTags: true);

            }
        }
    }
}