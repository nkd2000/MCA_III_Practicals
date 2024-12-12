using System;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program16 : Form {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program16());
        }
        public Program16() => InitializeComponent();

        private void ChechRight(object sender, MouseEventArgs e) {
            if ((radioButton1.Checked || radioButton2.Checked) && radioButton3.Checked) {
                checkBox2.Checked = true;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
            else if ((radioButton1.Checked || radioButton2.Checked) && radioButton4.Checked) {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else if ((radioButton1.Checked || radioButton2.Checked) && radioButton5.Checked) {
                checkBox3.Checked = true;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }
        }

        private void Program16_Load(object sender, EventArgs e) {
            
        }
    }
}
