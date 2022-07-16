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

namespace _201902027_Final_Odevi
{
    public partial class Form1 : Form
    {
        
        Random location = new Random(); 
        List<Point> points = new List<Point>(); 
        PictureBox FlippedImage1;
        PictureBox FlippedImage2;
        int FlippedCount = 0;
        int LevelUp = 30;
        int TimeLevel = 60;
        int Score = 0;
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {

            

            label1.Text = "3";// kartların görünmesi için geri sayım
            foreach (PictureBox picture in GamePanel.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in GamePanel.Controls)
            {
                //rastgele fotoğraf koyma
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
            ScoreTimer.Start();
            CountdownTimer.Start();
            img1.Image = Properties.Resources.image_1;
            dupimg1.Image = Properties.Resources.image_1;
            img2.Image = Properties.Resources.image_2;
            dupimg2.Image = Properties.Resources.image_2;
            img3.Image = Properties.Resources.image_3;
            dupimg3.Image = Properties.Resources.image_3;
            img4.Image = Properties.Resources.image_4;
            dupimg4.Image = Properties.Resources.image_4;
            img5.Image = Properties.Resources.image_5;
            dupimg5.Image = Properties.Resources.image_5;
            img6.Image = Properties.Resources.image_6;
            dupimg6.Image = Properties.Resources.image_6;
            img7.Image = Properties.Resources.image_7;
            dupimg7.Image = Properties.Resources.image_7;
            img8.Image = Properties.Resources.image_8;
            dupimg8.Image = Properties.Resources.image_8;
            img9.Image = Properties.Resources.image_9;
            dupimg9.Image = Properties.Resources.image_9;
            img10.Image = Properties.Resources.image_10;
            dupimg10.Image = Properties.Resources.image_10;



        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            ScoreCounter.Text = "60";
            timeLeft.Text = "60";
            levelValue.Text = "1";
            Form1_Load(sender, e);
        }

        private void ScoreTimer_Tick(object sender, EventArgs e)
        {
            ScoreTimer.Stop();
            foreach (PictureBox picture in GamePanel.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.cover;
            }
        }

        private void timeLeft_Click(object sender, EventArgs e)
        {

        }

        private void img1_Click(object sender, EventArgs e)
        {
            img1.Image = Properties.Resources.image_1;
            checkImages(img1, dupimg1);
        }

        private void img2_Click(object sender, EventArgs e)
        {
            img2.Image = Properties.Resources.image_2;
            checkImages(img2, dupimg2);
        }

        private void img3_Click(object sender, EventArgs e)
        {
            img3.Image = Properties.Resources.image_3;
            checkImages(img3, dupimg3);
        }

        private void img4_Click(object sender, EventArgs e)
        {
            img4.Image = Properties.Resources.image_4;
            checkImages(img4, dupimg4);
        }

        private void img5_Click(object sender, EventArgs e)
        {
            img5.Image = Properties.Resources.image_5;
            checkImages(img5, dupimg5);
        }

        private void img6_Click(object sender, EventArgs e)
        {
            img6.Image = Properties.Resources.image_6;
            checkImages(img6, dupimg6);
        }

        private void img7_Click(object sender, EventArgs e)
        {
            img7.Image = Properties.Resources.image_7;
            checkImages(img7, dupimg7);
        }

        private void img8_Click(object sender, EventArgs e)
        {
            img8.Image = Properties.Resources.image_8;
            checkImages(img8, dupimg8);
        }

        private void img9_Click(object sender, EventArgs e)
        {
            img9.Image = Properties.Resources.image_9;
            checkImages(img9, dupimg9);
        }

        private void img10_Click(object sender, EventArgs e)
        {
            img10.Image = Properties.Resources.image_10;
            checkImages(img10, dupimg10);
        }

        private void dupimg1_Click(object sender, EventArgs e)
        {
            dupimg1.Image = Properties.Resources.image_1;
            checkImages(dupimg1, img1);
        }

        private void dupimg2_Click(object sender, EventArgs e)
        {
            dupimg2.Image = Properties.Resources.image_2;
            checkImages(dupimg2, img2);
        }

        private void dupimg3_Click(object sender, EventArgs e)
        {
            dupimg3.Image = Properties.Resources.image_3;
            checkImages(dupimg3, img3);
        }

        private void dupimg4_Click(object sender, EventArgs e)
        {
            dupimg4.Image = Properties.Resources.image_4;
            checkImages(dupimg4, img4);
        }

        private void dupimg5_Click(object sender, EventArgs e)
        {
            dupimg5.Image = Properties.Resources.image_5;
            checkImages(dupimg5, img5);
        }

        private void dupimg6_Click(object sender, EventArgs e)
        {
            dupimg6.Image = Properties.Resources.image_6;
            checkImages(dupimg6, img6);
        }

        private void dupimg7_Click(object sender, EventArgs e)
        {
            dupimg7.Image = Properties.Resources.image_7;
            checkImages(dupimg7, img7);
        }

        private void dupimg8_Click(object sender, EventArgs e)
        {
            dupimg8.Image = Properties.Resources.image_8;
            checkImages(dupimg8, img8);
        }

        private void dupimg9_Click(object sender, EventArgs e)
        {
            dupimg9.Image = Properties.Resources.image_9;
            checkImages(dupimg9, img9);
        }

        private void dupimg10_Click(object sender, EventArgs e)
        {
            dupimg10.Image = Properties.Resources.image_10;
            checkImages(dupimg10, img10);
        }

       

        private void ScoreCounter_Click(object sender, EventArgs e)
        {

        }

        private void levelValue_Click(object sender, EventArgs e)
        {

        }

        private void levelLabel_Click(object sender, EventArgs e)
        {

        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

       

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer -= 1;
            label1.Text = Convert.ToString(timer);
            if(timer==0)
            {
                CountdownTimer.Stop();
                TimeRemaining.Start();
            }
        }

        private void TimeRemaining_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(timeLeft.Text);
            timer -= 1;
            timeLeft.Text = Convert.ToString(timer);
            if(timer==0)
            {
                TimeRemaining.Stop();
                MessageBox.Show("Puanın : " + ScoreCounter.Text + " seviyen : " + levelValue.Text);
                ScoreCounter.Text = "0";
                resetButton.Text = "Tekrar Oyna";
            }
         }
        
