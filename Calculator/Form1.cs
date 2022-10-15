namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            if (txtA.Text != String.Empty && txtB.Text != String.Empty) ;
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                txtTong.Text = (a + b).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            txtTong.Text = (a - b).ToString();
        }
    }
}