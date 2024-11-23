namespace WindowsFormsApp1
{
    partial class frmExercise
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.btnHo = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(332, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(186, 41);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Thoát Chương Trình";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(202, 105);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(446, 22);
            this.txtHo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ lót";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtTen.Location = new System.Drawing.Point(202, 152);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(446, 22);
            this.txtTen.TabIndex = 4;
            // 
            // lblHoten
            // 
            this.lblHoten.BackColor = System.Drawing.Color.Cyan;
            this.lblHoten.Location = new System.Drawing.Point(12, 9);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(776, 55);
            this.lblHoten.TabIndex = 5;
            this.lblHoten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHoten.DoubleClick += new System.EventHandler(this.lblHoten_DoubleClick);
            // 
            // btnHo
            // 
            this.btnHo.Location = new System.Drawing.Point(202, 227);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(94, 36);
            this.btnHo.TabIndex = 6;
            this.btnHo.Text = "Họ Lót";
            this.btnHo.UseVisualStyleBackColor = true;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(378, 227);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(92, 36);
            this.btnTen.TabIndex = 7;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Location = new System.Drawing.Point(536, 227);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(112, 36);
            this.btnHoTen.TabIndex = 8;
            this.btnHoTen.Text = "Họ và Tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // frmExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHo);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.btnClose);
            this.Name = "frmExercise";
            this.Text = "Bài Tập Họ Tên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExercise_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
    }
}