        private void changeLevel()
        {
            Score += Convert.ToInt32(ScoreCounter.Text);
            MessageBox.Show("Yeni seviye! ");
            if(Convert.ToInt32(ScoreCounter.Text)>= LevelUp)
            {
                ScoreCounter.Text = "0";
                TimeLevel -= 5;
                timeLeft.Text = Convert.ToString(TimeLevel);
                levelValue.Text = Convert.ToString(Convert.ToInt32(levelValue.Text) + 1);
                LevelUp += 5;
                if(TimeLevel<=15)
                {
                    MessageBox.Show("Oynadığın için teşekkürler! Oyunu tamamladın.");
                    Application.Exit();
                }
                Form1_Load(this, null);
            }
            else
            {
                MessageBox.Show("Oyun bitti. Yeni seviye için gereken puana ulaşamadın. Toplam Puan: " +Score);
                resetButton.Text = "Tekrar Oyna";
            }
        }

        private void FlipTime_Tick(object sender, EventArgs e)
        {
            FlipTime.Stop();
            FlippedImage1.Image = Properties.Resources.cover;
            FlippedImage2.Image = Properties.Resources.cover;
            FlippedImage1 = null;
            FlippedImage2 = null;

            

        }
        private void checkImages(PictureBox pic1, PictureBox pic2)
        {
            if(FlippedImage1==null)
            {
                FlippedImage1 = pic1;
            }
            else if(FlippedImage1 != null && FlippedImage2 == null)
            {
                if (FlippedImage1 != pic1)
                    FlippedImage2 = pic1;
            }
            if(FlippedImage1 != null && FlippedImage2 != null)
            {
                if (FlippedImage1.Tag == FlippedImage2.Tag)
                {
                    FlippedImage1 = null;
                    FlippedImage2 = null;
                    pic2.Enabled = false;
                    pic1.Enabled = false;
                    ++FlippedCount;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    FlipTime.Start();
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 5);
                }
            }
            if (FlippedCount ==10)
            {
                FlippedCount = 0;
                changeLevel();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EcoTimer_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            panel1.Width = r.Next(500);
            panel2.Width = r.Next(500);
            panel3.Width = r.Next(500);
            panel4.Width = r.Next(500);
         

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EcoTimer.Start();
            player.SoundLocation = @"C:\Users\ibrah\source\repos\201902027_Final_Odevi\Resources\The Following.wav";
            player.Play();
            panel1.BackColor = Color.RoyalBlue;
            panel2.BackColor = Color.DeepSkyBlue;
            panel3.BackColor = Color.Indigo;
            panel4.BackColor = Color.CornflowerBlue;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
            EcoTimer.Stop();
            panel1.Width = 300;
            panel2.Width = 300;
            panel3.Width = 300;
            panel4.Width = 300;
          
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
     

        }
    }
}
