using ProiectMPP.Service;
namespace ProiectMPP.UI
{
    public partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Username = new Bunifu.Framework.UI.BunifuTextbox();
            this.Password = new Bunifu.Framework.UI.BunifuTextbox();
            this.LogInButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LogInLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LogInButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.BackColor = System.Drawing.Color.Gray;
            this.Username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Username.BackgroundImage")));
            this.Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Username.ForeColor = System.Drawing.Color.Cyan;
            this.Username.Icon = ((System.Drawing.Image)(resources.GetObject("Username.Icon")));
            this.Username.Location = new System.Drawing.Point(81, 128);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(229, 36);
            this.Username.TabIndex = 0;
            this.Username.text = "Username";
            this.Username.OnTextChange += new System.EventHandler(this.Username_OnTextChange);
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.BackColor = System.Drawing.Color.Gray;
            this.Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Password.BackgroundImage")));
            this.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Password.ForeColor = System.Drawing.Color.Cyan;
            this.Password.Icon = ((System.Drawing.Image)(resources.GetObject("Password.Icon")));
            this.Password.Location = new System.Drawing.Point(81, 203);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(229, 36);
            this.Password.TabIndex = 1;
            this.Password.text = "Password";
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInButton.BackColor = System.Drawing.Color.Gray;
            this.LogInButton.Image = ((System.Drawing.Image)(resources.GetObject("LogInButton.Image")));
            this.LogInButton.ImageActive = null;
            this.LogInButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogInButton.InitialImage")));
            this.LogInButton.Location = new System.Drawing.Point(260, 246);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(50, 50);
            this.LogInButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogInButton.TabIndex = 2;
            this.LogInButton.TabStop = false;
            this.LogInButton.Zoom = 10;
            this.LogInButton.Click += new System.EventHandler(this.LogInAction_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel1.TabIndex = 0;
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.BackColor = System.Drawing.Color.Gray;
            this.LogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel.ForeColor = System.Drawing.Color.Cyan;
            this.LogInLabel.Location = new System.Drawing.Point(157, 79);
            this.LogInLabel.Margin = new System.Windows.Forms.Padding(4);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(62, 24);
            this.LogInLabel.TabIndex = 3;
            this.LogInLabel.Text = "Log In";
            this.LogInLabel.Click += new System.EventHandler(this.LogInLabel_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(397, 360);
            this.Controls.Add(this.LogInLabel);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogInButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox Username;
        private Bunifu.Framework.UI.BunifuTextbox Password;
        private Bunifu.Framework.UI.BunifuImageButton LogInButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel LogInLabel;
    }
}