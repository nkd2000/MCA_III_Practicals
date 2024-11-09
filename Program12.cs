using System;
using System.Drawing;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program12 : Form {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program12());
        }
        public Program12() => InitializeComponent();

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Program12_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (!textBox1.Font.Bold) {
                textBox1.Font = new Font(FontFamily.GenericSansSerif,8.25f,FontStyle.Bold);
            }
            else {
                textBox1.Font = new Font(FontFamily.GenericSansSerif, 8.25f, FontStyle.Regular);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (!textBox1.Font.Italic) {
                textBox1.Font = new Font(FontFamily.GenericSansSerif,8.25f,FontStyle.Italic);
            }
            else {
                textBox1.Font = new Font(FontFamily.GenericSansSerif, 8.25f, FontStyle.Regular);
            }
        }

        private void button3_Click(object sender, EventArgs e) => textBox1.ForeColor = Color.Red;

        private void button4_Click(object sender, EventArgs e) => textBox1.ForeColor = Color.Blue;

        private void button5_Click(object sender, EventArgs e) => textBox1.Visible = true;

        private void button6_Click(object sender, EventArgs e) => textBox1.Visible = false;
    }
}
