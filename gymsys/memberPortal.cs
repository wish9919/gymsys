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
    public partial class memberPortal : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\gymsysdb.mdf;Integrated Security=True");

       
     
      
        public memberPortal()
        {
            InitializeComponent();
            
        }

        private void memberPortal_Load(object sender, EventArgs e)
        {
            string sqlText = "SELECT * FROM members";
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlText, con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //direct method
                memberData.DataSource = dtbl;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            addMember check = new addMember();
            check.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    
    }
}
