namespace Homework_Session_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem newItem = new ListViewItem(new[] { lastName, firstName, phone });

            listView1.Items.Add(newItem);

            ClearTextBox();
        }

        public void ClearTextBox()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtPhone.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = listView1.SelectedItems[0];

            item.SubItems[0].Text = txtLastName.Text.Trim();
            item.SubItems[1].Text = txtFirstName.Text.Trim();
            item.SubItems[2].Text = txtPhone.Text.Trim();

            ClearTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dể xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = listView1.SelectedItems[0];

            listView1.Items.Remove(item);

            ClearTextBox();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem item = listView1.SelectedItems[0];

            txtLastName.Text = item.SubItems[0].Text;
            txtFirstName.Text = item.SubItems[1].Text;
            txtPhone.Text = item.SubItems[2].Text;
        }
    }
}
