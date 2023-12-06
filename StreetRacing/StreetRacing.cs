using System;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.Threading;

namespace StreetRacing
{
    public partial class StreetRacing : Form
    {
        
        // Variablen
        int roadSpeed = 5;
        int trafficSpeed = 5;
        int playerSpeed = 3;
        int score;
        int carImage;
        int treeImage;

        Random random = new Random();
        Random carPosition = new Random();
        Random treePosition = new Random();

        bool goLeft, goRight;

        // SoundPlayer sound = new SoundPlayer();

        public StreetRacing()
        {
            InitializeComponent();
            ResettGame();

            //// Event-Bindung für Tastenereignisse
            //this.KeyDown += keyisdown;
            //this.KeyUp += keyisup;

            //// Setzen des Fokus auf das Formular
            //this.Focus();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            LblScore.Text = "Score: " + score;
            score++;


            if (goLeft == true && Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
            if (goRight == true && Player.Left < 415)
            {
                Player.Left += playerSpeed;
            }

            PbRoad.Top += roadSpeed;
            PBRoad2.Top += roadSpeed;

            if (PBRoad2.Top > 10)
            {
                PBRoad2.Top = -519;
            }
            if (PbRoad.Top > 10)
            {
                PbRoad.Top = -519;
            }

            Car1.Top += trafficSpeed;   
            Car2.Top += trafficSpeed;
            Tree1.Top += trafficSpeed;
            Tree2.Top += trafficSpeed;

            if (Car1.Top > 500)
            {
                ChangeCar(Car1);
            }

            if (Car2.Top > 500)
            {
                ChangeCar(Car2);
            }

            if (Tree1.Top > 500)
            {
                ChangeTree(Tree1);
            }

            if (Tree2.Top > 500)
            {
                ChangeTree(Tree2);
            }

            // Kollisionsabfrage
            if (Player.Bounds.IntersectsWith(Car1.Bounds) || Player.Bounds.IntersectsWith(Car2.Bounds))
            {
                GameOver();
            }

            // Geshwindigkeitsanpassung
            if (score > 40 && score < 1000)
            {
                award.Image = Properties.Resources.bronze;
            }

            if (score > 1000 && score < 2500)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed =6;
                trafficSpeed = 7;
            }

            if (score > 2500 && score < 5000)
            {
                award.Image = Properties.Resources.gold;
                trafficSpeed = 7;
                roadSpeed = 8;
            }
            if (score > 5000 )
            {
                award.Image = Properties.Resources.diamond;
                trafficSpeed = 10;
                roadSpeed = 11;
            }
        }

        private void ChangeTree(PictureBox tempTree)
        {
            treeImage = random.Next(1, 3);
            switch (treeImage)
            {
                case 1:
                    tempTree.Image = Properties.Resources.Tree1;
                    break;
                case 2:
                    tempTree.Image = Properties.Resources.Tree2;
                    break;
            }

            tempTree.Top = treePosition.Next(10, 50);

            if ((string)tempTree.Tag == "treeLeft")
            {
                tempTree.Left = treePosition.Next(5, 64);
            }

            if ((string)tempTree.Tag == "treeRight")
            {
                tempTree.Left = treePosition.Next(358, 422);
            }
            
            if (Player.Bounds.IntersectsWith(Car1.Bounds) || (Player.Bounds.IntersectsWith(Car2.Bounds)))
            {
                GameOver();
            }

            // Anpassung der Geschwindigkeiten
            if (score > 40 && score < 800)
            {
                award.Image = Properties.Resources.bronze;
            }

            if (score > 800 && score < 1500)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed = 6;
                trafficSpeed = 7;
            }
            if (score > 1500 && score < 2500)
            {
                award.Image = Properties.Resources.gold;
                roadSpeed = 7;
                trafficSpeed = 8;
            }
            if (score > 2500 && score < 5000)
            {
                award.Image = Properties.Resources.diamond;
                roadSpeed = 9;
                trafficSpeed = 10;
            }
        }

        private void ChangeCar(PictureBox tempCar)
        {
            // Auswahl und Darstellung der Fahrzeuge
            carImage = random.Next(1, 12);
            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.Police;
                    break;
                case 10:
                    tempCar.Image = Properties.Resources.Car1;
                    break;
                case 11:
                    tempCar.Image = Properties.Resources.Car4;
                    break;
            }

            tempCar.Top = carPosition.Next(10, 50);

            if ((string) tempCar.Tag == "carLeft" )
            {
                tempCar.Left = carPosition.Next(5, 200);
            }

            if ((string ) tempCar.Tag =="carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }

            if (Player.Bounds.IntersectsWith(Car1.Bounds) || (Player.Bounds.IntersectsWith(Car2.Bounds)))
            {
                GameOver();
            }

            // Anpassung der Geschwindigkeiten
            if (score > 40 && score < 800)
            {
                award.Image = Properties.Resources.bronze;
            }

            if (score > 800 && score < 1500)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed=6;
                trafficSpeed = 7;
            }
            if (score > 1500 && score < 2500)
            {
                award.Image = Properties.Resources.gold;
                roadSpeed = 7;
                trafficSpeed = 8;
            }
            if (score > 2500 && score < 5000)
            {
                award.Image = Properties.Resources.diamond;
                roadSpeed = 9;
                trafficSpeed = 10;
            }
        }
            
        private void GameOver()
        {
            PlaySound();
            gameTimer.Stop();
            Explosion.Visible = true;
            Player.Controls.Add(Explosion);
            Explosion.Location = new Point(-8, 5);
            Explosion.BackColor = Color.Transparent;
            award.Visible = true;
            award.BringToFront();
            BtnStart.Enabled = true;
        }

        private void ResettGame()
        {
            BtnStart.Enabled = false;
            Explosion.Visible = false;
            award.Visible = false;
            goLeft = false;
            goRight = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 5;
            trafficSpeed = 5;
            //Car1.Top = carPosition.Next(10, 500) *-1;
            Car1.Top = -120;
            //Car1.Left = carPosition.Next(5, 200);
            Car1.Left = 66;

            //Car2.Top = carPosition.Next(10, 500) * -1;
            Car2.Top = -185;
            //Car2.Left = carPosition.Next(245, 422);
            Car2.Left = 294;

            PbRoad.Left = -2;
            PbRoad.Top = -638;
            PBRoad2.Left = -3;
            PBRoad2.Top = -222;

            // Sleep for 3 seconds (3000 milliseconds)
            Thread.Sleep(3000);

            gameTimer.Start();
            ThemeSound();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            ResettGame();
        }

        private void PlaySound()
        {
            System.Media.SoundPlayer playerCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playerCrash.Play();
        }


        private void ThemeSound()
        {
            try
            {
                using (SoundPlayer sound =
                new SoundPlayer("Resources/SpyHunter_kurz.wav"))
                {
                    sound.PlayLooping();
                }
            }
            catch (Exception ex)
            {
                // Hier könntest du Fehlerbehandlung hinzufügen, wenn das Abspielen fehlschlägt.
                MessageBox.Show("Fehler beim Abspielen des Sounds: " + ex.Message);
            }
        }
    }
}