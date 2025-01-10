using Parcial_1_Marco_Gonzalez.Config;
using Parcial_1_Marco_Gonzalez.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1_Marco_Gonzalez.Controllers
{
    internal class EmployeesController
    {
        Connection connection = new Connection();
        public List<EmployeeModel> getAll() 
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            using (var cn = connection.getConnection())
            {
                string querySring = $"SELECT Empleados.Nombre, Empleados.EmpleadoID, " +
                    $"Empleados.RolID,Empleados.Cedula ,Roles.Nombre as Rol FROM Empleados " +
                    $"JOIN Roles ON Empleados.RolID = Roles.RolID;";


                using (var command = new SqlCommand(querySring, cn))
                {
                    cn.Open();

                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            EmployeeModel employee = new EmployeeModel
                            {
                                EmpleadoID = (int)reader["EmpleadoID"],
                                Nombre = reader["Nombre"].ToString(),
                                Rol = reader["Rol"].ToString(),
                                Cedula = reader["Cedula"].ToString()
                            };

                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees;
        }
        public EmployeeModel getOne(int employeeId)
        {
            EmployeeModel? employee = null;

            using (var cn = connection.getConnection()) {
                string queryString = $"SELECT * FROM Empleados WHERE EmpleadoID = {employeeId}";

                using (var command = new SqlCommand(queryString, cn)) {

                    cn.Open();
                    using (var reader = command.ExecuteReader()) { 
                        
                        reader.Read();
                        employee = new EmployeeModel
                        {
                            EmpleadoID = (int)reader["EmpleadoID"],
                            Nombre = reader["Nombre"].ToString(),
                            RolId= (int)reader["RolID"],
                            Cedula= reader["Cedula"].ToString()
                        };
                        
                    }
                }
            }
            return employee;
        }

        public string insertOne(EmployeeModel employee) {



            using (var cn = connection.getConnection())
            {
                string queryString = $"INSERT INTO Empleados(Nombre, RolID, Cedula) " +
                    $"Values('{employee.Nombre}',{employee.RolId}, '{employee.Cedula}')";

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

        public string updateOne(EmployeeModel employee)
        {

            using (var cn = connection.getConnection())
            {
                var queryString = $"UPDATE Empleados SET Nombre = '{employee.Nombre}', RolID = {employee.RolId}, Cedula = '{employee.Cedula}' WHERE EmpleadoID = {employee.EmpleadoID};";
                MessageBox.Show(queryString);
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

        public bool deleteOne(int employeeId)
        {
            using (var cn = connection.getConnection())
            {
                string queryString = $"DELETE FROM Empleados WHERE EmpleadoID = {employeeId};";
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

        public List<EmployeeModel> search(string query)
        {
            var filteredEmployees = new List<EmployeeModel>();

            using (var cn = connection.getConnection())
            {

                string queryString = $"SELECT Empleados.Nombre, Empleados.EmpleadoID, " +
                    $"Empleados.RolID,Empleados.Cedula ,Roles.Nombre as Rol FROM Empleados " +
                    $"JOIN Roles ON Empleados.RolID = Roles.RolID WHERE Empleados.Nombre like '%{query}%'";


                using (var command = new SqlCommand(queryString, cn))
                {
                   
                    cn.Open();
                    
                    using (var reader = command.ExecuteReader())
                    {
                       
                        while (reader.Read())
                        {
                            
                            var employee = new EmployeeModel
                            {
                                EmpleadoID = (int)reader["EmpleadoID"],
                                Nombre = reader["Nombre"].ToString(),
                                Cedula = reader["Cedula"].ToString(),
                                Rol = reader["Rol"].ToString(),
                                RolId = (int)reader["RolID"]
                            };

                            filteredEmployees.Add(employee);
                        }
                    }
                }

            }
            return filteredEmployees;
        }
    }
}
