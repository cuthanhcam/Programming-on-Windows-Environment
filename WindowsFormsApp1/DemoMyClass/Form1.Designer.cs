namespace DemoMyClass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBorn = new System.Windows.Forms.Label();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.chkSport = new System.Windows.Forms.CheckBox();
            this.chkFilm = new System.Windows.Forms.CheckBox();
            this.chkTravel = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.radFemale);
            this.groupBox1.Controls.Add(this.radMale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkTravel);
            this.groupBox1.Controls.Add(this.chkFilm);
            this.groupBox1.Controls.Add(this.chkSport);
            this.groupBox1.Controls.Add(this.dtpBorn);
            this.groupBox1.Controls.Add(this.lblBorn);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(43, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 22);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ tên";
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Location = new System.Drawing.Point(337, 38);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(67, 16);
            this.lblBorn.TabIndex = 3;
            this.lblBorn.Text = "Ngày sinh";
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(410, 35);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(269, 22);
            this.dtpBorn.TabIndex = 4;
            // 
            // chkSport
            // 
            this.chkSport.AutoSize = true;
            this.chkSport.Location = new System.Drawing.Point(410, 96);
            this.chkSport.Name = "chkSport";
            this.chkSport.Size = new System.Drawing.Size(82, 20);
            this.chkSport.TabIndex = 5;
            this.chkSport.Text = "Thể thao";
            this.chkSport.UseVisualStyleBackColor = true;
            // 
            // chkFilm
            // 
            this.chkFilm.AutoSize = true;
            this.chkFilm.Location = new System.Drawing.Point(509, 96);
            this.chkFilm.Name = "chkFilm";
            this.chkFilm.Size = new System.Drawing.Size(84, 20);
            this.chkFilm.TabIndex = 6;
            this.chkFilm.Text = "Phim ảnh";
            this.chkFilm.UseVisualStyleBackColor = true;
            // 
            // chkTravel
            // 
            this.chkTravel.AutoSize = true;
            this.chkTravel.Location = new System.Drawing.Point(610, 96);
            this.chkTravel.Name = "chkTravel";
            this.chkTravel.Size = new System.Drawing.Size(69, 20);
            this.chkTravel.TabIndex = 7;
            this.chkTravel.Text = "Du lịch";
            this.chkTravel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sở thích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Giới tính";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(99, 95);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(57, 20);
            this.radMale.TabIndex = 10;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(200, 96);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(45, 20);
            this.radFemale.TabIndex = 11;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(537, 162);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(142, 29);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Xuất thông tin";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Demo Personal Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTravel;
        private System.Windows.Forms.CheckBox chkFilm;
        private System.Windows.Forms.CheckBox chkSport;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

