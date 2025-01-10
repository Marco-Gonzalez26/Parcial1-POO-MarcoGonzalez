using Parcial_1_Marco_Gonzalez.Controllers;
using Parcial_1_Marco_Gonzalez.Views.Projects;
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
    public partial class UC_Projects : UserControl
    {
        public UC_Projects()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            FmrProject frmProject = new FmrProject(null);
            frmProject.ShowDialog();
            this.fillGridView(1);
        }

        public void fillGridView(int number)
        {
            var projectsController = new ProjectsController();

            dgvProjects.DataSource = "";
            dgvProjects.Columns.Clear();

            var autoIncrement = new DataGridViewTextBoxColumn
            {
                HeaderText = "N.-",
                ReadOnly = true
            };
            dgvProjects.Columns.Add(autoIncrement);

            var btnEditar = new DataGridViewButtonColumn
            {
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };

            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };

            if (number == 1)
            {
                dgvProjects.DataSource = projectsController.getAll();
            }
            else if (number == 2)
            {
                dgvProjects.DataSource = projectsController.search(txtSearch.Text.Trim());

            }

            dgvProjects.Columns["Nombre"].HeaderText = "Nombre";
            dgvProjects.Columns["Descripcion"].HeaderText = "Descripción";
            dgvProjects.Columns["FechaInicio"].HeaderText = "Fecha Inicio";
            dgvProjects.Columns["FechaFin"].HeaderText = "Fecha Final";

            dgvProjects.Columns["ProyectoID"].Visible = false;


            dgvProjects.Columns.Add(btnEditar);
            dgvProjects.Columns.Add(btnEliminar);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                MessageBox.Show("Introduzca un nombre para buscar");
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            this.fillGridView(2);
        }

        public void editProject(int projectId)
        {

            FmrProject fmrProject = new FmrProject(projectId);
            fmrProject.ShowDialog();
            this.fillGridView(1);
        }
        public void deleteProject(int id)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro?", "Eliminar Empleado", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                EmployeesController employeesController = new EmployeesController();

                if (employeesController.deleteOne(id))
                {
                    MessageBox.Show("Registro se ha eliminado correctamente");
                    this.fillGridView(1);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar");
                }
            }
            else
            {
                MessageBox.Show("El usuario canceló la eliminación");
            }
        }

        private void UC_Projects_Load(object sender, EventArgs e)
        {
            dgvProjects.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);


            dgvProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProjects.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dgvProjects.AllowUserToResizeColumns = false;
            dgvProjects.AllowUserToResizeRows = false;
            dgvProjects.DefaultCellStyle.Font = new Font("Segoe UI", 12);



            this.fillGridView(1);
        }

        private void dgvProjects_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvProjects.Rows.Count; i++)
            {
                dgvProjects.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dgvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvProjects.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var selectedRow = dgvProjects.Rows[e.RowIndex];

                int projectId = (int)selectedRow.Cells["ProyectoID"].Value;


                if (dgvProjects.Columns[e.ColumnIndex].HeaderText == "Editar")
                {

                    editProject((int)projectId);
                }

                if (dgvProjects.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                {
                    deleteProject((int)projectId);
                }

            }
        }
    }
}
