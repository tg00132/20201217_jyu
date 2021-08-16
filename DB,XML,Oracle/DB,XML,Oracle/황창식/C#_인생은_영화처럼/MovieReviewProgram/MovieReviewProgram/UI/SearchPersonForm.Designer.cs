
namespace MovieReviewProgram.UI
{
    partial class SearchPersonForm
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
            this.personSearchList = new System.Windows.Forms.ListView();
            this.personName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personImage = new CxFlatUI.CxFlatPictureBox();
            this.close = new CxFlatUI.Controls.CxFlatButton();
            this.personDetail = new CxFlatUI.Controls.CxFlatButton();
            this.searchBtn = new CxFlatUI.Controls.CxFlatButton();
            this.personInput = new CxFlatUI.CxFlatTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personImage)).BeginInit();
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
            this.panel1.Font = new System.Drawing.Font("굵은안상수체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 48);
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
            this.uiLabel1.Text = "Search Person";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personSearchList
            // 
            this.personSearchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.personName});
            this.personSearchList.FullRowSelect = true;
            this.personSearchList.HideSelection = false;
            this.personSearchList.Location = new System.Drawing.Point(12, 54);
            this.personSearchList.Name = "personSearchList";
            this.personSearchList.Size = new System.Drawing.Size(305, 544);
            this.personSearchList.TabIndex = 8;
            this.personSearchList.UseCompatibleStateImageBehavior = false;
            this.personSearchList.View = System.Windows.Forms.View.Details;
            this.personSearchList.Click += new System.EventHandler(this.personSearchList_Click);
            // 
            // personName
            // 
            this.personName.Text = "이름";
            this.personName.Width = 300;
            // 
            // personImage
            // 
            this.personImage.BackColor = System.Drawing.Color.Transparent;
            this.personImage.Location = new System.Drawing.Point(356, 167);
            this.personImage.Name = "personImage";
            this.personImage.Size = new System.Drawing.Size(250, 375);
            this.personImage.TabIndex = 13;
            this.personImage.TabStop = false;
            // 
            // close
            // 
            this.close.ButtonType = CxFlatUI.ButtonType.Primary;
            this.close.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.close.Location = new System.Drawing.Point(490, 557);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(99, 35);
            this.close.TabIndex = 10;
            this.close.Text = "뒤로가기";
            this.close.TextColor = System.Drawing.Color.White;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // personDetail
            // 
            this.personDetail.ButtonType = CxFlatUI.ButtonType.Primary;
            this.personDetail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.personDetail.Location = new System.Drawing.Point(373, 557);
            this.personDetail.Name = "personDetail";
            this.personDetail.Size = new System.Drawing.Size(99, 35);
            this.personDetail.TabIndex = 11;
            this.personDetail.Text = "인물 정보";
            this.personDetail.TextColor = System.Drawing.Color.White;
            this.personDetail.Click += new System.EventHandler(this.personDetail_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.ButtonType = CxFlatUI.ButtonType.Primary;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchBtn.Location = new System.Drawing.Point(515, 118);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 35);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "검색";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // personInput
            // 
            this.personInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.personInput.Hint = "";
            this.personInput.Location = new System.Drawing.Point(344, 64);
            this.personInput.MaxLength = 32767;
            this.personInput.Multiline = false;
            this.personInput.Name = "personInput";
            this.personInput.PasswordChar = '\0';
            this.personInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.personInput.SelectedText = "";
            this.personInput.SelectionLength = 0;
            this.personInput.SelectionStart = 0;
            this.personInput.Size = new System.Drawing.Size(274, 38);
            this.personInput.TabIndex = 9;
            this.personInput.TabStop = false;
            this.personInput.UseSystemPasswordChar = false;
            this.personInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personInput_KeyPress);
            // 
            // SearchPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.personSearchList);
            this.Controls.Add(this.personImage);
            this.Controls.Add(this.close);
            this.Controls.Add(this.personDetail);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.personInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchPersonForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ListView personSearchList;
        private System.Windows.Forms.ColumnHeader personName;
        private CxFlatUI.CxFlatPictureBox personImage;
        private CxFlatUI.Controls.CxFlatButton close;
        private CxFlatUI.Controls.CxFlatButton personDetail;
        private CxFlatUI.Controls.CxFlatButton searchBtn;
        private CxFlatUI.CxFlatTextBox personInput;
    }
}