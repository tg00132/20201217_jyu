
namespace MovieReviewProgram.UI
{
    partial class SearchMovieForm
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
            this.movieSearchList = new System.Windows.Forms.ListView();
            this.mName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieDetail = new CxFlatUI.Controls.CxFlatButton();
            this.close = new CxFlatUI.Controls.CxFlatButton();
            this.moviePoster = new CxFlatUI.CxFlatPictureBox();
            this.searchBtn = new CxFlatUI.Controls.CxFlatButton();
            this.movieInput = new CxFlatUI.CxFlatTextBox();
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
            this.panel1.TabIndex = 2;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(18, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(196, 48);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Search Movie";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // movieSearchList
            // 
            this.movieSearchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mName,
            this.mReleaseDate});
            this.movieSearchList.FullRowSelect = true;
            this.movieSearchList.HideSelection = false;
            this.movieSearchList.Location = new System.Drawing.Point(12, 54);
            this.movieSearchList.Name = "movieSearchList";
            this.movieSearchList.Size = new System.Drawing.Size(305, 544);
            this.movieSearchList.TabIndex = 3;
            this.movieSearchList.UseCompatibleStateImageBehavior = false;
            this.movieSearchList.View = System.Windows.Forms.View.Details;
            this.movieSearchList.Click += new System.EventHandler(this.movieSearchList_Click);
            // 
            // mName
            // 
            this.mName.Text = "영화 제목";
            this.mName.Width = 150;
            // 
            // mReleaseDate
            // 
            this.mReleaseDate.Text = "개봉일";
            this.mReleaseDate.Width = 150;
            // 
            // movieDetail
            // 
            this.movieDetail.ButtonType = CxFlatUI.ButtonType.Primary;
            this.movieDetail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.movieDetail.Location = new System.Drawing.Point(373, 557);
            this.movieDetail.Name = "movieDetail";
            this.movieDetail.Size = new System.Drawing.Size(99, 35);
            this.movieDetail.TabIndex = 5;
            this.movieDetail.Text = "영화 정보";
            this.movieDetail.TextColor = System.Drawing.Color.White;
            this.movieDetail.Click += new System.EventHandler(this.movieDetail_Click);
            // 
            // close
            // 
            this.close.ButtonType = CxFlatUI.ButtonType.Primary;
            this.close.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.close.Location = new System.Drawing.Point(490, 557);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(99, 35);
            this.close.TabIndex = 5;
            this.close.Text = "뒤로가기";
            this.close.TextColor = System.Drawing.Color.White;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // moviePoster
            // 
            this.moviePoster.BackColor = System.Drawing.Color.Transparent;
            this.moviePoster.Location = new System.Drawing.Point(356, 167);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(250, 375);
            this.moviePoster.TabIndex = 6;
            this.moviePoster.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.ButtonType = CxFlatUI.ButtonType.Primary;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchBtn.Location = new System.Drawing.Point(515, 118);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 35);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "검색";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // movieInput
            // 
            this.movieInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.movieInput.Hint = "";
            this.movieInput.Location = new System.Drawing.Point(344, 64);
            this.movieInput.MaxLength = 32767;
            this.movieInput.Multiline = false;
            this.movieInput.Name = "movieInput";
            this.movieInput.PasswordChar = '\0';
            this.movieInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.movieInput.SelectedText = "";
            this.movieInput.SelectionLength = 0;
            this.movieInput.SelectionStart = 0;
            this.movieInput.Size = new System.Drawing.Size(274, 38);
            this.movieInput.TabIndex = 4;
            this.movieInput.TabStop = false;
            this.movieInput.UseSystemPasswordChar = false;
            this.movieInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.movieInput_KeyPress);
            // 
            // SearchMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 604);
            this.Controls.Add(this.moviePoster);
            this.Controls.Add(this.close);
            this.Controls.Add(this.movieDetail);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.movieInput);
            this.Controls.Add(this.movieSearchList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchMovie";
            this.Load += new System.EventHandler(this.SearchMovieForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ListView movieSearchList;
        private System.Windows.Forms.ColumnHeader mName;
        private System.Windows.Forms.ColumnHeader mReleaseDate;
        private CxFlatUI.Controls.CxFlatButton movieDetail;
        private CxFlatUI.Controls.CxFlatButton close;
        private CxFlatUI.CxFlatPictureBox moviePoster;
        private CxFlatUI.Controls.CxFlatButton searchBtn;
        private CxFlatUI.CxFlatTextBox movieInput;
    }
}