using System;
using System.Drawing;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program18 : Form {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program18());
        }
        public Program18() {
            InitializeComponent();
        }

        private void Program18_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (!richTextBox1.Font.Bold) {
                richTextBox1.Font = new Font(FontFamily.GenericSansSerif, 8.25f, FontStyle.Bold);
            }
            else {
                richTextBox1.Font = new Font(FontFamily.GenericSansSerif, 8.25f, FontStyle.Regular);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (!richTextBox1.Font.Italic) {
                richTextBox1.Font = new Font(FontFamily.GenericSansSerif, 8.25f, FontStyle.Italic);
            }
            else {
                richTextBox1.Font = new Font(FontFamily.GenericSansSerif, 8.25f, FontStyle.Regular);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (!richTextBox1.Font.Underline) {
                richTextBox1.Font = new Font(FontFamily.GenericSansSerif, 8.25f, FontStyle.Underline);
            }
            else {
                richTextBox1.Font = new Font(FontFamily.GenericSansSerif, 8.25f, FontStyle.Underline);
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            richTextBox1.ForeColor = Color.Blue; 

        }

        private void button5_Click(object sender, EventArgs e) {
            richTextBox1.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e) {
            richTextBox1.ForeColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e) {
            richTextBox1.BackColor = Color.Blue;
            richTextBox1.ForeColor = Color.White;
        }

        private void button8_Click(object sender, EventArgs e) {
            richTextBox1.BackColor = Color.Red;
            richTextBox1.ForeColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e) {
            richTextBox1.BackColor = Color.Green;
            richTextBox1.ForeColor = Color.White;
        }

        private void button13_Click(object sender, EventArgs e) {
            richTextBox2.Text = richTextBox1.Text;
          
        }

        private void SizeChanged(object sender, MouseEventArgs e) {
            if (comboBox1.SelectedItem != null) {
                float fsize; 
                float.TryParse(comboBox1.SelectedItem.ToString(), out fsize);
                richTextBox1.Font = new Font(FontFamily.GenericSansSerif,fsize);
            }
        }
    }
}
