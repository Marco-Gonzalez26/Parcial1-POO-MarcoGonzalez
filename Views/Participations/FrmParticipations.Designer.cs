namespace Parcial_1_Marco_Gonzalez.Views.Participations
{
    partial class FrmParticipations
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
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            cmbEmployee = new ComboBox();
            cmbProject = new ComboBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(251, 228);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 56);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cerrar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(48, 228);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 56);
            btnSave.TabIndex = 22;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 29);
            label1.Name = "label1";
            label1.Size = new Size(205, 25);
            label1.TabIndex = 24;
            label1.Text = "Empleado Participante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 114);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 25;
            label2.Text = "Proyecto";
            // 
            // cmbEmployee
            // 
            cmbEmployee.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(52, 72);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(324, 33);
            cmbEmployee.TabIndex = 26;
            // 
            // cmbProject
            // 
            cmbProject.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(52, 151);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(324, 33);
            cmbProject.TabIndex = 27;
            // 
            // FrmParticipations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 304);
            Controls.Add(cmbProject);
            Controls.Add(cmbEmployee);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "FrmParticipations";
            Text = "Agregar Participacion";
            Load += FrmParticipations_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private ComboBox cmbEmployee;
        private ComboBox cmbProject;
    }
}