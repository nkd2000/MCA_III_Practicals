using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MCA_III_Practicals {
    public partial class Programm27 : Form {
        SqlCommand cmd;
        SqlConnection conn;
        string query;
        string connStr;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Programm27());
        }
        public Programm27() {
            InitializeComponent();
        }

        private void Programm27_Load(object sender, EventArgs e) {
            dataGridView1.Hide();
            button2.Enabled = false;
            connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=nkd;Integrated Security=True";
            conn = new SqlConnection(connStr);

        }
        private void button1_Click(object sender, EventArgs e) {
            if(textBox2.Text != "" && textBox1.Text != "") {
                query = "Insert into [student]([id],[course],[dob],[addr]) " +
                    "values(@id,@course,@dob,@addr)";
                
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", textBox2.Text);
                cmd.Parameters.AddWithValue("@course",(radioButton1.Checked==true)?"MCA":"MSC IT");
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("addr", textBox1.Text);

                if(conn.State == ConnectionState.Closed) {
                    conn.Open();
                }
                try {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Record saved.");

                }catch(Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            query = $"delete from [student] where [id] = {textBox2.Text}";
            cmd = new SqlCommand(query, conn);
            if(conn.State == ConnectionState.Closed) {
                conn.Open();
            }
            try {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Student record {textBox2.Text} is deleted.");
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                
            }catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            query = $"select * from [student] where [id] = {textBox2.Text}";
            cmd = new SqlCommand(query, conn);
            if(conn.State == ConnectionState.Closed) {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if(dt.Rows.Count == 0) {
                MessageBox.Show("No student found.");
                conn.Close();
                return;
            }
            if (dt.Rows[0].ItemArray[1].ToString() != "MCA") { radioButton2.Checked = true; }
            else { radioButton1.Checked = true; }

            string date = dt.Rows[0].ItemArray[2].ToString();
            dateTimePicker1.Value = DateTime.Parse(date);
            textBox1.Text = dt.Rows[0].ItemArray[3].ToString();

            conn.Close();
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e) {
            button2.Enabled = false;
            dataGridView1.Show();
            query = $"select * from [student]";
            cmd = new SqlCommand(query, conn);
            if (conn.State == ConnectionState.Closed) {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(); 
            da.SelectCommand = cmd;
            
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            dataGridView1.DataSource = ds.Tables["student"];
            conn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) => radioButton2.Checked = false;

        private void radioButton2_CheckedChanged(object sender, EventArgs e) => radioButton1.Checked = false;
    }
}
