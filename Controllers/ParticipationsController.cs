using Parcial_1_Marco_Gonzalez.Config;
using Parcial_1_Marco_Gonzalez.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1_Marco_Gonzalez.Controllers
{
    internal class ParticipationsController
    {
        Connection connection = new Connection();
        public List<ParticipationModel> getAll()
        {
            List<ParticipationModel> participations = new List<ParticipationModel>();

            using (var cn = connection.getConnection())
            {
                string querySring = $"SELECT Participaciones.ParticipacionID, Participaciones.EmpleadoID, Participaciones.ProyectoID, " +
                    $"Empleados.EmpleadoID, Empleados.Nombre as Empleado, " +
                    $"Proyectos.ProyectoID, Proyectos.Nombre as Proyecto " +
                    $"FROM Participaciones " +
                    $"INNER JOIN Empleados ON Participaciones.EmpleadoID = Empleados.EmpleadoID " +
                    $"INNER JOIN Proyectos ON Participaciones.ProyectoID = Proyectos.ProyectoID;";


                using (var command = new SqlCommand(querySring, cn))
                {
                    cn.Open();

                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            ParticipationModel participation = new ParticipationModel
                            {
                                
                                Empleado = reader["Empleado"].ToString(),
                                EmpleadoID = (int)reader["EmpleadoID"],
                                Proyecto = reader["Proyecto"].ToString(),
                                ProyectoID = (int)reader["ProyectoID"],
                            };

                            participations.Add(participation);
                        }
                    }
                }
            }
            return participations;
        }
        public ParticipationModel getOne(int participationId)
        {
            ParticipationModel? participation = null;

            using (var cn = connection.getConnection())
            {
                string queryString = $"SELECT * FROM Participaciones WHERE ParticipacionID = {participationId}";

                using (var command = new SqlCommand(queryString, cn))
                {

                    cn.Open();
                    using (var reader = command.ExecuteReader())
                    {

                        if(reader.Read())
                        {
                            participation = new ParticipationModel
                            {
                                ParticipacionID = (int)reader["ParticipacionID"],
                                ProyectoID = (int)reader["ProyectoID"],
                                EmpleadoID = (int)reader["EmpleadoID"]
                            };
                        }


                    }
                }
            }
            return participation;
        }

        public string insertOne(ParticipationModel participation)
        {


            using (var cn = connection.getConnection())
            {

                string queryString = $"INSERT INTO Participaciones(EmpleadoID, ProyectoID) " +
                    $"Values({participation.EmpleadoID},{participation.ProyectoID})";
                MessageBox.Show(queryString);
                using (var command = new SqlCommand(queryString, cn))
                {
                    cn.Open();

                    try
                    {

                        command.ExecuteNonQuery();
                        return "Status: OK - Datos insertados correctamente";
                    }
                    catch (Exception e)
                    {
                        return "Status: ERROR - " + e.Message;

                    }
                }
            }

        }

        public string updateOne(ParticipationModel participation)
        {

            using (var cn = connection.getConnection())
            {
                var queryString = $"UPDATE Participaciones SET EmpleadoID = '{participation.EmpleadoID}'," +
                    $" ProyectoID = {participation.ProyectoID}" +
                    $" WHERE ProyectoID = {participation.ParticipacionID};";
                using (var comando = new SqlCommand(queryString, cn))
                {
                    try
                    {
                        cn.Open();
                        comando.ExecuteNonQuery();
                        return "Status: OK - Datos actualizados correctamente";
                    }
                    catch (Exception e)
                    {
                        return $"Status: Error - {e.Message}";
                    }
                }
            }

        }

        public bool deleteOne(int participationId)
        {
            using (var cn = connection.getConnection())
            {
                string queryString = $"DELETE FROM Participaciones WHERE ParticipacionID = {participationId}";

                using (var command = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }

        public List<ProjectModel> search(string query)
        {
            var filteredProjects = new List<ProjectModel>();

            using (var cn = connection.getConnection())
            {

                string queryString = $"SELECT Participaciones.ParticipacionID, Participaciones.EmpleadoID, Participaciones.ProyectoID, " +
                    $"Empleados.EmpleadoID, Empleados.Nombre as Empleado, " +
                    $"Proyectos.ProyectoID, Proyectos.Nombre as Proyecto" +
                    $"FROM Proyectos " +
                    $"INNER JOIN Empleados ON Participaciones.EmpleadoID = Empleados.EmpleadoID" +
                    $"INNER JOIN Participaciones ON Participaciones.ProyectoID = Proyectos.ProyectoID " +
                    $"WHERE Empleado LIKE '%{query}%' OR" +
                    $"Proyecto LIKE '%{query}%';";


                using (var command = new SqlCommand(queryString, cn))
                {

                    cn.Open();

                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            var project = new ProjectModel
                            {
                                ProyectoID = (int)reader["ProyectoID"],
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                FechaInicio = reader["FechaInicio"].ToString(),
                                FechaFin = reader["FechaFin"].ToString()
                            };

                            filteredProjects.Add(project);
                        }
                    }
                }

            }
            return filteredProjects;
        }
    }
}
