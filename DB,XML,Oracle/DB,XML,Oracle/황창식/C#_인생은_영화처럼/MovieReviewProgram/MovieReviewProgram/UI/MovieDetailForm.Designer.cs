
namespace MovieReviewProgram.UI
{
    partial class MovieDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.windowClose = new Sunny.UI.UISymbolButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.moviePoster = new CxFlatUI.CxFlatPictureBox();
            this.mName = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.mDirector = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.genre = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.releaseDate = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.overView = new Sunny.UI.UILabel();
            this.castList = new Sunny.UI.UIDataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.character = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutAc = new CxFlatUI.Controls.CxFlatButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castList)).BeginInit();
            this.SuspendLayout();
            // 
            // windowClose
            // 
            this.windowClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowClose.FillColor = System.Drawing.Color.Brown;
            this.windowClose.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowClose.FillPressColor = System.Drawing.Color.Maroon;
            this.windowClose.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.windowClose.Location = new System.Drawing.Point(693, 7);
            this.windowClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.windowClose.Name = "windowClose";
            this.windowClose.RectColor = System.Drawing.Color.Brown;
            this.windowClose.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowClose.RectPressColor = System.Drawing.Color.Maroon;
            this.windowClose.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowClose.Size = new System.Drawing.Size(90, 35);
            this.windowClose.Style = Sunny.UI.UIStyle.Custom;
            this.windowClose.Symbol = 61453;
            this.windowClose.TabIndex = 2;
            this.windowClose.Text = "Close";
            this.windowClose.Click += new System.EventHandler(this.windowClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.windowClose);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 48);
            this.panel1.TabIndex = 3;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(18, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(196, 48);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Movie Info";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moviePoster
            // 
            this.moviePoster.Location = new System.Drawing.Point(31, 95);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(350, 525);
            this.moviePoster.TabIndex = 4;
            this.moviePoster.TabStop = false;
            // 
            // mName
            // 
            this.mName.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mName.Location = new System.Drawing.Point(412, 76);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(323, 76);
            this.mName.TabIndex = 5;
            this.mName.Text = "Movie Title";
            this.mName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(412, 164);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(89, 30);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "Director : ";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mDirector
            // 
            this.mDirector.AutoSize = true;
            this.mDirector.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDirector.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mDirector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mDirector.Location = new System.Drawing.Point(493, 169);
            this.mDirector.Name = "mDirector";
            this.mDirector.Size = new System.Drawing.Size(71, 21);
            this.mDirector.TabIndex = 6;
            this.mDirector.Text = "Director";
            this.mDirector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mDirector.Click += new System.EventHandler(this.mDirector_Click);
            this.mDirector.MouseEnter += new System.EventHandler(this.mDirector_MouseEnter);
            this.mDirector.MouseLeave += new System.EventHandler(this.mDirector_MouseLeave);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(412, 194);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(73, 30);
            this.uiLabel4.TabIndex = 6;
            this.uiLabel4.Text = "Genre : ";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.genre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genre.Location = new System.Drawing.Point(475, 194);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(269, 30);
            this.genre.TabIndex = 6;
            this.genre.Text = "Genre";
            this.genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(412, 224);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(133, 30);
            this.uiLabel6.TabIndex = 6;
            this.uiLabel6.Text = "Release Date : ";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // releaseDate
            // 
            this.releaseDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.releaseDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.releaseDate.Location = new System.Drawing.Point(528, 224);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(213, 30);
            this.releaseDate.TabIndex = 6;
            this.releaseDate.Text = "Rlease Date";
            this.releaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(412, 365);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(57, 30);
            this.uiLabel8.TabIndex = 6;
            this.uiLabel8.Text = "Cast";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(412, 254);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(109, 30);
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "Overview";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // overView
            // 
            this.overView.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.overView.Location = new System.Drawing.Point(415, 283);
            this.overView.Name = "overView";
            this.overView.Size = new System.Drawing.Size(359, 81);
            this.overView.TabIndex = 6;
            this.overView.Text = "Cast";
            this.overView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // castList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.castList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.castList.BackgroundColor = System.Drawing.Color.White;
            this.castList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.castList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.castList.ColumnHeadersHeight = 32;
            this.castList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.castList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.character});
            this.castList.EnableHeadersVisualStyles = false;
            this.castList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.castList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.castList.Location = new System.Drawing.Point(416, 398);
            this.castList.Name = "castList";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.castList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.castList.RowTemplate.Height = 29;
            this.castList.SelectedIndex = -1;
            this.castList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.castList.ShowGridLine = true;
            this.castList.Size = new System.Drawing.Size(358, 256);
            this.castList.TabIndex = 7;
            // 
            // name
            // 
            this.name.HeaderText = "PerFormer";
            this.name.Name = "name";
            this.name.Width = 160;
            // 
            // character
            // 
            this.character.HeaderText = "Role";
            this.character.Name = "character";
            this.character.Width = 160;
            // 
            // aboutAc
            // 
            this.aboutAc.ButtonType = CxFlatUI.ButtonType.Primary;
            this.aboutAc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aboutAc.Location = new System.Drawing.Point(603, 370);
            this.aboutAc.Name = "aboutAc";
            this.aboutAc.Size = new System.Drawing.Size(171, 23);
            this.aboutAc.TabIndex = 8;
            this.aboutAc.Text = "About Actor/Actress";
            this.aboutAc.TextColor = System.Drawing.Color.White;
            this.aboutAc.Click += new System.EventHandler(this.aboutAc_Click);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(210, 63);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(171, 23);
            this.uiSymbolButton1.Symbol = 61444;
            this.uiSymbolButton1.TabIndex = 9;
            this.uiSymbolButton1.Text = "Add Favorite";
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // MovieDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 666);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.aboutAc);
            this.Controls.Add(this.castList);
            this.Controls.Add(this.mDirector);
            this.Controls.Add(this.overView);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.mName);
            this.Controls.Add(this.moviePoster);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovieDetailForm";
            this.Load += new System.EventHandler(this.MovieDetailForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UISymbolButton windowClose;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel uiLabel1;
        private CxFlatUI.CxFlatPictureBox moviePoster;
        private Sunny.UI.UILabel mName;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel mDirector;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel genre;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel releaseDate;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel overView;
        private Sunny.UI.UIDataGridView castList;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn character;
        private CxFlatUI.Controls.CxFlatButton aboutAc;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
    }
}