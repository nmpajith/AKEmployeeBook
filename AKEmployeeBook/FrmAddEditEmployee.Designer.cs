namespace AKEmployeeBook
{
    partial class FrmAddEditEmployee
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonOk = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxDepartment = new TextBox();
            textBoxSalary = new TextBox();
            buttonCancel = new Button();
            textBoxEmployeeID = new TextBox();
            labelError = new Label();
            labelTitle = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(labelTitle, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(508, 380);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.4223328F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.1553345F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.4223328F));
            tableLayoutPanel2.Controls.Add(buttonOk, 1, 7);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label6, 0, 5);
            tableLayoutPanel2.Controls.Add(textBoxFirstName, 1, 2);
            tableLayoutPanel2.Controls.Add(textBoxLastName, 1, 3);
            tableLayoutPanel2.Controls.Add(textBoxDepartment, 1, 4);
            tableLayoutPanel2.Controls.Add(textBoxSalary, 1, 5);
            tableLayoutPanel2.Controls.Add(buttonCancel, 2, 7);
            tableLayoutPanel2.Controls.Add(textBoxEmployeeID, 1, 1);
            tableLayoutPanel2.Controls.Add(labelError, 1, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(23, 73);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(462, 284);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.Location = new Point(255, 243);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(99, 34);
            buttonOk.TabIndex = 12;
            buttonOk.Text = "Add";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 40);
            label1.TabIndex = 1;
            label1.Text = "Employee ID:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(67, 40);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 80);
            label4.Name = "label4";
            label4.Size = new Size(66, 40);
            label4.TabIndex = 3;
            label4.Text = "Last Name:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 120);
            label5.Name = "label5";
            label5.Size = new Size(73, 40);
            label5.TabIndex = 4;
            label5.Text = "Department:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 160);
            label6.Name = "label6";
            label6.Size = new Size(41, 40);
            label6.TabIndex = 5;
            label6.Text = "Salary:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.Left;
            textBoxFirstName.Location = new Point(106, 48);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(248, 23);
            textBoxFirstName.TabIndex = 7;
            textBoxFirstName.KeyDown += textBox_KeyDown;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Left;
            textBoxLastName.Location = new Point(106, 88);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(248, 23);
            textBoxLastName.TabIndex = 8;
            textBoxLastName.KeyDown += textBox_KeyDown;
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Anchor = AnchorStyles.Left;
            textBoxDepartment.Location = new Point(106, 128);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(248, 23);
            textBoxDepartment.TabIndex = 9;
            textBoxDepartment.KeyDown += textBox_KeyDown;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Anchor = AnchorStyles.Left;
            textBoxSalary.Location = new Point(106, 168);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(248, 23);
            textBoxSalary.TabIndex = 10;
            textBoxSalary.KeyDown += textBox_KeyDown;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.Location = new Point(360, 243);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(99, 34);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxEmployeeID
            // 
            textBoxEmployeeID.Anchor = AnchorStyles.Left;
            textBoxEmployeeID.Location = new Point(106, 8);
            textBoxEmployeeID.Name = "textBoxEmployeeID";
            textBoxEmployeeID.ReadOnly = true;
            textBoxEmployeeID.Size = new Size(248, 23);
            textBoxEmployeeID.TabIndex = 13;
            // 
            // labelError
            // 
            labelError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelError.AutoSize = true;
            labelError.ForeColor = Color.IndianRed;
            labelError.Location = new Point(106, 200);
            labelError.Name = "labelError";
            labelError.Size = new Size(248, 40);
            labelError.TabIndex = 14;
            labelError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(23, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(462, 50);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Add New Employee";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.9310341F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.06896F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 9;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 30);
            label2.TabIndex = 1;
            label2.Text = "Employee ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmAddEditEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 380);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAddEditEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Employee";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonOk;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxDepartment;
        private TextBox textBoxSalary;
        private Button buttonCancel;
        private Label labelTitle;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TextBox textBoxEmployeeID;
        private Label labelError;
    }
}