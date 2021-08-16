
namespace MovieReviewProgram.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.searchMovieBtn = new Sunny.UI.UIImageButton();
            this.searchTvBtn = new Sunny.UI.UIImageButton();
            this.searchPersonBtn = new Sunny.UI.UIImageButton();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.uiImageButton2 = new Sunny.UI.UIImageButton();
            this.favoriteMovieBtn = new Sunny.UI.UIImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMovieBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTvBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPersonBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteMovieBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 48);
            this.panel1.TabIndex = 1;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(18, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(196, 48);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Movie Library";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchMovieBtn
            // 
            this.searchMovieBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.searchMovieBtn.ForeColor = System.Drawing.Color.White;
            this.searchMovieBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchMovieBtn.Image")));
            this.searchMovieBtn.Location = new System.Drawing.Point(16, 67);
            this.searchMovieBtn.Name = "searchMovieBtn";
            this.searchMovieBtn.Size = new System.Drawing.Size(303, 258);
            this.searchMovieBtn.TabIndex = 2;
            this.searchMovieBtn.TabStop = false;
            this.searchMovieBtn.Text = "Search Movie";
            this.searchMovieBtn.Click += new System.EventHandler(this.searchMovieBtn_Click);
            // 
            // searchTvBtn
            // 
            this.searchTvBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchTvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.searchTvBtn.ForeColor = System.Drawing.Color.White;
            this.searchTvBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchTvBtn.Image")));
            this.searchTvBtn.Location = new System.Drawing.Point(325, 67);
            this.searchTvBtn.Name = "searchTvBtn";
            this.searchTvBtn.Size = new System.Drawing.Size(303, 258);
            this.searchTvBtn.TabIndex = 2;
            this.searchTvBtn.TabStop = false;
            this.searchTvBtn.Text = "Search TV Show";
            this.searchTvBtn.Click += new System.EventHandler(this.searchTvBtn_Click);
            // 
            // searchPersonBtn
            // 
            this.searchPersonBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPersonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.searchPersonBtn.ForeColor = System.Drawing.Color.White;
            this.searchPersonBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchPersonBtn.Image")));
            this.searchPersonBtn.Location = new System.Drawing.Point(16, 331);
            this.searchPersonBtn.Name = "searchPersonBtn";
            this.searchPersonBtn.Size = new System.Drawing.Size(303, 258);
            this.searchPersonBtn.TabIndex = 2;
            this.searchPersonBtn.TabStop = false;
            this.searchPersonBtn.Text = "Search Person";
            this.searchPersonBtn.Click += new System.EventHandler(this.searchPersonBtn_Click);
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.uiImageButton1.ForeColor = System.Drawing.Color.White;
            this.uiImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("uiImageButton1.Image")));
            this.uiImageButton1.Location = new System.Drawing.Point(468, 331);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(160, 128);
            this.uiImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton1.TabIndex = 3;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = "About Program";
            this.uiImageButton1.Click += new System.EventHandler(this.uiImageButton1_Click);
            // 
            // uiImageButton2
            // 
            this.uiImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.uiImageButton2.ForeColor = System.Drawing.Color.White;
            this.uiImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("uiImageButton2.Image")));
            this.uiImageButton2.Location = new System.Drawing.Point(468, 461);
            this.uiImageButton2.Name = "uiImageButton2";
            this.uiImageButton2.Size = new System.Drawing.Size(160, 128);
            this.uiImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton2.TabIndex = 3;
            this.uiImageButton2.TabStop = false;
            this.uiImageButton2.Text = "Program Exit";
            this.uiImageButton2.Click += new System.EventHandler(this.uiImageButton2_Click);
            // 
            // favoriteMovieBtn
            // 
            this.favoriteMovieBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoriteMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.favoriteMovieBtn.ForeColor = System.Drawing.Color.White;
            this.favoriteMovieBtn.Image = ((System.Drawing.Image)(resources.GetObject("favoriteMovieBtn.Image")));
            this.favoriteMovieBtn.Location = new System.Drawing.Point(325, 331);
            this.favoriteMovieBtn.Name = "favoriteMovieBtn";
            this.favoriteMovieBtn.Size = new System.Drawing.Size(137, 258);
            this.favoriteMovieBtn.TabIndex = 2;
            this.favoriteMovieBtn.TabStop = false;
            this.favoriteMovieBtn.Text = "Favorite";
            this.favoriteMovieBtn.Click += new System.EventHandler(this.favoriteMovieBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(646, 604);
            this.Controls.Add(this.uiImageButton2);
            this.Controls.Add(this.uiImageButton1);
            this.Controls.Add(this.favoriteMovieBtn);
            this.Controls.Add(this.searchPersonBtn);
            this.Controls.Add(this.searchTvBtn);
            this.Controls.Add(this.searchMovieBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchMovieBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTvBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPersonBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteMovieBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIImageButton searchMovieBtn;
        private Sunny.UI.UIImageButton searchTvBtn;
        private Sunny.UI.UIImageButton searchPersonBtn;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UIImageButton uiImageButton2;
        private Sunny.UI.UIImageButton favoriteMovieBtn;
    }
}