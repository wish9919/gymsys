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
using System.Data.Sql;

namespace WindowsFormsApplication1
{
    public partial class register : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\gymsysdb.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        

        public register()
        {
            InitializeComponent();

        }

    

        private void register_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


     

       

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string fullname = fullnameTxt.Text;
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            string cpassword = cpasswordTxt.Text;

            string sqlText = "INSERT INTO users (username, password, name, email) VALUES ('" + username + "', '" + password + "', '" + fullname + "', '" + email + "')";
            if (username != "" & fullname != "" & email != "" & password != "" & !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(password) && password.Equals(cpassword))
            {
                con.Open();

                cmd.CommandText = sqlText;
                cmd.ExecuteNonQuery();
                cmd.Clone();
                DialogResult d;
                d = MessageBox.Show("Proceed?", "Confirm", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Insert failed or passsword mismatch!");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
