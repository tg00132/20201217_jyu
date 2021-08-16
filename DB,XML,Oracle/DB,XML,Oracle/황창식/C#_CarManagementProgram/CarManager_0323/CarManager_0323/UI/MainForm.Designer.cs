
namespace CarManager_0323
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.createTable = new Sunny.UI.UISymbolButton();
            this.deleteTable = new Sunny.UI.UISymbolButton();
            this.insertOrder = new Sunny.UI.UISymbolButton();
            this.info = new Sunny.UI.UISymbolButton();
            this.selectDeal = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(1, 190);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(836, 330);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cxFlatPictureBox1.TabIndex = 0;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // createTable
            // 
            this.createTable.BackColor = System.Drawing.Color.Transparent;
            this.createTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTable.FillColor = System.Drawing.Color.Transparent;
            this.createTable.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createTable.Location = new System.Drawing.Point(744, 28);
            this.createTable.MinimumSize = new System.Drawing.Size(1, 1);
            this.createTable.Name = "createTable";
            this.createTable.RectColor = System.Drawing.Color.Silver;
            this.createTable.Size = new System.Drawing.Size(32, 32);
            this.createTable.Style = Sunny.UI.UIStyle.Custom;
            this.createTable.Symbol = 61543;
            this.createTable.TabIndex = 1;
            this.createTable.Click += new System.EventHandler(this.createTable_Click);
            // 
            // deleteTable
            // 
            this.deleteTable.BackColor = System.Drawing.Color.Transparent;
            this.deleteTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTable.FillColor = System.Drawing.Color.Transparent;
            this.deleteTable.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.deleteTable.Location = new System.Drawing.Point(795, 28);
            this.deleteTable.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteTable.Name = "deleteTable";
            this.deleteTable.RectColor = System.Drawing.Color.Silver;
            this.deleteTable.Size = new System.Drawing.Size(32, 32);
            this.deleteTable.Style = Sunny.UI.UIStyle.Custom;
            this.deleteTable.Symbol = 61544;
            this.deleteTable.TabIndex = 1;
            this.deleteTable.Click += new System.EventHandler(this.deleteTable_Click);
            // 
            // insertOrder
            // 
            this.insertOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertOrder.Location = new System.Drawing.Point(39, 104);
            this.insertOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertOrder.Name = "insertOrder";
            this.insertOrder.Size = new System.Drawing.Size(170, 41);
            this.insertOrder.Symbol = 57587;
            this.insertOrder.TabIndex = 2;
            this.insertOrder.Text = "거래 정보 추가";
            this.insertOrder.Click += new System.EventHandler(this.insertOrder_Click);
            // 
            // info
            // 
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.info.Location = new System.Drawing.Point(433, 104);
            this.info.MinimumSize = new System.Drawing.Size(1, 1);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(170, 41);
            this.info.Symbol = 61530;
            this.info.TabIndex = 2;
            this.info.Text = "도움말";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // selectDeal
            // 
            this.selectDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectDeal.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.selectDeal.Location = new System.Drawing.Point(236, 104);
            this.selectDeal.MinimumSize = new System.Drawing.Size(1, 1);
            this.selectDeal.Name = "selectDeal";
            this.selectDeal.Size = new System.Drawing.Size(170, 41);
            this.selectDeal.Symbol = 57574;
            this.selectDeal.TabIndex = 2;
            this.selectDeal.Text = "거래 정보 보기";
            this.selectDeal.Click += new System.EventHandler(this.selectDeal_Click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.Brown;
            this.uiSymbolButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSymbolButton2.FillPressColor = System.Drawing.Color.Maroon;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(630, 104);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.RectColor = System.Drawing.Color.Brown;
            this.uiSymbolButton2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSymbolButton2.RectPressColor = System.Drawing.Color.Maroon;
            this.uiSymbolButton2.Size = new System.Drawing.Size(170, 41);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61453;
            this.uiSymbolButton2.TabIndex = 2;
            this.uiSymbolButton2.Text = "프로그램 종료";
            this.uiSymbolButton2.Click += new System.EventHandler(this.programExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 522);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.insertOrder);
            this.Controls.Add(this.selectDeal);
            this.Controls.Add(this.deleteTable);
            this.Controls.Add(this.createTable);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "차량 고객 관리 프로그램 v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UISymbolButton createTable;
        private Sunny.UI.UISymbolButton deleteTable;
        private Sunny.UI.UISymbolButton insertOrder;
        private Sunny.UI.UISymbolButton info;
        private Sunny.UI.UISymbolButton selectDeal;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
    }
}

