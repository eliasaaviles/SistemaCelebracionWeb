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
    public partial class cHermano : System.Web.UI.Page
    {
        Expression<Func<Hermano, bool>> filter = x => true;

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Hermano> u = new List<Hermano>();
            u.Add(new Hermano());
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
                    filter = (x => x.HermanoId == id);
                    break;

                case 2://Nombre 
                    filter = (x => x.Nombre.Contains(TextBoxBuscar.Text));
                    break;

                case 3: //Direccion
                    filter = (x => x.Direccion.Contains(TextBoxBuscar.Text));
                    break;
            }

            Repositorio<Hermano> rep = new Repositorio<Hermano>();
            GridView.DataSource = rep.GetList(filter);
            GridView.DataBind();
        }
    }
}