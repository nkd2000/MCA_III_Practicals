using System;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program15 : Form {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program15());
        }
        public Program15() => InitializeComponent();

        private void Program15_Load(object sender, EventArgs e) {
            button1.Hide();
            button3.Hide();
            panel1.Hide();
            panel2.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void button2_Click(object sender, EventArgs e) {
            button1.Enabled = true;
            if (radioButton1.Checked) {
                button1.Show();
                panel1.Show();
                toConvert.Text = "Enter Decimal value : ";
                label2.Text = "Equilent Binary is : ";
                label3.Text = "Equilent Octal is : ";
                label4.Text = "Equilent Hexadecimal is : ";
            }else if (radioButton2.Checked) {
                button1.Show();
                panel1.Show();
                toConvert.Text = "Enter Binary value : ";
                label2.Text = "Equilent Decimal is : ";
                label3.Text = "Equilent Octal is : ";
                label4.Text = "Equilent Hexadecimal is : ";
            }else if (radioButton3.Checked) {
                button1.Show();
                panel1.Show();
                toConvert.Text = "Enter Octal value : ";
                label2.Text = "Equilent Decimal is : ";
                label3.Text = "Equilent Binary is : ";
                label4.Text = "Equilent Hexadecimal is : ";
            }
            else {
                MessageBox.Show("Please select an option.");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if(!(int.TryParse(textBox1.Text, out _))) {
                MessageBox.Show("Enter only numeric value");
            }else {
                panel2.Show();
                button3.Show();
                button1.Enabled = false;
                if (radioButton1.Checked) {
                    //decimal to binary, octal and hexadecimal
                    textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 2);
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 8);
                    textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 16);
                }
                else if (radioButton2.Checked) {
                    //binary to decimal, octal and hexadecimal
                    textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text,2), 10);
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text,2), 8);
                    textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 16);
                }
                else if (radioButton3.Checked) {
                    //octal to decimal, binary and hexadecimal
                    textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 10);
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text,8), 2);
                    textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text,8), 16);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            button1.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
