using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CelebracionSistemaWeb2._0.UI.Registros
{
    public partial class rCelebracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                LlenaCombobox();
                ViewState["Celebracion"] = new Celebracion();
            }
        }

        private int ComprobarID(int id)
        {
            if (CelebracionIdInput.Text == String.Empty)
                id = 0;
            else
                id = int.Parse(CelebracionIdInput.Text);
            return id;
        }

        private void LlenaCombobox()
        {
            Repositorio<Tema> tema = new Repositorio<Tema>();
            TemaDrown.DataSource = tema.GetList(c => true);
            TemaDrown.DataValueField = "TemaId";
            TemaDrown.DataTextField = "Descripcion";
            TemaDrown.DataBind();
            ViewState["Tema"] = new Tema();

            Repositorio<Canto> canto = new Repositorio<Canto>();
            CantoEntradaDrown.DataSource = canto.GetList(c => true);
            CantoEntradaDrown.DataValueField = "CantoId";
            CantoEntradaDrown.DataTextField = "Nombre";
            CantoEntradaDrown.DataBind();
            ViewState["Canto"] = new Canto();

            Repositorio<Hermano> hermano = new Repositorio<Hermano>();
            HermanoDrown.DataSource = hermano.GetList(c => true);
            HermanoDrown.DataValueField = "HermanoId";
            HermanoDrown.DataTextField = "Nombre";
            HermanoDrown.DataBind();
            ViewState["Hermano"] = new Canto();

            
            CantoDrown.DataSource = canto.GetList(c => true);
            CantoDrown.DataValueField = "CantoId";
            CantoDrown.DataTextField = "Nombre";
            CantoDrown.DataBind();
            ViewState["Canto"] = new Canto();

            MonitorDrown.DataSource = hermano.GetList(c => true);
            MonitorDrown.DataValueField = "HermanoId";
            MonitorDrown.DataTextField = "Nombre";
            MonitorDrown.DataBind();
            ViewState["Hermano"] = new Canto();

            

        }

        protected void BindGrid()
        {
            DetalleGridView.DataSource = ((Celebracion)ViewState["Celebracion"]).Detalle;

            DetalleGridView.DataBind();
        }

        public void Vaciar()
        {
            CelebracionIdInput.Text = "";
            FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            LecturaDrown.Text = "";
            DetalleGridView.DataBind();           
            ViewState["detalle"] = null;
        }

        public void Vaciar2()
        {

            LecturaDrown.Text = "";            
            FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private Celebracion LlenaClase()
        {
            Celebracion celebracion = new Celebracion();

            celebracion.CelebracionId = util.ToInt(CelebracionIdInput.Text);
            celebracion.HermanoId = util.ToInt(HermanoDrown.SelectedValue);
            celebracion.NombreHermano = util.RetornarNombre2(MonitorDrown.SelectedValue);
            celebracion.Fecha = Convert.ToDateTime(FechaTextBox.Text);
           
         

            celebracion.Detalle = (List<CelebracionDetalle>)ViewState["detalle"];

            return celebracion;
        }

        private void LlenaCampos(Celebracion celebracion)
        {
            CelebracionDetalle detalle = new CelebracionDetalle();
            CelebracionIdInput.Text = celebracion.CelebracionId.ToString();
            FechaTextBox.Text = celebracion.Fecha.ToString("yyyy-MM-dd");
            HermanoDrown.Text = celebracion.HermanoId.ToString();
           


            //Cargar el detalle al Grid
            ViewState["detalle"] = celebracion.Detalle;
            DetalleGridView.DataSource = (List<CelebracionDetalle>)ViewState["detalle"];

            DetalleGridView.DataBind();

        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            Celebracion celebracion = new Celebracion();
            List<CelebracionDetalle> celebracionDetalle = new List<CelebracionDetalle>();

            

            if (DetalleGridView.Rows.Count != 0)
            {
                celebracionDetalle = (List<CelebracionDetalle>)ViewState["detalle"];
            }




            celebracionDetalle.Add(new CelebracionDetalle(util.ToInt(CelebracionIdInput.Text), OrdenDrown.SelectedItem.Text, LecturaDrown.Text, MonitorDrown.SelectedItem.Text, CantoDrown.SelectedItem.Text));

            


            ViewState["detalle"] = celebracionDetalle;


            DetalleGridView.DataSource = ViewState["detalle"];
            DetalleGridView.DataBind();


           

           
            Vaciar2();
        }

        protected void DetalleGridView_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
           
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (DetalleGridView.Rows.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['danger']('Requiere Añadir algo al detalle!!!');", addScriptTags: true);

                return;
            }

            if (Page.IsValid)
            {
                Repositorio<Celebracion> rb = new Repositorio<Celebracion>();

                int id = 0;

                if (ComprobarID(id) == 0)
                {
                    if (rb.Guardar(LlenaClase()))
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Celebracion Guardada!!!');", addScriptTags: true);
                        Vaciar();
                        Vaciar2();

                    }

                }
                else
                {
                    if (rb.Modificar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Celebracion Modificada!!!');", addScriptTags: true);
                    Vaciar();
                }
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Celebracion> repositorio = new Repositorio<Celebracion>();
            Celebracion celebracion = repositorio.Buscar(int.Parse(CelebracionIdInput.Text));

            if (celebracion != null)
            {
                LlenaCampos(celebracion);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Encontrado!!!');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudoEncontrado!!!');", addScriptTags: true);
            }
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            Repositorio<Celebracion> repositorio = new Repositorio<Celebracion>();

         
            if (repositorio != null)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Eliminado!!!');", addScriptTags: true);
                Vaciar();
            }
            else
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo Eliminar');", addScriptTags: true);
            }


        }
}