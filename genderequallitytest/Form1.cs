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
            
           
            /* SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT * FROM reportsOfUser", con);
           myReader  = myCommand.ExecuteReader();
            do
            {
                while (myReader.Read())
                {
                    linkLabel1.Text = myReader["title"].ToString();
                    label1.Text = myReader["authorName"].ToString();
                    label2.Text = myReader["datePublished"].ToString();

                }
            } while (myReader.Read()); */

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void populateItem()
        {
            Listitems[] listItems = new Listitems[20];
            for (int i = 0; i < listItems.Length; i++){
                listItems[i] = new Listitems();
                listItems[i].Title = "Get your data";
                listItems[i].message = "Any data source";
                if (flowLayoutPanel1.Controls.Count > 0) {
                    flowLayoutPanel1.Controls.Clear();
                }
                else {
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                }
            } 

        }

        private void listitems1_Load(object sender, EventArgs e)
        {

        }

        private void listitems2_Load(object sender, EventArgs e)
        {

        }
    }
}
