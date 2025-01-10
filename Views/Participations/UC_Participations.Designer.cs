namespace Parcial_1_Marco_Gonzalez.Views.Participations
{
    partial class UC_Participations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Participations));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAdd = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvParticipations = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvParticipations).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(542, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(143, 42);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Agregar";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(440, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(43, 39);
            btnSearch.TabIndex = 3;
            btnSearch.TextAlign = ContentAlignment.TopLeft;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(159, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar por nombre...";
            txtSearch.Size = new Size(275, 33);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 54);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 2;
            label2.Text = "Buscar: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 0;
            label1.Text = "Participaciones";
            // 
            // dgvParticipations
            // 
            dgvParticipations.AllowUserToAddRows = false;
            dgvParticipations.AllowUserToDeleteRows = false;
            dgvParticipations.AllowUserToResizeColumns = false;
            dgvParticipations.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvParticipations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvParticipations.BackgroundColor = Color.White;
            dgvParticipations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvParticipations.ColumnHeadersHeight = 48;
            dgvParticipations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvParticipations.DefaultCellStyle = dataGridViewCellStyle2;
            dgvParticipations.Dock = DockStyle.Fill;
            dgvParticipations.GridColor = Color.FromArgb(224, 224, 224);
            dgvParticipations.Location = new Point(0, 100);
            dgvParticipations.MultiSelect = false;
            dgvParticipations.Name = "dgvParticipations";
            dgvParticipations.ReadOnly = true;
            dgvParticipations.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvParticipations.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvParticipations.Size = new Size(710, 411);
            dgvParticipations.TabIndex = 4;
            dgvParticipations.CellClick += dgvParticipations_CellClick;
            dgvParticipations.DataBindingComplete += dgvParticipations_DataBindingComplete;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 100);
            panel1.TabIndex = 5;
            // 
            // UC_Participations
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvParticipations);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            MaximumSize = new Size(710, 511);
            MinimumSize = new Size(710, 511);
            Name = "UC_Participations";
            Size = new Size(710, 511);
            ((System.ComponentModel.ISupportInitialize)dgvParticipations).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private Label label1;
        private DataGridView dgvParticipations;
        private Panel panel1;
    }
}
