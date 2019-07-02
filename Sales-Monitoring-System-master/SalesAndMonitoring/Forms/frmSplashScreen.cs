/*--------------------------------------------------------------------------------------------------------------*/
// PROGRAMMER: WINSTON L. GUBANTES
// REFERENCES: VISUAL C# PROGRAMMING BY: BARBARA DOYLE
//             VISUAL BASIC .NET HOW TO PROGRAM BY: DEITEL & TIM R. NIETO
//
// PURPOSE:    SAMPLE OF SPLASH SCREEN
// LANGUAGE:   C# .NET
/*--------------------------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesAndMonitoring
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();

            //THE EFFECTS STARTS HERE
            this.CenterToScreen();
            this.Opacity = .01;
            tmrFader.Interval = 40;
            tmrFader.Enabled = true;
        }

        private void tmrFader_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + .01;
            if (this.Opacity == 1)
            {
                tmrFader.Enabled = false;
                Visible = false;
                Close();
            }
        }
    }
}