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

namespace WindowsFormsApplication1
{
    public partial class login : MetroFramework.Forms.MetroForm
    {
        public bool loginflag { get; set; }
        public login()
        {
            InitializeComponent();
            loginflag = false;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void loginFunc()
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\gymsysdb.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM users WHERE username='" + username + "' AND password='" + password + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {

                loginflag = true;
            }
            else
            {
                loginflag = false;
            }

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginFunc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void usernameTxt_Click(object sender, EventArgs e)
        {

        }

        
        private void passwordTxt_Click(object sender, EventArgs e)
        {

        }

        private void login_Enter(object sender, EventArgs e)
        {
           
        }                       

        private void button2_Enter(object sender, EventArgs e)
        {
       
        }

        private void passwordTxt_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = button2;
        }

       
    }
}
