
namespace CarManager_0323.UI
{
    partial class DealViewForm
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
            this.dealList = new System.Windows.Forms.ListView();
            this.deal_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cusInfo = new Sunny.UI.UIButton();
            this.viewClose = new Sunny.UI.UIButton();
            this.carInfo = new Sunny.UI.UIButton();
            this.sellerInfo = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // dealList
            // 
            this.dealList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.dealList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deal_count,
            this.deal_name,
            this.deal_model,
            this.deal_price,
            this.deal_seller,
            this.deal_date});
            this.dealList.FullRowSelect = true;
            this.dealList.HideSelection = false;
            this.dealList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dealList.Location = new System.Drawing.Point(12, 69);
            this.dealList.Name = "dealList";
            this.dealList.Size = new System.Drawing.Size(525, 369);
            this.dealList.TabIndex = 4;
            this.dealList.UseCompatibleStateImageBehavior = false;
            this.dealList.View = System.Windows.Forms.View.Details;
            // 
            // deal_count
            // 
            this.deal_count.Text = "번호";
            this.deal_count.Width = 40;
            // 
            // deal_name
            // 
            this.deal_name.Text = "고객 이름";
            this.deal_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_name.Width = 80;
            // 
            // deal_model
            // 
            this.deal_model.Text = "구매차량";
            this.deal_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_model.Width = 100;
            // 
            // deal_price
            // 
            this.deal_price.Text = "구매가격(만원)";
            this.deal_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_price.Width = 120;
            // 
            // deal_seller
            // 
            this.deal_seller.Text = "판매자";
            this.deal_seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_seller.Width = 80;
            // 
            // deal_date
            // 
            this.deal_date.Text = "거래날짜";
            this.deal_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_date.Width = 100;
            // 
            // cusInfo
            // 
            this.cusInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cusInfo.Location = new System.Drawing.Point(554, 82);
            this.cusInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusInfo.Name = "cusInfo";
            this.cusInfo.Size = new System.Drawing.Size(135, 35);
            this.cusInfo.TabIndex = 5;
            this.cusInfo.Text = "고객 상세 정보";
            this.cusInfo.Click += new System.EventHandler(this.cusInfo_Click);
            // 
            // viewClose
            // 
            this.viewClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewClose.Location = new System.Drawing.Point(554, 383);
            this.viewClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewClose.Name = "viewClose";
            this.viewClose.Size = new System.Drawing.Size(135, 35);
            this.viewClose.TabIndex = 5;
            this.viewClose.Text = "닫기";
            this.viewClose.Click += new System.EventHandler(this.viewClose_Click);
            // 
            // carInfo
            // 
            this.carInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carInfo.Location = new System.Drawing.Point(554, 123);
            this.carInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.carInfo.Name = "carInfo";
            this.carInfo.Size = new System.Drawing.Size(135, 35);
            this.carInfo.TabIndex = 5;
            this.carInfo.Text = "차량 상세 정보";
            this.carInfo.Click += new System.EventHandler(this.carInfo_Click);
            // 
            // sellerInfo
            // 
            this.sellerInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellerInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.sellerInfo.Location = new System.Drawing.Point(554, 164);
            this.sellerInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.sellerInfo.Name = "sellerInfo";
            this.sellerInfo.Size = new System.Drawing.Size(135, 35);
            this.sellerInfo.TabIndex = 5;
            this.sellerInfo.Text = "판매원 상세 정보";
            this.sellerInfo.Click += new System.EventHandler(this.sellerInfo_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(554, 205);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(135, 35);
            this.uiButton1.TabIndex = 5;
            this.uiButton1.Text = "거래 전체 삭제";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // DealViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.viewClose);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.sellerInfo);
            this.Controls.Add(this.carInfo);
            this.Controls.Add(this.cusInfo);
            this.Controls.Add(this.dealList);
            this.Name = "DealViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "거래 내역 보기";
            this.Load += new System.EventHandler(this.DealViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dealList;
        private System.Windows.Forms.ColumnHeader deal_count;
        private System.Windows.Forms.ColumnHeader deal_name;
        private System.Windows.Forms.ColumnHeader deal_model;
        private System.Windows.Forms.ColumnHeader deal_price;
        private System.Windows.Forms.ColumnHeader deal_seller;
        private Sunny.UI.UIButton cusInfo;
        private Sunny.UI.UIButton viewClose;
        private System.Windows.Forms.ColumnHeader deal_date;
        private Sunny.UI.UIButton carInfo;
        private Sunny.UI.UIButton sellerInfo;
        private Sunny.UI.UIButton uiButton1;
    }
}