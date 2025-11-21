using System;
using System.CodeDom.Compiler;

namespace WMProjekt
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void SetForm(List<Spiel> Results)
        {
            var results = Results;

            Spiel achtelfinal1 = results[0];
            goalsTeam1.Text = achtelfinal1.toreMannschaft1.ToString();
            goalsTeam2.Text = achtelfinal1.toreMannschaft2.ToString();
            team1.Text = achtelfinal1.m1.GetName();
            team2.Text = achtelfinal1.m2.GetName();
            picTeam1.Image = Image.FromFile("flaggen/"+ achtelfinal1.m1.GetName() + "png");
            picTeam2.Image = Image.FromFile("flaggen/" + achtelfinal1.m2.GetName() + "png");

            Spiel achtelfinal2 = results[1];
            goalsTeam3.Text = achtelfinal2.toreMannschaft1.ToString();
            goalsTeam4.Text = achtelfinal2.toreMannschaft2.ToString();
            team3.Text = achtelfinal2.m1.GetName();
            team4.Text = achtelfinal2.m2.GetName();
            picTeam3.Image = Image.FromFile("flaggen/" + achtelfinal2.m1.GetName() + "png");
            picTeam4.Image = Image.FromFile("flaggen/" + achtelfinal2.m2.GetName() + "png");

            Spiel achtelfinal3 = results[2];
            goalsTeam5.Text = achtelfinal3.toreMannschaft1.ToString();
            goalsTeam6.Text = achtelfinal3.toreMannschaft2.ToString();
            team5.Text = achtelfinal3.m1.GetName();
            team6.Text = achtelfinal3.m2.GetName();
            picTeam5.Image = Image.FromFile("flaggen/" + achtelfinal3.m1.GetName() + "png");
            picTeam6.Image = Image.FromFile("flaggen/" + achtelfinal3.m2.GetName() + "png");

            Spiel achtelfinal4 = results[3];
            goalsTeam7.Text = achtelfinal4.toreMannschaft1.ToString();
            goalsTeam8.Text = achtelfinal4.toreMannschaft2.ToString();
            team7.Text = achtelfinal4.m1.GetName();
            team8.Text = achtelfinal4.m2.GetName();
            picTeam7.Image = Image.FromFile("flaggen/" + achtelfinal4.m1.GetName() + "png");
            picTeam8.Image = Image.FromFile("flaggen/" + achtelfinal4.m2.GetName() + "png");

            Spiel achtelfinal5 = results[4];
            goalsTeam15.Text = achtelfinal5.toreMannschaft1.ToString();
            goalsTeam16.Text = achtelfinal5.toreMannschaft2.ToString();
            team15.Text = achtelfinal5.m1.GetName();
            team16.Text = achtelfinal5.m2.GetName();
            picTeam15.Image = Image.FromFile("flaggen/" + achtelfinal5.m1.GetName() + "png");
            picTeam16.Image = Image.FromFile("flaggen/" + achtelfinal5.m2.GetName() + "png");

            Spiel achtelfinal6 = results[5];
            goalsTeam17.Text = achtelfinal6.toreMannschaft1.ToString();
            goalsTeam18.Text = achtelfinal6.toreMannschaft2.ToString();
            team17.Text = achtelfinal6.m1.GetName();
            team18.Text = achtelfinal6.m2.GetName();
            picTeam17.Image = Image.FromFile("flaggen/" + achtelfinal6.m1.GetName() + "png");
            picTeam18.Image = Image.FromFile("flaggen/" + achtelfinal6.m2.GetName() + "png");





        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
