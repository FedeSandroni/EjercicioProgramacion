using System;
using System.Web.WebSockets;
using System.Windows.Forms;
using Motor;

namespace EjercicioBilog
{
    public partial class AgregarEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Savebtn_Click(object sender, EventArgs e)
        {
            ///SUPONIENDO QUE TODOS LOS DATOS INGRESADOS POR EL USUARIO ESTAN BIEN.. EL EMAIL NO SE PUEDE REPETIR


           Empleado empleado = new Empleado();
           empleado.ID = emailtxt.Text;
           empleado.nombre = nombretxt.Text;
           empleado.apellido = apellidotxt.Text;

           int counter = empleado.Guardar();

            if (counter == 0)
            {
                MessageBox.Show("No se pudo guardar el empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El empleado se guardo correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}