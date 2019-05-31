namespace Something_Something_Wizards
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.uselessButton = new System.Windows.Forms.Button();
            this.defendButton = new System.Windows.Forms.Button();
            this.passButton = new System.Windows.Forms.Button();
            this.attack1Button = new System.Windows.Forms.Button();
            this.attack2Button = new System.Windows.Forms.Button();
            this.attack3Button = new System.Windows.Forms.Button();
            this.attack4Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 8;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(199, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "What will you do?";
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.attackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.attackButton.Location = new System.Drawing.Point(72, 339);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(185, 36);
            this.attackButton.TabIndex = 1;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // uselessButton
            // 
            this.uselessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.uselessButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.uselessButton.Location = new System.Drawing.Point(529, 400);
            this.uselessButton.Name = "uselessButton";
            this.uselessButton.Size = new System.Drawing.Size(185, 36);
            this.uselessButton.TabIndex = 2;
            this.uselessButton.Text = "Press for Money!";
            this.uselessButton.UseVisualStyleBackColor = true;
            // 
            // defendButton
            // 
            this.defendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.defendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.defendButton.Location = new System.Drawing.Point(72, 400);
            this.defendButton.Name = "defendButton";
            this.defendButton.Size = new System.Drawing.Size(185, 36);
            this.defendButton.TabIndex = 3;
            this.defendButton.Text = "Defend";
            this.defendButton.UseVisualStyleBackColor = true;
            // 
            // passButton
            // 
            this.passButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passButton.Location = new System.Drawing.Point(529, 339);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(185, 36);
            this.passButton.TabIndex = 4;
            this.passButton.Text = "Pass";
            this.passButton.UseVisualStyleBackColor = true;
            // 
            // attack1Button
            // 
            this.attack1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.attack1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.attack1Button.Location = new System.Drawing.Point(72, 339);
            this.attack1Button.Name = "attack1Button";
            this.attack1Button.Size = new System.Drawing.Size(185, 36);
            this.attack1Button.TabIndex = 5;
            this.attack1Button.UseVisualStyleBackColor = true;
            this.attack1Button.Visible = false;
            this.attack1Button.Click += new System.EventHandler(this.attack1Button_Click);
            // 
            // attack2Button
            // 
            this.attack2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.attack2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.attack2Button.Location = new System.Drawing.Point(529, 339);
            this.attack2Button.Name = "attack2Button";
            this.attack2Button.Size = new System.Drawing.Size(185, 36);
            this.attack2Button.TabIndex = 6;
            this.attack2Button.UseVisualStyleBackColor = true;
            this.attack2Button.Visible = false;
            // 
            // attack3Button
            // 
            this.attack3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.attack3Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.attack3Button.Location = new System.Drawing.Point(72, 400);
            this.attack3Button.Name = "attack3Button";
            this.attack3Button.Size = new System.Drawing.Size(185, 36);
            this.attack3Button.TabIndex = 7;
            this.attack3Button.UseVisualStyleBackColor = true;
            this.attack3Button.Visible = false;
            // 
            // attack4Button
            // 
            this.attack4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.attack4Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.attack4Button.Location = new System.Drawing.Point(529, 400);
            this.attack4Button.Name = "attack4Button";
            this.attack4Button.Size = new System.Drawing.Size(185, 36);
            this.attack4Button.TabIndex = 8;
            this.attack4Button.UseVisualStyleBackColor = true;
            this.attack4Button.Visible = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.attack4Button);
            this.Controls.Add(this.attack3Button);
            this.Controls.Add(this.attack2Button);
            this.Controls.Add(this.attack1Button);
            this.Controls.Add(this.passButton);
            this.Controls.Add(this.defendButton);
            this.Controls.Add(this.uselessButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button uselessButton;
        private System.Windows.Forms.Button defendButton;
        private System.Windows.Forms.Button passButton;
        private System.Windows.Forms.Button attack1Button;
        private System.Windows.Forms.Button attack2Button;
        private System.Windows.Forms.Button attack3Button;
        private System.Windows.Forms.Button attack4Button;
    }
}
