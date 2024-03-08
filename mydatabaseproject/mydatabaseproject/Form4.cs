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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-M1LCTLT\\ROOT;Initial Catalog=projectdatabase;Integrated Security=True";

        private void Form4_Load(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M1LCTLT\\ROOT;Initial Catalog=projectdatabase;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select c.Name,c.address,c.phonenumper,r.date_needed, r.dayes_needed,i.license_numper,i.type,i.color,i.rental_price from customer c inner join reservation r on c.ID = r.ID inner join car_info i on r.ID = i.ID ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item["name"];
                dataGridView1.Rows[n].Cells[1].Value = item["address"];
                dataGridView1.Rows[n].Cells[2].Value = item["phonenumper"];
                dataGridView1.Rows[n].Cells[3].Value = item["date_needed"];
                dataGridView1.Rows[n].Cells[4].Value = item["dayes_needed"];
                dataGridView1.Rows[n].Cells[5].Value = item["license_numper"];
                dataGridView1.Rows[n].Cells[6].Value = item["type"];
                dataGridView1.Rows[n].Cells[7].Value = item["color"];
                dataGridView1.Rows[n].Cells[8].Value = item["rental_price"];
            }
        }
    }
}
