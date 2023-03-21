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
    public partial class FrmEasy : Form
    {
        public FrmEasy()
        {
            InitializeComponent();
        }

        private void FrmEasy_Load(object sender, EventArgs e)
        {

        }

        /* list of rudiments pictured obtained with the following queries
         * 
         * create table unnested as 
	            select rudiment_id, name, unnest(tempi) as tempo, unnest(difficulties) as diff, rhythm_id, category 
	            from rudiments;
         * create table easy as 
	            select rudiment_id, name, tempo 
	            from unnested 
	            where diff=1;
         * select * from easy order by tempo;
         * select distinct name from easy;
         */
    }
}
