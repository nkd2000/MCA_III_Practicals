using System;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program19 : Form {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program19());
        }
        public Program19() => InitializeComponent();

        private void timer1_Tick(object sender, EventArgs e) => label1.Text = DateTime.Now.ToString("hh:mm:ss tt");

        private void button1_Click(object sender, EventArgs e) => timer1.Start();

        private void button2_Click(object sender, EventArgs e) => timer1.Stop();

        private void button3_Click(object sender, EventArgs e) {
            timer1.Stop();
            label1.Text = "00 : 00 : 00";
        }
    }
}
