
namespace MovieReviewProgram.UI
{
    partial class PersonDetailForm
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
            this.windowClose = new Sunny.UI.UISymbolButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.birth = new Sunny.UI.UILabel();
            this.biography = new Sunny.UI.UILabel();
            this.place = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.labelll = new Sunny.UI.UILabel();
            this.personName = new Sunny.UI.UILabel();
            this.personImage = new CxFlatUI.CxFlatPictureBox();
            this.knownList = new Sunny.UI.UIDataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.character = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutAc = new CxFlatUI.Controls.CxFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knownList)).BeginInit();
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
            this.panel1.Font = new System.Drawing.Font("굵은안상수체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 48);
            this.panel1.TabIndex = 7;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Orbit-B BT", 18.25F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(18, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(196, 48);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Person Info";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // birth
            // 
            this.birth.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.birth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.birth.Location = new System.Drawing.Point(466, 164);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(250, 30);
            this.birth.TabIndex = 10;
            this.birth.Text = "Birth";
            this.birth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // biography
            // 
            this.biography.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.biography.Location = new System.Drawing.Point(415, 260);
            this.biography.Name = "biography";
            this.biography.Size = new System.Drawing.Size(359, 129);
            this.biography.TabIndex = 12;
            this.biography.Text = "Biography";
            this.biography.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // place
            // 
            this.place.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.place.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.place.Location = new System.Drawing.Point(538, 197);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(168, 30);
            this.place.TabIndex = 14;
            this.place.Text = "place";
            this.place.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(412, 389);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(120, 30);
            this.uiLabel3.TabIndex = 15;
            this.uiLabel3.Text = "Known For";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(412, 230);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(96, 30);
            this.uiLabel8.TabIndex = 16;
            this.uiLabel8.Text = "Biography";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(412, 197);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(133, 30);
            this.uiLabel4.TabIndex = 18;
            this.uiLabel4.Text = "Place of Birth : ";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelll
            // 
            this.labelll.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelll.Location = new System.Drawing.Point(412, 164);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(73, 30);
            this.labelll.TabIndex = 19;
            this.labelll.Text = "Birth : ";
            this.labelll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personName
            // 
            this.personName.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personName.Location = new System.Drawing.Point(410, 76);
            this.personName.Name = "personName";
            this.personName.Size = new System.Drawing.Size(323, 76);
            this.personName.TabIndex = 9;
            this.personName.Text = "Person Name";
            this.personName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personImage
            // 
            this.personImage.Location = new System.Drawing.Point(31, 95);
            this.personImage.Name = "personImage";
            this.personImage.Size = new System.Drawing.Size(350, 525);
            this.personImage.TabIndex = 8;
            this.personImage.TabStop = false;
            // 
            // knownList
            // 
            this.knownList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.knownList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.knownList.BackgroundColor = System.Drawing.Color.White;
            this.knownList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.knownList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.knownList.ColumnHeadersHeight = 32;
            this.knownList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.knownList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.character,
            this.ReleaseDate});
            this.knownList.EnableHeadersVisualStyles = false;
            this.knownList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.knownList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.knownList.Location = new System.Drawing.Point(416, 422);
            this.knownList.Name = "knownList";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.knownList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.knownList.RowTemplate.Height = 29;
            this.knownList.SelectedIndex = -1;
            this.knownList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.knownList.ShowGridLine = true;
            this.knownList.Size = new System.Drawing.Size(358, 232);
            this.knownList.TabIndex = 20;
            // 
            // name
            // 
            this.name.HeaderText = "Movie";
            this.name.Name = "name";
            this.name.Width = 160;
            // 
            // character
            // 
            this.character.HeaderText = "Role";
            this.character.Name = "character";
            this.character.Width = 160;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            // 
            // aboutAc
            // 
            this.aboutAc.ButtonType = CxFlatUI.ButtonType.Primary;
            this.aboutAc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aboutAc.Location = new System.Drawing.Point(603, 395);
            this.aboutAc.Name = "aboutAc";
            this.aboutAc.Size = new System.Drawing.Size(171, 23);
            this.aboutAc.TabIndex = 21;
            this.aboutAc.Text = "About Movie";
            this.aboutAc.TextColor = System.Drawing.Color.White;
            this.aboutAc.Click += new System.EventHandler(this.aboutAc_Click);
            // 
            // PersonDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 666);
            this.Controls.Add(this.aboutAc);
            this.Controls.Add(this.knownList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.biography);
            this.Controls.Add(this.place);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.labelll);
            this.Controls.Add(this.personName);
            this.Controls.Add(this.personImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PersonDetailForm";
            this.Load += new System.EventHandler(this.PersonDetailForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knownList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton windowClose;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel birth;
        private Sunny.UI.UILabel biography;
        private Sunny.UI.UILabel place;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel labelll;
        private Sunny.UI.UILabel personName;
        private CxFlatUI.CxFlatPictureBox personImage;
        private Sunny.UI.UIDataGridView knownList;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn character;
        private CxFlatUI.Controls.CxFlatButton aboutAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
    }
}