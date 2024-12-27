using System;
using System.IO;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program24_Std_Registration : Form {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program24_Std_Registration());
        }
        public Program24_Std_Registration() {
            InitializeComponent();
        }

        private void Program24_Std_Registration_Load(object sender, EventArgs e) {
            label6.Text = string.Empty;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            comboBox1.Items.AddRange(new string[] { "MCA", "MSC IT" });
            comboBox1.SelectedItem = "MCA";
        }

        private void button1_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) ) {
                label6.Text = "All fields are mendedary";
                return;
            }
            
            string fname = "StudenRegistration.txt";
            if (!File.Exists(fname)) {
                using (File.Create(fname)) {
                    label6.Text = $"file {fname} is created successfully";
                }
                using(StreamWriter writer = new StreamWriter(fname)) {
                    writer.WriteLine($"\n{"Reg no",-6} | {"Name",-20} | {"Mobile number",-15} | {"Class",-10} | {"Address",-20}");
                    for(int i=0; i< 79; i++) { writer.Write("-"); }
                    writer.WriteLine();
                }
            }
            string regId = (textBox1.TextLength * textBox2.TextLength * textBox3.TextLength).ToString();
            string record = $"{regId,-6} | {textBox1.Text,-20} | {textBox2.Text,-15} | {comboBox1.SelectedItem,-10} | {textBox3.Text,-20}";
            using (StreamWriter writer = new StreamWriter(fname, append: true)) {
                writer.WriteLine(record);
                label6.Text = $"Student Registration complete. Registration number is {regId}";
            }

        }

        private void button3_Click(object sender, EventArgs e) {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedItem = null;
            label6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) {
            new Program24_Std_Registration_show().Show();
            this.Hide();

        }
    }
}
