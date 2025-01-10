using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial_1_Marco_Gonzalez.Models;
using Parcial_1_Marco_Gonzalez.Controllers;
namespace Parcial_1_Marco_Gonzalez.Views.Employees
{
    public partial class FrmEmployee : Form
    {
        private int? employeeID = null;

        public FrmEmployee(int? employeeId)
        {
            InitializeComponent();

            employeeID = employeeId;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtIdNumber.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            var rolId = cmbRole.SelectedIndex + 1;

            var employee = new EmployeeModel 
            { Nombre = txtName.Text.Trim(), RolId = rolId, Cedula = txtIdNumber.Text.Trim(), EmpleadoID = employeeID };

            EmployeesController employeesController = new EmployeesController();

            if (employeeID != null) {
                var editResult = employeesController.updateOne(employee);

                MessageBox.Show(editResult);
                this.Hide();
                return;
            }
            var result = employeesController.insertOne(employee);

            MessageBox.Show(result);
            this.Hide();



        }

        public void loadRoles()
        {
            RolesController roles = new RolesController();
            cmbRole.DataSource = roles.getAll();
            cmbRole.ValueMember = "RolID";
            cmbRole.DisplayMember = "Nombre";
        }

        private void Frm_AddEmployee_Load(object sender, EventArgs e)
        {
            loadRoles();

            if(employeeID != null)
            {
                EmployeesController employeeController = new EmployeesController();

                var editEmployee = employeeController.getOne((int)employeeID);

                txtIdNumber.Text = editEmployee.Cedula;
                txtName.Text = editEmployee.Nombre;
                cmbRole.SelectedIndex = editEmployee.RolId - 1;

                this.Text = "Editar Empleado";
                btnSave.Text = "Editar";
            }
        }


    }
}
