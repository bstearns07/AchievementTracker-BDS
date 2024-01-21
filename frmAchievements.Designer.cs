namespace AchievementTracker_BDS
{
    partial class FrmAchievements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAchievements));
            lblComplete = new Label();
            txtComplete = new TextBox();
            lblDescription = new Label();
            lblAchievements = new Label();
            rchtxtDescription = new RichTextBox();
            btnBack = new Button();
            btnDelete = new Button();
            btnAddAchievement = new Button();
            chklstAchievements = new CheckedListBox();
            TxtNumberOfTrophies = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblComplete
            // 
            lblComplete.AutoSize = true;
            lblComplete.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblComplete.Location = new Point(616, 15);
            lblComplete.Margin = new Padding(6, 0, 6, 0);
            lblComplete.Name = "lblComplete";
            lblComplete.Size = new Size(215, 33);
            lblComplete.TabIndex = 8;
            lblComplete.Text = "Percent Complete:";
            // 
            // txtComplete
            // 
            txtComplete.BackColor = SystemColors.InactiveCaption;
            txtComplete.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplete.Location = new Point(834, 15);
            txtComplete.Margin = new Padding(6);
            txtComplete.Multiline = true;
            txtComplete.Name = "txtComplete";
            txtComplete.ReadOnly = true;
            txtComplete.Size = new Size(91, 33);
            txtComplete.TabIndex = 7;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(76, 576);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(150, 33);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description:";
            // 
            // lblAchievements
            // 
            lblAchievements.AutoSize = true;
            lblAchievements.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAchievements.Location = new Point(50, 55);
            lblAchievements.Margin = new Padding(4, 0, 4, 0);
            lblAchievements.Name = "lblAchievements";
            lblAchievements.Size = new Size(176, 33);
            lblAchievements.TabIndex = 3;
            lblAchievements.Text = "Achievements:";
            // 
            // rchtxtDescription
            // 
            rchtxtDescription.BackColor = SystemColors.InactiveCaption;
            rchtxtDescription.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rchtxtDescription.Location = new Point(234, 576);
            rchtxtDescription.Margin = new Padding(4, 2, 4, 2);
            rchtxtDescription.Name = "rchtxtDescription";
            rchtxtDescription.ReadOnly = true;
            rchtxtDescription.Size = new Size(675, 123);
            rchtxtDescription.TabIndex = 6;
            rchtxtDescription.Text = "";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(933, 652);
            btnBack.Margin = new Padding(4, 2, 4, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(253, 47);
            btnBack.TabIndex = 2;
            btnBack.Text = "&Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(933, 134);
            btnDelete.Margin = new Padding(4, 2, 4, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(253, 47);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "&Delete Achievement";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnAddAchievement
            // 
            btnAddAchievement.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAchievement.Location = new Point(933, 55);
            btnAddAchievement.Margin = new Padding(4, 2, 4, 2);
            btnAddAchievement.Name = "btnAddAchievement";
            btnAddAchievement.Size = new Size(253, 47);
            btnAddAchievement.TabIndex = 0;
            btnAddAchievement.Text = "&Add Achievement";
            btnAddAchievement.UseVisualStyleBackColor = true;
            btnAddAchievement.Click += BtnAddAchievement_Click;
            // 
            // chklstAchievements
            // 
            chklstAchievements.BackColor = SystemColors.InactiveCaption;
            chklstAchievements.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chklstAchievements.FormattingEnabled = true;
            chklstAchievements.Location = new Point(234, 55);
            chklstAchievements.Margin = new Padding(4, 2, 4, 2);
            chklstAchievements.Name = "chklstAchievements";
            chklstAchievements.Size = new Size(691, 498);
            chklstAchievements.TabIndex = 4;
            chklstAchievements.ItemCheck += ChklstAchievements_ItemCheck;
            chklstAchievements.SelectedIndexChanged += ChklstAchievements_SelectedIndexChanged;
            // 
            // TxtNumberOfTrophies
            // 
            TxtNumberOfTrophies.BackColor = SystemColors.InactiveCaption;
            TxtNumberOfTrophies.Location = new Point(542, 15);
            TxtNumberOfTrophies.Multiline = true;
            TxtNumberOfTrophies.Name = "TxtNumberOfTrophies";
            TxtNumberOfTrophies.ReadOnly = true;
            TxtNumberOfTrophies.Size = new Size(65, 33);
            TxtNumberOfTrophies.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 13);
            label1.Name = "label1";
            label1.Size = new Size(302, 33);
            label1.TabIndex = 11;
            label1.Text = "Number of Achievements:";
            // 
            // FrmAchievements
            // 
            AcceptButton = btnAddAchievement;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = btnBack;
            ClientSize = new Size(1204, 726);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(TxtNumberOfTrophies);
            Controls.Add(lblComplete);
            Controls.Add(txtComplete);
            Controls.Add(chklstAchievements);
            Controls.Add(lblDescription);
            Controls.Add(lblAchievements);
            Controls.Add(rchtxtDescription);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnAddAchievement);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAchievements";
            Text = "Achievements";
            FormClosing += FrmAchievements_FormClosing;
            Load += Achievements_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComplete;
        private TextBox txtComplete;
        private Label lblDescription;
        private Label lblAchievements;
        private RichTextBox rchtxtDescription;
        private Button btnBack;
        private Button btnDelete;
        private Button btnAddAchievement;
        private CheckedListBox chklstAchievements;
        private TextBox TxtNumberOfTrophies;
        private Label label1;
    }
}