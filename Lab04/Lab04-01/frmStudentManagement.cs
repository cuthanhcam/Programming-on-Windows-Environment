using Lab04_01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Lab04_01
{
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void frmStudentMangement_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();

                // Eager loading để tải cả Faculty
                List<Faculty> listFaculties = context.Faculties.ToList();
                List<Student> listStudents = context.Students.Include(s => s.Faculty).ToList();

                FillFacultyCombobox(listFaculties);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillFacultyCombobox(List<Faculty> listFaculties)
        {
            comboBoxFaculty.DataSource = listFaculties;
            comboBoxFaculty.DisplayMember = "FacultyName"; // Tên hiển thị
            comboBoxFaculty.ValueMember = "FacultyID";    // Giá trị lưu trữ
        }
        private void BindGrid(List<Student> listStudents)
        {
            dataGridViewStudents.Rows.Clear(); // Xóa các dòng cũ

            // Kiểm tra và chỉ thêm cột một lần
            if (dataGridViewStudents.Columns.Count == 0)
            {
                dataGridViewStudents.Columns.Add("StudentID", "Student ID");
                dataGridViewStudents.Columns.Add("FullName", "Full Name");
                dataGridViewStudents.Columns.Add("AverageScore", "Average Score");
                dataGridViewStudents.Columns.Add("FacultyName", "Faculty Name");
            }

            foreach (var item in listStudents)
            {
                int index = dataGridViewStudents.Rows.Add(); // Thêm dòng mới
                dataGridViewStudents.Rows[index].Cells[0].Value = item.StudentID;
                dataGridViewStudents.Rows[index].Cells[1].Value = item.FullName;
                dataGridViewStudents.Rows[index].Cells[2].Value = item.AverageScore;
                dataGridViewStudents.Rows[index].Cells[3].Value = item.Faculty?.FacultyName; // Kiểm tra null
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                    string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                    string.IsNullOrWhiteSpace(txtAverageScore.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtStudentID.Text.Length != 10)
                {
                    MessageBox.Show("Mã số sinh viên phải có 10 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra AverageScore
                if (!double.TryParse(txtAverageScore.Text, out double averageScore) || averageScore < 0 || averageScore > 100)
                {
                    MessageBox.Show("Điểm trung bình phải là số thực từ 0 đến 100!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                StudentContextDB context = new StudentContextDB();

                // Kiểm tra trùng StudentID
                if (context.Students.Any(s => s.StudentID == txtStudentID.Text))
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm sinh viên mới
                Student newStudent = new Student
                {
                    StudentID = txtStudentID.Text,
                    FullName = txtStudentName.Text,
                    AverageScore = averageScore,
                    FacultyID = (int)comboBoxFaculty.SelectedValue
                };

                context.Students.Add(newStudent);
                context.SaveChanges();

                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật DataGridView
                BindGrid(context.Students.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                    string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                    string.IsNullOrWhiteSpace(txtAverageScore.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra AverageScore
                if (!double.TryParse(txtAverageScore.Text, out double averageScore) || averageScore < 0 || averageScore > 100)
                {
                    MessageBox.Show("Điểm trung bình phải là số thực từ 0 đến 100!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                StudentContextDB context = new StudentContextDB();
                string studentID = txtStudentID.Text;
                Student studentToUpdate = context.Students.FirstOrDefault(s => s.StudentID == studentID);

                if (studentToUpdate == null)
                {
                    MessageBox.Show("Không tìm thấy MSSV cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật thông tin sinh viên
                studentToUpdate.FullName = txtStudentName.Text;
                studentToUpdate.AverageScore = averageScore;
                studentToUpdate.FacultyID = (int)comboBoxFaculty.SelectedValue;

                context.SaveChanges();

                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật DataGridView
                BindGrid(context.Students.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();

                // Lấy danh sách các dòng được chọn
                var selectedRows = dataGridViewStudents.SelectedRows;

                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sinh viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa các sinh viên đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        if (row.Cells[0].Value != null) // Kiểm tra nếu ô StudentID không rỗng
                        {
                            string studentID = row.Cells[0].Value.ToString(); // Lấy giá trị StudentID
                            Student studentToDelete = context.Students.FirstOrDefault(s => s.StudentID == studentID);

                            if (studentToDelete != null)
                            {
                                context.Students.Remove(studentToDelete);
                            }
                        }
                    }

                    context.SaveChanges();

                    MessageBox.Show("Xóa thành công các sinh viên đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật DataGridView
                    BindGrid(context.Students.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null && dataGridViewStudents.CurrentRow.Cells[0].Value != null)
            {
                txtStudentID.Text = dataGridViewStudents.CurrentRow.Cells[0].Value.ToString();
                txtStudentName.Text = dataGridViewStudents.CurrentRow.Cells[1].Value?.ToString();
                txtAverageScore.Text = dataGridViewStudents.CurrentRow.Cells[2].Value?.ToString();
                comboBoxFaculty.Text = dataGridViewStudents.CurrentRow.Cells[3].Value?.ToString();
            }
        }
        private void ResetForm()
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtAverageScore.Clear();
            comboBoxFaculty.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void facultyManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacultyManagement facultyForm = new frmFacultyManagement();
            facultyForm.ShowDialog();
        }

        private void toolStripButtonFacultyManagement_Click(object sender, EventArgs e)
        {
            frmFacultyManagement facultyForm = new frmFacultyManagement();
            facultyForm.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch();
            searchForm.ShowDialog();
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch();
            searchForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
