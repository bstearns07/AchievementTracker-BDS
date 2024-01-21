namespace AchievementTracker_BDS
{
    partial class FrmAchievementTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAchievementTracker));
            lstGameList = new ListBox();
            btnExit = new Button();
            btnAddGame = new Button();
            btnViewAchievements = new Button();
            lblGames = new Label();
            btnDeleteGame = new Button();
            btnAbout = new Button();
            SuspendLayout();
            // 
            // lstGameList
            // 
            lstGameList.BackColor = SystemColors.InactiveCaption;
            lstGameList.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lstGameList.FormattingEnabled = true;
            lstGameList.ItemHeight = 33;
            lstGameList.Location = new Point(110, 49);
            lstGameList.Margin = new Padding(6);
            lstGameList.Name = "lstGameList";
            lstGameList.Size = new Size(569, 367);
            lstGameList.TabIndex = 0;
            lstGameList.SelectedIndexChanged += LstGameList_SelectedIndexChanged;
            lstGameList.DoubleClick += BtnViewAchievements_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(693, 442);
            btnExit.Margin = new Padding(6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(199, 49);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // btnAddGame
            // 
            btnAddGame.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddGame.Location = new Point(693, 49);
            btnAddGame.Margin = new Padding(6);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(199, 49);
            btnAddGame.TabIndex = 2;
            btnAddGame.Text = "&Add Game";
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += BtnAddGame_Click;
            // 
            // btnViewAchievements
            // 
            btnViewAchievements.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewAchievements.Location = new Point(110, 442);
            btnViewAchievements.Margin = new Padding(6);
            btnViewAchievements.Name = "btnViewAchievements";
            btnViewAchievements.Size = new Size(262, 49);
            btnViewAchievements.TabIndex = 1;
            btnViewAchievements.Text = "&View Achievements";
            btnViewAchievements.UseVisualStyleBackColor = true;
            btnViewAchievements.Click += BtnViewAchievements_Click;
            // 
            // lblGames
            // 
            lblGames.AutoSize = true;
            lblGames.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGames.Location = new Point(6, 49);
            lblGames.Margin = new Padding(6, 0, 6, 0);
            lblGames.Name = "lblGames";
            lblGames.Size = new Size(93, 33);
            lblGames.TabIndex = 6;
            lblGames.Text = "Games:";
            // 
            // btnDeleteGame
            // 
            btnDeleteGame.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteGame.Location = new Point(693, 143);
            btnDeleteGame.Margin = new Padding(6);
            btnDeleteGame.Name = "btnDeleteGame";
            btnDeleteGame.Size = new Size(199, 49);
            btnDeleteGame.TabIndex = 3;
            btnDeleteGame.Text = "&Delete Game";
            btnDeleteGame.UseVisualStyleBackColor = true;
            btnDeleteGame.Click += BtnDeleteGame_Click;
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbout.Location = new Point(693, 361);
            btnAbout.Margin = new Padding(6);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(199, 49);
            btnAbout.TabIndex = 4;
            btnAbout.Text = "About This App";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += BtnAbout_Click;
            // 
            // frmAchievementTracker
            // 
            AcceptButton = btnViewAchievements;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = btnExit;
            ClientSize = new Size(919, 523);
            Controls.Add(btnAbout);
            Controls.Add(btnDeleteGame);
            Controls.Add(lblGames);
            Controls.Add(btnViewAchievements);
            Controls.Add(btnAddGame);
            Controls.Add(btnExit);
            Controls.Add(lstGameList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAchievementTracker";
            Text = "Achievement Tracker - Game Selection";
            Load += FrmAchievementTracker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGameList;
        private Button btnExit;
        private Button btnAddGame;
        private Button btnViewAchievements;
        private Label lblGames;
        private Button btnDeleteGame;
        private Button btnAbout;
    }
}