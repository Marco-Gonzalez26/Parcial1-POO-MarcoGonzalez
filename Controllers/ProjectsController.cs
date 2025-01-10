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
    internal class ProjectsController
    {
        Connection connection = new Connection();
        public List<ProjectModel> getAll()
        {
            List<ProjectModel> projects = new List<ProjectModel>();

            using (var cn = connection.getConnection())
            {
                string querySring = $"SELECT * FROM Proyectos";


                using (var command = new SqlCommand(querySring, cn))
                {
                    cn.Open();

                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            ProjectModel project = new ProjectModel
                            {
                                ProyectoID = (int)reader["ProyectoID"],
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                FechaInicio = reader["FechaInicio"].ToString(),
                                FechaFin = reader["FechaFin"].ToString()
                            };

                            projects.Add(project);
                        }
                    }
                }
            }
            return projects;
        }
        public ProjectModel getOne(int projectId)
        {
            ProjectModel? project = null;

            using (var cn = connection.getConnection())
            {
                string queryString = $"SELECT * FROM Proyectos WHERE ProyectoID = {projectId}";

                using (var command = new SqlCommand(queryString, cn))
                {

                    cn.Open();
                    using (var reader = command.ExecuteReader())
                    {

                        reader.Read();
                        project = new ProjectModel
                        {
                            ProyectoID = (int)reader["ProyectoID"],
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            FechaInicio = reader["FechaInicio"].ToString(),
                            FechaFin = reader["FechaFin"].ToString()
                        };

                    }
                }
            }
            return project;
        }

        public string insertOne(ProjectModel project)
        {



            using (var cn = connection.getConnection())
            {
                
                string queryString = $"INSERT INTO Proyectos(Nombre, Descripcion ,FechaInicio, FechaFin) " +
                    $"Values('{project.Nombre}','{project.Descripcion}', '{DateTime.Parse(project.FechaInicio)}', '{DateTime.Parse(project.FechaFin)}')";
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

        public string updateOne(ProjectModel project)
        {

            using (var cn = connection.getConnection())
            {
                var queryString = $"UPDATE Proyectos SET Nombre = '{project.Nombre}', Descripcion = '{project.Descripcion}', FechaInicio = '{DateTime.Parse(project.FechaInicio)}', FechaFin = '{DateTime.Parse(project.FechaFin)}'" +
                    $" WHERE ProyectoID = {project.ProyectoID};";
               
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

        public bool deleteOne(int projectId)
        {
            using (var cn = connection.getConnection())
            {
                string queryString = $"DELETE FROM Proyectos WHERE ProyectoID = {projectId}";
                MessageBox.Show(queryString);
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

                string queryString = $"SELECT * FROM Proyectos WHERE Nombre like '%{query}%'";


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
