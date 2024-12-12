using System;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program17 : Form {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program17());
        }
        public Program17() => InitializeComponent();

        private void Program17_Load(object sender, EventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {
            if (!listBox1.Items.Contains(textBox1.Text)) {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            else {
                MessageBox.Show("Item already exist.");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if(!listBox2.Items.Contains(listBox1.SelectedItem))
                listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e) {
            if (!listBox2.Items.Contains(listBox1.Items))    
                listBox2.Items.AddRange(listBox1.Items);
        }

        private void button3_Click(object sender, EventArgs e) {
            if (!listBox1.Items.Contains(listBox2.SelectedItem))
                listBox1.Items.Add(listBox2.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e) {
            if (!listBox1.Items.Contains(listBox2.Items))
                listBox1.Items.AddRange(listBox2.Items);
        }

        private void button6_Click(object sender, EventArgs e) {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button7_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e) {
            listBox1.Sorted = true;
            listBox2.Sorted = true;
        }
    }
}
