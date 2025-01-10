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
using System.Xml.Linq;

namespace Parcial_1_Marco_Gonzalez.Views.Participations
{
    public partial class FrmParticipations : Form
    {
        private ProjectsController projectsController = new ProjectsController();
        private EmployeesController employeesController = new EmployeesController();
        private ParticipationsController participationsController = new ParticipationsController();
        private int? participationID = null;
        public FrmParticipations(int? participationId)
        {
            participationID = participationId;
            InitializeComponent();
        }
        private void loadProjects()
        {
            cmbProject.DataSource = projectsController.getAll();
            cmbProject.ValueMember = "ProyectoID";
            cmbProject.DisplayMember = "Nombre";
        }
        private void loadEmployees()
        {
            cmbEmployee.DataSource = employeesController.getAll();
            cmbEmployee.ValueMember = "EmpleadoID";
            cmbEmployee.DisplayMember = "Nombre";
        }
        private void FrmParticipations_Load(object sender, EventArgs e)
        {
            if (projectsController.getAll().Count == 0)
            {
                MessageBox.Show("Favor agregar proyectos antes de continuar");
                this.Hide();
            }
            if (employeesController.getAll().Count == 0)
            {
                MessageBox.Show("Favor agregar empleados antes de continuar");
                this.Hide();
            }

            loadProjects();
            loadEmployees();

            if (participationID != null)
            {
                ParticipationModel participationToEdit = participationsController.getOne((int)participationID);

                cmbEmployee.SelectedIndex = participationToEdit.EmpleadoID;
                cmbProject.SelectedIndex = participationToEdit.ProyectoID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var employeeId = (int)cmbEmployee.SelectedValue;
            var projectId = (int)cmbProject.SelectedValue;
            var value = cmbEmployee.SelectedValue.ToString();
            MessageBox.Show(value);
            var participation = new ParticipationModel
            { ParticipacionID = (int)participationID, ProyectoID = projectId, EmpleadoID = employeeId };

            EmployeesController employeesController = new EmployeesController();

            if (participationID != null)
            {
                var editResult = participationsController.updateOne(participation);

                MessageBox.Show(editResult);
                this.Hide();
                return;
            }
            var result = participationsController.insertOne(participation);

            MessageBox.Show(result);
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            var employeeId = (int)cmbEmployee.SelectedValue;
            var projectId = (int)cmbProject.SelectedValue;

            var participation = new ParticipationModel
            { ProyectoID = projectId, EmpleadoID = employeeId };

            EmployeesController employeesController = new EmployeesController();

            if (participationID != null)
            {
                participation.ParticipacionID = (int)participationID;
                var editResult = participationsController.updateOne(participation);

                MessageBox.Show(editResult);
                this.Hide();
                return;
            }
            var result = participationsController.insertOne(participation);

            MessageBox.Show(result);
            
            this.Hide();
        }
    }
}
