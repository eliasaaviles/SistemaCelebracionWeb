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
    public partial class rHermanos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private int ComprobarID(int id)
        {
            if (IdInput.Value == String.Empty)
                id = 0;
            else
                id = int.Parse(IdInput.Value);
            return id;
        }

        private void Limpiar()
        {

            IdInput.Value = "";
            NombreInput.Text = String.Empty;
            DireccionInput.Text = String.Empty;
            TelCasaInput.Text = String.Empty;
            TelCelularInput.Text = String.Empty;
            OtroTelInput.Text = String.Empty;

        }

        private Hermano LlenaClase()
        {
            int id = 0;
            return new Hermano(
                ComprobarID(id),
                NombreInput.Text,
                DireccionInput.Text,
                TelCasaInput.Text,
                TelCelularInput.Text,
                OtroTelInput.Text,
                Convert.ToDateTime(fechaTextbox.Text)            
            );
        }

      

        private void LlenarCampos(Hermano hermano)
        {
            NombreInput.Text = hermano.Nombre;
            DireccionInput.Text = hermano.Direccion;
            TelCasaInput.Text = hermano.TelefonoCasa;
            TelCelularInput.Text = hermano.TelefonoCelular;
            OtroTelInput.Text = hermano.TelefonoOtro;
            fechaTextbox.Text = hermano.FechaNacimiento.ToString("yyyy-MM-dd");

        }

        protected void Buscarbtn_Click(object sender, EventArgs e)
        {
            Repositorio<Hermano> Repositorio = new Repositorio<Hermano>();
            Hermano hermano = Repositorio.Buscar(int.Parse(IdInput.Value));

            if (hermano != null)
            {
                LlenarCampos(hermano);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario Encontrado');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Usuario no Encontrado');", addScriptTags: true);
            }

        }

        protected void EliminarBtn_Click(object sender, EventArgs e)
        {
            Repositorio<Hermano> repositorio = new Repositorio<Hermano>();
            Hermano hermano = repositorio.Buscar(int.Parse(IdInput.Value));

            if (hermano != null)
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
                Repositorio<Hermano> usuario = new Repositorio<Hermano>();

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
    }
    }
