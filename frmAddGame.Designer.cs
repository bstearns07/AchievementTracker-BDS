namespace AchievementTracker_BDS
{
    partial class FrmAddGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddGame));
            lblGameTitle = new Label();
            txtGameTitle = new TextBox();
            lblPlatform = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            cboPlatforms = new ComboBox();
            SuspendLayout();
            // 
            // lblGameTitle
            // 
            lblGameTitle.AutoSize = true;
            lblGameTitle.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGameTitle.Location = new Point(7, 75);
            lblGameTitle.Margin = new Padding(6, 0, 6, 0);
            lblGameTitle.Name = "lblGameTitle";
            lblGameTitle.Size = new Size(141, 33);
            lblGameTitle.TabIndex = 0;
            lblGameTitle.Text = "Game Title:";
            // 
            // txtGameTitle
            // 
            txtGameTitle.BackColor = SystemColors.InactiveCaption;
            txtGameTitle.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGameTitle.Location = new Point(154, 75);
            txtGameTitle.Margin = new Padding(6, 6, 6, 6);
            txtGameTitle.Name = "txtGameTitle";
            txtGameTitle.Size = new Size(450, 41);
            txtGameTitle.TabIndex = 1;
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlatform.Location = new Point(7, 171);
            lblPlatform.Margin = new Padding(6, 0, 6, 0);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(118, 33);
            lblPlatform.TabIndex = 5;
            lblPlatform.Text = "Platform:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(154, 243);
            btnSave.Margin = new Padding(6, 6, 6, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 49);
            btnSave.TabIndex = 3;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(355, 243);
            btnCancel.Margin = new Padding(6, 6, 6, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 49);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // cboPlatforms
            // 
            cboPlatforms.BackColor = SystemColors.InactiveCaption;
            cboPlatforms.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboPlatforms.FormattingEnabled = true;
            cboPlatforms.Location = new Point(152, 169);
            cboPlatforms.Margin = new Padding(4, 2, 4, 2);
            cboPlatforms.Name = "cboPlatforms";
            cboPlatforms.Size = new Size(452, 41);
            cboPlatforms.TabIndex = 2;
            // 
            // frmAddGame
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = btnCancel;
            ClientSize = new Size(650, 347);
            ControlBox = false;
            Controls.Add(cboPlatforms);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblPlatform);
            Controls.Add(txtGameTitle);
            Controls.Add(lblGameTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddGame";
            Text = "Add Game";
            Load += FrmAddGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGameTitle;
        private TextBox txtGameTitle;
        private Label lblPlatform;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cboPlatforms;
    }
}