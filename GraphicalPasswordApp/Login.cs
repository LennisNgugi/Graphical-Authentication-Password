using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalPasswordApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lennis\Desktop\Pardeep Project\GraphicalPasswordApp\GraphicalPasswordApp\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where email_address ='" + textBox1.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main mm = new Main();
                mm.Show();
            }
            else
            {
                MessageBox.Show("Please enter correct email address and choosen image pattern", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Login1 rg = new Login1();
            rg.Show();
            Close();
        }
    }
}
