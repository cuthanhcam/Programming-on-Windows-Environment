namespace DataTransmission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void delPassData(string text);
        private void btnSend_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            delPassData del = new delPassData(frm.funData);
            del(this.textBox1.Text);
            frm.Show();
        }
    }
}
