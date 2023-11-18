namespace Practica_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double C1, C2, C3, C4;
            C1 = double.Parse(textBox1.Text);
            C2 = double.Parse(textBox2.Text);
            C3 = double.Parse(textBox3.Text);
            C4 = double.Parse(textBox4.Text);

            if (C1 >= 6.0)
                textBox5.Text = "APROBADO";
            else textBox5.Text = "REPROBADO";
            if (C2 >= 6.0)
                textBox6.Text = "APROBADO";
            else textBox6.Text = "REPROBADO";
            if (C3 >= 6.0)
                textBox7.Text = "APROBADO";
            else textBox7.Text = "REPROBADO";
            if (C4 >= 6.0)
                textBox8.Text = "APROBADO";
            else textBox8.Text = "REPROBADO";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}