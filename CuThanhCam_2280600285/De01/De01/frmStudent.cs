using De01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De01
{
    public partial class frmStudent : Form
    {
        private StudentManagementEntities db = new StudentManagementEntities();
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadClasses();
            ConfigureListView();

            txtStudentID.TextChanged += ControlDataChanged;
            txtStudentName.TextChanged += ControlDataChanged;
            dateTimePickerDateOfBirth.ValueChanged += ControlDataChanged;
            comboBoxClass.SelectedIndexChanged += ControlDataChanged;
        }
        private void ConfigureListView()
        {
            listViewStudent.View = View.Details;
            listViewStudent.FullRowSelect = true;
            listViewStudent.GridLines = true;

            listViewStudent.Columns.Add("StudentID", 100);
            listViewStudent.Columns.Add("StudentName", 150);
            listViewStudent.Columns.Add("Date of Birth", 120);
            listViewStudent.Columns.Add("Class", 100);
        }
        private void LoadStudents()
        {
            listViewStudent.Items.Clear();
            var students = db.Students.Include("Class").ToList();

            foreach (var student in students)
            {
                var item = new ListViewItem(student.StudentID);
                item.SubItems.Add(student.StudentName);
                item.SubItems.Add(student.DateOfBirth?.ToString("yyyy-MM-dd"));
                item.SubItems.Add(student.Class?.ClassName ?? "");
                listViewStudent.Items.Add(item);
            }
        }


        private void LoadClasses()
        {
            comboBoxClass.DataSource = db.Classes.ToList();
            comboBoxClass.DisplayMember = "ClassName";
            comboBoxClass.ValueMember = "ClassID";
        }

        private void listViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count > 0)
            {
                var selectedItem = listViewStudent.SelectedItems[0];
                txtStudentID.Text = selectedItem.SubItems[0].Text;
                txtStudentName.Text = selectedItem.SubItems[1].Text;

                if (DateTime.TryParse(selectedItem.SubItems[2].Text, out DateTime dateOfBirth))
                {
                    dateTimePickerDateOfBirth.Value = dateOfBirth;
                }
                else
                {
                    dateTimePickerDateOfBirth.Value = DateTime.Now;
                }

                var className = selectedItem.SubItems[3].Text;
                var classID = db.Classes.FirstOrDefault(c => c.ClassName == className)?.ClassID;

                if (classID != null)
                {
                    comboBoxClass.SelectedValue = classID;
                }

                btnSave.Enabled = false;
                btnNoSave.Enabled = false;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var student = new Student
            {
                StudentID = txtStudentID.Text,
                StudentName = txtStudentName.Text,
                DateOfBirth = dateTimePickerDateOfBirth.Value,
                ClassID = comboBoxClass.SelectedValue.ToString()
            };

            db.Students.Add(student);
            db.SaveChanges();
            LoadStudents();
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var studentID = txtStudentID.Text;
            var student = db.Students.Find(studentID);
            if (student != null)
            {
                student.StudentName = txtStudentName.Text;
                student.DateOfBirth = dateTimePickerDateOfBirth.Value;
                student.ClassID = comboBoxClass.SelectedValue.ToString();
                db.SaveChanges();
                LoadStudents();
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên!", "Lỗi");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var studentID = txtStudentID.Text;
            var student = db.Students.Find(studentID);

            if (student != null)
            {
                var result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sinh viên với ID {studentID} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                    LoadStudents();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên!", "Lỗi");
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.ToLower();
            var students = db.Students
                .Include("Class")
                .Where(s => s.StudentName.ToLower().Contains(searchText))
                .ToList();

            listViewStudent.Items.Clear();
            foreach (var student in students)
            {
                var item = new ListViewItem(student.StudentID);
                item.SubItems.Add(student.StudentName);
                item.SubItems.Add(student.DateOfBirth?.ToString("yyyy-MM-dd"));
                item.SubItems.Add(student.Class?.ClassName ?? "");
                listViewStudent.Items.Add(item);
            }
        }
        private bool isDataChanged = false;
        private void ControlDataChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
            btnSave.Enabled = true;
            btnNoSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isDataChanged)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.SaveChanges();
                    LoadStudents();
                    MessageBox.Show("Lưu thay đổi thành công!", "Thông báo");
                    isDataChanged = false;
                }
                btnSave.Enabled = false;
                btnNoSave.Enabled = false;
            }
        }

        private void btnNoSave_Click(object sender, EventArgs e)
        {
            LoadStudents();
            MessageBox.Show("Thay đổi đã được hủy!", "Thông báo");
            btnSave.Enabled = false;
            btnNoSave.Enabled = false;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Lỗi");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!", "Lỗi");
                return false;
            }

            if (comboBoxClass.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp!", "Lỗi");
                return false;
            }

            return true;
        }
        
        private void frmStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đóng ứng dụng?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
