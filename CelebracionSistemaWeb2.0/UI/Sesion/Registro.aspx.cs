using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CelebracionSistemaWeb2._0.UI.Sesion
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {

            IdInput.Value = "";
            NombreInput.Text = String.Empty;
            EmailInput.Text = String.Empty;
            UsuarioInput.Text = String.Empty;
            PasswordInput.Text = String.Empty;
            ConPasswordInput.Text = String.Empty;


        }
        private Usuario LlenaClase()
        {
            int id = 0;
            return new Usuario(
                ComprobarID(id),
                NombreInput.Text,
                PasswordInput.Text,                
                UsuarioInput.Text,
                EmailInput.Text,                
                false
                

                );
        }

        private int ComprobarID(int id)
        {
            if (IdInput.Value == String.Empty)
                id = 0;
            else
                id = int.Parse(IdInput.Value);
            return id;
        }

        private void LlenarCampos(Usuario usuario)
        {
            NombreInput.Text = usuario.Nombre;                   
            EmailInput.Text = usuario.Email;
            UsuarioInput.Text = usuario.NombreUsuario;
            PasswordInput.Text = usuario.Clave;
            ConPasswordInput.Text = usuario.Clave;
            
        }

       

        protected void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Repositorio<Usuario> usuario = new Repositorio<Usuario>();

                int id = 0;

              
                    if (ComprobarID(id) == 0)
                    {
                        if (usuario.Guardar(LlenaClase()))
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Guardado!!!');", addScriptTags: true);
                        Limpiar();
                    }
                    else
                    {
                        if (usuario.Modificar(LlenaClase()))
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Modificado!!!');", addScriptTags: true);
                        Limpiar();
                    }
                }
              
            
        }

        protected void VaciarBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void EliminarBtn_Click(object sender, EventArgs e)
        {
            Repositorio<Usuario> usuarioRepository = new Repositorio<Usuario>();
            Usuario usuario = usuarioRepository.Buscar(int.Parse(IdInput.Value));

           if (usuario != null)
            {
                usuarioRepository.Eliminar(int.Parse(IdInput.Value));
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Eliminado!!!');", addScriptTags: true);
                Limpiar();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo Eliminar');", addScriptTags: true);
            }
        }

        public void Buscarbtn_Click(object sender, EventArgs e)
        {
           
                Repositorio<Usuario> usuarioRepository = new Repositorio<Usuario>();
                Usuario usuario = usuarioRepository.Buscar(int.Parse(IdInput.Value));

                if (usuario != null)
                {
                    LlenarCampos(usuario);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario Encontrado');", addScriptTags: true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Usuario no Encontrado');", addScriptTags: true);
                }

            }
        }
    
}