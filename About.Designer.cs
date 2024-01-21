namespace AchievementTracker_BDS
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            lblAuthor = new Label();
            lblPublished = new Label();
            lblCompany = new Label();
            txtAuthor = new TextBox();
            txtPublished = new TextBox();
            txtCompany = new TextBox();
            lblAbout = new Label();
            txtAbout = new RichTextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor.Location = new Point(9, 32);
            lblAuthor.Margin = new Padding(6, 0, 6, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(99, 33);
            lblAuthor.TabIndex = 0;
            lblAuthor.Text = "Author:";
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPublished.Location = new Point(9, 115);
            lblPublished.Margin = new Padding(6, 0, 6, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(128, 33);
            lblPublished.TabIndex = 3;
            lblPublished.Text = "Published:";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompany.Location = new Point(9, 198);
            lblCompany.Margin = new Padding(6, 0, 6, 0);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(118, 33);
            lblCompany.TabIndex = 5;
            lblCompany.Text = "Company:";
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = SystemColors.ActiveCaption;
            txtAuthor.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthor.Location = new Point(219, 26);
            txtAuthor.Margin = new Padding(6);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(331, 41);
            txtAuthor.TabIndex = 2;
            txtAuthor.TabStop = false;
            // 
            // txtPublished
            // 
            txtPublished.BackColor = SystemColors.InactiveCaption;
            txtPublished.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublished.Location = new Point(219, 109);
            txtPublished.Margin = new Padding(6);
            txtPublished.Name = "txtPublished";
            txtPublished.ReadOnly = true;
            txtPublished.Size = new Size(331, 41);
            txtPublished.TabIndex = 4;
            txtPublished.TabStop = false;
            // 
            // txtCompany
            // 
            txtCompany.BackColor = SystemColors.InactiveCaption;
            txtCompany.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompany.Location = new Point(219, 198);
            txtCompany.Margin = new Padding(6);
            txtCompany.Name = "txtCompany";
            txtCompany.ReadOnly = true;
            txtCompany.Size = new Size(331, 41);
            txtCompany.TabIndex = 6;
            txtCompany.TabStop = false;
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAbout.Location = new Point(9, 273);
            lblAbout.Margin = new Padding(6, 0, 6, 0);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(188, 33);
            lblAbout.TabIndex = 7;
            lblAbout.Text = "About this App:";
            // 
            // txtAbout
            // 
            txtAbout.BackColor = SystemColors.InactiveCaption;
            txtAbout.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAbout.Location = new Point(219, 273);
            txtAbout.Margin = new Padding(6);
            txtAbout.Name = "txtAbout";
            txtAbout.ReadOnly = true;
            txtAbout.Size = new Size(1003, 463);
            txtAbout.TabIndex = 8;
            txtAbout.Text = "";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1083, 767);
            btnBack.Margin = new Padding(6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 49);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = btnBack;
            ClientSize = new Size(1249, 828);
            ControlBox = false;
            Controls.Add(btnBack);
            Controls.Add(txtAbout);
            Controls.Add(lblAbout);
            Controls.Add(txtCompany);
            Controls.Add(txtPublished);
            Controls.Add(txtAuthor);
            Controls.Add(lblCompany);
            Controls.Add(lblPublished);
            Controls.Add(lblAuthor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            Text = "Achievement Tracker";
            Load += About_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAuthor;
        private Label lblPublished;
        private Label lblCompany;
        private TextBox txtAuthor;
        private TextBox txtPublished;
        private TextBox txtCompany;
        private Label lblAbout;
        private RichTextBox txtAbout;
        private Button btnBack;
    }
}