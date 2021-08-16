
namespace MovieReviewProgram.UI
{
    partial class TvDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.character = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castList = new Sunny.UI.UIDataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overView = new Sunny.UI.UILabel();
            this.releaseDate = new Sunny.UI.UILabel();
            this.tvWriter = new Sunny.UI.UILabel();
            this.genre = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.tvName = new Sunny.UI.UILabel();
            this.tvPoster = new CxFlatUI.CxFlatPictureBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.windowClose = new Sunny.UI.UISymbolButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.tvDirector = new Sunny.UI.UILabel();
            this.aboutAc = new CxFlatUI.Controls.CxFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.castList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvPoster)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // character
            // 
            this.character.HeaderText = "Role";
            this.character.Name = "character";
            this.character.Width = 160;
            // 
            // castList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.castList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.castList.BackgroundColor = System.Drawing.Color.White;
            this.castList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.castList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.castList.ColumnHeadersHeight = 32;
            this.castList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.castList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.character});
            this.castList.EnableHeadersVisualStyles = false;
            this.castList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.castList.GridColor = System.Drawing.SystemColors.Control;
            this.castList.Location = new System.Drawing.Point(416, 432);
            this.castList.Name = "castList";
            this.castList.RectColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.castList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.castList.RowTemplate.Height = 29;
            this.castList.SelectedIndex = -1;
            this.castList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.castList.ShowGridLine = true;
            this.castList.Size = new System.Drawing.Size(358, 222);
            this.castList.TabIndex = 20;
            // 
            // name
            // 
            this.name.HeaderText = "PerFormer";
            this.name.Name = "name";
            this.name.Width = 160;
            // 
            // overView
            // 
            this.overView.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.overView.Location = new System.Drawing.Point(415, 314);
            this.overView.Name = "overView";
            this.overView.Size = new System.Drawing.Size(359, 85);
            this.overView.TabIndex = 11;
            this.overView.Text = "Cast";
            this.overView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // releaseDate
            // 
            this.releaseDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.releaseDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.releaseDate.Location = new System.Drawing.Point(528, 254);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(246, 30);
            this.releaseDate.TabIndex = 12;
            this.releaseDate.Text = "Rlease Date";
            this.releaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tvWriter
            // 
            this.tvWriter.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tvWriter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tvWriter.Location = new System.Drawing.Point(513, 194);
            this.tvWriter.Name = "tvWriter";
            this.tvWriter.Size = new System.Drawing.Size(261, 30);
            this.tvWriter.TabIndex = 13;
            this.tvWriter.Text = "screenplay";
            this.tvWriter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.genre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genre.Location = new System.Drawing.Point(475, 224);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(299, 30);
            this.genre.TabIndex = 14;
            this.genre.Text = "Genre";
            this.genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(412, 284);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(109, 30);
            this.uiLabel5.TabIndex = 15;
            this.uiLabel5.Text = "Overview";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(412, 399);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(57, 30);
            this.uiLabel8.TabIndex = 16;
            this.uiLabel8.Text = "Cast";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(412, 254);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(133, 30);
            this.uiLabel6.TabIndex = 17;
            this.uiLabel6.Text = "Release Date : ";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(412, 224);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(73, 30);
            this.uiLabel4.TabIndex = 18;
            this.uiLabel4.Text = "Genre : ";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tvName
            // 
            this.tvName.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvName.Location = new System.Drawing.Point(412, 76);
            this.tvName.Name = "tvName";
            this.tvName.Size = new System.Drawing.Size(323, 76);
            this.tvName.TabIndex = 10;
            this.tvName.Text = "Tv Title";
            this.tvName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tvPoster
            // 
            this.tvPoster.Location = new System.Drawing.Point(31, 95);
            this.tvPoster.Name = "tvPoster";
            this.tvPoster.Size = new System.Drawing.Size(350, 525);
            this.tvPoster.TabIndex = 9;
            this.tvPoster.TabStop = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Orbit-B BT", 18.25F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(18, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(196, 48);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "TV Show Info";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(412, 194);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(123, 30);
            this.uiLabel2.TabIndex = 19;
            this.uiLabel2.Text = "ScreenPlay : ";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.windowClose);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Font = new System.Drawing.Font("굵은안상수체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 48);
            this.panel1.TabIndex = 8;
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
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(412, 164);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(89, 30);
            this.uiLabel3.TabIndex = 19;
            this.uiLabel3.Text = "Director : ";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tvDirector
            // 
            this.tvDirector.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tvDirector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tvDirector.Location = new System.Drawing.Point(492, 164);
            this.tvDirector.Name = "tvDirector";
            this.tvDirector.Size = new System.Drawing.Size(282, 30);
            this.tvDirector.TabIndex = 13;
            this.tvDirector.Text = "Director";
            this.tvDirector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aboutAc
            // 
            this.aboutAc.ButtonType = CxFlatUI.ButtonType.Primary;
            this.aboutAc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aboutAc.Location = new System.Drawing.Point(603, 406);
            this.aboutAc.Name = "aboutAc";
            this.aboutAc.Size = new System.Drawing.Size(171, 23);
            this.aboutAc.TabIndex = 21;
            this.aboutAc.Text = "About Actor/Actress";
            this.aboutAc.TextColor = System.Drawing.Color.White;
            this.aboutAc.Click += new System.EventHandler(this.aboutAc_Click);
            // 
            // TvDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 666);
            this.Controls.Add(this.aboutAc);
            this.Controls.Add(this.castList);
            this.Controls.Add(this.overView);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.tvDirector);
            this.Controls.Add(this.tvWriter);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.tvName);
            this.Controls.Add(this.tvPoster);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TvDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TvDetailForm";
            this.Load += new System.EventHandler(this.TvDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.castList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvPoster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn character;
        private Sunny.UI.UIDataGridView castList;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private Sunny.UI.UILabel overView;
        private Sunny.UI.UILabel releaseDate;
        private Sunny.UI.UILabel tvWriter;
        private Sunny.UI.UILabel genre;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel tvName;
        private CxFlatUI.CxFlatPictureBox tvPoster;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UISymbolButton windowClose;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel tvDirector;
        private CxFlatUI.Controls.CxFlatButton aboutAc;
    }
}