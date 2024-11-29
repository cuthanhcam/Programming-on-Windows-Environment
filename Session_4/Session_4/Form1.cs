using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Session_4
{
    public partial class Form1 : Form
    {
        List<Student> students;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<Student>();
            students.Add(new Student(1, "A", 20));
            students.Add(new Student(2, "B", 21));
            students.Add(new Student(3, "C", 22));
            dataStudent.DataSource = students;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát", "Câu hỏi thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student(int.Parse(txtId.Text), txtName.Text, int.Parse(txtAge.Text));
            students.Add(s);

            dataStudent.DataSource = new BindingList<Student>(students);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dataStudent.SelectedRows[0].Index;

            students[selectedIndex].Id = int.Parse(txtId.Text);
            students[selectedIndex].Name = txtName.Text;
            students[selectedIndex].Age = int.Parse(txtAge.Text);

            dataStudent.DataSource = new BindingList<Student>(students);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dataStudent.SelectedRows[0].Index;

            students.RemoveAt(selectedIndex);

            dataStudent.DataSource = new BindingList<Student>(students);
        }

        private void dataStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dataStudent.CurrentRow == null) return;

            DataGridViewRow selectedRow = dataStudent.CurrentRow;

            txtId.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;     // Cột Id
            txtName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;   // Cột Name
            txtAge.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;    // Cột Age
        }

    }
}
