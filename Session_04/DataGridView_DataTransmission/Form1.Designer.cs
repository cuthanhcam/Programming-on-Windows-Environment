namespace DataGridView_DataTransmission
{
    partial class Form1
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
            listView1 = new ListView();
            colId = new ColumnHeader();
            colName = new ColumnHeader();
            colSalary = new ColumnHeader();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colId, colName, colSalary });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = true;
            listView1.Location = new Point(39, 48);
            listView1.Name = "listView1";
            listView1.Size = new Size(450, 339);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "Id";
            colId.Width = 150;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 150;
            // 
            // colSalary
            // 
            colSalary.Text = "Salary";
            colSalary.Width = 150;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(531, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(531, 97);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(531, 143);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(531, 191);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 436);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "List View - 2280600285 Cu Thanh Cam";
            FormClosing += Form1_FormClosing_1;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader colId;
        private ColumnHeader colName;
        private ColumnHeader colSalary;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
    }
}