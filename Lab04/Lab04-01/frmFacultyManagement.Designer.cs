namespace Lab04_01
{
    partial class frmFacultyManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalProfessor = new System.Windows.Forms.TextBox();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.lblTotalProfessor = new System.Windows.Forms.Label();
            this.lblFacultyName = new System.Windows.Forms.Label();
            this.lblFacultyID = new System.Windows.Forms.Label();
            this.dataGridViewFaculty = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalProfessor);
            this.groupBox1.Controls.Add(this.txtFacultyName);
            this.groupBox1.Controls.Add(this.txtFacultyID);
            this.groupBox1.Controls.Add(this.lblTotalProfessor);
            this.groupBox1.Controls.Add(this.lblFacultyName);
            this.groupBox1.Controls.Add(this.lblFacultyID);
            this.groupBox1.Location = new System.Drawing.Point(16, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faculty Information";
            // 
            // txtTotalProfessor
            // 
            this.txtTotalProfessor.Location = new System.Drawing.Point(118, 115);
            this.txtTotalProfessor.Name = "txtTotalProfessor";
            this.txtTotalProfessor.Size = new System.Drawing.Size(258, 22);
            this.txtTotalProfessor.TabIndex = 5;
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(118, 72);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(258, 22);
            this.txtFacultyName.TabIndex = 4;
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.Location = new System.Drawing.Point(118, 33);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(258, 22);
            this.txtFacultyID.TabIndex = 3;
            // 
            // lblTotalProfessor
            // 
            this.lblTotalProfessor.AutoSize = true;
            this.lblTotalProfessor.Location = new System.Drawing.Point(10, 118);
            this.lblTotalProfessor.Name = "lblTotalProfessor";
            this.lblTotalProfessor.Size = new System.Drawing.Size(102, 16);
            this.lblTotalProfessor.TabIndex = 2;
            this.lblTotalProfessor.Text = "Total Professor:";
            // 
            // lblFacultyName
            // 
            this.lblFacultyName.AutoSize = true;
            this.lblFacultyName.Location = new System.Drawing.Point(10, 75);
            this.lblFacultyName.Name = "lblFacultyName";
            this.lblFacultyName.Size = new System.Drawing.Size(93, 16);
            this.lblFacultyName.TabIndex = 1;
            this.lblFacultyName.Text = "Faculty Name:";
            // 
            // lblFacultyID
            // 
            this.lblFacultyID.AutoSize = true;
            this.lblFacultyID.Location = new System.Drawing.Point(10, 36);
            this.lblFacultyID.Name = "lblFacultyID";
            this.lblFacultyID.Size = new System.Drawing.Size(69, 16);
            this.lblFacultyID.TabIndex = 0;
            this.lblFacultyID.Text = "Faculty ID:";
            // 
            // dataGridViewFaculty
            // 
            this.dataGridViewFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaculty.Location = new System.Drawing.Point(446, 27);
            this.dataGridViewFaculty.Name = "dataGridViewFaculty";
            this.dataGridViewFaculty.RowHeadersWidth = 51;
            this.dataGridViewFaculty.RowTemplate.Height = 24;
            this.dataGridViewFaculty.Size = new System.Drawing.Size(514, 231);
            this.dataGridViewFaculty.TabIndex = 1;
            this.dataGridViewFaculty.SelectionChanged += new System.EventHandler(this.dataGridViewFaculty_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(339, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(219, 235);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(101, 30);
            this.btnAddUpdate.TabIndex = 3;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(885, 282);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmFacultyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 333);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewFaculty);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFacultyManagement";
            this.Text = "Faculty Management";
            this.Load += new System.EventHandler(this.frmFacultyManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalProfessor;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.Label lblTotalProfessor;
        private System.Windows.Forms.Label lblFacultyName;
        private System.Windows.Forms.Label lblFacultyID;
        private System.Windows.Forms.DataGridView dataGridViewFaculty;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnClose;
    }
}