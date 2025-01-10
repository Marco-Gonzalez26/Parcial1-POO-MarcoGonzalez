using Parcial_1_Marco_Gonzalez.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1_Marco_Gonzalez.Views.Employees
{
    public partial class UC_Employees : UserControl
    {
        public UC_Employees()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmEmployee frm_AddEmployee = new FrmEmployee(null);
            frm_AddEmployee.ShowDialog();
            this.fillGridView(1);
        }

        public void fillGridView(int number)
        {
            var employeesController = new EmployeesController();

            dgvEmployees.DataSource = "";
            dgvEmployees.Columns.Clear();
            
            var autoIncrement = new DataGridViewTextBoxColumn
            {
                HeaderText = "N.-",
                ReadOnly = true
            };
            dgvEmployees.Columns.Add(autoIncrement);

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
                dgvEmployees.DataSource = employeesController.getAll();
            }
            else if (number == 2)
            {
                dgvEmployees.DataSource = employeesController.search(txtSearch.Text.Trim());

            }

            dgvEmployees.Columns["Nombre"].HeaderText = "Nombre";
            dgvEmployees.Columns["Cedula"].HeaderText = "Cédula";
            dgvEmployees.Columns["Rol"].HeaderText = "Rol";
            dgvEmployees.Columns["EmpleadoID"].Visible = false;
            dgvEmployees.Columns["RolID"].Visible = false;

            dgvEmployees.Columns.Add(btnEditar);
            dgvEmployees.Columns.Add(btnEliminar);
        }

        private void UC_Employees_Load(object sender, EventArgs e)
        {

            dgvEmployees.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);


            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dgvEmployees.AllowUserToResizeColumns = false;
            dgvEmployees.AllowUserToResizeRows = false;
            dgvEmployees.DefaultCellStyle.Font = new Font("Segoe UI", 12);



            this.fillGridView(1);


        }

        private void dgvEmployees_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvEmployees.Rows.Count; i++)
            {
                dgvEmployees.Rows[i].Cells[0].Value = i + 1;
            }


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

        public void editEmployee(int employeeId)
        {

            FrmEmployee frmAddEmployee = new FrmEmployee(employeeId);
            frmAddEmployee.ShowDialog();
            this.fillGridView(1);
        }
        public void deleteEmployee(int id)
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

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvEmployees.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var selectedRow = dgvEmployees.Rows[e.RowIndex];
               
                int employeeId = (int)selectedRow.Cells["EmpleadoID"].Value;


                if (dgvEmployees.Columns[e.ColumnIndex].HeaderText == "Editar")
                {
                    
                    editEmployee((int)employeeId);
                }

                if (dgvEmployees.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                {
                    deleteEmployee((int)employeeId);
                }

            }
        }

    }
}
