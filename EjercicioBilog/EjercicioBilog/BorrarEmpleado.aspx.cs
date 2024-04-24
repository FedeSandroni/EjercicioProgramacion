using Motor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EjercicioBilog
{
    public partial class BorrarEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// BORRAR EMPLEADO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT COUNT({emailEmpleado.Text})";
            int exist = Globals.CommandExecuteQueryScalar(query);

            if (exist == 0)
            {
                MessageBox.Show($"No se encontro un empleado con el email {emailEmpleado.Text}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Empleado empleado = new Empleado();
                int counter = empleado.Borrar(emailEmpleado.Text);

                if (counter == 0)
                {
                    MessageBox.Show($"No se pudo borrar el empleado {emailEmpleado.Text}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"El empleado {emailEmpleado.Text} se borro correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}