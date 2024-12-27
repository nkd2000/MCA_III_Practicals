using System;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Program22 : Form {
        string currentPlayer = "X";
        int counter = 0;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program22());
        }
        public Program22() {
            InitializeComponent();
        }

        private void Program22_Load(object sender, EventArgs e) {
            StartGame();
        }

        private void CheckWin(object sender, EventArgs e) {
            System.Windows.Forms.Label clickEdLabel = (System.Windows.Forms.Label)sender;
            if(counter != 9) {
                if (clickEdLabel.Text == "") {
                    clickEdLabel.Text = currentPlayer;
                    counter += 1;
                }
                
                if (IsWinner(clickEdLabel)) {
                    MessageBox.Show($"{currentPlayer} is winner");
                    panel1.Enabled = false;
                    button1.Show();
                }
                else {
                    if(counter%2 == 0) {
                        currentPlayer = "X";
                    }
                    else {
                        currentPlayer = "O";
                    }
                }
            }
            if(counter == 9){
                MessageBox.Show("Game is Draw ");
                panel1.Enabled = false;
                button1.Show();
            }
        }
        public bool IsWinner(Control player) {
            if (counter < 3) return false;

            if(player.Text == label1.Text && player.Text == label2.Text && player.Text == label3.Text) {
                return true;
            }else if(player.Text == label1.Text && player.Text == label4.Text && player.Text == label7.Text) {
                return true;
            }else if(player.Text == label1.Text && player.Text == label5.Text && player.Text == label9.Text) {
                return true;
            }else if(player.Text == label2.Text && player.Text == label5.Text && player.Text == label8.Text) {
                return true;
            }else if(player.Text == label3.Text && player.Text == label6.Text && player.Text == label9.Text) {
                return true;
            }else if(player.Text == label4.Text && player.Text == label5.Text && player.Text == label6.Text) {
                return true;
            }else if(player.Text == label5.Text && player.Text == label3.Text && player.Text == label7.Text) {
                return true;
            }else if(player.Text == label7.Text && player.Text == label8.Text && player.Text == label9.Text) {
                return true;
            }
            else {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            StartGame();
        }
        public void StartGame() {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            counter = 0;
            currentPlayer = "X";
            panel1.Enabled = true;
            button1.Hide();
        }
    }
}
