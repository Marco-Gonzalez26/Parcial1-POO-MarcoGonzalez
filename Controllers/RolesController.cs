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
    internal class RolesController
    {
        private readonly Connection connection = new Connection();
        public List<RoleModel> getAll()
        {
            List<RoleModel> roles = new List<RoleModel>();

            using (var cn = connection.getConnection())
            {
                string querySring = $"SELECT * FROM Roles;";


                using (var command = new SqlCommand(querySring, cn))
                {
                    cn.Open();

                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            RoleModel role = new RoleModel
                            {
                                RolID = Convert.ToInt32(reader["RolID"]),
                                Nombre = reader["Nombre"].ToString(),
                                
                            };

                            roles.Add(role);
                        }
                    }
                }
            }
            return roles;
        }
        public bool deleteOne(int roleId)
        {
            using (var cn = connection.getConnection())
            {
                string queryString = $"DELETE FROM Poles WHERE RolID = {roleId}";

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
    }
}
