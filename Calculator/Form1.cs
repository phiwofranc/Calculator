namespace Calculator
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

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            tbAnswer.Text = tbAnswer.Text + button.Text;
        }

        //private void button2_Click(object sender, EventArgs e)
       // {
       //     int number1 = 2;
       ////     tbAnswer.Text = tbAnswer.Text + "2";
        //}

       // private void button3_Click(object sender, EventArgs e)
        //{
        //    tbAnswer.Text = tbAnswer.Text + "3";
        //}

        //private void button0_Click(object sender, EventArgs e)
        //{
        //    tbAnswer.Text = tbAnswer.Text + "0";
        //}
    }
}