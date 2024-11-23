using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMyClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            string birthDate = dtpBorn.Value.ToString("dd/MM/yyyy");

            string gender = radMale.Checked ? "Nam" : radFemale.Checked ? "Nữ" : "Chưa chọn";

            string hobbies = "";
            if (chkSport.Checked) hobbies += "Thể thao, ";
            if (chkFilm.Checked) hobbies += "Xem phim, ";
            if (chkTravel.Checked) hobbies += "Du lịch, ";
            if (hobbies.EndsWith(", ")) hobbies = hobbies.Substring(0, hobbies.Length - 2);
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (gender == "Chưa chọn")
            {
                MessageBox.Show("Vui lòng nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string result = $"Họ tên: {name}, Giới tính: {gender}, Ngày sinh: {birthDate}, Sở thích: {hobbies} ";

            MessageBox.Show(result, "Thông tin người dùng", MessageBoxButtons.OK);
        }
    }
}
