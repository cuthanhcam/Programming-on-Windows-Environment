namespace Homework_Session_3
{
    partial class Form1
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            Detail = new GroupBox();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPhone = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Detail.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.LabelEdit = true;
            listView1.Location = new Point(17, 32);
            listView1.Name = "listView1";
            listView1.Scrollable = false;
            listView1.Size = new Size(450, 260);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Last Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phone";
            columnHeader3.Width = 150;
            // 
            // Detail
            // 
            Detail.Controls.Add(listView1);
            Detail.Location = new Point(12, 33);
            Detail.Name = "Detail";
            Detail.Size = new Size(489, 311);
            Detail.TabIndex = 1;
            Detail.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtFirstName);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(520, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 311);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(235, 257);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(124, 257);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 257);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(18, 205);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(311, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(18, 132);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(311, 27);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(18, 55);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(311, 27);
            txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Last Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 391);
            Controls.Add(groupBox2);
            Controls.Add(Detail);
            Name = "Form1";
            Text = "ListView Demo 2280600285 - Cu Thanh Cam";
            FormClosing += Form1_FormClosing;
            Detail.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private GroupBox Detail;
        private GroupBox groupBox2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtPhone;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Label label2;
    }
}
