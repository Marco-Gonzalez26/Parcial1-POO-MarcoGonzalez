using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1_Marco_Gonzalez.Models
{
    internal class ParticipationModel
    {
        public int ParticipacionID { get; set; }
        public string? Empleado { get; set; }
        public string? Proyecto { get; set; } 

        public int EmpleadoID { get; set; }
        public int ProyectoID { get; set; }
    }
}
