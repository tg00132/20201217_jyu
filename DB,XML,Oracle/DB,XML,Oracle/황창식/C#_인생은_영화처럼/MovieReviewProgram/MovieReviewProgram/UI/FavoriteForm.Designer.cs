
namespace MovieReviewProgram.UI
{
    partial class FavoriteForm
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
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.favoriteMoiveList = new System.Windows.Forms.ListView();
            this.mName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moviePoster = new CxFlatUI.CxFlatPictureBox();
            this.close = new CxFlatUI.Controls.CxFlatButton();
            this.movieDetail = new CxFlatUI.Controls.CxFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.Brown;
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.Maroon;
            this.uiSymbolButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(551, 7);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.RectColor = System.Drawing.Color.Brown;
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.Maroon;
            this.uiSymbolButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSymbolButton1.Size = new System.Drawing.Size(90, 35);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 61453;
            this.uiSymbolButton1.TabIndex = 2;
            this.uiSymbolButton1.Text = "Close";
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.uiSymbolButton1);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 48);
            this.panel1.TabIndex = 7;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(18, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(196, 48);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "My Favorite";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // favoriteMoiveList
            // 
            this.favoriteMoiveList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mName,
            this.mGenre,
            this.mReleaseDate});
            this.favoriteMoiveList.FullRowSelect = true;
            this.favoriteMoiveList.HideSelection = false;
            this.favoriteMoiveList.Location = new System.Drawing.Point(12, 54);
            this.favoriteMoiveList.Name = "favoriteMoiveList";
            this.favoriteMoiveList.Size = new System.Drawing.Size(305, 544);
            this.favoriteMoiveList.TabIndex = 8;
            this.favoriteMoiveList.UseCompatibleStateImageBehavior = false;
            this.favoriteMoiveList.View = System.Windows.Forms.View.Details;
            this.favoriteMoiveList.Click += new System.EventHandler(this.favoriteMoiveList_Click);
            // 
            // mName
            // 
            this.mName.Text = "영화 제목";
            this.mName.Width = 100;
            // 
            // mGenre
            // 
            this.mGenre.Text = "장르";
            this.mGenre.Width = 100;
            // 
            // mReleaseDate
            // 
            this.mReleaseDate.Text = "개봉일";
            this.mReleaseDate.Width = 100;
            // 
            // moviePoster
            // 
            this.moviePoster.BackColor = System.Drawing.Color.Transparent;
            this.moviePoster.Location = new System.Drawing.Point(356, 93);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(250, 375);
            this.moviePoster.TabIndex = 13;
            this.moviePoster.TabStop = false;
            // 
            // close
            // 
            this.close.ButtonType = CxFlatUI.ButtonType.Primary;
            this.close.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.close.Location = new System.Drawing.Point(490, 520);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(99, 35);
            this.close.TabIndex = 10;
            this.close.Text = "뒤로가기";
            this.close.TextColor = System.Drawing.Color.White;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // movieDetail
            // 
            this.movieDetail.ButtonType = CxFlatUI.ButtonType.Primary;
            this.movieDetail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.movieDetail.Location = new System.Drawing.Point(373, 520);
            this.movieDetail.Name = "movieDetail";
            this.movieDetail.Size = new System.Drawing.Size(99, 35);
            this.movieDetail.TabIndex = 11;
            this.movieDetail.Text = "영화 정보";
            this.movieDetail.TextColor = System.Drawing.Color.White;
            this.movieDetail.Click += new System.EventHandler(this.movieDetail_Click);
            // 
            // FavoriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.favoriteMoiveList);
            this.Controls.Add(this.moviePoster);
            this.Controls.Add(this.close);
            this.Controls.Add(this.movieDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FavoriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FavoriteForm";
            this.Load += new System.EventHandler(this.FavoriteForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ListView favoriteMoiveList;
        private System.Windows.Forms.ColumnHeader mName;
        private System.Windows.Forms.ColumnHeader mReleaseDate;
        private CxFlatUI.CxFlatPictureBox moviePoster;
        private CxFlatUI.Controls.CxFlatButton close;
        private CxFlatUI.Controls.CxFlatButton movieDetail;
        private System.Windows.Forms.ColumnHeader mGenre;
    }
}