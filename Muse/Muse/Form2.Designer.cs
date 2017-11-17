namespace Muse
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.RandomSongTitleLabel = new System.Windows.Forms.Label();
            this.RandomSongLabel = new System.Windows.Forms.Label();
            this.RateSongsButton = new System.Windows.Forms.Button();
            this.SomethingLikedButton = new System.Windows.Forms.Button();
            this.SomethingNewButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SongsRatedLabel = new System.Windows.Forms.Label();
            this.Advertisement1Label = new System.Windows.Forms.Label();
            this.Advertisement2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(12, 34);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(59, 25);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Time";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(12, 59);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(57, 25);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.Location = new System.Drawing.Point(12, 9);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(73, 25);
            this.ProfileLabel.TabIndex = 2;
            this.ProfileLabel.Text = "Profile";
            // 
            // RandomSongTitleLabel
            // 
            this.RandomSongTitleLabel.AutoSize = true;
            this.RandomSongTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.RandomSongTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomSongTitleLabel.Location = new System.Drawing.Point(479, 9);
            this.RandomSongTitleLabel.Name = "RandomSongTitleLabel";
            this.RandomSongTitleLabel.Size = new System.Drawing.Size(143, 24);
            this.RandomSongTitleLabel.TabIndex = 3;
            this.RandomSongTitleLabel.Text = "Song of the Day";
            // 
            // RandomSongLabel
            // 
            this.RandomSongLabel.BackColor = System.Drawing.Color.Transparent;
            this.RandomSongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomSongLabel.Location = new System.Drawing.Point(317, 43);
            this.RandomSongLabel.Name = "RandomSongLabel";
            this.RandomSongLabel.Size = new System.Drawing.Size(305, 50);
            this.RandomSongLabel.TabIndex = 4;
            this.RandomSongLabel.Text = "label1";
            this.RandomSongLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.RandomSongLabel.TextChanged += new System.EventHandler(this.RandomSongLabel_TextChanged);
            // 
            // RateSongsButton
            // 
            this.RateSongsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateSongsButton.Location = new System.Drawing.Point(12, 150);
            this.RateSongsButton.Name = "RateSongsButton";
            this.RateSongsButton.Size = new System.Drawing.Size(332, 55);
            this.RateSongsButton.TabIndex = 5;
            this.RateSongsButton.Text = "Rate Songs";
            this.RateSongsButton.UseVisualStyleBackColor = true;
            this.RateSongsButton.Click += new System.EventHandler(this.RateSongsButton_Click);
            // 
            // SomethingLikedButton
            // 
            this.SomethingLikedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SomethingLikedButton.Location = new System.Drawing.Point(12, 255);
            this.SomethingLikedButton.Name = "SomethingLikedButton";
            this.SomethingLikedButton.Size = new System.Drawing.Size(332, 55);
            this.SomethingLikedButton.TabIndex = 6;
            this.SomethingLikedButton.Text = "Something I\'d Like";
            this.SomethingLikedButton.UseVisualStyleBackColor = true;
            this.SomethingLikedButton.Click += new System.EventHandler(this.SomethingLikedButton_Click);
            // 
            // SomethingNewButton
            // 
            this.SomethingNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SomethingNewButton.Location = new System.Drawing.Point(12, 325);
            this.SomethingNewButton.Name = "SomethingNewButton";
            this.SomethingNewButton.Size = new System.Drawing.Size(332, 55);
            this.SomethingNewButton.TabIndex = 7;
            this.SomethingNewButton.Text = "Something New";
            this.SomethingNewButton.UseVisualStyleBackColor = true;
            this.SomethingNewButton.Click += new System.EventHandler(this.SomethingNewButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(527, 416);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(95, 33);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SongsRatedLabel
            // 
            this.SongsRatedLabel.BackColor = System.Drawing.Color.Transparent;
            this.SongsRatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongsRatedLabel.Location = new System.Drawing.Point(365, 150);
            this.SongsRatedLabel.Name = "SongsRatedLabel";
            this.SongsRatedLabel.Size = new System.Drawing.Size(257, 55);
            this.SongsRatedLabel.TabIndex = 9;
            this.SongsRatedLabel.Text = "Songs Rated: 0";
            this.SongsRatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Advertisement1Label
            // 
            this.Advertisement1Label.AutoSize = true;
            this.Advertisement1Label.BackColor = System.Drawing.Color.Transparent;
            this.Advertisement1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advertisement1Label.Location = new System.Drawing.Point(375, 262);
            this.Advertisement1Label.MaximumSize = new System.Drawing.Size(270, 0);
            this.Advertisement1Label.Name = "Advertisement1Label";
            this.Advertisement1Label.Size = new System.Drawing.Size(243, 40);
            this.Advertisement1Label.TabIndex = 10;
            this.Advertisement1Label.Text = "Rating more songs leads to more accurate recommendations!";
            this.Advertisement1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Advertisement2Label
            // 
            this.Advertisement2Label.BackColor = System.Drawing.Color.Transparent;
            this.Advertisement2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advertisement2Label.Location = new System.Drawing.Point(375, 332);
            this.Advertisement2Label.Name = "Advertisement2Label";
            this.Advertisement2Label.Size = new System.Drawing.Size(247, 40);
            this.Advertisement2Label.TabIndex = 11;
            this.Advertisement2Label.Text = "Get acquainted with a new genre!";
            this.Advertisement2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.Advertisement2Label);
            this.Controls.Add(this.Advertisement1Label);
            this.Controls.Add(this.SongsRatedLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SomethingNewButton);
            this.Controls.Add(this.SomethingLikedButton);
            this.Controls.Add(this.RateSongsButton);
            this.Controls.Add(this.RandomSongLabel);
            this.Controls.Add(this.RandomSongTitleLabel);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Muse Home";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Label RandomSongTitleLabel;
        private System.Windows.Forms.Label RandomSongLabel;
        private System.Windows.Forms.Button RateSongsButton;
        private System.Windows.Forms.Button SomethingLikedButton;
        private System.Windows.Forms.Button SomethingNewButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label SongsRatedLabel;
        private System.Windows.Forms.Label Advertisement1Label;
        private System.Windows.Forms.Label Advertisement2Label;
    }
}