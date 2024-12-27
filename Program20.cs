using System;
using System.Drawing;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program20 : Form {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program20());
        }
        public Program20() => InitializeComponent();

        private void Program20_Load(object sender, EventArgs e) {}
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e) {
            label1.BackColor = Color.FromArgb((int)(hScrollBar1.Value * 255/91), Color.Red);
            label4.Text = $"Opacity :{(int)(hScrollBar1.Value * 255 / 91)}";
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e) {
            label2.BackColor = Color.FromArgb((int)(hScrollBar2.Value * 255/91), Color.Green);
            label5.Text = $"Opacity :{(int)(hScrollBar2.Value * 255/91)}";
        }
        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e) {
            label3.BackColor = Color.FromArgb((int)(hScrollBar3.Value * 255/91), Color.Blue);
            label6.Text = $"Opacity :{(int)(hScrollBar3.Value * 255 / 91)}";
        }
    }
}
