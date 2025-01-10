namespace Parcial_1_Marco_Gonzalez
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            MainPanel = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            SidePanel = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnParticipations = new Button();
            btnProjects = new Button();
            btnEmployees = new Button();
            panel1.SuspendLayout();
            MainPanel.SuspendLayout();
            SidePanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(MainPanel);
            panel1.Controls.Add(SidePanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 511);
            panel1.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(panel4);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label2);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            MainPanel.Location = new Point(174, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(710, 511);
            MainPanel.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 514);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            label3.Location = new Point(162, 224);
            label3.Name = "label3";
            label3.Size = new Size(366, 37);
            label3.TabIndex = 1;
            label3.Text = "El mejor gestor de proyectos\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            label2.Location = new Point(199, 174);
            label2.Name = "label2";
            label2.Size = new Size(289, 37);
            label2.TabIndex = 0;
            label2.Text = "Bienvenido/a a Planify";
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.White;
            SidePanel.Controls.Add(panel3);
            SidePanel.Controls.Add(panel2);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(174, 511);
            SidePanel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 83);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 23);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 0;
            label1.Text = "Planify";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnParticipations);
            panel2.Controls.Add(btnProjects);
            panel2.Controls.Add(btnEmployees);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 385);
            panel2.TabIndex = 2;
            // 
            // btnParticipations
            // 
            btnParticipations.BackColor = Color.White;
            btnParticipations.Cursor = Cursors.Hand;
            btnParticipations.FlatAppearance.BorderSize = 0;
            btnParticipations.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnParticipations.FlatStyle = FlatStyle.Flat;
            btnParticipations.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParticipations.Location = new Point(0, 126);
            btnParticipations.Name = "btnParticipations";
            btnParticipations.Size = new Size(174, 57);
            btnParticipations.TabIndex = 3;
            btnParticipations.Text = "Participaciones";
            btnParticipations.UseVisualStyleBackColor = false;
            btnParticipations.Click += btnParticipations_Click;
            // 
            // btnProjects
            // 
            btnProjects.BackColor = Color.White;
            btnProjects.Cursor = Cursors.Hand;
            btnProjects.FlatAppearance.BorderSize = 0;
            btnProjects.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnProjects.FlatStyle = FlatStyle.Flat;
            btnProjects.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProjects.Location = new Point(0, 63);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(174, 57);
            btnProjects.TabIndex = 2;
            btnProjects.Text = "Proyectos";
            btnProjects.TextAlign = ContentAlignment.MiddleRight;
            btnProjects.UseVisualStyleBackColor = false;
            btnProjects.Click += btnProjects_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.White;
            btnEmployees.Cursor = Cursors.Hand;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployees.Location = new Point(0, 0);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(174, 57);
            btnEmployees.TabIndex = 0;
            btnEmployees.Text = "Empleados";
            btnEmployees.TextAlign = ContentAlignment.MiddleRight;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximumSize = new Size(900, 550);
            MinimumSize = new Size(900, 550);
            Name = "Main";
            Text = "Planify";
            panel1.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            SidePanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel MainPanel;
        private Panel SidePanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Button btnParticipations;
        private Button btnProjects;
        private Button btnEmployees;
        private Label label3;
        private Label label2;
        private Panel panel4;
    }
}
