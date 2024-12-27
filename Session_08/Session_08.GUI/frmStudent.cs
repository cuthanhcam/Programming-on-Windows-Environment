using Session_08.BUS;
using Session_08.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_08.GUI
{
    public partial class frmStudent : Form
    {
        private readonly StudentService _studentService;
        private readonly ClassService _classService;
        public frmStudent(StudentService studentService, ClassService classService)
        {
            InitializeComponent();
            _studentService = studentService;
            _classService = classService;
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
            var students = _studentService.GetAllStudents();

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
            comboBoxClass.DataSource = _classService.GetAllClasses();
            comboBoxClass.DisplayMember = "ClassName";
            comboBoxClass.ValueMember = "ClassID";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var student = new Student
            {
                StudentID = txtStudentID.Text,
                StudentName = txtStudentName.Text,
                DateOfBirth = dateTimePickerDateOfBirth.Value,
                ClassID = comboBoxClass.SelectedValue.ToString()
            };

            try
            {
                _studentService.AddStudent(student);
                LoadStudents();
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var student = new Student
            {
                StudentID = txtStudentID.Text,
                StudentName = txtStudentName.Text,
                DateOfBirth = dateTimePickerDateOfBirth.Value,
                ClassID = comboBoxClass.SelectedValue.ToString()
            };

            try
            {
                _studentService.UpdateStudent(student);
                LoadStudents();
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var studentID = txtStudentID.Text;

            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!", "Lỗi");
                return;
            }

            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sinh viên với ID {studentID} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _studentService.DeleteStudent(studentID);
                    LoadStudents();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa sinh viên: {ex.Message}", "Lỗi");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text;

            var students = _studentService.SearchStudents(searchText);

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
                var classList = _classService.GetAllClasses();
                var classObj = classList.FirstOrDefault(c => c.ClassName == className);

                if (classObj != null)
                {
                    comboBoxClass.SelectedValue = classObj.ClassID;
                }

                btnSave.Enabled = false;
                btnNoSave.Enabled = false;
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
                var student = new Student
                {
                    StudentID = txtStudentID.Text,
                    StudentName = txtStudentName.Text,
                    DateOfBirth = dateTimePickerDateOfBirth.Value,
                    ClassID = comboBoxClass.SelectedValue.ToString()
                };

                DialogResult result = MessageBox.Show("Bạn có chắc muốn lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _studentService.UpdateStudent(student);
                        LoadStudents();
                        MessageBox.Show("Lưu thay đổi thành công!", "Thông báo");
                        isDataChanged = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lưu thay đổi: {ex.Message}", "Lỗi");
                    }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                 "Bạn có chắc chắn muốn đóng ứng dụng?",
                 "Xác nhận",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
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
    }
}
