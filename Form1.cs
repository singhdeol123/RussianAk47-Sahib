using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RussianAk47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }
        // class initialize
        Russianclass class1 = new Russianclass();
        private int chancesleft = 2;
        private int points = -10;
        private int point  = +10;

        private void btnLoad_Click(object sender, EventArgs e)// button for load a bullet in a chamber 
        {

            txtResult.Text = class1.loadwepeon(out int bullet);
           
            Bullettxt.Text = Convert.ToString(bullet);
            btnSpin.Enabled = true;
            btnFire.Enabled = false;
            btnSafePlace.Enabled = false;
            btnBullet.Enabled = false;

        }

        private void Bullettxt_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void btnSpin_Click(object sender, EventArgs e)// spin chamber , when bullet is stored in the gun chamber spin by click on spin button for random place for bullet
        {
           txtResult.Text = class1.rolling( out int safeplace ,out int roll);
            txtsafeplace.Text = Convert.ToString(safeplace);
            Bullettxt.Text = Convert.ToString(roll);

            // button visiality yes or no
            btnSpin.Enabled = true;
            btnFire.Enabled = true;
            btnSafePlace.Enabled = true;
            btnBullet.Enabled = false;
        }
        // shootaway button
        private void btnSafePlace_Click(object sender, EventArgs e)
        {   
            txtResult.Text = class1.safeplace(Convert.ToInt32(Bullettxt.Text), out int freeshoot);
            {
                Bullettxt.Text = freeshoot.ToString();
                freeshoot--;




                chancesleft--;
                txtsafeplace.Text = chancesleft.ToString();
                if (chancesleft == 0)
                {
                    txtResult.Text = "no more chances ... you loose the game";
                    btnSafePlace.Enabled = false;
                }
                else if (Bullettxt.Text == "3" )
                {
                    txtResult.Text = "You win";
                    txtPoints.Text = point.ToString(); 
                    btnSpin.Enabled = false;
                    btnFire.Enabled = false;
                    btnSafePlace.Enabled = false;
                    btnBullet.Enabled = false;

                }

                    btnBullet.Enabled = true;
                btnSpin.Enabled = true;
                SoundPlayer shoot = new SoundPlayer(RussianAk47.Properties.Resources.shoot);
                shoot.Play();
            }
        }
        
        // fire button 
        private void btnFire_Click(object sender, EventArgs e)
        {
            txtResult.Text = class1.fire(Convert.ToInt32(Bullettxt.Text),out int freeshoots);
            {
                Bullettxt.Text = freeshoots.ToString();
                freeshoots--;
                
                if (freeshoots == -1) { txtResult.Text = "You Loose"; txtPoints.Text = points.ToString();
                    btnSafePlace.Enabled = false; btnFire.Enabled = false; btnBullet.Enabled = false;
                    btnSpin.Enabled = false;
                }
               
                
            }

 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtsafeplace_TextChanged(object sender, EventArgs e)
        { if (txtsafeplace.Text == "0")
            {

                btnSpin.Enabled = true;
                btnFire.Enabled = false;
                btnSafePlace.Enabled = true;
                btnBullet.Enabled = true;
            }
        }
        // reset button for restart the application
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
