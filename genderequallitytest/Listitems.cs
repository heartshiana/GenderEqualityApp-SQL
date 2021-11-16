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
    public partial class Listitems : UserControl
    {

        SqlConnection con = new SqlConnection("Data Source = LAPTOP-JCHQ9QRE; Initial Catalog = userReports; Integrated Security = true");

        public Listitems()
        {
            InitializeComponent();
        }

        #region
        private string _title;
        private string _message;

        public string Title
        {
            get { return _title; }
            set { _title = value; label1.Text = value; }
        }
        public string message
        {
            get { return _message; }
            set { _message = value; label2.Text = value; }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from reportsOfUser", con);
            myReader = myCommand.ExecuteReader();

            do
            {
                while (myReader.Read())
                {
                    
                    label1.Text = myReader["Username"].ToString();
                    label2.Text = myReader["Experiences"].ToString();

                }
            } while (myReader.Read());
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
