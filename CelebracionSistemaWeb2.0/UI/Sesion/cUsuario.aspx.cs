using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CelebracionSistemaWeb2._0.UI.Sesion
{
    public partial class cUsuario : System.Web.UI.Page
    {
        Expression<Func<Usuario, bool>> filter = x => true;

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Usuario> u = new List<Usuario>();
            u.Add(new Usuario());
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
                    filter = (x => x.IdUsuario == id);
                    break;

                case 2://Nombre 
                    filter = (x => x.Nombre.Contains(TextBoxBuscar.Text));
                    break;

                case 3: //Nombre usuario
                    filter = (x => x.NombreUsuario.Contains(TextBoxBuscar.Text));
                    break;

                case 4: //Nombre usuario
                    filter = (x => x.Email.Contains(TextBoxBuscar.Text));
                    break;
            }

            Repositorio<Usuario> rep = new Repositorio<Usuario>();
            GridView.DataSource = rep.GetList(filter);
            GridView.DataBind();
        }

    
    }
}