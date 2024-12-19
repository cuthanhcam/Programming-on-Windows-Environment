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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // Clear all columns in the DataGridView at startup
            dataGridViewSearchResult.Columns.Clear();

            // Load dữ liệu cho comboBoxFaculty
            using (var context = new StudentContextDB())
            {
                var faculties = context.Faculties.ToList();

                // Thêm mục "Empty" vào comboBox
                var defaultFaculty = new Faculty { FacultyID = -1, FacultyName = "Empty" };
                faculties.Insert(0, defaultFaculty);

                comboBoxFaculty.DataSource = faculties;
                comboBoxFaculty.DisplayMember = "FacultyName";
                comboBoxFaculty.ValueMember = "FacultyID";
                comboBoxFaculty.SelectedIndex = 0; // Chọn "Empty" mặc định
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new StudentContextDB())
            {
                var query = context.Students.AsQueryable();

                // Điều kiện tìm kiếm
                if (!string.IsNullOrWhiteSpace(txtStudentID.Text))
                {
                    query = query.Where(s => s.StudentID == txtStudentID.Text); // Exact match
                }

                if (!string.IsNullOrWhiteSpace(txtStudentName.Text))
                {
                    query = query.Where(s => s.FullName == txtStudentName.Text); // Exact match
                }

                if (comboBoxFaculty.SelectedIndex > 0) // Bỏ qua "Empty"
                {
                    int selectedFacultyID = (int)comboBoxFaculty.SelectedValue;
                    query = query.Where(s => s.FacultyID == selectedFacultyID);
                }

                var searchResult = query.Select(s => new SearchResult
                {
                    StudentID = s.StudentID,
                    FullName = s.FullName,
                    FacultyName = s.Faculty.FacultyName,
                    AverageScore = s.AverageScore
                }).ToList();

                if (searchResult.Count > 0)
                {
                    BindGrid(searchResult);
                    txtSearchResult.Text = $"{searchResult.Count}";
                }
                else
                {
                    dataGridViewSearchResult.Rows.Clear();
                    dataGridViewSearchResult.Columns.Clear();
                    txtSearchResult.Text = "0";
                }
            }
        }

        private void BindGrid(List<SearchResult> searchResult)
        {
            dataGridViewSearchResult.Rows.Clear();

            // Thêm cột nếu chưa có
            if (dataGridViewSearchResult.Columns.Count == 0)
            {
                dataGridViewSearchResult.Columns.Add("StudentID", "Student ID");
                dataGridViewSearchResult.Columns.Add("FullName", "Full Name");
                dataGridViewSearchResult.Columns.Add("FacultyName", "Faculty");
                dataGridViewSearchResult.Columns.Add("AverageScore", "Average Score");
            }

            // Thêm các dòng từ danh sách tìm kiếm
            foreach (var student in searchResult)
            {
                int index = dataGridViewSearchResult.Rows.Add();
                dataGridViewSearchResult.Rows[index].Cells["StudentID"].Value = student.StudentID;
                dataGridViewSearchResult.Rows[index].Cells["FullName"].Value = student.FullName;
                dataGridViewSearchResult.Rows[index].Cells["FacultyName"].Value = student.FacultyName;
                dataGridViewSearchResult.Rows[index].Cells["AverageScore"].Value = student.AverageScore;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            comboBoxFaculty.SelectedIndex = 0; // Reset về "Empty"
            dataGridViewSearchResult.Rows.Clear();
            dataGridViewSearchResult.Columns.Clear();
            txtSearchResult.Clear();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
