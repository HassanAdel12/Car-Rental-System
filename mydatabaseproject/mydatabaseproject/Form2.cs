using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-M1LCTLT\\ROOT;Initial Catalog=projectdatabase;Integrated Security=True";

        private void button2_Click(object sender, EventArgs e)
        {
            //add employee
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {

                    string q = "insert into employees(name,[National number],salary,password,[address work],[city work])values('" + name.Text.ToString() + "','" + national.Text.ToString() + "','" + salary.Text.ToString() + "','" + password.Text.ToString() + "','" + address.Text.ToString() + "','" + city.Text.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee has been Inserted");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert is not complet" + ex);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-M1LCTLT\\ROOT;Initial Catalog=projectdatabase;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("update employees SET name='" + name.Text + "',salary='" + salary.Text + "',password='" + password.Text + "',[address work]='" + address.Text + "',[city work]='" + city.Text + "'WHERE [National number]='" + national.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                MessageBox.Show(" Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update  is not complet" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-M1LCTLT\\ROOT;Initial Catalog=projectdatabase;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("delete FROM employees WHERE  [National number]='" + national.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("employee has been deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete  is not complet" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //show emploees
            dataGridView1.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M1LCTLT\\ROOT;Initial Catalog=projectdatabase;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * FROM employees ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item["name"];
                dataGridView1.Rows[n].Cells[1].Value = item["National number"];
                dataGridView1.Rows[n].Cells[2].Value = item["Salary"];
                dataGridView1.Rows[n].Cells[3].Value = item["password"];
                dataGridView1.Rows[n].Cells[4].Value = item["address work"];
                dataGridView1.Rows[n].Cells[5].Value = item["city work"];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
