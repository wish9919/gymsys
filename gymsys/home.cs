using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class home : MetroFramework.Forms.MetroForm
    {
        public bool loggedIn { get; set;}
        public home()
        {
            InitializeComponent();
            loggedIn = false;
        }

        private void home_Load(object sender, EventArgs e)
        {
           
        }

        private void home_Activated(object sender, EventArgs e)
        {
            if (loggedIn == false)
            {
                //open login form
                login check = new login();
                check.ShowDialog();

                if (check.loginflag == false)
                {
                    MessageBox.Show("Login Failed!");
                }
                else
                {
                    loggedIn = true;
                }
            }

          
        }

        private void member_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World");
            memberPortal check = new memberPortal();
            check.ShowDialog();
        }
    }
}
