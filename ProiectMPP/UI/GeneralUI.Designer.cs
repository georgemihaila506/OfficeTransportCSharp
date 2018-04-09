namespace ProiectMPP.UI
{
    partial class GeneralUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReserveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.OfficeName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SignOut = new Bunifu.Framework.UI.BunifuImageButton();
            this.loadingAll1 = new ProiectMPP.UI.LoadingAll();
            this.findUser1 = new ProiectMPP.UI.FindUser();
            this.reserve1 = new ProiectMPP.UI.Reserve();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.ReserveButton);
            this.panel1.Controls.Add(this.OfficeName);
            this.panel1.Controls.Add(this.SignOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 100);
            this.panel1.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Activecolor = System.Drawing.Color.Black;
            this.SearchButton.BackColor = System.Drawing.Color.Black;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.BorderRadius = 0;
            this.SearchButton.ButtonText = "               Search";
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.DisabledColor = System.Drawing.Color.Gray;
            this.SearchButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SearchButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("SearchButton.Iconimage")));
            this.SearchButton.Iconimage_right = null;
            this.SearchButton.Iconimage_right_Selected = null;
            this.SearchButton.Iconimage_Selected = null;
            this.SearchButton.IconMarginLeft = 0;
            this.SearchButton.IconMarginRight = 0;
            this.SearchButton.IconRightVisible = true;
            this.SearchButton.IconRightZoom = 0D;
            this.SearchButton.IconVisible = true;
            this.SearchButton.IconZoom = 90D;
            this.SearchButton.IsTab = false;
            this.SearchButton.Location = new System.Drawing.Point(236, 17);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Normalcolor = System.Drawing.Color.Black;
            this.SearchButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.SearchButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SearchButton.selected = false;
            this.SearchButton.Size = new System.Drawing.Size(331, 59);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "               Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Textcolor = System.Drawing.Color.Cyan;
            this.SearchButton.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ReserveButton
            // 
            this.ReserveButton.Activecolor = System.Drawing.Color.Black;
            this.ReserveButton.BackColor = System.Drawing.Color.Black;
            this.ReserveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReserveButton.BorderRadius = 0;
            this.ReserveButton.ButtonText = "               Reserve";
            this.ReserveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReserveButton.DisabledColor = System.Drawing.Color.Gray;
            this.ReserveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ReserveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ReserveButton.Iconimage")));
            this.ReserveButton.Iconimage_right = null;
            this.ReserveButton.Iconimage_right_Selected = null;
            this.ReserveButton.Iconimage_Selected = null;
            this.ReserveButton.IconMarginLeft = 0;
            this.ReserveButton.IconMarginRight = 0;
            this.ReserveButton.IconRightVisible = true;
            this.ReserveButton.IconRightZoom = 0D;
            this.ReserveButton.IconVisible = true;
            this.ReserveButton.IconZoom = 90D;
            this.ReserveButton.IsTab = false;
            this.ReserveButton.Location = new System.Drawing.Point(617, 17);
            this.ReserveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Normalcolor = System.Drawing.Color.Black;
            this.ReserveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ReserveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ReserveButton.selected = false;
            this.ReserveButton.Size = new System.Drawing.Size(331, 59);
            this.ReserveButton.TabIndex = 2;
            this.ReserveButton.Text = "               Reserve";
            this.ReserveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReserveButton.Textcolor = System.Drawing.Color.Cyan;
            this.ReserveButton.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // OfficeName
            // 
            this.OfficeName.AutoSize = true;
            this.OfficeName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficeName.ForeColor = System.Drawing.Color.Cyan;
            this.OfficeName.Location = new System.Drawing.Point(3, 9);
            this.OfficeName.Name = "OfficeName";
            this.OfficeName.Size = new System.Drawing.Size(65, 23);
            this.OfficeName.TabIndex = 1;
            this.OfficeName.Text = "Office";
            // 
            // SignOut
            // 
            this.SignOut.BackColor = System.Drawing.Color.Black;
            this.SignOut.Image = ((System.Drawing.Image)(resources.GetObject("SignOut.Image")));
            this.SignOut.ImageActive = null;
            this.SignOut.Location = new System.Drawing.Point(1029, 12);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(64, 64);
            this.SignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SignOut.TabIndex = 0;
            this.SignOut.TabStop = false;
            this.SignOut.Zoom = 10;
            this.SignOut.Click += new System.EventHandler(this.Sign_Out);
            // 
            // loadingAll1
            // 
            this.loadingAll1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadingAll1.Location = new System.Drawing.Point(109, 106);
            this.loadingAll1.Name = "loadingAll1";
            this.loadingAll1.Size = new System.Drawing.Size(991, 519);
            this.loadingAll1.TabIndex = 4;
            // 
            // findUser1
            // 
            this.findUser1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.findUser1.Location = new System.Drawing.Point(109, 106);
            this.findUser1.Name = "findUser1";
            this.findUser1.Size = new System.Drawing.Size(991, 519);
            this.findUser1.TabIndex = 3;
            // 
            // reserve1
            // 
            this.reserve1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reserve1.Location = new System.Drawing.Point(109, 106);
            this.reserve1.Name = "reserve1";
            this.reserve1.Size = new System.Drawing.Size(951, 654);
            this.reserve1.TabIndex = 5;
            // 
            // GeneralUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 637);
            this.ControlBox = false;
            this.Controls.Add(this.reserve1);
            this.Controls.Add(this.loadingAll1);
            this.Controls.Add(this.findUser1);
            this.Controls.Add(this.panel1);
            this.Name = "GeneralUI";
            this.Text = "GeneralUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton SignOut;
        private Bunifu.Framework.UI.BunifuCustomLabel OfficeName;
        private Bunifu.Framework.UI.BunifuFlatButton SearchButton;
        private Bunifu.Framework.UI.BunifuFlatButton ReserveButton;
        private FindUser findUser1;
        private LoadingAll loadingAll1;
        private Reserve reserve1;
    }
}