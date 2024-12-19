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

namespace Lab04_01
{
    public partial class frmFacultyManagement : Form
    {
        public frmFacultyManagement()
        {
            InitializeComponent();
        }

        private void frmFacultyManagement_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFaculties = context.Faculties.ToList();
                BindGrid(listFaculties);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<Faculty> listFaculties)
        {
            dataGridViewFaculty.Rows.Clear();

            if (dataGridViewFaculty.Columns.Count == 0)
            {
                dataGridViewFaculty.Columns.Add("FacultyID", "Faculty ID");
                dataGridViewFaculty.Columns.Add("FacultyName", "Faculty Name");
                dataGridViewFaculty.Columns.Add("TotalProfessor", "Total Professors");
                dataGridViewFaculty.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Cho phép chọn toàn dòng
                dataGridViewFaculty.MultiSelect = true; // Cho phép chọn nhiều dòng
            }

            foreach (var faculty in listFaculties)
            {
                int index = dataGridViewFaculty.Rows.Add();
                dataGridViewFaculty.Rows[index].Cells[0].Value = faculty.FacultyID;
                dataGridViewFaculty.Rows[index].Cells[1].Value = faculty.FacultyName;
                dataGridViewFaculty.Rows[index].Cells[2].Value = faculty.TotalProfessor;
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFacultyID.Text) || string.IsNullOrWhiteSpace(txtFacultyName.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtFacultyID.Text, out int facultyID))
                {
                    MessageBox.Show("Mã khoa phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var context = new StudentContextDB())
                {
                    Faculty faculty = context.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);

                    if (faculty == null)
                    {
                        // Thêm mới
                        faculty = new Faculty
                        {
                            FacultyID = facultyID,
                            FacultyName = txtFacultyName.Text,
                            TotalProfessor = string.IsNullOrEmpty(txtTotalProfessor.Text) ? (int?)null : int.Parse(txtTotalProfessor.Text)
                        };
                        context.Faculties.Add(faculty);
                    }
                    else
                    {
                        // Cập nhật
                        faculty.FacultyName = txtFacultyName.Text;
                        faculty.TotalProfessor = string.IsNullOrEmpty(txtTotalProfessor.Text) ? (int?)null : int.Parse(txtTotalProfessor.Text);
                    }

                    context.SaveChanges();
                    BindGrid(context.Faculties.ToList());
                    MessageBox.Show("Thêm hoặc cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                var selectedRows = dataGridViewFaculty.SelectedRows;

                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa các khoa đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var context = new StudentContextDB())
                    {
                        foreach (DataGridViewRow row in selectedRows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                int facultyID = int.Parse(row.Cells[0].Value.ToString());
                                Faculty facultyToDelete = context.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);

                                if (facultyToDelete != null)
                                {
                                    context.Faculties.Remove(facultyToDelete);
                                }
                            }
                        }

                        context.SaveChanges();
                        BindGrid(context.Faculties.ToList());
                        MessageBox.Show("Xóa thành công các khoa đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewFaculty_SelectionChanged(object sender, EventArgs e)
        {
            // Hiển thị thông tin dòng được chọn trong các TextBox
            if (dataGridViewFaculty.CurrentRow != null && dataGridViewFaculty.CurrentRow.Cells[0].Value != null)
            {
                txtFacultyID.Text = dataGridViewFaculty.CurrentRow.Cells[0].Value.ToString();
                txtFacultyName.Text = dataGridViewFaculty.CurrentRow.Cells[1].Value?.ToString();
                txtTotalProfessor.Text = dataGridViewFaculty.CurrentRow.Cells[2].Value?.ToString();
            }
        }
    }
}
