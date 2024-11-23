using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmExercise : Form
    {
        public frmExercise()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExercise_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoten.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoten.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoten.Text = txtHo.Text + " " + txtTen.Text;
        }


        private void lblHoten_DoubleClick(object sender, EventArgs e)
        {
            lblHoten.Text = string.Empty;
        }

    }
}
