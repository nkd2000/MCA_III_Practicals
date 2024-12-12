using System;
using System.Globalization;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program14 : Form {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program14());
        }
        public Program14() => InitializeComponent();

        private void Program14_Load(object sender, EventArgs e) {}

        private void clear_form_Click(object sender, EventArgs e) {
            mark_301.Clear();
            mark_303.Clear();
            mark_302.Clear();
            mark_304.Clear();
            mark_306.Clear();
            mark_305.Clear();
            std_name.Clear();
            std_grade.Clear();
            std_percentage.Clear();
            std_total_marks.Clear();
        }

        private void show_result_Click(object sender, EventArgs e) {
            float totalMarks = float.Parse(mark_301.Text)+ float.Parse(mark_302.Text)+ float.Parse(mark_303.Text) + float.Parse(mark_304.Text)+ float.Parse(mark_305.Text) + float.Parse(mark_306.Text);
            float percent = totalMarks * 100 / 600;
            char grade = ' ';
            if (percent < 33)
                grade = 'F';
            else if (percent >= 33 && percent < 50)
                grade = 'C';
            else if (percent >= 50 && percent < 60)
                grade = 'B';
            else if (percent >= 60 && percent <= 100)
                grade = 'A';

            if (std_name.Text.Length < 3) {
                MessageBox.Show("Enter student name", "Program 14", MessageBoxButtons.OK);
            }
            else {
                std_total_marks.Text = totalMarks.ToString();
                std_percentage.Text = percent.ToString("F",CultureInfo.InvariantCulture)+"%";
                std_grade.Text = grade.ToString();
            }
        }

        private void exit_form_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
