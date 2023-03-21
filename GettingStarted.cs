using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* icon downloaded from https://www.flaticon.com/free-icons/music */
/* background image from https://www.freepik.com/free-vector/music-equalizer-technology-black-background-with-white-digital-sound-wave_16406826.htm */
/* images from https://vicfirth.zildjian.com/education/40-essential-rudiments.html */

namespace LickBuilder
{
    public partial class GettingStarted : Form
    {
        public GettingStarted()
        {
            InitializeComponent();
        }

        

        private void GettingStarted_Load(object sender, EventArgs e)
        {

        }

        private void cmDifficulties_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmDifficulties.Text)
            {
                case "Easy":
                    MessageBox.Show("Writing an Easy level lick...");
                    /* create a list to hold the level 1 rudiments */
                    /* populated based on output of this query:
                     * create view easy_100 as 
	                        select * 
	                        from easy
	                        where tempo=100;
                     * tempo = 100 has the most rudiments associated with it
                    */
                    List<string> Easy = new List<string>();
                    /* add elements to the list */
                    Easy.Add("Multiple Bounce Roll");
                    Easy.Add("Double Stroke Roll");
                    Easy.Add("Five Stroke Roll");
                    Easy.Add("Six Stroke Roll");
                    Easy.Add("Seven Stroke Roll");
                    Easy.Add("Flam");
                    Easy.Add("Drag");
                    Easy.Add("Single Drag Tap Triplet");
                    Easy.Add("Lesson 25");
                    /* create a variable for the initial list length that won't change */
                    int easy_length = Easy.Count;

                    /* generate a random number to represent a list index */
                    Random easy_index = new Random();

                    // new form to display music
                    FrmEasyLick EasyLick = new FrmEasyLick();
                    List<PictureBox> easyPics = new List<PictureBox>();

                    // add picture boxes to array
                    easyPics.Add(EasyLick.pictureBox1);
                    easyPics.Add(EasyLick.pictureBox2);
                    easyPics.Add(EasyLick.pictureBox3);
                    easyPics.Add(EasyLick.pictureBox4);
                    easyPics.Add(EasyLick.pictureBox5);
                    easyPics.Add(EasyLick.pictureBox6);
                    easyPics.Add(EasyLick.pictureBox7);
                    easyPics.Add(EasyLick.pictureBox8);
                    easyPics.Add(EasyLick.pictureBox9);


                    // these for loops populate the picture boxes based on the random index value that is 
                    // continually generated
                    List<int> easy_unused = new List<int>();
                    for (int i=0; i<=8; i++)
                    {
                        easy_unused.Add(i);
                    }

                    /* iterate as many times as the initial list is long */
                    for (int i=0; i<easy_length; i++)
                    { 
                        int toReturn = easy_index.Next(easy_unused.Count);

                        /* generate a random number between 0 and the length of the list currently */
                        switch (easy_unused[toReturn])
                        {
                            case 0:
                                easyPics[i].Image = Properties.Resources.multiple_bounce_roll;
                                easy_unused.RemoveAt(toReturn);
                                break;
                            case 1:
                                easyPics[i].Image = Properties.Resources.double_stroke_roll;
                                easy_unused.RemoveAt(toReturn);
                                break;
                            case 2:
                                easyPics[i].Image = Properties.Resources.five_stroke_roll;
                                easy_unused.RemoveAt(toReturn);
                                break;
                            case 3:
                                easyPics[i].Image = Properties.Resources.six_stroke_roll;
                                easy_unused.RemoveAt(toReturn);
                                break;
                            case 4:
                                easyPics[i].Image = Properties.Resources.seven_stroke_roll;
                                easy_unused.RemoveAt(toReturn);
                                break;
                            case 5:
                                easyPics[i].Image = Properties.Resources.flam;
                                easy_unused.RemoveAt(toReturn);
                                break;
                            case 6:
                                easyPics[i].Image = Properties.Resources.drag;
                                easy_unused.RemoveAt(toReturn);
                                break;
                            case 7:
                                easyPics[i].Image = Properties.Resources.single_drag_tap_triplet;
                                easy_unused.RemoveAt(toReturn);
                                break;
                            case 8:
                                easyPics[i].Image = Properties.Resources.lesson_25;
                                easy_unused.RemoveAt(toReturn);
                                break;
                            default:
                                break;

                        }

                        /* remove the element and reset the index value */
                        Easy.RemoveAt(toReturn);
                        toReturn = 0;
                    }

                    // show the form that has the music printed on it
                    EasyLick.Show();

                    break;

                case "Medium":
                    MessageBox.Show("Writing a Medium level lick...");
                    /* create a list to hold the level 2 rudiments
                        populated based on output of this query:
                     * create view medium_easy_100 as 
	                        select * 
	                        from medium_easy
	                        where tempo=100;
                     * tempo = 100 has the most rudiments associated with it
                    */
                    List<string> Medium = new List<string>();
                    /* add elements to the list */
                    Medium.Add("Five Stroke Roll Triple");
                    Medium.Add("Ten Stroke Roll");
                    Medium.Add("Eleven Stroke Roll");
                    Medium.Add("Single Paradiddle");
                    Medium.Add("Double Paradiddle");
                    Medium.Add("Triple Paradiddle");
                    Medium.Add("Paradiddle Diddle");
                    Medium.Add("Flam Accent");
                    Medium.Add("Swiss Army Triplet");
                    Medium.Add("Flam Drag");
                    Medium.Add("Single Ratamacue");
                    Medium.Add("Triple Ratamacue");
                    /* create a variable for the initial list length that won't change */
                    int med_length = Medium.Count;
                    /* generate a random number to represent a list index */
                    Random med_index = new Random();

                    // new form to display music
                    FrmMediumLick MediumLick = new FrmMediumLick();
                    List<PictureBox> medPics = new List<PictureBox>();

                    // add picture boxes to array
                    medPics.Add(MediumLick.pictureBox1);
                    medPics.Add(MediumLick.pictureBox2);
                    medPics.Add(MediumLick.pictureBox3);
                    medPics.Add(MediumLick.pictureBox4);
                    medPics.Add(MediumLick.pictureBox5);
                    medPics.Add(MediumLick.pictureBox6);
                    medPics.Add(MediumLick.pictureBox7);
                    medPics.Add(MediumLick.pictureBox8);
                    medPics.Add(MediumLick.pictureBox9);
                    medPics.Add(MediumLick.pictureBox10);
                    medPics.Add(MediumLick.pictureBox11);
                    medPics.Add(MediumLick.pictureBox12);


                    // these for loops populate the picture boxes based on the random index value that is 
                    // continually generated
                    List<int> med_unused = new List<int>();
                    for (int i = 0; i <= 11; i++)
                    {
                        med_unused.Add(i);
                    }

                    /* iterate as many times as the initial list is long */
                    for (int i = 0; i < med_length; i++)
                    { 
                        int toReturn = med_index.Next(med_unused.Count);

                        /* generate a random number between 0 and the length of the list currently */
                        switch (med_unused[toReturn])
                        {
                            case 0:
                                medPics[i].Image = Properties.Resources.five_stroke_roll_triple;
                                med_unused.RemoveAt(toReturn);
                                break;
                            case 1:
                                medPics[i].Image = Properties.Resources.ten_stroke_roll;
                                med_unused.RemoveAt(toReturn);
                                break;
                            case 2:
                                medPics[i].Image = Properties.Resources.eleven_stroke_roll;
                                med_unused.RemoveAt(toReturn);
                                break;
                            case 3:
                                medPics[i].Image = Properties.Resources.single_paradiddle;
                                med_unused.RemoveAt(toReturn);
                                break;
                            case 4:
                                medPics[i].Image = Properties.Resources.double_paradiddle;
                                med_unused.RemoveAt(toReturn);
                                break;
                            case 5:
                                medPics[i].Image = Properties.Resources.triple_paradiddle;
                                med_unused.RemoveAt(toReturn);
                                break;
                            case 6:
                                medPics[i].Image = Properties.Resources.paradiddle_diddle;
                                med_unused.RemoveAt(toReturn);
                                break;
                            case 7:
                                medPics[i].Image = Properties.Resources.flam_accent;
                                med_unused.RemoveAt(toReturn);
                                break;
                            case 8:
                                medPics[i].Image = Properties.Resources.swiss_army_triplet;
                                med_unused.RemoveAt(toReturn);
                                break;
                            case 9:
                                medPics[i].Image = Properties.Resources.flam_drag;
                                med_unused.RemoveAt(toReturn);
                                break;
                            case 10:
                                medPics[i].Image = Properties.Resources.single_ratamacue;
                                med_unused.RemoveAt(toReturn);
                                break;
                            case 11:
                                medPics[i].Image = Properties.Resources.triple_ratamacue;
                                med_unused.RemoveAt(toReturn);
                                break;
                            default:
                                break;

                        }

                        /* remove the element and reset the index value */
                        Medium.RemoveAt(toReturn);
                        toReturn = 0;
                    }

                    // show the form that has the music printed on it
                    MediumLick.Show();

                    break;

                case "Advanced":
                    MessageBox.Show("Writing an Advanced level lick...");
                    /* create a list to hold the level 3 rudiments*/
                    /* populated based on output of this query:
                     * create view medium_hard_100 as 
	                        select * 
	                        from medium_hard
	                        where tempo=100;
                     * tempo = 100 has the most rudiments associated with it
                    */
                    List<string> Adv = new List<string>();
                    /* add elements to the list */
                    Adv.Add("Single Stroke Roll");
                    Adv.Add("Single Stroke Four");
                    Adv.Add("Triple Stroke Roll");
                    Adv.Add("Nine Stroke Roll");
                    Adv.Add("Thirteen Stroke Roll");
                    Adv.Add("Fifteen Stroke Roll");
                    Adv.Add("Seventeen Stroke Roll");
                    Adv.Add("Flam Tap");
                    Adv.Add("Flamacue");
                    Adv.Add("Flam Paradiddle");
                    Adv.Add("Flammed Mill");
                    Adv.Add("Flam Paradiddle Diddle");
                    Adv.Add("Pataflafla");
                    Adv.Add("Single Drag Tap");
                    Adv.Add("Single Dragadiddle");
                    Adv.Add("Drag Paradiddle 1");
                    Adv.Add("Double Ratamacue");
                    /* create a variable for the initial list length that won't change */
                    int adv_length = Adv.Count;
                    /* generate a random number to represent a list index */
                    Random adv_index = new Random();

                    // new form to display music
                    FrmAdvancedLick AdvancedLick = new FrmAdvancedLick();
                    List<PictureBox> advPics = new List<PictureBox>();

                    // add picture boxes to array
                    advPics.Add(AdvancedLick.pictureBox1);
                    advPics.Add(AdvancedLick.pictureBox2);
                    advPics.Add(AdvancedLick.pictureBox3);
                    advPics.Add(AdvancedLick.pictureBox4);
                    advPics.Add(AdvancedLick.pictureBox5);
                    advPics.Add(AdvancedLick.pictureBox6);
                    advPics.Add(AdvancedLick.pictureBox7);
                    advPics.Add(AdvancedLick.pictureBox8);
                    advPics.Add(AdvancedLick.pictureBox9);
                    advPics.Add(AdvancedLick.pictureBox10);
                    advPics.Add(AdvancedLick.pictureBox11);
                    advPics.Add(AdvancedLick.pictureBox12);
                    advPics.Add(AdvancedLick.pictureBox13);
                    advPics.Add(AdvancedLick.pictureBox14);
                    advPics.Add(AdvancedLick.pictureBox15);
                    advPics.Add(AdvancedLick.pictureBox16);
                    advPics.Add(AdvancedLick.pictureBox17);

                    // these for loops populate the picture boxes based on the random index value that is 
                    // continually generated
                    List<int> adv_unused = new List<int>();
                    for (int i = 0; i <= 16; i++)
                    {
                        adv_unused.Add(i);
                    }

                    /* iterate as many times as the initial list is long */
                    for (int i = 0; i < adv_length; i++)
                    {
                        int toReturn = adv_index.Next(adv_unused.Count);

                        /* generate a random number between 0 and the length of the list currently */
                        switch (adv_unused[toReturn])
                        {
                            case 0:
                                advPics[i].Image = Properties.Resources.single_stroke_roll;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 1:
                                advPics[i].Image = Properties.Resources.single_stroke_four;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 2:
                                advPics[i].Image = Properties.Resources.triple_stroke_roll;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 3:
                                advPics[i].Image = Properties.Resources.nine_stroke_roll;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 4:
                                advPics[i].Image = Properties.Resources.thirteen_stroke_roll;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 5:
                                advPics[i].Image = Properties.Resources.fifteen_stroke_roll;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 6:
                                advPics[i].Image = Properties.Resources.seventeen_stroke_roll;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 7:
                                advPics[i].Image = Properties.Resources.flam_tap;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 8:
                                advPics[i].Image = Properties.Resources.flamacue;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 9:
                                advPics[i].Image = Properties.Resources.flam_paradiddle;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 10:
                                advPics[i].Image = Properties.Resources.flammed_mill;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 11:
                                advPics[i].Image = Properties.Resources.flam_paradiddle_diddle;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 12:
                                advPics[i].Image = Properties.Resources.pataflafla;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 13:
                                advPics[i].Image = Properties.Resources.single_drag_tap;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 14:
                                advPics[i].Image = Properties.Resources.single_dragadiddle;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 15:
                                advPics[i].Image = Properties.Resources.drag_paradiddle_1;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            case 16:
                                advPics[i].Image = Properties.Resources.double_ratamacue;
                                adv_unused.RemoveAt(toReturn);
                                break;
                            default:
                                break;

                        }

                        /* remove the element and reset the index value */
                        Adv.RemoveAt(toReturn);
                        toReturn = 0;
                    }

                    // show the form that has the music printed on it
                    AdvancedLick.Show();

                    break;

                case "Expert":
                    MessageBox.Show("Writing an Expert level lick...");
                    /* create a list to hold the level 4 rudiments*/
                    /* populated based on output of this query:
                     * create view hard_120 as 
	                        select * 
	                        from hard
	                        where tempo=120;
                     * tempo = 120 has the most rudiments associated with it
                    */
                    List<string> Ex = new List<string>();
                    /* add elements to the list */
                    Ex.Add("Single Stroke Roll");
                    Ex.Add("Single Stroke Seven");
                    Ex.Add("Triple Stroke Roll");
                    Ex.Add("Nine Stroke Roll");
                    Ex.Add("Thirteen Stroke Roll");
                    Ex.Add("Fifteen Stroke Roll");
                    Ex.Add("Seventeen Stroke Roll");
                    Ex.Add("Flam Tap");
                    Ex.Add("Flamacue");
                    Ex.Add("Flam Paradiddle");
                    Ex.Add("Drag Paradiddle 1");
                    Ex.Add("Flam Paradiddle Diddle");
                    Ex.Add("Pataflafla");
                    Ex.Add("Single Drag Tap");
                    Ex.Add("Single Dragadiddle");
                    /* create a variable for the initial list length that won't change */
                    int ex_length = Ex.Count;
                    /* generate a random number to represent a list index */
                    Random ex_index = new Random();

                    // new form to display music
                    FrmExpertLick ExpertLick = new FrmExpertLick();
                    List<PictureBox> exPics = new List<PictureBox>();

                    // add picture boxes to array
                    exPics.Add(ExpertLick.pictureBox1);
                    exPics.Add(ExpertLick.pictureBox2);
                    exPics.Add(ExpertLick.pictureBox3);
                    exPics.Add(ExpertLick.pictureBox4);
                    exPics.Add(ExpertLick.pictureBox5);
                    exPics.Add(ExpertLick.pictureBox6);
                    exPics.Add(ExpertLick.pictureBox7);
                    exPics.Add(ExpertLick.pictureBox8);
                    exPics.Add(ExpertLick.pictureBox9);
                    exPics.Add(ExpertLick.pictureBox10);
                    exPics.Add(ExpertLick.pictureBox11);
                    exPics.Add(ExpertLick.pictureBox12);
                    exPics.Add(ExpertLick.pictureBox13);
                    exPics.Add(ExpertLick.pictureBox14);
                    exPics.Add(ExpertLick.pictureBox15);

                    // these for loops populate the picture boxes based on the random index value that is 
                    // continually generated
                    List<int> ex_unused = new List<int>();
                    for (int i = 0; i <= 14; i++)
                    {
                        ex_unused.Add(i);
                    }

                    /* iterate as many times as the initial list is long */
                    for (int i = 0; i < ex_length; i++)
                    {
                        int toReturn = ex_index.Next(ex_unused.Count);

                        /* generate a random number between 0 and the length of the list currently */
                        switch (ex_unused[toReturn])
                        {
                            case 0:
                                exPics[i].Image = Properties.Resources.single_stroke_roll;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 1:
                                exPics[i].Image = Properties.Resources.single_stroke_seven;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 2:
                                exPics[i].Image = Properties.Resources.triple_stroke_roll;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 3:
                                exPics[i].Image = Properties.Resources.nine_stroke_roll;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 4:
                                exPics[i].Image = Properties.Resources.thirteen_stroke_roll;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 5:
                                exPics[i].Image = Properties.Resources.fifteen_stroke_roll;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 6:
                                exPics[i].Image = Properties.Resources.seventeen_stroke_roll;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 7:
                                exPics[i].Image = Properties.Resources.flam_tap;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 8:
                                exPics[i].Image = Properties.Resources.flamacue;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 9:
                                exPics[i].Image = Properties.Resources.flam_paradiddle;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 10:
                                exPics[i].Image = Properties.Resources.drag_paradiddle_1;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 11:
                                exPics[i].Image = Properties.Resources.flam_paradiddle_diddle;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 12:
                                exPics[i].Image = Properties.Resources.pataflafla;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 13:
                                exPics[i].Image = Properties.Resources.single_drag_tap;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            case 14:
                                exPics[i].Image = Properties.Resources.single_dragadiddle;
                                ex_unused.RemoveAt(toReturn);
                                break;
                            default:
                                break;

                        }

                        /* remove the element and reset the index value */
                        Ex.RemoveAt(toReturn);
                        toReturn = 0;
                    }

                    // show the form that has the music printed on it
                    ExpertLick.Show();

                    break;

                default:
                    MessageBox.Show("No selection. Please select your desired level of difficutly.");
                    break;

            }
        }

        private void picEasy_Click(object sender, EventArgs e)
        {
            /* child form that shows pics of level 1 rudiments */
            FrmEasy EasyChild = new FrmEasy();
            EasyChild.Show();
            
        }

        private void picMedium_Click(object sender, EventArgs e)
        {
            /* child form that shows pics of level 2 rudiments */
            FrmMedium MediumChild = new FrmMedium();
            MediumChild.Show();
        }

        private void picAdvanced_Click(object sender, EventArgs e)
        {
            /* child form that shows pics of level 3 rudiments */
            FrmAdvanced AdvancedChild = new FrmAdvanced();
            AdvancedChild.Show();
            
        }

        private void picExpert_Click(object sender, EventArgs e)
        {
            /* child form that shows pics of level 4 rudiments */
            FrmExpert ExpertChild = new FrmExpert();
            ExpertChild.Show();
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
            const string message = "Are you sure?";
            const string caption = "Close Panel";
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
