using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1_Marco_Gonzalez.Models
{
    internal class ProjectModel
    {
        public int ProyectoID { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? FechaInicio  { get; set; }
        public string? FechaFin { get; set; }
    }
}
