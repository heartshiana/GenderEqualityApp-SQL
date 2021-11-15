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



namespace gender_equality___teest
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public ListView lv;

        public Form2()
        {
            InitializeComponent();
            instance = this;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

         private void add(string name, string exp)
        {
            String[] row = { name, exp };
            ListViewItem items = new ListViewItem(row);

            ListViewItem item = new ListViewItem(row);

            listView1.Items.Add(item);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userReport = textBox1.Text;
            string reportDetails = richTextBox1.Text;

            bool allPopulated = userReport != string.Empty && reportDetails != string.Empty;

            if (allPopulated)
            {
                add(userReport, reportDetails);
            /*    string connectionString = "Data sourcce = (localdb)\\MSSQLLocalDB; Initial Catalog = userReports, Integrated Security = true";
                SqlConnection connection = new SqlConnection(connectionString);
                string queryString = "INSERT INTO reportOfUser VALUES (@Username, @Experiences)";

                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@Username";
                param1.Value = userReport;

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@Experiences";
                param2.Value = reportDetails;

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(param1);
                command.Parameters.Add(param2);

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Thank you for your feedback", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information); */

               
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            // add columns
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Experiences", 150);

        }
       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            String name = listView1.SelectedItems[0].SubItems[0].Text;
            String experiences = listView1.SelectedItems[0].SubItems[1].Text;
           
            //

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            

        }

        private void listView1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                e.ItemHeight = (int)e.Graphics.MeasureString(listView1.Items[1].ToString(), listView1.Font, listView1.Width).Height;
            };
        }
    }
}
