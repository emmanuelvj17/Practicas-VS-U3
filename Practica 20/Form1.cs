namespace Practica_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;
            edad = int.Parse(textBox1.Text);
            if (edad < 12) textBox2.Text = "Niño";
            if ((edad >= 12) && (edad <= 17)) textBox2.Text = "Adolecente";
            if ((edad >= 18) && (edad <= 60)) textBox2.Text = "Adulto";
            if (edad > 60) textBox2.Text = "Adulto mayor";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}