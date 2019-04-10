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
    public partial class cCanto : System.Web.UI.Page
    {
        Expression<Func<Canto, bool>> filter = x => true;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Canto> u = new List<Canto>();
            u.Add(new Canto());
            GridView.DataSource = u;
            GridView.DataBind();
        }

        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            int id = 0;

            switch (DropDownListFiltro.SelectedIndex)
            {
                case 0://Todo
                    filter = x => true;
                    break;

                case 1://Id
                    id = int.Parse(TextBoxBuscar.Text);
                    filter = (x => x.CantoId == id);
                    break;

                case 2://Nombre 
                    filter = (x => x.Nombre.Contains(TextBoxBuscar.Text));
                    break;

             
            }

            Repositorio<Canto> rep = new Repositorio<Canto>();
            GridView.DataSource = rep.GetList(filter);
            GridView.DataBind();
        }
    }
}