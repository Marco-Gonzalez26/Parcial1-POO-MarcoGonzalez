
using Parcial_1_Marco_Gonzalez.Views.Employees;
using Parcial_1_Marco_Gonzalez.Views.Participations;
using Parcial_1_Marco_Gonzalez.Views.Projects;
using Parcial_1_Marco_Gonzalez.Views.Roles;


namespace Parcial_1_Marco_Gonzalez
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void btnEmployees_Click(object sender, EventArgs e)
        {
           UC_Employees employees = new UC_Employees();
            MainPanel.Controls.Clear();
            employees.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(employees);
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            UC_Projects projects = new UC_Projects();
            MainPanel.Controls.Clear();
            projects.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(projects);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            UC_Roles roles = new UC_Roles();
            MainPanel.Controls.Clear();
            roles.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(roles);

        }

        private void btnParticipations_Click(object sender, EventArgs e)
        {
            UC_Participations participations = new UC_Participations();
            MainPanel.Controls.Clear();
            participations.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(participations);
        }
    }
}
