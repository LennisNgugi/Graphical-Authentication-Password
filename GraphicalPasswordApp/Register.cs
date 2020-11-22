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
    public partial class Register : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lennis\Desktop\Pardeep Project\GraphicalPasswordApp\GraphicalPasswordApp\Login.mdf;Integrated Security=True;Connect Timeout=30");

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button1.Image + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Login Saved");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button1.Image + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Account Created");
            Close();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button15.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button14.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button13.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button12.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button16.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button3.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button4.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button5.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button6.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button2.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button8.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button9.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button10.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button11.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login Values ('" + textBox1.Text + "','" + button7.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
