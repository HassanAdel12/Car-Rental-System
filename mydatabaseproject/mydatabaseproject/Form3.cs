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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-M1LCTLT\\ROOT;Initial Catalog=projectdatabase;Integrated Security=True";

        private void Form3_Load(object sender, EventArgs e)
        {
            int num = new Random().Next(1000, 9999);
            numper.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date;
            date = dateTimePicker1.Text;
            string s = comboBox2.Text;
            string ss = comboBox3.Text;
            if (s == "Convertiable")
            {

                switch (ss)
                {
                    case "1":
                        textBox1.Text = "1000"; 
                        break;
                    case "2":
                        textBox1.Text = "1100"; 
                        break;
                    case "3":
                        textBox1.Text = "1200";
                        break;
                    case "4":
                        textBox1.Text = "1300";
                        break;
                    case "5":
                        textBox1.Text = "1400";
                        break;
                    case "6":
                        textBox1.Text = "1500";
                        break;
                    case "7":
                        textBox1.Text = "1600";
                        break;
                    default:
                        textBox1.Text = "1050"; 
                        break;
                }
            }
            if (s == "Couple")
            {
                switch (ss)
                {
                    case "1":
                        textBox1.Text = "1200";
                        break;
                    case "2":
                        textBox1.Text = "1300";
                        break;
                    case "3":
                        textBox1.Text = "1400";
                        break;
                    case "4":
                        textBox1.Text = "1500";
                        break;
                    case "5":
                        textBox1.Text = "1600";
                        break;
                    case "6":
                        textBox1.Text = "1700";
                        break;
                    case "7":
                        textBox1.Text = "1800";
                        break;
                    default:
                        textBox1.Text = "1250";
                        break;
                }
            }
            if (s == "crossover")
            {
                switch (ss)
                {
                    case "1":
                        textBox1.Text = "1500";
                        break;
                    case "2":
                        textBox1.Text = "1600";
                        break;
                    case "3":
                        textBox1.Text = "1700";
                        break;
                    case "4":
                        textBox1.Text = "1800";
                        break;
                    case "5":
                        textBox1.Text = "1900";
                        break;
                    case "6":
                        textBox1.Text = "2100";
                        break;
                    case "7":
                        textBox1.Text = "2200";
                        break;
                    default:
                        textBox1.Text = "1550";
                        break;
                }
            }
            if (s == "Diesel")
            {
                switch (ss)
                {
                    case "1":
                        textBox1.Text = "900";
                        break;
                    case "2":
                        textBox1.Text = "1000";
                        break;
                    case "3":
                        textBox1.Text = "1100";
                        break;
                    case "4":
                        textBox1.Text = "1200";
                        break;
                    case "5":
                        textBox1.Text = "1300";
                        break;
                    case "6":
                        textBox1.Text = "1400";
                        break;
                    case "7":
                        textBox1.Text = "1500";
                        break;
                    default:
                        textBox1.Text = "950";
                        break;
                }
            }
            if (s == "hybrid")
            {
                switch (ss)
                {
                    case "1":
                        textBox1.Text = "1300";
                        break;
                    case "2":
                        textBox1.Text = "1350";
                        break;
                    case "3":
                        textBox1.Text = "1500";
                        break;
                    case "4":
                        textBox1.Text = "1600";
                        break;
                    case "5":
                        textBox1.Text = "1700";
                        break;
                    case "6":
                        textBox1.Text = "1800";
                        break;
                    case "7":
                        textBox1.Text = "1900";
                        break;
                    default:
                        textBox1.Text = "1400";
                        break;
                }
            }
            if (s == "Sedan")
            {
                switch (ss)
                {
                    case "1":
                        textBox1.Text = "1600";
                        break;
                    case "2":
                        textBox1.Text = "1700";
                        break;
                    case "3":
                        textBox1.Text = "1800";
                        break;
                    case "4":
                        textBox1.Text = "1900";
                        break;
                    case "5":
                        textBox1.Text = "2000";
                        break;
                    case "6":
                        textBox1.Text = "2100";
                        break;
                    case "7":
                        textBox1.Text = "2200";
                        break;
                    default:
                        textBox1.Text = "1660";
                        break;
                }
            }
            if (s == "Sports Car")
            {
                switch (ss)
                {
                    case "1":
                        textBox1.Text = "1200";
                        break;
                    case "2":
                        textBox1.Text = "1210";
                        break;
                    case "3":
                        textBox1.Text = "1310";
                        break;
                    case "4":
                        textBox1.Text = "1400";
                        break;
                    case "5":
                        textBox1.Text = "1500";
                        break;
                    case "6":
                        textBox1.Text = "1600";
                        break;
                    case "7":
                        textBox1.Text = "1700";
                        break;
                    default:
                        textBox1.Text = "1250";
                        break;
                }
            }
            if (s == "SUV")
            {
                switch (ss)
                {
                    case "1":
                        textBox1.Text = "2000";
                        break;
                    case "2":
                        textBox1.Text = "2110";
                        break;
                    case "3":
                        textBox1.Text = "2210";
                        break;
                    case "4":
                        textBox1.Text = "2300";
                        break;
                    case "5":
                        textBox1.Text = "2500";
                        break;
                    case "6":
                        textBox1.Text = "2600";
                        break;
                    case "7":
                        textBox1.Text = "2800";
                        break;
                    default:
                        textBox1.Text = "2050";
                        break;
                }
            }
            if (s == "Truck")
            {
                switch (ss)
                {
                    case "1":
                        textBox1.Text = "2100";
                        break;
                    case "2":
                        textBox1.Text = "2210";
                        break;
                    case "3":
                        textBox1.Text = "2310";
                        break;
                    case "4":
                        textBox1.Text = "2400";
                        break;
                    case "5":
                        textBox1.Text = "2500";
                        break;
                    case "6":
                        textBox1.Text = "2600";
                        break;
                    case "7":
                        textBox1.Text = "2800";
                        break;
                    default:
                        textBox1.Text = "2150";
                        break;
                }
            }
            if (s == "VAN")
            {
                switch (ss)
                {
                    case "1":
                        textBox1.Text = "2100";
                        break;
                    case "2":
                        textBox1.Text = "2210";
                        break;
                    case "3":
                        textBox1.Text = "2310";
                        break;
                    case "4":
                        textBox1.Text = "2400";
                        break;
                    case "5":
                        textBox1.Text = "2500";
                        break;
                    case "6":
                        textBox1.Text = "2600";
                        break;
                    case "7":
                        textBox1.Text = "2800";
                        break;
                    default:
                        textBox1.Text = "2150";
                        break;
                }
            }
            if (s == "Wagon")
            {
                switch (ss)
                {
                    case "1":
                        textBox1.Text = "2300";
                        break;
                    case "2":
                        textBox1.Text = "2410";
                        break;
                    case "3":
                        textBox1.Text = "2510";
                        break;
                    case "4":
                        textBox1.Text = "2600";
                        break;
                    case "5":
                        textBox1.Text = "2700";
                        break;
                    case "6":
                        textBox1.Text = "2800";
                        break;
                    case "7":
                        textBox1.Text = "2900";
                        break;
                    default:
                        textBox1.Text = "2350";
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    int x = Convert.ToInt32(phone.Text);
                    string q = "insert into car_info(license_numper,type,color,rental_price)values('" + numper.Text.ToString() + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "')";
                    string q2 = "insert into reservation(date_needed,dayes_needed)values('" + dateTimePicker1.Text.ToString() + "','" + comboBox3.Text + "')";
                    string q3 = "insert into customer(Name,address,phonenumper)values('" + name.Text.ToString() + "','" + address.Text + "','" + phone.Text + "')";
                     

                    SqlCommand cmd = new SqlCommand(q,con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand(q2, con);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(q3, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert is not complet" + ex);

            }
        }
    }
}
