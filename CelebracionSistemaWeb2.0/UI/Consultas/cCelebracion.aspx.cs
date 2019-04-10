using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CelebracionSistemaWeb2._0.UI.Consultas
{
    public partial class cCelebracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DesdeTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                HastaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }

        }

        Expression<Func<Celebracion, bool>> filtro = x => true;
        Repositorio<Celebracion> celebracion = new Repositorio<Celebracion>();


        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            DateTime desde = Convert.ToDateTime(DesdeTextBox.Text);
            DateTime hasta = Convert.ToDateTime(HastaTextBox.Text);



            switch (FiltroDropDownList.SelectedIndex)
            {
                case 0://Todos

                    filtro = x => true && (x.Fecha >= desde && x.Fecha <= hasta);

                    break;
                case 1://ID
                    id = util.ToInt(CriterioTextBox.Text);

                    filtro = c => c.CelebracionId == id && (c.Fecha >= desde && c.Fecha <= hasta);


                  break;

                case 2://  Tema
                    filtro = c => c.Tema.Contains(CriterioTextBox.Text) && (c.Fecha >= desde && c.Fecha <= hasta);


                    break;             

                   

                
             

            }

            var lista = celebracion.GetList(filtro);
            Session["celebracion"] = lista;
            CriterioTextBox.Text = "";
            GridView.DataSource = lista;
            GridView.DataBind();

        }
    }
}