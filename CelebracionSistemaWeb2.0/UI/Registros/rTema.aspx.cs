using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CelebracionSistemaWeb2._0.UI.Registros
{
    public partial class rTema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {

            IdInput.Value = "";
            DescripcionInput.Text = String.Empty;



        }
        private Tema LlenaClase()
        {
            int id = 0;
            return new Tema(
                ComprobarID(id),
                DescripcionInput.Text

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

        private void LlenarCampos(Tema tema)
        {
            DescripcionInput.Text = tema.Descripcion;

        }

        protected void Buscarbtn_Click(object sender, EventArgs e)
        {
            Repositorio<Tema> repositorio = new Repositorio<Tema>();
            Tema tema = repositorio.Buscar(int.Parse(IdInput.Value));

            if (tema != null)
            {
                LlenarCampos(tema);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario Encontrado');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Usuario no Encontrado');", addScriptTags: true);
            }
        }

        protected void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Repositorio<Tema> tema = new Repositorio<Tema>();

                int id = 0;


                if (ComprobarID(id) == 0)
                {
                    if (tema.Guardar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Guardado!!!');", addScriptTags: true);
                    Limpiar();
                }
                else
                {
                    if (tema.Modificar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Modificado!!!');", addScriptTags: true);
                    Limpiar();
                }
            }
        }

        protected void EliminarBtn_Click(object sender, EventArgs e)
        {
            Repositorio<Tema> repositorio = new Repositorio<Tema>();
            Tema tema = repositorio.Buscar(int.Parse(IdInput.Value));

            if (tema != null)
            {
                repositorio.Eliminar(int.Parse(IdInput.Value));
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Eliminado!!!');", addScriptTags: true);
                Limpiar();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo Eliminar');", addScriptTags: true);
            }
        }

        protected void VaciarBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
