using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class FormSnake : Form
    {
        private bool isGameActive;
        private anakonda snake;
        private Fruit fruit;
        string lastKey = "right";
        int score = 0, highScore = 0, lastHighScore;
        double averageScore;
        SoundPlayer bgMusic = new SoundPlayer(@"D:\csProjects\snake\Assets\crazyScienceOwls.wav");
        List<int> average = new List<int>();

        public FormSnake()
        {
            InitializeComponent();
            isGameActive = false;
            timer.Enabled = true;
            pauseToolStripMenuItem.Enabled = false;
            restartToolStripMenuItem.Enabled = false;
            menuStrip.BackColor = Color.FromArgb(255, 41, 44, 51);
            menuStrip.ForeColor = Color.FromArgb(217, 203, 38);
            menuStrip.Renderer = new MyRenderer();
            this.Icon = new Icon(@"D:\csProjects\snake\Assets\snakeIcon.ico");
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (!e.Item.Selected) base.OnRenderMenuItemBackground(e);
                else
                {
                    Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                    SolidBrush hoverBrush = new SolidBrush(Color.FromArgb(255, 66, 69, 76));
                    e.Graphics.FillRectangle(hoverBrush, rc);
                    e.Graphics.DrawRectangle(Pens.Black, 1, 0, rc.Width - 2, rc.Height - 1);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isGameActive)
            {
                panelBackground.CreateGraphics().Clear(Color.FromArgb(255, 124, 176, 97));
                snake.moveSnake();
                snake.draw(panelBackground.CreateGraphics(), new SolidBrush(Color.FromArgb(255, 51, 51, 51)));
                startToolStripMenuItem.Enabled = false;
                restartToolStripMenuItem.Enabled = true;

                if (canSpawnFood())
                {
                    fruit.drawFruit(panelBackground.CreateGraphics(), new SolidBrush(Color.Red));
                }
                else
                {
                    fruit.newFruit();
                    fruit.drawFruit(panelBackground.CreateGraphics(), new SolidBrush(Color.Red));
                }

                if (fruit.ifNewFruit(snake.x[0], snake.y[0]))
                {
                    snake.add();
                    score++;
                    labelScorePoints.Text = Convert.ToString(score);
                }

                if(snake.isAlive() == false)
                {
                    lastHighScore = highScore;
                    if(score < lastHighScore)
                    {
                        highScore = lastHighScore;
                    }
                    else
                    {
                        highScore = score;        
                    }

                    pauseToolStripMenuItem.Enabled = false;
                    labelHighScorePoints.Text = Convert.ToString(highScore);
                    isGameActive = false;
                    bgMusic.Stop();
                    panelBackground.CreateGraphics().Clear(Color.FromArgb(255, 124, 176, 97));

                    average.Add(score);
                    double scoreSum = 0;
                    average.ForEach(delegate(int number)
                    {
                        scoreSum += number;
                    });

                    averageScore = scoreSum / average.Count;

                    TextWriter result = new StreamWriter(@"D:\csProjects\snake\Scores\highScore.txt");
                    result.Write("High Score: " + Convert.ToString(highScore) + "\n");
                    result.Write("Average Score: " + Convert.ToString(Math.Round(averageScore, 2)));
                    result.Close();
                    startToolStripMenuItem.Enabled = true;
                    restartToolStripMenuItem.Enabled = false;

                    timer.Enabled = false;
                    panelBackground.CreateGraphics().Clear(Color.FromArgb(255, 124, 176, 97));
                    FontFamily fontFamily1 = new FontFamily("Arial");
                    Font f = new Font(fontFamily1, 24);
                    Brush b = new SolidBrush(Color.FromArgb(255, 11, 11, 11));
                    panelBackground.CreateGraphics().DrawString("GAME OVER", f, b, 75, 150);
                    panelBackground.CreateGraphics().DrawString("Press Start", f, b, 95, 190);
                    

                    if (highScore - lastHighScore > 0)
                    {
                        if (highScore - lastHighScore == 1)
                        {
                            MessageBox.Show("Congratulations! You improved your high score by " + (highScore - lastHighScore) + " point!");
                        }
                        else
                        {
                            MessageBox.Show("Congratulations! You improved your high score by " + (highScore - lastHighScore) + " points!");
                        }
                    }
                }
            }
            else
            {
                FontFamily fontFamily1 = new FontFamily("Arial");
                Font f = new Font(fontFamily1, 24);
                Brush b = new SolidBrush(Color.FromArgb(255, 11, 11, 11));
                panelBackground.CreateGraphics().DrawString("Press Start", f, b, 90, 160);         
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            isGameActive = true;
            snake = new anakonda(panelBackground.Width, panelBackground.Height);
            fruit = new Fruit(snake.segment);
            pauseToolStripMenuItem.Enabled = true;
            restartToolStripMenuItem.Enabled = true;
            score = 0;
            labelScorePoints.Text = Convert.ToString(score);
            lastKey = "right";
            bgMusic.Play();
        }

        private void FormSnake_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (lastKey == "bottom")
                {
                    snake.move = "bottom";
                }
                else
                {
                    snake.move = "top";
                    lastKey = "top";
                }
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (lastKey == "top")
                {
                    snake.move = "top";
                }
                else
                {
                    snake.move = "bottom";
                    lastKey = "bottom";
                }
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if(lastKey == "right")
                {
                    snake.move = "right";
                }
                else
                {
                    snake.move = "left";
                    lastKey = "left";
                }
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (lastKey == "left")
                {
                    snake.move = "left";
                }
                else
                {
                    snake.move = "right";
                    lastKey = "right";
                }
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isGameActive)
            {
                isGameActive = false;
                pauseToolStripMenuItem.Text = "Resume";
                panelBackground.CreateGraphics().Clear(Color.FromArgb(255, 124, 176, 97));
                restartToolStripMenuItem.Enabled = false;
                timer.Enabled = false;
                FontFamily fontFamily1 = new FontFamily("Arial");
                Font f = new Font(fontFamily1, 24);
                Brush b = new SolidBrush(Color.FromArgb(255, 11, 11, 11));
                panelBackground.CreateGraphics().DrawString("Press Resume", f, b, 65, 160);
            }
            else
            {
                timer.Enabled = true;
                isGameActive = true;
                pauseToolStripMenuItem.Text = "Pause";    
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            if (isGameActive)
            {
                snake = new anakonda(panelBackground.Width, panelBackground.Height);
                fruit = new Fruit(snake.segment);
                lastKey = "right";

                lastHighScore = highScore;
                if (score < lastHighScore)
                {
                    highScore = lastHighScore;
                }
                else
                {
                    highScore = score;
                }
                labelHighScorePoints.Text = Convert.ToString(highScore);

                average.Add(score);
                double scoreSum = 0;
                average.ForEach(delegate (int number)
                {
                    scoreSum += number;
                });

                averageScore = scoreSum / average.Count;

                TextWriter result = new StreamWriter(@"D:\csProjects\snake\Scores\highScore.txt");
                result.Write("High Score: " + Convert.ToString(highScore) + "\n");
                result.Write("Average Score: " + Convert.ToString(Math.Round(averageScore, 2)));
                result.Close();

                score = 0;
                labelScorePoints.Text = Convert.ToString(score);

                if (highScore - lastHighScore > 0)
                {
                    timer.Enabled = false;
                    if (highScore - lastHighScore == 1)
                    {
                        MessageBox.Show("Congratulations! You improved your high score by " + (highScore - lastHighScore) + " point!");
                    }
                    else
                    {
                        MessageBox.Show("Congratulations! You improved your high score by " + (highScore - lastHighScore) + " points!");
                    }
                }

                timer.Enabled = true;
            }
        }

        private void slowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Interval = 100;
        }

        private void fasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Interval = 100;
            timer.Interval -= 30;
        }

        private void ultraFastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Interval = 100;
            timer.Interval -= 60;
        }

        private void ultraFastHardMasterExtraPremiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Interval = 100;
            timer.Interval -= 99;
        }

        private bool canSpawnFood()
        {
            for (int i = 1; i < snake.segments; i++)
            {
                if (fruit.x == snake.x[i] && fruit.y == snake.y[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}