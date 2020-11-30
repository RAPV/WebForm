using App.Data;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public class AlumnoBL
    {
        public List<Alumno> GetAlumnos (string filtro)
        {
            List<Alumno> resultado;
            //AlumnoDA alumnoDA;
            var alumnoDA = new AlumnoDA();

            resultado = alumnoDA.GetAll(filtro);

            return resultado;
            
        }

        public Alumno GetByIdAlumno(int id)
        {
            Alumno Resultado;

            var alumnoDA = new AlumnoDA();

            Resultado = alumnoDA.GetById(id);

            return Resultado;
        }

        public int InsertAlumno(Alumno alumno)
        {
            int Resultado;
            var alumnoDA = new AlumnoDA();

            Resultado = alumnoDA.Insert(alumno);
            return Resultado;
        }

        public int UpdateAlumno(Alumno alumno)
        {
            int Resultado;
            var alumnoDA = new AlumnoDA();

            Resultado = alumnoDA.Update(alumno);
            return Resultado;
        }
        public void save(Alumno alumno)
        {
            var alumnoDA = new AlumnoDA();
            if (string.IsNullOrWhiteSpace(alumno.Nombres))
                throw new Exception("Es necesario el nombre del artista.");
            if (string.IsNullOrWhiteSpace(alumno.Apellidos))
                throw new Exception("Es necesario el nombre del artista.");
            if (string.IsNullOrWhiteSpace(alumno.Direccion))
                throw new Exception("Es necesario el nombre del artista.");
            if (string.IsNullOrWhiteSpace(alumno.Sexo))
                throw new Exception("Es necesario el nombre del artista.");
            if (string.IsNullOrWhiteSpace(Convert.ToString(alumno.FechaNacimiento))) 
                throw new Exception("Es necesario el nombre del artista.");


                if (alumno.AlumnoID > 0)
                   alumnoDA.Update(alumno);
                else
                alumnoDA.Insert(alumno);

              


        }
    }
}
