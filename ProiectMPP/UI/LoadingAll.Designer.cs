namespace ProiectMPP.UI
{
    partial class LoadingAll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.All = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.All)).BeginInit();
            this.SuspendLayout();
            // 
            // All
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.All.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.All.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.All.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.All.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.All.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.All.DoubleBuffered = true;
            this.All.EnableHeadersVisualStyles = false;
            this.All.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.All.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.All.HeaderForeColor = System.Drawing.Color.Black;
            this.All.Location = new System.Drawing.Point(181, 149);
            this.All.Name = "All";
            this.All.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.All.RowTemplate.Height = 24;
            this.All.Size = new System.Drawing.Size(568, 361);
            this.All.TabIndex = 0;
            this.All.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.All_CellContentClick);
            this.All.Click += new System.EventHandler(this.LoadingAll_Load);
            this.All.Enter += new System.EventHandler(this.LoadingAll_Load);
            this.All.MouseClick += new System.Windows.Forms.MouseEventHandler(this.All_MouseClick);
            // 
            // LoadingAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.All);
            this.Name = "LoadingAll";
            this.Size = new System.Drawing.Size(942, 659);
            this.Load += new System.EventHandler(this.LoadingAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.All)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid All;
    }
}
