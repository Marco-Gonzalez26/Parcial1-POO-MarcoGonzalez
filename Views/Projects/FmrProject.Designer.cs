namespace Parcial_1_Marco_Gonzalez.Views.Projects
{
    partial class FmrProject
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
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            rTxtDesc = new RichTextBox();
            label4 = new Label();
            dTStart = new DateTimePicker();
            dTEnd = new DateTimePicker();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 128);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 14;
            label3.Text = "Descripción";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(253, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 56);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cerrar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(54, 404);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 56);
            btnSave.TabIndex = 12;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 227);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 11;
            label2.Text = "Fecha Inicio";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(54, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(324, 33);
            txtName.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 34);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // rTxtDesc
            // 
            rTxtDesc.BorderStyle = BorderStyle.FixedSingle;
            rTxtDesc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rTxtDesc.Location = new Point(54, 165);
            rTxtDesc.Name = "rTxtDesc";
            rTxtDesc.Size = new Size(324, 47);
            rTxtDesc.TabIndex = 15;
            rTxtDesc.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 308);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 16;
            label4.Text = "Fecha Fin";
            // 
            // dTStart
            // 
            dTStart.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTStart.Location = new Point(54, 264);
            dTStart.Name = "dTStart";
            dTStart.Size = new Size(324, 29);
            dTStart.TabIndex = 17;
            // 
            // dTEnd
            // 
            dTEnd.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTEnd.Location = new Point(54, 346);
            dTEnd.Name = "dTEnd";
            dTEnd.Size = new Size(324, 29);
            dTEnd.TabIndex = 18;
            // 
            // FmrProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 483);
            Controls.Add(dTEnd);
            Controls.Add(dTStart);
            Controls.Add(label4);
            Controls.Add(rTxtDesc);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FmrProject";
            Text = "Agregar Proyecto";
            Load += FmrProject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private RichTextBox rTxtDesc;
        private Label label4;
        private DateTimePicker dTStart;
        private DateTimePicker dTEnd;
    }
}