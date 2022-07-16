
namespace _201902027_Final_Odevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.levelValue = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.timeLeft = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.img5 = new System.Windows.Forms.PictureBox();
            this.img10 = new System.Windows.Forms.PictureBox();
            this.dupimg5 = new System.Windows.Forms.PictureBox();
            this.dupimg10 = new System.Windows.Forms.PictureBox();
            this.img4 = new System.Windows.Forms.PictureBox();
            this.img9 = new System.Windows.Forms.PictureBox();
            this.dupimg4 = new System.Windows.Forms.PictureBox();
            this.dupimg9 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.img8 = new System.Windows.Forms.PictureBox();
            this.dupimg3 = new System.Windows.Forms.PictureBox();
            this.dupimg8 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img7 = new System.Windows.Forms.PictureBox();
            this.dupimg2 = new System.Windows.Forms.PictureBox();
            this.dupimg7 = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img6 = new System.Windows.Forms.PictureBox();
            this.dupimg1 = new System.Windows.Forms.PictureBox();
            this.dupimg6 = new System.Windows.Forms.PictureBox();
            this.ScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeRemaining = new System.Windows.Forms.Timer(this.components);
            this.FlipTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EcoTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // levelValue
            // 
            this.levelValue.AutoSize = true;
            this.levelValue.BackColor = System.Drawing.Color.Transparent;
            this.levelValue.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelValue.ForeColor = System.Drawing.SystemColors.Control;
            this.levelValue.Location = new System.Drawing.Point(758, 31);
            this.levelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levelValue.Name = "levelValue";
            this.levelValue.Size = new System.Drawing.Size(34, 42);
            this.levelValue.TabIndex = 17;
            this.levelValue.Text = "1";
            this.levelValue.Click += new System.EventHandler(this.levelValue_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelLabel.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.levelLabel.Location = new System.Drawing.Point(669, 37);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(95, 27);
            this.levelLabel.TabIndex = 16;
            this.levelLabel.Text = "Seviye :";
            this.levelLabel.Click += new System.EventHandler(this.levelLabel_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.resetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(676, 300);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(201, 58);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Yeniden Oyna";
            this.resetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.BackColor = System.Drawing.Color.Transparent;
            this.timeLeft.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.timeLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.timeLeft.Location = new System.Drawing.Point(844, 248);
            this.timeLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(50, 42);
            this.timeLeft.TabIndex = 14;
            this.timeLeft.Text = "60";
            this.timeLeft.Click += new System.EventHandler(this.timeLeft_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.SystemColors.Control;
            this.Time.Location = new System.Drawing.Point(672, 254);
            this.Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(164, 27);
            this.Time.TabIndex = 13;
            this.Time.Text = "Kalan Zaman :";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(894, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 54);
            this.label1.TabIndex = 12;
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.BackColor = System.Drawing.Color.Transparent;
            this.ScoreCounter.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCounter.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreCounter.Location = new System.Drawing.Point(758, 209);
            this.ScoreCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(34, 42);
            this.ScoreCounter.TabIndex = 11;
            this.ScoreCounter.Text = "0";
            this.ScoreCounter.Click += new System.EventHandler(this.ScoreCounter_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreLabel.Location = new System.Drawing.Point(669, 215);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(77, 27);
            this.ScoreLabel.TabIndex = 10;
            this.ScoreLabel.Text = "Puan :";
            this.ScoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Transparent;
            this.GamePanel.Controls.Add(this.img5);
            this.GamePanel.Controls.Add(this.img10);
            this.GamePanel.Controls.Add(this.dupimg5);
            this.GamePanel.Controls.Add(this.dupimg10);
            this.GamePanel.Controls.Add(this.img4);
            this.GamePanel.Controls.Add(this.img9);
            this.GamePanel.Controls.Add(this.dupimg4);
            this.GamePanel.Controls.Add(this.dupimg9);
            this.GamePanel.Controls.Add(this.img3);
            this.GamePanel.Controls.Add(this.img8);
            this.GamePanel.Controls.Add(this.dupimg3);
            this.GamePanel.Controls.Add(this.dupimg8);
            this.GamePanel.Controls.Add(this.img2);
            this.GamePanel.Controls.Add(this.img7);
            this.GamePanel.Controls.Add(this.dupimg2);
            this.GamePanel.Controls.Add(this.dupimg7);
            this.GamePanel.Controls.Add(this.img1);
            this.GamePanel.Controls.Add(this.img6);
            this.GamePanel.Controls.Add(this.dupimg1);
            this.GamePanel.Controls.Add(this.dupimg6);
            this.GamePanel.Location = new System.Drawing.Point(10, 13);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(651, 530);
            this.GamePanel.TabIndex = 9;
            // 
            // img5
            // 
            this.img5.Location = new System.Drawing.Point(521, 7);
            this.img5.Margin = new System.Windows.Forms.Padding(4);
            this.img5.Name = "img5";
            this.img5.Size = new System.Drawing.Size(120, 123);
            this.img5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img5.TabIndex = 51;
            this.img5.TabStop = false;
            this.img5.Tag = "5";
            this.img5.Click += new System.EventHandler(this.img5_Click);
            // 
            // img10
            // 
            this.img10.Location = new System.Drawing.Point(521, 138);
            this.img10.Margin = new System.Windows.Forms.Padding(4);
            this.img10.Name = "img10";
            this.img10.Size = new System.Drawing.Size(120, 123);
            this.img10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img10.TabIndex = 50;
            this.img10.TabStop = false;
            this.img10.Tag = "10";
            this.img10.Click += new System.EventHandler(this.img10_Click);
            // 
            // dupimg5
            // 
            this.dupimg5.Location = new System.Drawing.Point(521, 268);
            this.dupimg5.Margin = new System.Windows.Forms.Padding(4);
            this.dupimg5.Name = "dupimg5";
            this.dupimg5.Size = new System.Drawing.Size(120, 123);
            this.dupimg5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg5.TabIndex = 49;
            this.dupimg5.TabStop = false;
            this.dupimg5.Tag = "5";
            this.dupimg5.Click += new System.EventHandler(this.dupimg5_Click);
            // 
            // dupimg10
            // 
            this.dupimg10.Location = new System.Drawing.Point(521, 399);
            this.dupimg10.Margin = new System.Windows.Forms.Padding(4);
            this.dupimg10.Name = "dupimg10";
            this.dupimg10.Size = new System.Drawing.Size(120, 123);
            this.dupimg10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg10.TabIndex = 48;
            this.dupimg10.TabStop = false;
            this.dupimg10.Tag = "10";
            this.dupimg10.Click += new System.EventHandler(this.dupimg10_Click);
            // 
            // img4
            // 
            this.img4.Location = new System.Drawing.Point(393, 7);
            this.img4.Margin = new System.Windows.Forms.Padding(4);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(120, 123);
            this.img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img4.TabIndex = 47;
            this.img4.TabStop = false;
            this.img4.Tag = "4";
            this.img4.Click += new System.EventHandler(this.img4_Click);
            // 
            // img9
            // 
            this.img9.Location = new System.Drawing.Point(393, 138);
            this.img9.Margin = new System.Windows.Forms.Padding(4);
            this.img9.Name = "img9";
            this.img9.Size = new System.Drawing.Size(120, 123);
            this.img9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img9.TabIndex = 46;
            this.img9.TabStop = false;
            this.img9.Tag = "9";
            this.img9.Click += new System.EventHandler(this.img9_Click);
            // 
            // dupimg4
            // 
            this.dupimg4.Location = new System.Drawing.Point(393, 268);
            this.dupimg4.Margin = new System.Windows.Forms.Padding(4);
            this.dupimg4.Name = "dupimg4";
            this.dupimg4.Size = new System.Drawing.Size(120, 123);
            this.dupimg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg4.TabIndex = 45;
            this.dupimg4.TabStop = false;
            this.dupimg4.Tag = "4";
            this.dupimg4.Click += new System.EventHandler(this.dupimg4_Click);
            // 
            // dupimg9
            // 
            this.dupimg9.Location = new System.Drawing.Point(393, 399);
            this.dupimg9.Margin = new System.Windows.Forms.Padding(4);
            this.dupimg9.Name = "dupimg9";
            this.dupimg9.Size = new System.Drawing.Size(120, 123);
            this.dupimg9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg9.TabIndex = 44;
            this.dupimg9.TabStop = false;
            this.dupimg9.Tag = "9";
            this.dupimg9.Click += new System.EventHandler(this.dupimg9_Click);
            // 
            // img3
            // 
            this.img3.Location = new System.Drawing.Point(265, 7);
            this.img3.Margin = new System.Windows.Forms.Padding(4);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(120, 123);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img3.TabIndex = 43;
            this.img3.TabStop = false;
            this.img3.Tag = "3";
            this.img3.Click += new System.EventHandler(this.img3_Click);
            // 
            // img8
            // 
            this.img8.Location = new System.Drawing.Point(265, 138);
            this.img8.Margin = new System.Windows.Forms.Padding(4);
            this.img8.Name = "img8";
            this.img8.Size = new System.Drawing.Size(120, 123);
            this.img8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img8.TabIndex = 42;
            this.img8.TabStop = false;
            this.img8.Tag = "8";
            this.img8.Click += new System.EventHandler(this.img8_Click);
            // 
            // dupimg3
            // 
            this.dupimg3.Location = new System.Drawing.Point(265, 268);
            this.dupimg3.Margin = new System.Windows.Forms.Padding(4);
            this.dupimg3.Name = "dupimg3";
            this.dupimg3.Size = new System.Drawing.Size(120, 123);
            this.dupimg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg3.TabIndex = 41;
            this.dupimg3.TabStop = false;
            this.dupimg3.Tag = "3";
            this.dupimg3.Click += new System.EventHandler(this.dupimg3_Click);
            // 
            // dupimg8
            // 
            this.dupimg8.Location = new System.Drawing.Point(265, 399);
            this.dupimg8.Margin = new System.Windows.Forms.Padding(4);
            this.dupimg8.Name = "dupimg8";
            this.dupimg8.Size = new System.Drawing.Size(120, 123);
            this.dupimg8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg8.TabIndex = 40;
            this.dupimg8.TabStop = false;
            this.dupimg8.Tag = "8";
            this.dupimg8.Click += new System.EventHandler(this.dupimg8_Click);
            // 
            // img2
            // 
            this.img2.Location = new System.Drawing.Point(137, 7);
            this.img2.Margin = new System.Windows.Forms.Padding(4);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(120, 123);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2.TabIndex = 39;
            this.img2.TabStop = false;
            this.img2.Tag = "2";
            this.img2.Click += new System.EventHandler(this.img2_Click);
            // 
            // img7
            // 
            this.img7.Location = new System.Drawing.Point(137, 138);
            this.img7.Margin = new System.Windows.Forms.Padding(4);
            this.img7.Name = "img7";
            this.img7.Size = new System.Drawing.Size(120, 123);
            this.img7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img7.TabIndex = 38;
            this.img7.TabStop = false;
            this.img7.Tag = "7";
            this.img7.Click += new System.EventHandler(this.img7_Click);
            // 
            // dupimg2
            // 
            this.dupimg2.Location = new System.Drawing.Point(137, 268);
            this.dupimg2.Margin = new System.Windows.Forms.Padding(4);
            this.dupimg2.Name = "dupimg2";
            this.dupimg2.Size = new System.Drawing.Size(120, 123);
            this.dupimg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg2.TabIndex = 37;
            this.dupimg2.TabStop = false;
            this.dupimg2.Tag = "2";
            this.dupimg2.Click += new System.EventHandler(this.dupimg2_Click);
            // 
            // dupimg7
            // 
            this.dupimg7.Location = new System.Drawing.Point(137, 399);
            this.dupimg7.Margin = new System.Windows.Forms.Padding(4);
            this.dupimg7.Name = "dupimg7";
            this.dupimg7.Size = new System.Drawing.Size(120, 123);
            this.dupimg7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg7.TabIndex = 36;
            this.dupimg7.TabStop = false;
            this.dupimg7.Tag = "7";
            this.dupimg7.Click += new System.EventHandler(this.dupimg7_Click);
            // 
            // img1
            // 
            this.img1.Location = new System.Drawing.Point(9, 7);
            this.img1.Margin = new System.Windows.Forms.Padding(4);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(120, 123);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 35;
            this.img1.TabStop = false;
            this.img1.Tag = "1";
            this.img1.Click += new System.EventHandler(this.img1_Click);
            // 
            // img6
            // 
            this.img6.Location = new System.Drawing.Point(9, 138);
            this.img6.Margin = new System.Windows.Forms.Padding(4);
            this.img6.Name = "img6";
            this.img6.Size = new System.Drawing.Size(120, 123);
            this.img6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img6.TabIndex = 34;
            this.img6.TabStop = false;
            this.img6.Tag = "6";
            this.img6.Click += new System.EventHandler(this.img6_Click);
            // 
            // dupimg1
            // 
            this.dupimg1.Location = new System.Drawing.Point(9, 268);
            this.dupimg1.Margin = new System.Windows.Forms.Padding(4);
            this.dupimg1.Name = "dupimg1";
            this.dupimg1.Size = new System.Drawing.Size(120, 123);
            this.dupimg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg1.TabIndex = 33;
            this.dupimg1.TabStop = false;
            this.dupimg1.Tag = "1";
            this.dupimg1.Click += new System.EventHandler(this.dupimg1_Click);
            // 
            // dupimg6
            // 
            this.dupimg6.Location = new System.Drawing.Point(9, 399);
            this.dupimg6.Margin = new System.Windows.Forms.Padding(4);
            this.dupimg6.Name = "dupimg6";
            this.dupimg6.Size = new System.Drawing.Size(120, 123);
            this.dupimg6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg6.TabIndex = 32;
            this.dupimg6.TabStop = false;
            this.dupimg6.Tag = "6";
            this.dupimg6.Click += new System.EventHandler(this.dupimg6_Click);
            // 
            // ScoreTimer
            // 
            this.ScoreTimer.Interval = 3000;
            this.ScoreTimer.Tick += new System.EventHandler(this.ScoreTimer_Tick);
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Interval = 1000;
            this.CountdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // TimeRemaining
            // 
            this.TimeRemaining.Interval = 1000;
            this.TimeRemaining.Tick += new System.EventHandler(this.TimeRemaining_Tick);
            // 
            // FlipTime
            // 
            this.FlipTime.Interval = 300;
            this.FlipTime.Tick += new System.EventHandler(this.FlipTime_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(19, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 10);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(19, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 10);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(19, 582);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 10);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Location = new System.Drawing.Point(19, 598);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(385, 10);
            this.panel4.TabIndex = 21;
            // 
            // EcoTimer
            // 
            this.EcoTimer.Tick += new System.EventHandler(this.EcoTimer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(677, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "Müzik Başlat";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(819, 560);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 42);
            this.button2.TabIndex = 27;
            this.button2.Text = "Müzik Durdur";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_201902027_Final_Odevi.Properties.Resources.Adsız_tasarım__1_;
            this.pictureBox1.Location = new System.Drawing.Point(677, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_201902027_Final_Odevi.Properties.Resources.Adsız_tasarım;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 624);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.levelValue);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreCounter);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GamePanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label levelValue;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.PictureBox img5;
        private System.Windows.Forms.PictureBox img10;
        private System.Windows.Forms.PictureBox dupimg5;
        private System.Windows.Forms.PictureBox dupimg10;
        private System.Windows.Forms.PictureBox img4;
        private System.Windows.Forms.PictureBox img9;
        private System.Windows.Forms.PictureBox dupimg4;
        private System.Windows.Forms.PictureBox dupimg9;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.PictureBox img8;
        private System.Windows.Forms.PictureBox dupimg3;
        private System.Windows.Forms.PictureBox dupimg8;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img7;
        private System.Windows.Forms.PictureBox dupimg2;
        private System.Windows.Forms.PictureBox dupimg7;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img6;
        private System.Windows.Forms.PictureBox dupimg1;
        private System.Windows.Forms.PictureBox dupimg6;
        private System.Windows.Forms.Timer ScoreTimer;
        private System.Windows.Forms.Timer CountdownTimer;
        private System.Windows.Forms.Timer TimeRemaining;
        private System.Windows.Forms.Timer FlipTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer EcoTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

