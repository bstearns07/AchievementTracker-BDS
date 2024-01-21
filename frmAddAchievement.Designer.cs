namespace AchievementTracker_BDS
{
    partial class frmAddAchievement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAchievement));
            btnSave = new Button();
            btnCancel = new Button();
            lblTrophyName = new Label();
            lblDescription = new Label();
            txtAchievementName = new TextBox();
            rchtxtDescription = new RichTextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(344, 358);
            btnSave.Margin = new Padding(6, 6, 6, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 49);
            btnSave.TabIndex = 3;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(539, 358);
            btnCancel.Margin = new Padding(6, 6, 6, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 49);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTrophyName
            // 
            lblTrophyName.AutoSize = true;
            lblTrophyName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrophyName.Location = new Point(37, 49);
            lblTrophyName.Margin = new Padding(6, 0, 6, 0);
            lblTrophyName.Name = "lblTrophyName";
            lblTrophyName.Size = new Size(233, 33);
            lblTrophyName.TabIndex = 0;
            lblTrophyName.Text = "Achievement Name:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(121, 128);
            lblDescription.Margin = new Padding(6, 0, 6, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(150, 33);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description:";
            // 
            // txtAchievementName
            // 
            txtAchievementName.BackColor = SystemColors.InactiveCaption;
            txtAchievementName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAchievementName.Location = new Point(279, 47);
            txtAchievementName.Margin = new Padding(6, 6, 6, 6);
            txtAchievementName.Name = "txtAchievementName";
            txtAchievementName.Size = new Size(515, 41);
            txtAchievementName.TabIndex = 1;
            // 
            // rchtxtDescription
            // 
            rchtxtDescription.BackColor = SystemColors.InactiveCaption;
            rchtxtDescription.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rchtxtDescription.Location = new Point(279, 128);
            rchtxtDescription.Margin = new Padding(4, 2, 4, 2);
            rchtxtDescription.Name = "rchtxtDescription";
            rchtxtDescription.Size = new Size(515, 224);
            rchtxtDescription.TabIndex = 2;
            rchtxtDescription.Text = "";
            // 
            // frmAddAchievement
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = btnCancel;
            ClientSize = new Size(804, 448);
            ControlBox = false;
            Controls.Add(rchtxtDescription);
            Controls.Add(txtAchievementName);
            Controls.Add(lblDescription);
            Controls.Add(lblTrophyName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddAchievement";
            Text = "Add Trophy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label lblTrophyName;
        private Label lblDescription;
        private TextBox txtAchievementName;
        private RichTextBox rchtxtDescription;
    }
}