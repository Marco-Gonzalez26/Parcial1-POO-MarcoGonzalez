using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1_Marco_Gonzalez.Models
{
    internal class EmployeeModel
    {
        public int? EmpleadoID { get; set; }
        public string? Nombre { get; set; }
        public string? Rol { get; set; }
        public string? Cedula { get; set; }
        public int RolId { get; set; }
    }
}
