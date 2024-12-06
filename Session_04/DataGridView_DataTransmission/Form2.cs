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
    public partial class Form2 : Form
    {
        public delegate void SaveDateHandler(string id, string name, string salary);
        public event SaveDateHandler DataSaved;
        public Form2(string id = "", string name = "", string salary = "")
        {
            InitializeComponent();
            txtId.Text = id;
            txtName.Text = name;
            txtSalary.Text = salary;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataSaved.Invoke(txtId.Text, txtName.Text, txtSalary.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
