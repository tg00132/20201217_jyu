
namespace CarManager_0323.UI
{
    partial class CustDetailViewForm
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
            this.cusOK = new Sunny.UI.UISymbolButton();
            this.cusCancel = new Sunny.UI.UISymbolButton();
            this.name = new Sunny.UI.UISymbolLabel();
            this.tel = new Sunny.UI.UISymbolLabel();
            this.addr = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.cusName = new Sunny.UI.UITextBox();
            this.cusTel = new Sunny.UI.UITextBox();
            this.cusAddr = new Sunny.UI.UITextBox();
            this.cusEmail = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // cusOK
            // 
            this.cusOK.BackColor = System.Drawing.Color.Transparent;
            this.cusOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cusOK.Location = new System.Drawing.Point(110, 352);
            this.cusOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusOK.Name = "cusOK";
            this.cusOK.Size = new System.Drawing.Size(131, 35);
            this.cusOK.TabIndex = 28;
            this.cusOK.Text = "수정";
            this.cusOK.Click += new System.EventHandler(this.cusOK_Click);
            // 
            // cusCancel
            // 
            this.cusCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cusCancel.Location = new System.Drawing.Point(265, 352);
            this.cusCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusCancel.Name = "cusCancel";
            this.cusCancel.Size = new System.Drawing.Size(131, 35);
            this.cusCancel.Symbol = 61453;
            this.cusCancel.TabIndex = 27;
            this.cusCancel.Text = "나가기";
            this.cusCancel.Click += new System.EventHandler(this.cusCancel_Click);
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
            this.name.TabIndex = 26;
            this.name.Text = "이름";
            // 
            // tel
            // 
            this.tel.BackColor = System.Drawing.Color.Transparent;
            this.tel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tel.Location = new System.Drawing.Point(46, 161);
            this.tel.MinimumSize = new System.Drawing.Size(1, 1);
            this.tel.Name = "tel";
            this.tel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.tel.Size = new System.Drawing.Size(86, 38);
            this.tel.Symbol = 61947;
            this.tel.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.tel.TabIndex = 25;
            this.tel.Text = "전화";
            // 
            // addr
            // 
            this.addr.BackColor = System.Drawing.Color.Transparent;
            this.addr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addr.Location = new System.Drawing.Point(46, 219);
            this.addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.addr.Name = "addr";
            this.addr.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.addr.Size = new System.Drawing.Size(86, 38);
            this.addr.Symbol = 61573;
            this.addr.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.addr.TabIndex = 24;
            this.addr.Text = "주소";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(46, 277);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(86, 38);
            this.uiSymbolLabel1.Symbol = 61573;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.uiSymbolLabel1.TabIndex = 23;
            this.uiSymbolLabel1.Text = "이메일";
            // 
            // cusName
            // 
            this.cusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusName.FillColor = System.Drawing.Color.White;
            this.cusName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cusName.Location = new System.Drawing.Point(147, 108);
            this.cusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cusName.Maximum = 2147483647D;
            this.cusName.Minimum = -2147483648D;
            this.cusName.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusName.Name = "cusName";
            this.cusName.Padding = new System.Windows.Forms.Padding(5);
            this.cusName.Size = new System.Drawing.Size(308, 29);
            this.cusName.TabIndex = 19;
            // 
            // cusTel
            // 
            this.cusTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusTel.FillColor = System.Drawing.Color.White;
            this.cusTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cusTel.Location = new System.Drawing.Point(147, 166);
            this.cusTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cusTel.Maximum = 2147483647D;
            this.cusTel.Minimum = -2147483648D;
            this.cusTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusTel.Name = "cusTel";
            this.cusTel.Padding = new System.Windows.Forms.Padding(5);
            this.cusTel.Size = new System.Drawing.Size(308, 29);
            this.cusTel.TabIndex = 20;
            // 
            // cusAddr
            // 
            this.cusAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusAddr.FillColor = System.Drawing.Color.White;
            this.cusAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cusAddr.Location = new System.Drawing.Point(147, 224);
            this.cusAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cusAddr.Maximum = 2147483647D;
            this.cusAddr.Minimum = -2147483648D;
            this.cusAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusAddr.Name = "cusAddr";
            this.cusAddr.Padding = new System.Windows.Forms.Padding(5);
            this.cusAddr.Size = new System.Drawing.Size(308, 29);
            this.cusAddr.TabIndex = 21;
            // 
            // cusEmail
            // 
            this.cusEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusEmail.FillColor = System.Drawing.Color.White;
            this.cusEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cusEmail.Location = new System.Drawing.Point(147, 282);
            this.cusEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cusEmail.Maximum = 2147483647D;
            this.cusEmail.Minimum = -2147483648D;
            this.cusEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusEmail.Name = "cusEmail";
            this.cusEmail.Padding = new System.Windows.Forms.Padding(5);
            this.cusEmail.Size = new System.Drawing.Size(308, 29);
            this.cusEmail.TabIndex = 22;
            // 
            // CustDetailViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 454);
            this.Controls.Add(this.cusCancel);
            this.Controls.Add(this.cusOK);
            this.Controls.Add(this.cusEmail);
            this.Controls.Add(this.cusAddr);
            this.Controls.Add(this.cusTel);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.name);
            this.Name = "CustDetailViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "고객 상세 정보";
            this.Load += new System.EventHandler(this.CustDetailViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton cusOK;
        private Sunny.UI.UISymbolButton cusCancel;
        private Sunny.UI.UISymbolLabel name;
        private Sunny.UI.UISymbolLabel tel;
        private Sunny.UI.UISymbolLabel addr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox cusName;
        private Sunny.UI.UITextBox cusTel;
        private Sunny.UI.UITextBox cusAddr;
        private Sunny.UI.UITextBox cusEmail;
    }
}