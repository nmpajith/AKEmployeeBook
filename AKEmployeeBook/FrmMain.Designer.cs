namespace AKEmployeeBook
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            comboBoxDepartments = new ComboBox();
            buttonRefresh = new Button();
            buttonAdd = new Button();
            textBoxFilter = new TextBox();
            compositionRootBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)compositionRootBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(957, 477);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, FirstName, LastName, Department, Salary });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Azure;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(53, 103);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(851, 321);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "EmployeeID";
            ID.HeaderText = "EmployeeID ";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FirstName.DataPropertyName = "FirstName";
            FirstName.FillWeight = 200F;
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 200;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Resizable = DataGridViewTriState.False;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastName.DataPropertyName = "LastName";
            LastName.FillWeight = 200F;
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 200;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // Department
            // 
            Department.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Department.DataPropertyName = "Department";
            Department.FillWeight = 200F;
            Department.HeaderText = "Department";
            Department.MinimumWidth = 200;
            Department.Name = "Department";
            Department.ReadOnly = true;
            // 
            // Salary
            // 
            Salary.DataPropertyName = "Salary";
            Salary.HeaderText = "Salary";
            Salary.MinimumWidth = 150;
            Salary.Name = "Salary";
            Salary.ReadOnly = true;
            Salary.Width = 150;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 0);
            label1.Name = "label1";
            label1.Size = new Size(851, 50);
            label1.TabIndex = 1;
            label1.Text = "Acuity Knowledge Employees Book";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(comboBoxDepartments, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonRefresh, 4, 0);
            tableLayoutPanel2.Controls.Add(buttonAdd, 3, 0);
            tableLayoutPanel2.Controls.Add(textBoxFilter, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(53, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(851, 44);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 44);
            label2.TabIndex = 0;
            label2.Text = "Search By:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxDepartments
            // 
            comboBoxDepartments.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxDepartments.FormattingEnabled = true;
            comboBoxDepartments.Location = new Point(73, 10);
            comboBoxDepartments.Name = "comboBoxDepartments";
            comboBoxDepartments.Size = new Size(194, 23);
            comboBoxDepartments.TabIndex = 1;
            comboBoxDepartments.SelectedIndexChanged += comboBoxDepartments_SelectedIndexChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackgroundImage = (Image)resources.GetObject("buttonRefresh.BackgroundImage");
            buttonRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRefresh.Location = new Point(543, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(40, 38);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdd.BackgroundImage = (Image)resources.GetObject("buttonAdd.BackgroundImage");
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(473, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(64, 38);
            buttonAdd.TabIndex = 2;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilter.Location = new Point(273, 10);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(194, 23);
            textBoxFilter.TabIndex = 4;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // compositionRootBindingSource
            // 
            compositionRootBindingSource.DataSource = typeof(AKDataAccess.CompositionRoot);
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 477);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmMain";
            Text = "Acuity Knowledge Employees Book";
            Load += FrmMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)compositionRootBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView;
        private BindingSource compositionRootBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Salary;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private ComboBox comboBoxDepartments;
        private Button buttonAdd;
        private Button buttonRefresh;
        private TextBox textBoxFilter;
    }
}