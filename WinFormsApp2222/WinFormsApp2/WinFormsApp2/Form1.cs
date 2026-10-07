namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
        }

        private void groupBox2_Enter(object? sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object? sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object? sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Sum();
            }
        }

        private void radioButton4_CheckedChanged(object? sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Sum();
            }
        }

        private void radioButton5_CheckedChanged(object? sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                Sum();
            }
        }

        private void label1_Click(object? sender, EventArgs e)
        {

        }

        private void label3_Click(object? sender, EventArgs e)
        {
            Sum();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton3.Checked = true;
        }

        private void radioButton2_CheckedChanged(object? sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
                Sum();
            }
        }

        private void radioButton1_CheckedChanged(object? sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
                Sum();
            }
        }

        private void Sum()
        {
            double costmeat = 1000;
            double costveg = 500;
            double summa = 0;
            double natsenka = 0;
            if (checkBox1.Checked)
            {
                costmeat += 100;
            }
            if (checkBox2.Checked)
            {
                costmeat += 50;
            }
            if (checkBox3.Checked)
            {
                costveg += 50;
            }
            if (checkBox4.Checked)
            {
                costveg += 50;
            }
            double meat = costmeat * Convert.ToDouble(numericUpDown1.Value);
            double veg = costveg * Convert.ToDouble(numericUpDown2.Value);
            summa = meat + veg;
            if (radioButton5.Checked)
            {
                natsenka = summa * 0.1;
            }
            label7.Text = summa.ToString();
            label8.Text = "0";
            label9.Text = natsenka.ToString();
            label10.Text = (summa + natsenka).ToString();
        }

        private void checkBox1_CheckedChanged(object? sender, EventArgs e)
        {
            Sum();
        }

        private void checkBox2_CheckedChanged(object? sender, EventArgs e)
        {
            Sum();
        }

        private void checkBox3_CheckedChanged(object? sender, EventArgs e)
        {
            Sum();
        }

        private void checkBox4_CheckedChanged(object? sender, EventArgs e)
        {
            Sum();
        }

        private void numericUpDown1_ValueChanged(object? sender, EventArgs e)
        {
            Sum();
        }

        private void numericUpDown2_ValueChanged(object? sender, EventArgs e)
        {
            Sum();
        }

        private void pictureBox2_Click(object? sender, EventArgs e)
        {

        }
    }
}