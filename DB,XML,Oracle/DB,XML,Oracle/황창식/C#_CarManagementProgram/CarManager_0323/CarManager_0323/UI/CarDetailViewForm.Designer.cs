
namespace CarManager_0323.UI
{
    partial class CarDetailViewForm
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
            this.cusCancel = new Sunny.UI.UISymbolButton();
            this.cusOK = new Sunny.UI.UISymbolButton();
            this.carPrice = new Sunny.UI.UITextBox();
            this.carComp = new Sunny.UI.UITextBox();
            this.carColor = new Sunny.UI.UITextBox();
            this.carModel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.addr = new Sunny.UI.UISymbolLabel();
            this.tel = new Sunny.UI.UISymbolLabel();
            this.name = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.carYear = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // cusCancel
            // 
            this.cusCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cusCancel.Location = new System.Drawing.Point(265, 422);
            this.cusCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusCancel.Name = "cusCancel";
            this.cusCancel.Size = new System.Drawing.Size(131, 35);
            this.cusCancel.Symbol = 61453;
            this.cusCancel.TabIndex = 37;
            this.cusCancel.Text = "나가기";
            this.cusCancel.Click += new System.EventHandler(this.cusCancel_Click);
            // 
            // cusOK
            // 
            this.cusOK.BackColor = System.Drawing.Color.Transparent;
            this.cusOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cusOK.Location = new System.Drawing.Point(110, 422);
            this.cusOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusOK.Name = "cusOK";
            this.cusOK.Size = new System.Drawing.Size(131, 35);
            this.cusOK.TabIndex = 38;
            this.cusOK.Text = "수정";
            this.cusOK.Click += new System.EventHandler(this.cusOK_Click);
            // 
            // carPrice
            // 
            this.carPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carPrice.FillColor = System.Drawing.Color.White;
            this.carPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carPrice.Location = new System.Drawing.Point(147, 279);
            this.carPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carPrice.Maximum = 2147483647D;
            this.carPrice.Minimum = -2147483648D;
            this.carPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.carPrice.Name = "carPrice";
            this.carPrice.Padding = new System.Windows.Forms.Padding(5);
            this.carPrice.Size = new System.Drawing.Size(308, 29);
            this.carPrice.TabIndex = 32;
            // 
            // carComp
            // 
            this.carComp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carComp.FillColor = System.Drawing.Color.White;
            this.carComp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carComp.Location = new System.Drawing.Point(147, 222);
            this.carComp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carComp.Maximum = 2147483647D;
            this.carComp.Minimum = -2147483648D;
            this.carComp.MinimumSize = new System.Drawing.Size(1, 1);
            this.carComp.Name = "carComp";
            this.carComp.Padding = new System.Windows.Forms.Padding(5);
            this.carComp.Size = new System.Drawing.Size(308, 29);
            this.carComp.TabIndex = 31;
            // 
            // carColor
            // 
            this.carColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carColor.FillColor = System.Drawing.Color.White;
            this.carColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carColor.Location = new System.Drawing.Point(147, 165);
            this.carColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carColor.Maximum = 2147483647D;
            this.carColor.Minimum = -2147483648D;
            this.carColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.carColor.Name = "carColor";
            this.carColor.Padding = new System.Windows.Forms.Padding(5);
            this.carColor.Size = new System.Drawing.Size(308, 29);
            this.carColor.TabIndex = 30;
            // 
            // carModel
            // 
            this.carModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carModel.FillColor = System.Drawing.Color.White;
            this.carModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carModel.Location = new System.Drawing.Point(147, 108);
            this.carModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carModel.Maximum = 2147483647D;
            this.carModel.Minimum = -2147483648D;
            this.carModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.carModel.Name = "carModel";
            this.carModel.Padding = new System.Windows.Forms.Padding(5);
            this.carModel.Size = new System.Drawing.Size(308, 29);
            this.carModel.TabIndex = 29;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(46, 274);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(86, 38);
            this.uiSymbolLabel1.Symbol = 61573;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.uiSymbolLabel1.TabIndex = 33;
            this.uiSymbolLabel1.Text = "가격";
            // 
            // addr
            // 
            this.addr.BackColor = System.Drawing.Color.Transparent;
            this.addr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addr.Location = new System.Drawing.Point(46, 217);
            this.addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.addr.Name = "addr";
            this.addr.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.addr.Size = new System.Drawing.Size(86, 38);
            this.addr.Symbol = 61573;
            this.addr.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.addr.TabIndex = 34;
            this.addr.Text = "제조사";
            // 
            // tel
            // 
            this.tel.BackColor = System.Drawing.Color.Transparent;
            this.tel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tel.Location = new System.Drawing.Point(46, 160);
            this.tel.MinimumSize = new System.Drawing.Size(1, 1);
            this.tel.Name = "tel";
            this.tel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.tel.Size = new System.Drawing.Size(86, 38);
            this.tel.Symbol = 61947;
            this.tel.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.tel.TabIndex = 35;
            this.tel.Text = "색상";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.name.Location = new System.Drawing.Point(46, 103);
            this.name.MinimumSize = new System.Drawing.Size(1, 1);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.name.Size = new System.Drawing.Size(86, 38);
            this.name.Style = Sunny.UI.UIStyle.Custom;
            this.name.Symbol = 61881;
            this.name.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.name.TabIndex = 36;
            this.name.Text = "모델명";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(46, 331);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(86, 38);
            this.uiSymbolLabel2.Symbol = 61573;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.uiSymbolLabel2.TabIndex = 33;
            this.uiSymbolLabel2.Text = "연식";
            // 
            // carYear
            // 
            this.carYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carYear.FillColor = System.Drawing.Color.White;
            this.carYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carYear.Location = new System.Drawing.Point(147, 336);
            this.carYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carYear.Maximum = 2147483647D;
            this.carYear.Minimum = -2147483648D;
            this.carYear.MinimumSize = new System.Drawing.Size(1, 1);
            this.carYear.Name = "carYear";
            this.carYear.Padding = new System.Windows.Forms.Padding(5);
            this.carYear.Size = new System.Drawing.Size(308, 29);
            this.carYear.TabIndex = 32;
            // 
            // CarDetailViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 507);
            this.Controls.Add(this.cusCancel);
            this.Controls.Add(this.cusOK);
            this.Controls.Add(this.carYear);
            this.Controls.Add(this.carPrice);
            this.Controls.Add(this.carComp);
            this.Controls.Add(this.carColor);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.name);
            this.Name = "CarDetailViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "차량 상세 정보";
            this.Load += new System.EventHandler(this.CarDetailViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton cusCancel;
        private Sunny.UI.UISymbolButton cusOK;
        private Sunny.UI.UITextBox carPrice;
        private Sunny.UI.UITextBox carComp;
        private Sunny.UI.UITextBox carColor;
        private Sunny.UI.UITextBox carModel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel addr;
        private Sunny.UI.UISymbolLabel tel;
        private Sunny.UI.UISymbolLabel name;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox carYear;
    }
}