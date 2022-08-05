using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class PingPong : Form
    {
        //Location Variables
      //int cpuDirection = 5;           //set cpu player speed  
        int ballXCoordinate = 5;    //set ball speed in X-coordinate
        int ballYCoordinate = 6;    //set ball speed in Y-coordinate

        //Score variables
        int playerscore = 0;
        int player2score = 0; 

        //size variables
        int bottomBoundry;
      //int centerPoint;
        int xMidpoint;  //use to find cter-point
        int yMidpoint;  //use to find center-point

        //Detection Variables 
        bool playerDetectedUp;
        bool playerDetectedDown;

        bool player2DetectedUp;
        bool player2DetectedDown;

        //special keys
        int spaceBarClicked = 0; //it'll stop the game if space bar is pressed

        public PingPong()
        {
            InitializeComponent();
            //Clientsize will gives the size of the window...
            Winner1.Visible = false;
            Winner2.Visible = false; 

            bottomBoundry = ClientSize.Height - Player1.Height;
            //Finding midpoint

            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;
        }


        private void PingPong_Load(object sender, EventArgs e)
        {

        }         

        //this method's code will execute itself after every 20ms
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            //Adjust where the ball is

            Ball1.Top -= ballYCoordinate;
            Ball1.Left -= ballXCoordinate;

   
            //check if ball exited the left side of screen
            if (Ball1.Left < 0) //ball has exited
            {
                Ball1.Left = xMidpoint;
                Ball1.Top = newSpot; //newSpot is randomly generated value / y-coordinate.
                ballXCoordinate = -ballXCoordinate;
                player2score++;
                cpuScoreLabel.Text = player2score.ToString();
            }
            //check if ball exited the right side of screen
            if (Ball1.Left + Ball1.Width > ClientSize.Width) //ball has exited right side
            {
                Ball1.Left = xMidpoint;
                Ball1.Top = newSpot; //newSpot is randomly generated value / y-coordinate.
                ballXCoordinate = -ballXCoordinate;
                playerscore++;
                playerScoreLabel.Text = playerscore.ToString();
            }
            //ensure the ball is within the boundry of screen
            if (Ball1.Top < 0 || Ball1.Top + Ball1.Height > ClientSize.Height)
            {
                ballYCoordinate = -ballYCoordinate;  //ball will bounce back in negative direction
            }

            //check if the ball hits the player or CPU paddle
            if (Ball1.Bounds.IntersectsWith(Player1.Bounds) || Ball1.Bounds.IntersectsWith(Player2.Bounds))
            {
                ballXCoordinate= -ballXCoordinate; //send the ball in opposite direction
                ballXCoordinate++;
                //ballYCoordinate++;
            }

            //move player up
            if (playerDetectedUp == true && Player1.Top > 0)
            {
                Player1.Top -= 10;
            }
            //move player down
            if (playerDetectedDown == true && Player1.Top < bottomBoundry)
            {
                Player1.Top += 10;
            }

            //move player up
            if (player2DetectedUp == true && Player2.Top > 0)
            {
                Player2.Top -= 10;
            }
            //move player down
            if (player2DetectedDown == true && Player2.Top < bottomBoundry)
            {
                Player2.Top += 10;
            }

            //check for winner...
            if (playerscore >= 5 ) 
            {
                Winner1.Visible = true;
                gameTimer.Stop();
            }
            else if(player2score >= 5)
            {
                Winner2.Visible = true;
                gameTimer.Stop();
            }
        }

        private void PingPong_KeyUp(object sender, KeyEventArgs e)
        {
            //For Player 1
            if (e.KeyCode == Keys.W)
            {
                playerDetectedUp = false;
            }
            
            if (e.KeyCode == Keys.S)
            {
                playerDetectedDown = false;
            }
            //For Player 2
            if (e.KeyCode == Keys.Up)
            {
                player2DetectedUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                player2DetectedDown = false;

            }
        }
        private void PingPong_KeyDown(object sender, KeyEventArgs e)
        {
            //if player presses up arrow, move paddle upwards
            if (e.KeyCode == Keys.W)
            {
                playerDetectedUp = true;
            }
            //if player presses down arrow,move paddle downwards
            if (e.KeyCode == Keys.S)
            {
                playerDetectedDown = true;
            }


            //if player2 presses up arrow, move paddle upwards
            if (e.KeyCode == Keys.Up)
            {
                player2DetectedUp = true;
            }
            //if player2 presses down arrow,move paddle downwards
            if (e.KeyCode == Keys.Down)
            {
                player2DetectedDown = true;
            }
            //if player presses up space, pause the game
            if (e.KeyCode == Keys.Space)
            {
                if (spaceBarClicked % 2 == 0)
                {
                    gameTimer.Stop();
                }
                else
                {
                    gameTimer.Start();
                }
            }
            spaceBarClicked++;
        }

    }
}
