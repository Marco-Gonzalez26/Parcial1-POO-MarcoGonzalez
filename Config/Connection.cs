using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Parcial_1_Marco_Gonzalez.Config
{
    internal class Connection
    {
       
            private readonly string connectionString = "Server=LAPTOP-L6SUJ856\\ALWAYSDEV;Database=Parcial1_GestionProyectos;uid=root;pwd=123456;TrustServerCertificate=True";

            public SqlConnection getConnection()
            {
                return new SqlConnection(connectionString);
            }
        }
    
}
