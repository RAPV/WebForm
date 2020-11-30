using App.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class AlumnoDA : BaseConnection
    {
        public List<Alumno> GetAll(string filtro)
        {
            var retorno = new List<Alumno>();
            var sql = "usp_GetAllAlumno";

            using (var dbConnection = this.GetConnection())
            {
                IDbCommand command = new SqlCommand(sql);
                command.Connection = dbConnection;

                command.Parameters.Add(new SqlParameter("@filtro", filtro));

                command.CommandType = CommandType.StoredProcedure;

                dbConnection.Open();

                var reader = command.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var alumno = new App.Entities.Alumno();

                    indice = reader.GetOrdinal("AlumnoID");
                    alumno.AlumnoID = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Nombres");
                    alumno.Nombres = reader.GetString(indice);

                    indice = reader.GetOrdinal("Apellidos");
                    alumno.Apellidos = reader.GetString(indice);

                    indice = reader.GetOrdinal("Direccion");
                    alumno.Direccion = reader.GetString(indice);

                    indice = reader.GetOrdinal("Sexo");
                    alumno.Sexo = reader.GetString(indice);

                    indice = reader.GetOrdinal("FechaNacimiento");
                    alumno.FechaNacimiento = Convert.ToDateTime(reader.GetDateTime(indice));

                    retorno.Add(alumno);
                }

            }
            return retorno;

        }

        public Alumno GetById(int id)
        {
            var respuesta = new App.Entities.Alumno();
            var sql = "usp_GetByIdAlumno";

            using (var dbConnection = this.GetConnection())
            {
                IDbCommand command = new SqlCommand(sql);
                command.Connection = dbConnection;

                command.Parameters.Add(new SqlParameter("@id", id));

                command.CommandType = CommandType.StoredProcedure;
                dbConnection.Open();

                var reader = command.ExecuteReader();
                var indice = 0;

                while (reader.Read())
                {
                    var alumno = new Alumno();

                    indice = reader.GetOrdinal("AlumnoID");
                    alumno.AlumnoID = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Nombres");
                    alumno.Nombres = reader.GetString(indice);

                    indice = reader.GetOrdinal("Apellidos");
                    alumno.Apellidos = reader.GetString(indice);

                    indice = reader.GetOrdinal("Direccion");
                    alumno.Direccion = reader.GetString(indice);

                    indice = reader.GetOrdinal("Sexo");
                    alumno.Sexo = reader.GetString(indice);

                    indice = reader.GetOrdinal("FechaNacimiento");
                    alumno.FechaNacimiento = Convert.ToDateTime(reader.GetDateTime(indice));

                    respuesta= alumno;
                }
                return respuesta;
            }
        }

        public int Update(Alumno alumno)
        {
            var retorno = 0;
            var sql = "usp_UpdateAlumno";

            using (var dbConnection = this.GetConnection())
            {
                IDbCommand command = new SqlCommand(sql);
                command.Connection = dbConnection;

                command.Parameters.Add(new SqlParameter("@AlumnoID", alumno.AlumnoID));

                command.Parameters.Add(new SqlParameter("@Nombres", alumno.Nombres));
                command.Parameters.Add(new SqlParameter("@Apellidos", alumno.Apellidos));
                command.Parameters.Add(new SqlParameter("@Direccion", alumno.Direccion));
                command.Parameters.Add(new SqlParameter("@Sexo", alumno.Sexo));
                command.Parameters.Add(new SqlParameter("@FechaNacimiento", alumno.FechaNacimiento));

                command.CommandType = CommandType.StoredProcedure;

                dbConnection.Open();

                retorno = Convert.ToInt32(command.ExecuteScalar());

            }

            return retorno;
        }

        public int Insert(Alumno alumno)
        {
            var retorno = 0;
            var sql = "usp_InsertAlumno";

            using (var dbConnection = this.GetConnection())
            {
                IDbCommand command = new SqlCommand(sql);
                command.Connection = dbConnection;

                command.Parameters.Add(new SqlParameter("@Nombres", alumno.Nombres));
                command.Parameters.Add(new SqlParameter("@Apellidos", alumno.Apellidos));
                command.Parameters.Add(new SqlParameter("@Direccion", alumno.Direccion));
                command.Parameters.Add(new SqlParameter("@Sexo", alumno.Sexo));
                command.Parameters.Add(new SqlParameter("@FechaNacimiento", alumno.FechaNacimiento));

                command.CommandType = CommandType.StoredProcedure;

                dbConnection.Open();

                retorno = Convert.ToInt32(command.ExecuteScalar());

            }

            return retorno;
        }
    }
}
