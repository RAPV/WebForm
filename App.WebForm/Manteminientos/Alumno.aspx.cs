using App.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App.WebForm.Manteminientos
{
    public partial class Alumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            var filtro = $"%{txtFilterByName.Text}%";
            var alumnoBE = new AlumnoBL();
            var alumno = alumnoBE.GetAlumnos(filtro);

            dgvListado.DataSource = alumno;
            dgvListado.DataBind();
        }
    }
}