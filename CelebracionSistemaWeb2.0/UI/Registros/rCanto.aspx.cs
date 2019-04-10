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
    public partial class rCanto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {

            IdInput.Value = "";
            DescripcionInput.Text = String.Empty;
        


        }
        private Canto LlenaClase()
        {
            int id = 0;
            return new Canto(
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

        private void LlenarCampos(Canto canto)
        {
            DescripcionInput.Text = canto.Nombre;
           
        }

        protected void Buscarbtn_Click(object sender, EventArgs e)
        {
            Repositorio<Canto> repositorio = new Repositorio<Canto>();
            Canto canto = repositorio.Buscar(int.Parse(IdInput.Value));

            if (canto != null)
            {
                LlenarCampos(canto);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario Encontrado');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Usuario no Encontrado');", addScriptTags: true);
            }

        }

        protected void EliminarBtn_Click(object sender, EventArgs e)
        {
            Repositorio<Canto> repositorio = new Repositorio<Canto>();
            Canto canto = repositorio.Buscar(int.Parse(IdInput.Value));

            if (canto != null)
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

        protected void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Repositorio<Canto> canto = new Repositorio<Canto>();

                int id = 0;


                if (ComprobarID(id) == 0)
                {
                    if (canto.Guardar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Guardado!!!');", addScriptTags: true);
                    Limpiar();
                }
                else
                {
                    if (canto.Modificar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Modificado!!!');", addScriptTags: true);
                    Limpiar();
                }
            }

        }

        protected void VaciarBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}