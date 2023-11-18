namespace Practica_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double sueldo, aumento, nsueldo;
            sueldo = double.Parse(textBox1.Text);
            if (sueldo < 400000.00)
            {
                aumento = sueldo * 0.15;
                nsueldo = sueldo + aumento;

                textBox2.Text = nsueldo.ToString();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = " ";
            textBox2.Text = " ";

        }
    }

}