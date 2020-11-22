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

namespace GraphicalPasswordApp
{
    public partial class Start : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lennis\Desktop\Pardeep Project\GraphicalPasswordApp\GraphicalPasswordApp\Login.mdf;Integrated Security=True;Connect Timeout=30");

        public Start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login rg = new Login();
            rg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sqlcon.Open();
            //SqlCommand cmd = sqlcon.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            ////cmd.CommandText = "insert into login Values ('" + textBox1.Text +"')";
            //cmd.ExecuteNonQuery();
            //sqlcon.Close();
            //MessageBox.Show("Login Saved");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            //Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login rg = new Login();
            rg.Show();
            //Close();
        }
    }

       
}

