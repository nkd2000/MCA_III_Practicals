using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program13 : Form {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program13());
        }
        public Program13() => InitializeComponent();

        private void Program13_Load(object sender, EventArgs e) {}

        private void button1_Click(object sender, EventArgs e) {
            if (!TestInput())
                button1.Enabled = false;

            label3.Text = $"Result is : {float.Parse(textBox1.Text) + float.Parse(textBox2.Text)}";

        }
        public bool TestInput() {
            if (!(float.TryParse(textBox1.Text, out _) && float.TryParse(textBox2.Text, out _))) {
                label3.Text = "Not a valid number.";
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e) {
            if (!TestInput())
                button1.Enabled = false;

            label3.Text = $"Result is : {float.Parse(textBox1.Text) - float.Parse(textBox2.Text)}";
        }

        private void button3_Click(object sender, EventArgs e) {
            if (!TestInput())
                button1.Enabled = false;

            label3.Text = $"Result is : {float.Parse(textBox1.Text) * float.Parse(textBox2.Text)}";
        }

        private void button4_Click(object sender, EventArgs e) {
            if (!TestInput())
                button1.Enabled = false;

            label3.Text = $"Result is : {float.Parse(textBox1.Text) / float.Parse(textBox2.Text)}";
        }
    }
}
