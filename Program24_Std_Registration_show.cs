using System;
using System.IO;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program24_Std_Registration_show : Form {
        public Program24_Std_Registration_show() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            new Program24_Std_Registration().Show();
            this.Close();
        }

        private void Program24_Std_Registration_show_Load(object sender, EventArgs e) {
            textBox1.ReadOnly = true;
            string fname = "StudenRegistration.txt";
            
            if (!File.Exists(fname)) {
                textBox1.Text = "Do data available";
            }
            using (StreamReader reader = new StreamReader(fname)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    textBox1.AppendText(line + Environment.NewLine);
                }
            }
        }
    }
}
