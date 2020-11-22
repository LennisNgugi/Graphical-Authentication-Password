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
    public partial class Login4 : Form
    {
        public Login4()
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
                MessageBox.Show("please enter correct email address and choosen image pattern", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Main rg = new Main();
            rg.Show();
            MessageBox.Show("You've succussfully logged in");
            Close();
        }
    }
}
