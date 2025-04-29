namespace EmployeeApplication
{
    partial class fromEmployeeDatabase
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
            panel1 = new Panel();
            textBoxPosition = new RichTextBox();
            label4 = new Label();
            buttonSubmitEmployee = new Button();
            textBoxLastName = new RichTextBox();
            label3 = new Label();
            textBoxFirstName = new RichTextBox();
            textBoxEmployeeId = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            listBoxEmployeeIds = new ListBox();
            listBoxFirstNames = new ListBox();
            listBoxLastNames = new ListBox();
            listBoxPositions = new ListBox();
            panel2 = new Panel();
            buttonReset = new Button();
            buttonRemovePrevious = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxPosition);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonSubmitEmployee);
            panel1.Controls.Add(textBoxLastName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxFirstName);
            panel1.Controls.Add(textBoxEmployeeId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(13, 15);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 109);
            panel1.TabIndex = 0;
            // 
            // textBoxPosition
            // 
            textBoxPosition.BackColor = Color.LightCyan;
            textBoxPosition.Font = new Font("Comic Mono", 12F);
            textBoxPosition.Location = new Point(579, 28);
            textBoxPosition.Margin = new Padding(3, 2, 3, 2);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(134, 29);
            textBoxPosition.TabIndex = 8;
            textBoxPosition.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Mono", 12F);
            label4.Location = new Point(579, 13);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 7;
            label4.Text = "Position";
            // 
            // buttonSubmitEmployee
            // 
            buttonSubmitEmployee.BackColor = Color.LightCyan;
            buttonSubmitEmployee.Font = new Font("Comic Mono", 12F);
            buttonSubmitEmployee.Location = new Point(287, 67);
            buttonSubmitEmployee.Margin = new Padding(3, 2, 3, 2);
            buttonSubmitEmployee.Name = "buttonSubmitEmployee";
            buttonSubmitEmployee.Size = new Size(176, 30);
            buttonSubmitEmployee.TabIndex = 0;
            buttonSubmitEmployee.Text = "SUBMIT";
            buttonSubmitEmployee.UseVisualStyleBackColor = false;
            buttonSubmitEmployee.Click += buttonSubmitEmployee_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.LightCyan;
            textBoxLastName.Font = new Font("Comic Mono", 12F);
            textBoxLastName.Location = new Point(383, 28);
            textBoxLastName.Margin = new Padding(3, 2, 3, 2);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(134, 29);
            textBoxLastName.TabIndex = 5;
            textBoxLastName.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Mono", 12F);
            label3.Location = new Point(383, 13);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.LightCyan;
            textBoxFirstName.Font = new Font("Comic Mono", 12F);
            textBoxFirstName.Location = new Point(202, 28);
            textBoxFirstName.Margin = new Padding(3, 2, 3, 2);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(134, 29);
            textBoxFirstName.TabIndex = 2;
            textBoxFirstName.Text = "";
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.BackColor = Color.LightCyan;
            textBoxEmployeeId.Font = new Font("Comic Mono", 12F);
            textBoxEmployeeId.Location = new Point(18, 28);
            textBoxEmployeeId.Margin = new Padding(3, 2, 3, 2);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.Size = new Size(134, 29);
            textBoxEmployeeId.TabIndex = 1;
            textBoxEmployeeId.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Mono", 12F);
            label1.Location = new Point(18, 13);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 0;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Mono", 12F);
            label2.Location = new Point(202, 13);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 178F));
            tableLayoutPanel1.Controls.Add(listBoxEmployeeIds, 0, 0);
            tableLayoutPanel1.Controls.Add(listBoxFirstNames, 1, 0);
            tableLayoutPanel1.Controls.Add(listBoxLastNames, 2, 0);
            tableLayoutPanel1.Controls.Add(listBoxPositions, 3, 0);
            tableLayoutPanel1.Location = new Point(14, 128);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2676582F));
            tableLayoutPanel1.Size = new Size(754, 233);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // listBoxEmployeeIds
            // 
            listBoxEmployeeIds.BackColor = Color.LightCyan;
            listBoxEmployeeIds.Font = new Font("Comic Mono", 12F);
            listBoxEmployeeIds.FormattingEnabled = true;
            listBoxEmployeeIds.ItemHeight = 17;
            listBoxEmployeeIds.Location = new Point(3, 2);
            listBoxEmployeeIds.Margin = new Padding(3, 2, 3, 2);
            listBoxEmployeeIds.Name = "listBoxEmployeeIds";
            listBoxEmployeeIds.Size = new Size(191, 225);
            listBoxEmployeeIds.TabIndex = 0;
            // 
            // listBoxFirstNames
            // 
            listBoxFirstNames.BackColor = Color.LightCyan;
            listBoxFirstNames.Font = new Font("Comic Mono", 12F);
            listBoxFirstNames.FormattingEnabled = true;
            listBoxFirstNames.ItemHeight = 17;
            listBoxFirstNames.Location = new Point(200, 2);
            listBoxFirstNames.Margin = new Padding(3, 2, 3, 2);
            listBoxFirstNames.Name = "listBoxFirstNames";
            listBoxFirstNames.Size = new Size(175, 225);
            listBoxFirstNames.TabIndex = 1;
            // 
            // listBoxLastNames
            // 
            listBoxLastNames.BackColor = Color.LightCyan;
            listBoxLastNames.Font = new Font("Comic Mono", 12F);
            listBoxLastNames.FormattingEnabled = true;
            listBoxLastNames.ItemHeight = 17;
            listBoxLastNames.Location = new Point(381, 2);
            listBoxLastNames.Margin = new Padding(3, 2, 3, 2);
            listBoxLastNames.Name = "listBoxLastNames";
            listBoxLastNames.Size = new Size(191, 225);
            listBoxLastNames.TabIndex = 2;
            // 
            // listBoxPositions
            // 
            listBoxPositions.BackColor = Color.LightCyan;
            listBoxPositions.Font = new Font("Comic Mono", 12F);
            listBoxPositions.FormattingEnabled = true;
            listBoxPositions.ItemHeight = 17;
            listBoxPositions.Location = new Point(578, 2);
            listBoxPositions.Margin = new Padding(3, 2, 3, 2);
            listBoxPositions.Name = "listBoxPositions";
            listBoxPositions.Size = new Size(171, 225);
            listBoxPositions.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonReset);
            panel2.Controls.Add(buttonRemovePrevious);
            panel2.Location = new Point(196, 365);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 41);
            panel2.TabIndex = 2;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.LightCyan;
            buttonReset.Font = new Font("Comic Mono", 12F);
            buttonReset.Location = new Point(199, 7);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(176, 28);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "RESET DATABASE";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonRemovePrevious
            // 
            buttonRemovePrevious.BackColor = Color.LightCyan;
            buttonRemovePrevious.Font = new Font("Comic Mono", 12F);
            buttonRemovePrevious.Location = new Point(16, 7);
            buttonRemovePrevious.Margin = new Padding(3, 2, 3, 2);
            buttonRemovePrevious.Name = "buttonRemovePrevious";
            buttonRemovePrevious.Size = new Size(176, 28);
            buttonRemovePrevious.TabIndex = 1;
            buttonRemovePrevious.Text = "REMOVE PREVIOUS";
            buttonRemovePrevious.UseVisualStyleBackColor = false;
            buttonRemovePrevious.Click += buttonRemovePrevious_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ado_usseewa;
            pictureBox2.Location = new Point(774, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 308);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // fromEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(985, 416);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Comic Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fromEmployeeDatabase";
            Text = "Employee Database";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ListBox listBoxEmployeeIds;
        private ListBox listBoxFirstNames;
        private ListBox listBoxLastNames;
        private ListBox listBoxPositions;
        private Panel panel2;
        private Button buttonReset;
        private Button buttonRemovePrevious;
        private Button buttonSubmitEmployee;
        private Label label4;
        private RichTextBox textBoxLastName;
        private Label label3;
        private Label label2;
        private RichTextBox textBoxFirstName;
        private RichTextBox textBoxEmployeeId;
        private RichTextBox textBoxPosition;
        private PictureBox pictureBox2;
    }
}
