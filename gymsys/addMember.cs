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
    public partial class addMember : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\gymsysdb.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public addMember()
        {
            InitializeComponent();
        }

        private void addMember_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string nic = nicTxt.Text;
            string name = nameTxt.Text;
            string gender = genderTxt.Text;
            string email = emailTxt.Text;
            string mobile = mobileTxt.Text;
            string dateBirth = dateBirthTxt.Value.Date.ToString("yyyy/MM/dd");
            string address = addressTxt.Text;
            string joinedDate = joinedDateTxt.Value.Date.ToString("yyyy/MM/dd");
            string weight = weightTxt.Text;
            string height = heightTxt.Text;

            string sqlText = "INSERT INTO members (nic, name, gender, email, mobile, dateBirth, address, joinedDate, weight, height) VALUES ('" + nic + "', '" + name + "', '" + gender + "', '" + email + "', '" + mobile + "', '" + dateBirth + "', '" + address + "', '" + joinedDate + "', '" + weight + "', '" + height + "')";

            if (nic != "" & name != "" & gender != "" & email != "" & mobile != "" & dateBirth != "" & address != "" & joinedDate != "" & weight != "" & height != "")
            {
                con.Open();
                cmd.CommandText = sqlText;
                cmd.ExecuteNonQuery();
                cmd.Clone();
                MessageBox.Show("Data Added Successfully!");
                con.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("All fields are required!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            memberPortal check = new memberPortal();
            check.ShowDialog();
        }
    }
}
