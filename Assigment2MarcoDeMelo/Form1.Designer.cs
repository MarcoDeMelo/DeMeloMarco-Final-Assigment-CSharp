
namespace Assigment2MarcoDeMelo
{
    partial class Form1
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
            this.player2Box = new System.Windows.Forms.TextBox();
            this.player1Box = new System.Windows.Forms.TextBox();
            this.player2 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.player1ScoreBox = new System.Windows.Forms.TextBox();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.targetWord = new System.Windows.Forms.TextBox();
            this.targetWordLabel = new System.Windows.Forms.Label();
            this.insertPrompt = new System.Windows.Forms.Label();
            this.playerGuessBox = new System.Windows.Forms.TextBox();
            this.guessWordButton = new System.Windows.Forms.Button();
            this.pictureBoxWheel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).BeginInit();
            this.SuspendLayout();
            // 
            // player2Box
            // 
            this.player2Box.Location = new System.Drawing.Point(461, 43);
            this.player2Box.Margin = new System.Windows.Forms.Padding(4);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(156, 22);
            this.player2Box.TabIndex = 1;
            // 
            // player1Box
            // 
            this.player1Box.Location = new System.Drawing.Point(135, 43);
            this.player1Box.Margin = new System.Windows.Forms.Padding(4);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(160, 22);
            this.player1Box.TabIndex = 2;
            this.player1Box.TextChanged += new System.EventHandler(this.player1Box_TextChanged);
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.player2.Location = new System.Drawing.Point(340, 38);
            this.player2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(85, 25);
            this.player2.TabIndex = 3;
            this.player2.Text = "Player2";
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.ForeColor = System.Drawing.Color.DarkGreen;
            this.player1.Location = new System.Drawing.Point(13, 38);
            this.player1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(85, 25);
            this.player1.TabIndex = 4;
            this.player1.Text = "Player1";
            // 
            // player1ScoreBox
            // 
            this.player1ScoreBox.Location = new System.Drawing.Point(135, 89);
            this.player1ScoreBox.Margin = new System.Windows.Forms.Padding(4);
            this.player1ScoreBox.Name = "player1ScoreBox";
            this.player1ScoreBox.ReadOnly = true;
            this.player1ScoreBox.Size = new System.Drawing.Size(160, 22);
            this.player1ScoreBox.TabIndex = 5;
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.player1ScoreLabel.Location = new System.Drawing.Point(16, 81);
            this.player1ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(69, 25);
            this.player1ScoreLabel.TabIndex = 6;
            this.player1ScoreLabel.Text = "Score";
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.player2ScoreLabel.Location = new System.Drawing.Point(340, 82);
            this.player2ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(69, 25);
            this.player2ScoreLabel.TabIndex = 7;
            this.player2ScoreLabel.Text = "Score";
            // 
            // player2ScoreBox
            // 
            this.player2ScoreBox.Location = new System.Drawing.Point(461, 90);
            this.player2ScoreBox.Margin = new System.Windows.Forms.Padding(4);
            this.player2ScoreBox.Name = "player2ScoreBox";
            this.player2ScoreBox.ReadOnly = true;
            this.player2ScoreBox.Size = new System.Drawing.Size(160, 22);
            this.player2ScoreBox.TabIndex = 8;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Tomato;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Khaki;
            this.startButton.Location = new System.Drawing.Point(855, 442);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(177, 97);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // targetWord
            // 
            this.targetWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetWord.Location = new System.Drawing.Point(899, 63);
            this.targetWord.Margin = new System.Windows.Forms.Padding(4);
            this.targetWord.Name = "targetWord";
            this.targetWord.ReadOnly = true;
            this.targetWord.Size = new System.Drawing.Size(151, 30);
            this.targetWord.TabIndex = 10;
            // 
            // targetWordLabel
            // 
            this.targetWordLabel.AutoSize = true;
            this.targetWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetWordLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.targetWordLabel.Location = new System.Drawing.Point(648, 59);
            this.targetWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.targetWordLabel.Name = "targetWordLabel";
            this.targetWordLabel.Size = new System.Drawing.Size(182, 32);
            this.targetWordLabel.TabIndex = 11;
            this.targetWordLabel.Text = "Target Word";
            // 
            // insertPrompt
            // 
            this.insertPrompt.AutoSize = true;
            this.insertPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertPrompt.ForeColor = System.Drawing.Color.Crimson;
            this.insertPrompt.Location = new System.Drawing.Point(812, 172);
            this.insertPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.insertPrompt.Name = "insertPrompt";
            this.insertPrompt.Size = new System.Drawing.Size(179, 25);
            this.insertPrompt.TabIndex = 12;
            this.insertPrompt.Text = "Insert guess here";
            this.insertPrompt.Click += new System.EventHandler(this.insertPrompt_Click);
            // 
            // playerGuessBox
            // 
            this.playerGuessBox.Location = new System.Drawing.Point(819, 222);
            this.playerGuessBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerGuessBox.Name = "playerGuessBox";
            this.playerGuessBox.Size = new System.Drawing.Size(212, 22);
            this.playerGuessBox.TabIndex = 13;
            // 
            // guessWordButton
            // 
            this.guessWordButton.Location = new System.Drawing.Point(871, 265);
            this.guessWordButton.Margin = new System.Windows.Forms.Padding(4);
            this.guessWordButton.Name = "guessWordButton";
            this.guessWordButton.Size = new System.Drawing.Size(161, 44);
            this.guessWordButton.TabIndex = 14;
            this.guessWordButton.Text = "Guess Word";
            this.guessWordButton.UseVisualStyleBackColor = true;
            this.guessWordButton.Click += new System.EventHandler(this.guessWordButton_Click);
            // 
            // pictureBoxWheel
            // 
            this.pictureBoxWheel.Image = global::Assigment2MarcoDeMelo.Properties.Resources.wheelPause;
            this.pictureBoxWheel.Location = new System.Drawing.Point(23, 143);
            this.pictureBoxWheel.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxWheel.Name = "pictureBoxWheel";
            this.pictureBoxWheel.Size = new System.Drawing.Size(763, 396);
            this.pictureBoxWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWheel.TabIndex = 0;
            this.pictureBoxWheel.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.guessWordButton);
            this.Controls.Add(this.playerGuessBox);
            this.Controls.Add(this.insertPrompt);
            this.Controls.Add(this.targetWordLabel);
            this.Controls.Add(this.targetWord);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.player2ScoreBox);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.player1ScoreBox);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1Box);
            this.Controls.Add(this.player2Box);
            this.Controls.Add(this.pictureBoxWheel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWheel;
        private System.Windows.Forms.TextBox player2Box;
        private System.Windows.Forms.TextBox player1Box;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.TextBox player1ScoreBox;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.TextBox player2ScoreBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox targetWord;
        private System.Windows.Forms.Label targetWordLabel;
        private System.Windows.Forms.Label insertPrompt;
        private System.Windows.Forms.TextBox playerGuessBox;
        private System.Windows.Forms.Button guessWordButton;
    }
}

