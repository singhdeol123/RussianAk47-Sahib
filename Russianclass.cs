using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace RussianAk47
{

    class Russianclass //class
    {
        
        // sounds for clik buttons

        SoundPlayer click = new SoundPlayer(RussianAk47.Properties.Resources.click);
        SoundPlayer load = new SoundPlayer(RussianAk47.Properties.Resources.load);
        SoundPlayer shoot = new SoundPlayer(RussianAk47.Properties.Resources.shoot);
        string notification; // result message

        //function for load gun
        public string loadwepeon(out int bullet)

        {
            bullet = 1;
            notification = "Bullet is loaded";
            click.Play();
            return notification;
        }
        // function for spin the chamber
        public string rolling (out int safeplace ,out int roll)
        {// random number
            safeplace = 2;
            Random mynum = new Random();
            roll = mynum.Next(1, 6);
            load.Play();
            notification = "Now Bullet is at a Random Place Ready For Shoot";

           
           
            return notification;

        }

        //function for shoot
        public string fire(int shoots, out int freeshoots)
        {
            freeshoots = shoots;// shootaway string
            freeshoots--;
            if ( freeshoots == 0)
            {
                notification = " You losse";
            }
            
               shoot.Play();
            return notification;
           
        } 
        // function for shootaway button
        public string safeplace(int shoot, out int freeshoot)

        {
            

            freeshoot = shoot;
            freeshoot--;
           

            
            return notification;
           
        }
    }
}
