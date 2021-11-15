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

namespace genderequallitytest
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-JCHQ9QRE; Initial Catalog = userReports; Integrated Security = true");
     

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO reportsOfUser (Username, Experience) VALUES(@Username, @Experience);", con); 

            cmd.Parameters.AddWithValue("Username", textBox1.Text);
            cmd.Parameters.AddWithValue("Experience", richTextBox1.Text);

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM reportsOfUser", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            // here is the showing of the database
            dataGridView1.DataSource = dtbl;
            
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            con.Close();

            MessageBox.Show("Sent in database");


        }
    }
}
