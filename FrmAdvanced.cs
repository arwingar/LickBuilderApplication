using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* icon downloaded from https://www.flaticon.com/free-icons/music */
/* background image from https://www.freepik.com/free-vector/musical-notes-pattern-black-background_15245884.htm */
/* images from https://vicfirth.zildjian.com/education/40-essential-rudiments.html */

namespace LickBuilder
{
    public partial class FrmAdvanced : Form
    {
        public FrmAdvanced()
        {
            InitializeComponent();
        }

        private void FrmAdvanced_Load(object sender, EventArgs e)
        {

        }

        /* list of rudiments pictured obtained with the following queries
         * 
         * create table medium_hard as 
	            select rudiment_id, name, tempo 
	            from unnested 
	            where diff=3;
         * select* from medium_hard order by tempo;
        */
    }
}
