using Motor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EjercicioBilog
{
    public partial class ModificarEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = $"select * from Empleados where LOWER(id) = LOWER('{emailtxt.Text}')";
            DataTable empleado = Globals.GetDataTable(query);

            if (empleado.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro el empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombretxt.Text = empleado.Rows[0]["Nombre"].ToString();
                apellidotxt.Text = empleado.Rows[0]["Apellido"].ToString();
                emailtxt.Enabled = false;
            }
        }

        protected void Modificarbtn_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.ID = emailtxt.Text;
            empleado.nombre = nombretxt.Text;
            empleado.apellido = apellidotxt.Text;
            int counter = empleado.Modificar();

            if (counter == 0)
            {
                MessageBox.Show("No se pudo modificar el empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El empleado se modifico correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}