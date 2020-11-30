using App.Business;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App.WebForm.Manteminientos
{
    public partial class AlumnoEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)//llamaria solo una vez a la funcion
            {
                InitData();
            }
        }


        private void InitData()
        {
            var codigo = Request.QueryString["cod"];

            if (!string.IsNullOrWhiteSpace(codigo))
            {
                var artistaId = Convert.ToInt32(codigo);
                var alumnoBL = new AlumnoBL(); 

                var alumno = alumnoBL.GetByIdAlumno(artistaId);

                if (alumno != null)
                {
                    hidCodigo.Value = alumno.AlumnoID.ToString();
                    txtNombre.Text = alumno.Nombres;
                    txtApellidos.Text = alumno.Apellidos;
                    txtDireccion.Text = alumno.Direccion;
                    txtSexo.Text = alumno.Sexo;
                    txtFechaNacimiento.Text = Convert.ToString(alumno.FechaNacimiento);
                }
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            var alumnoBL = new AlumnoBL();
            var alumno = new App.Entities.Alumno();

            alumno.Nombres = txtNombre.Text;
            alumno.Apellidos = txtApellidos.Text;
            alumno.Direccion = txtDireccion.Text;
            alumno.Sexo = txtSexo.Text;
            alumno.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);

            if (!string.IsNullOrWhiteSpace(hidCodigo.Value))
            {
                alumno.AlumnoID = Convert.ToInt32(hidCodigo.Value);             
               
                alumnoBL.save(alumno);

            }

                alumnoBL.save(alumno);

        }
    }
}