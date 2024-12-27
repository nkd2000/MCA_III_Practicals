using System;
using System.Drawing;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program21 : Form {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program21());
        }
        public Program21() => InitializeComponent();

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) {
            label1.BackColor = Color.FromArgb((int)(vScrollBar1.Value * 255 / vScrollBar1.Maximum), Color.Red);
            label2.Text = $"Color : Red ({(vScrollBar1.Value * (255/91)) *100 /182})%";
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e) {
            label1.BackColor = Color.FromArgb((int)(vScrollBar2.Value * 255 / vScrollBar2.Maximum), Color.Green);
            label2.Text = $"Color : Green ({(vScrollBar2.Value * (255 / 91)) * 100 / 182})%";
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e) {
            label1.BackColor = Color.FromArgb((int)(vScrollBar3.Value * 255 / vScrollBar3.Maximum), Color.Blue);
            label2.Text = $"Color : Blue ({(vScrollBar3.Value * (255 / 91)) * 100 / 182})%";
        }

        private void Program21_Load(object sender, EventArgs e) {
        }
    }
}
