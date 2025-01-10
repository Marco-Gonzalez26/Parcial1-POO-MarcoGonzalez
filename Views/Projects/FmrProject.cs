using Parcial_1_Marco_Gonzalez.Controllers;
using Parcial_1_Marco_Gonzalez.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1_Marco_Gonzalez.Views.Projects
{
    public partial class FmrProject : Form
    {
        private ProjectsController projectsController = new ProjectsController();
        private int? projectID;
        public FmrProject(int? projectId)
        {
            projectID = projectId;
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Length == 0 || rTxtDesc.Text.Length == 0)
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            ProjectModel project = new ProjectModel
            {
                Nombre = txtName.Text.Trim(),
                Descripcion = rTxtDesc.Text.Trim(),
                FechaInicio = dTStart.Text.Trim(),
                FechaFin = dTEnd.Text.Trim(),
            };
            if (projectID != null)
            {
                project.ProyectoID = (int)projectID;

                string editResult = projectsController.updateOne(project);
                MessageBox.Show(editResult);
                return;
            }
            string result = projectsController.insertOne(project);
            MessageBox.Show(result);
        }

        private void FmrProject_Load(object sender, EventArgs e)
        {
            if (projectID != null)
            {
                ProjectModel projectToEdit = projectsController.getOne((int)projectID);

                txtName.Text = projectToEdit.Nombre;
                rTxtDesc.Text = projectToEdit.Descripcion;
                dTStart.Value = DateTime.Parse(projectToEdit.FechaInicio);
                dTEnd.Value = DateTime.Parse(projectToEdit.FechaFin);

            }
        }
    }
}
