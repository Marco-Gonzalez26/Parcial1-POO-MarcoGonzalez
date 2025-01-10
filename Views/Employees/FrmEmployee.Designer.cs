namespace Parcial_1_Marco_Gonzalez.Views.Employees
{
    partial class FrmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            cmbRole = new ComboBox();
            label2 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtIdNumber = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 33);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(53, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(324, 33);
            txtName.TabIndex = 1;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(53, 254);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(324, 33);
            cmbRole.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 214);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 3;
            label2.Text = "Rol";
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(53, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 56);
            btnSave.TabIndex = 4;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(252, 340);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 56);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cerrar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtIdNumber
            // 
            txtIdNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdNumber.Location = new Point(53, 165);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(324, 33);
            txtIdNumber.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 127);
            label3.Name = "label3";
            label3.Size = new Size(184, 25);
            label3.TabIndex = 6;
            label3.Text = "Cédula de Identidad";
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 431);
            Controls.Add(txtIdNumber);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(cmbRole);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FrmEmployee";
            Text = "Añadir Empleado";
            Load += Frm_AddEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private ComboBox cmbRole;
        private Label label2;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtIdNumber;
        private Label label3;
    }
}