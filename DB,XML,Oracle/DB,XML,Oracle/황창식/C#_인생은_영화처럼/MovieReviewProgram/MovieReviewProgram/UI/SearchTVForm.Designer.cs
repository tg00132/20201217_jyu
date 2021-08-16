﻿
namespace MovieReviewProgram.UI
{
    partial class SearchTVForm
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
            this.tvSearchList = new System.Windows.Forms.ListView();
            this.tvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvImage = new CxFlatUI.CxFlatPictureBox();
            this.close = new CxFlatUI.Controls.CxFlatButton();
            this.tvDetail = new CxFlatUI.Controls.CxFlatButton();
            this.searchBtn = new CxFlatUI.Controls.CxFlatButton();
            this.tvInput = new CxFlatUI.CxFlatTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvImage)).BeginInit();
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
            this.panel1.TabIndex = 14;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Orbit-B BT", 18.25F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(18, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(227, 48);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Search TV Show";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tvSearchList
            // 
            this.tvSearchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tvName,
            this.tvCountry});
            this.tvSearchList.FullRowSelect = true;
            this.tvSearchList.HideSelection = false;
            this.tvSearchList.Location = new System.Drawing.Point(12, 54);
            this.tvSearchList.Name = "tvSearchList";
            this.tvSearchList.Size = new System.Drawing.Size(305, 544);
            this.tvSearchList.TabIndex = 15;
            this.tvSearchList.UseCompatibleStateImageBehavior = false;
            this.tvSearchList.View = System.Windows.Forms.View.Details;
            this.tvSearchList.Click += new System.EventHandler(this.tvSearchList_Click);
            // 
            // tvName
            // 
            this.tvName.Text = "이름";
            this.tvName.Width = 150;
            // 
            // tvCountry
            // 
            this.tvCountry.Text = "국가";
            this.tvCountry.Width = 150;
            // 
            // tvImage
            // 
            this.tvImage.BackColor = System.Drawing.Color.Transparent;
            this.tvImage.Location = new System.Drawing.Point(356, 167);
            this.tvImage.Name = "tvImage";
            this.tvImage.Size = new System.Drawing.Size(250, 375);
            this.tvImage.TabIndex = 20;
            this.tvImage.TabStop = false;
            // 
            // close
            // 
            this.close.ButtonType = CxFlatUI.ButtonType.Primary;
            this.close.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.close.Location = new System.Drawing.Point(490, 557);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(99, 35);
            this.close.TabIndex = 17;
            this.close.Text = "뒤로가기";
            this.close.TextColor = System.Drawing.Color.White;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // tvDetail
            // 
            this.tvDetail.ButtonType = CxFlatUI.ButtonType.Primary;
            this.tvDetail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tvDetail.Location = new System.Drawing.Point(373, 557);
            this.tvDetail.Name = "tvDetail";
            this.tvDetail.Size = new System.Drawing.Size(99, 35);
            this.tvDetail.TabIndex = 18;
            this.tvDetail.Text = "시리즈 정보";
            this.tvDetail.TextColor = System.Drawing.Color.White;
            this.tvDetail.Click += new System.EventHandler(this.tvDetail_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.ButtonType = CxFlatUI.ButtonType.Primary;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchBtn.Location = new System.Drawing.Point(515, 118);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 35);
            this.searchBtn.TabIndex = 19;
            this.searchBtn.Text = "검색";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // tvInput
            // 
            this.tvInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tvInput.Hint = "";
            this.tvInput.Location = new System.Drawing.Point(344, 64);
            this.tvInput.MaxLength = 32767;
            this.tvInput.Multiline = false;
            this.tvInput.Name = "tvInput";
            this.tvInput.PasswordChar = '\0';
            this.tvInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tvInput.SelectedText = "";
            this.tvInput.SelectionLength = 0;
            this.tvInput.SelectionStart = 0;
            this.tvInput.Size = new System.Drawing.Size(274, 38);
            this.tvInput.TabIndex = 16;
            this.tvInput.TabStop = false;
            this.tvInput.UseSystemPasswordChar = false;
            this.tvInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tvInput_KeyPress);
            // 
            // SearchTVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvSearchList);
            this.Controls.Add(this.tvImage);
            this.Controls.Add(this.close);
            this.Controls.Add(this.tvDetail);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.tvInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchTVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TVSearchForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tvImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ListView tvSearchList;
        private System.Windows.Forms.ColumnHeader tvName;
        private CxFlatUI.CxFlatPictureBox tvImage;
        private CxFlatUI.Controls.CxFlatButton close;
        private CxFlatUI.Controls.CxFlatButton tvDetail;
        private CxFlatUI.Controls.CxFlatButton searchBtn;
        private CxFlatUI.CxFlatTextBox tvInput;
        private System.Windows.Forms.ColumnHeader tvCountry;
    }
}