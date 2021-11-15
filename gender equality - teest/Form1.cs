using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gender_equality___teest
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public RichTextBox rbt1;
        public TextBox tb1;

        public Form1()
        {
            InitializeComponent();
            instance = this;
            rbt1 = richTextBox1;
            tb1 = textBox1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userReport = textBox1.Text;
            string reportDetails = richTextBox1.Text;

            bool allPopulated = userReport != string.Empty && reportDetails != string.Empty;

            if (allPopulated)
            {

                // Set up connection to the database
                // string connectionstring = "Database source = (localdb) = ; Integrated Security = true"
                // SQLconnection connection = new SQLconnection(connectionString);
                // connection.Open();
                // string querystring = "INSERT INTO _______ VALUES

                // SqlParameter param1 = new SqlParameter();
                // param1.ParameterName = "@";
                // param1.Value = __String;

                // SqlCommand command = new SqlCommand(querystring, connection);
                // command.Parameters.Add(param1);
                // command ExecuteNonQuery{};
                // connection.Close();
                // MessageBox.Show("Report is sent", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                

            }
            else
            {
                MessageBox.Show("Please fill out the fields.", "Incomplete Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
