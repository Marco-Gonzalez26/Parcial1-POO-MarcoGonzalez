using Parcial_1_Marco_Gonzalez.Controllers;
using Parcial_1_Marco_Gonzalez.Views.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1_Marco_Gonzalez.Views.Participations
{
    public partial class UC_Participations : UserControl
    {
        public UC_Participations()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmParticipations frmPartipation = new FrmParticipations(null);
            frmPartipation.ShowDialog();
            this.fillGridView(1);
        }

        public void fillGridView(int number)
        {
            var participationsController = new ParticipationsController();

            dgvParticipations.DataSource = "";
            dgvParticipations.Columns.Clear();

            var autoIncrement = new DataGridViewTextBoxColumn
            {
                HeaderText = "N.-",
                ReadOnly = true
            };
            dgvParticipations.Columns.Add(autoIncrement);


            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };

            if (number == 1)
            {
                dgvParticipations.DataSource = participationsController.getAll();
            }
            else if (number == 2)
            {
                dgvParticipations.DataSource = participationsController.search(txtSearch.Text.Trim());

            }

            dgvParticipations.Columns["Empleado"].HeaderText = "Empleado";
            dgvParticipations.Columns["Proyecto"].HeaderText = "Proyecto";
            dgvParticipations.Columns["ParticipacionID"].Visible = false;
            dgvParticipations.Columns["EmpleadoID"].Visible = false;
            dgvParticipations.Columns["ProyectoID"].Visible = false;

         ;
            dgvParticipations.Columns.Add(btnEliminar);
        }

        private void UC_Employees_Load(object sender, EventArgs e)
        {

            dgvParticipations.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);


            dgvParticipations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvParticipations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dgvParticipations.AllowUserToResizeColumns = false;
            dgvParticipations.AllowUserToResizeRows = false;
            dgvParticipations.DefaultCellStyle.Font = new Font("Segoe UI", 12);



            this.fillGridView(1);


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

        public void editParticipation(int participationId)
        {

            FrmParticipations frmParticipations = new FrmParticipations(participationId);
            frmParticipations.ShowDialog();
            this.fillGridView(1);
        }
        public void deleteParticipation(int id)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro?", "Eliminar Empleado", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ParticipationsController employeesController = new ParticipationsController();

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


        private void dgvParticipations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvParticipations.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var selectedRow = dgvParticipations.Rows[e.RowIndex];

                int participationId = (int)selectedRow.Cells["ParticipacionID"].Value;


                if (dgvParticipations.Columns[e.ColumnIndex].HeaderText == "Editar")
                {

                    editParticipation((int)participationId);
                }

                if (dgvParticipations.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                {
                    deleteParticipation((int)participationId);
                }

            }
        }

        private void dgvParticipations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvParticipations.Rows.Count; i++)
            {
                dgvParticipations.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
