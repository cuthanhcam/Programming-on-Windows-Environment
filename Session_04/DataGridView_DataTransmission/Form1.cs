using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_DataTransmission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.DataSaved += (id, name, salary) =>
            {
                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(name);
                item.SubItems.Add(salary);
                listView1.Items.Add(item);
            };
            form2.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Form2 form2 = new Form2(selectedItem.Text, selectedItem.SubItems[1].Text, selectedItem.SubItems[2].Text);
                form2.DataSaved += (id, name, salary) =>
                {
                    selectedItem.Text = id;
                    selectedItem.SubItems[1].Text = name;
                    selectedItem.SubItems[2].Text = salary;
                };
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listView1.Items.Remove(listView1.SelectedItems[i]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng dể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
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
    }
}
