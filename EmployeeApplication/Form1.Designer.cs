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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            panel2 = new Panel();
            buttonReset = new Button();
            buttonRemoveSelected = new Button();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            dataGridViewEmployeeDatabase = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeeDatabase).BeginInit();
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
            // panel2
            // 
            panel2.Controls.Add(buttonReset);
            panel2.Controls.Add(buttonRemoveSelected);
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
            // buttonRemoveSelected
            // 
            buttonRemoveSelected.BackColor = Color.LightCyan;
            buttonRemoveSelected.Font = new Font("Comic Mono", 12F);
            buttonRemoveSelected.Location = new Point(16, 7);
            buttonRemoveSelected.Margin = new Padding(3, 2, 3, 2);
            buttonRemoveSelected.Name = "buttonRemoveSelected";
            buttonRemoveSelected.Size = new Size(176, 28);
            buttonRemoveSelected.TabIndex = 1;
            buttonRemoveSelected.Text = "REMOVE SELECTED";
            buttonRemoveSelected.UseVisualStyleBackColor = false;
            buttonRemoveSelected.Click += buttonRemovePrevious_Click;
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
            // panel3
            // 
            panel3.Controls.Add(dataGridViewEmployeeDatabase);
            panel3.Location = new Point(11, 137);
            panel3.Name = "panel3";
            panel3.Size = new Size(756, 217);
            panel3.TabIndex = 5;
            // 
            // dataGridViewEmployeeDatabase
            // 
            dataGridViewEmployeeDatabase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployeeDatabase.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEmployeeDatabase.BackgroundColor = Color.LightCyan;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Comic Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEmployeeDatabase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEmployeeDatabase.Location = new Point(0, 3);
            dataGridViewEmployeeDatabase.Name = "dataGridViewEmployeeDatabase";
            dataGridViewEmployeeDatabase.Size = new Size(753, 211);
            dataGridViewEmployeeDatabase.TabIndex = 0;
            // 
            // fromEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(985, 416);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Comic Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fromEmployeeDatabase";
            Text = "Employee Database";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeeDatabase).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button buttonReset;
        private Button buttonRemoveSelected;
        private Button buttonSubmitEmployee;
        private Label label4;
        private RichTextBox textBoxLastName;
        private Label label3;
        private Label label2;
        private RichTextBox textBoxFirstName;
        private RichTextBox textBoxEmployeeId;
        private RichTextBox textBoxPosition;
        private PictureBox pictureBox2;
        private Panel panel3;
        private DataGridView dataGridViewEmployeeDatabase;
    }
}
