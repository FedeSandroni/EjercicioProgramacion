using Motor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioBilog
{
    public partial class ListarEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///AL CARGAR LA PAGINA...
            ///

            DataTable data = Globals.GetDataTable("SELECT ID as Email, Nombre, Apellido FROM Empleados");
            GridView.DataSource = data;
            GridView.DataBind();

        }
    }
}