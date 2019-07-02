/*--------------------------------------------------------------------------------------------------------------*/
// PROGRAMMER: WINSTON L. GUBANTES
// REFERENCES: VISUAL C# PROGRAMMING BY: BARBARA DOYLE
//             VISUAL BASIC .NET HOW TO PROGRAM BY: DEITEL & TIM R. NIETO
// PURPOSE: SAMPLE LOGIN SYSTEM FOR C#
// LANGUAGE: C# .NET
/*--------------------------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesAndMonitoring.Database;

namespace SalesAndMonitoring
{
    public partial class frmLogin : Form
    {
        private string User = "";
        private bool isvalid = false;
        private string[] privileges;

        public string[] Privileges
        {
            get { return privileges; }
        }

        public string getUser
        {
            get { return User; }
        }

        public bool isValid
        {
            get { return isvalid; }
        }

        //Use to validate user login entry
        private void sValidate()
        {
            var user =
                BusinessAccessLayer.GetEntity().User_tbl.Where(
                    e => e.UserID == txtUsername.Text && e.Password == txtPassword.Text);


            if(user.Count() >0)
            {
                isvalid = true;
                User = txtUsername.Text;
                Close();
                return;
            }

            MessageBox.Show("Invalid username or password", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //---------------------------------------------//

        //Constructor()
        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No) { return; }
            Application.Exit();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            sValidate();
        
        }

    }
}