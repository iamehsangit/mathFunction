namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int number1;
        int number2;
        int total;
        string opt;
        int alu = 0;


        private void btn2_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "2";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "1";
        }



        private void btn3_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            opt = "+";
            number1 = Convert.ToInt32(txttotal.Text);
            txttotal.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(txttotal.Text);
            if(opt=="+")
            {
                total=number1 + number2;
            }
            txttotal.Text=total.ToString();
        }
    }
}
