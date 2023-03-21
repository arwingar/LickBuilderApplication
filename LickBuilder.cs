using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* icon downloaded from https://www.flaticon.com/free-icons/music 
   background image from https://www.freepik.com/free-vector/music-equalizer-technology-black-background-with-white-digital-sound-wave_16406826.htm
*/


namespace LickBuilder
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            GettingStarted GettingStartedDialog = new GettingStarted();
            GettingStartedDialog.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (CloseCancel() == true)
            {
                this.Close();
            };
        }

        public static bool CloseCancel()
        {
            const string message = "Close the LickBuilder program?";
            const string caption = "Are you sure?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
    }
}
