namespace Parcial_1_Marco_Gonzalez.Views.Projects
{
    partial class UC_Projects
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Projects));
            panel1 = new Panel();
            btnAdd = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            dgvProjects = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 110);
            panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(549, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(143, 42);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Agregar";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(166, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar por nombre...";
            txtSearch.Size = new Size(275, 33);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(447, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(43, 39);
            btnSearch.TabIndex = 8;
            btnSearch.TextAlign = ContentAlignment.TopLeft;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 5;
            label1.Text = "Proyectos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 54);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 7;
            label2.Text = "Buscar: ";
            // 
            // dgvProjects
            // 
            dgvProjects.BackgroundColor = Color.White;
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Dock = DockStyle.Fill;
            dgvProjects.GridColor = Color.White;
            dgvProjects.Location = new Point(0, 110);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.Size = new Size(710, 401);
            dgvProjects.TabIndex = 1;
            dgvProjects.CellClick += dgvProjects_CellClick;
            dgvProjects.DataBindingComplete += dgvProjects_DataBindingComplete;
            // 
            // UC_Projects
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvProjects);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            MaximumSize = new Size(710, 511);
            MinimumSize = new Size(710, 511);
            Name = "UC_Projects";
            Size = new Size(710, 511);
            Load += UC_Projects_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvProjects;
        private Button btnAdd;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private Label label2;
    }
}
