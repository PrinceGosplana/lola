using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BuildGirl.Directors;

namespace BuildGirl
{
    public partial class Form1 : Form
    {
        GirlStyleBuilder girl = new GirlStyleBuilder();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = girl.GetProduct().Picture;

        }

        private void btn_dress_Click(object sender, EventArgs e)
        {
            if (cb_dress.Text == "Home")
            {
                
                HomeDirector dir = new HomeDirector(girl);
                dir.Construct();
                pictureBox1.Image = girl.GetProduct().Picture;
            }
            if (cb_dress.Text == "Work")
            {
                WorkDirector dir = new WorkDirector(girl);
                dir.Construct();
                pictureBox1.Image = girl.GetProduct().Picture;
            }
            if (cb_dress.Text == "Waitress")
            {
                WaitressDirector dir = new WaitressDirector(girl);
                dir.Construct();
                pictureBox1.Image = girl.GetProduct().Picture;
            }
            if (cb_dress.Text == "BatGirl")
            {
                BatGirlDirector dir = new BatGirlDirector(girl);
                dir.Construct();
                pictureBox1.Image = girl.GetProduct().Picture;
            }
            if (cb_dress.Text == "Protect")
            {
                ProtectDirector dir = new ProtectDirector(girl);
                dir.Construct();
                pictureBox1.Image = girl.GetProduct().Picture;
            }
            if (cb_dress.Text == "Party")
            {
                PartyDirector dir = new PartyDirector(girl);
                dir.Construct();
                pictureBox1.Image = girl.GetProduct().Picture;
            }
            if (cb_dress.Text == "Sex")
            {
                SexDirector dir = new SexDirector(girl);
                dir.Construct();
                pictureBox1.Image = girl.GetProduct().Picture;
            }
            if (cb_dress.Text == "Bride")
            {
                BrideDirectory dir = new BrideDirectory(girl);
                dir.Construct();
                pictureBox1.Image = girl.GetProduct().Picture;
            }
            if (cb_dress.Text == "Playgirl")
            {
                PlaygirlDirector dir = new PlaygirlDirector(girl);
                dir.Construct();
                pictureBox1.Image = girl.GetProduct().Picture;
            }
            if (cb_dress.Text == "Merry Christmas")
            {
                MerryChristmasDirector dir = new MerryChristmasDirector(girl);
                dir.Construct();
                pictureBox1.Image = girl.GetProduct().Picture;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Girl1;
        }
    }
}
