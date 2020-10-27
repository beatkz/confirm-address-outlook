namespace Confirm_Address_for_Outlook_2013
{
    partial class ConfirmAddressConfig
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.MyDomains = new System.Windows.Forms.ListView();
            this.colhMyDomain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OriginalURLLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.PortingURLLink = new System.Windows.Forms.LinkLabel();
            this.AppVersion = new System.Windows.Forms.Label();
            this.InsiderDomainBatchCheck = new System.Windows.Forms.CheckBox();
            this.OutsiderDomainBatchCheck = new System.Windows.Forms.CheckBox();
            this.CountDown = new System.Windows.Forms.CheckBox();
            this.NoDisplayInsiderDomainOnly = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CountDownTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CountDownTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "あなたの組織のメールアドレスのドメイン名を指定してください。";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(19, 218);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(105, 30);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "追加(&A)";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(197, 218);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(105, 30);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "編集(&E)";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(375, 218);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(105, 30);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "削除(&R)";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // MyDomains
            // 
            this.MyDomains.AllowColumnReorder = true;
            this.MyDomains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colhMyDomain});
            this.MyDomains.HideSelection = false;
            this.MyDomains.Location = new System.Drawing.Point(19, 31);
            this.MyDomains.Name = "MyDomains";
            this.MyDomains.Size = new System.Drawing.Size(461, 181);
            this.MyDomains.TabIndex = 5;
            this.MyDomains.UseCompatibleStateImageBehavior = false;
            this.MyDomains.View = System.Windows.Forms.View.Details;
            // 
            // colhMyDomain
            // 
            this.colhMyDomain.Text = "ドメイン名";
            this.colhMyDomain.Width = 455;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm-Address for Outlook";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Original by Meatian, urakami, kentaro.matsumae";
            // 
            // OriginalURLLink
            // 
            this.OriginalURLLink.AutoSize = true;
            this.OriginalURLLink.Location = new System.Drawing.Point(42, 402);
            this.OriginalURLLink.Name = "OriginalURLLink";
            this.OriginalURLLink.Size = new System.Drawing.Size(269, 15);
            this.OriginalURLLink.TabIndex = 8;
            this.OriginalURLLink.TabStop = true;
            this.OriginalURLLink.Text = "https://github.com/Meatian/confirm-address";
            this.OriginalURLLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OriginalURLLink_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Outlook ported by Keiji Momose";
            // 
            // PortingURLLink
            // 
            this.PortingURLLink.AutoSize = true;
            this.PortingURLLink.Location = new System.Drawing.Point(42, 432);
            this.PortingURLLink.Name = "PortingURLLink";
            this.PortingURLLink.Size = new System.Drawing.Size(262, 15);
            this.PortingURLLink.TabIndex = 10;
            this.PortingURLLink.TabStop = true;
            this.PortingURLLink.Text = "https://github.com/beatkz/confirm-address";
            this.PortingURLLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OriginalURLLink_LinkClicked);
            // 
            // AppVersion
            // 
            this.AppVersion.AutoSize = true;
            this.AppVersion.Location = new System.Drawing.Point(308, 359);
            this.AppVersion.Name = "AppVersion";
            this.AppVersion.Size = new System.Drawing.Size(98, 15);
            this.AppVersion.TabIndex = 11;
            this.AppVersion.Text = "Version: x.x.x.x";
            // 
            // InsiderDomainBatchCheck
            // 
            this.InsiderDomainBatchCheck.AutoSize = true;
            this.InsiderDomainBatchCheck.Location = new System.Drawing.Point(19, 304);
            this.InsiderDomainBatchCheck.Name = "InsiderDomainBatchCheck";
            this.InsiderDomainBatchCheck.Size = new System.Drawing.Size(225, 19);
            this.InsiderDomainBatchCheck.TabIndex = 12;
            this.InsiderDomainBatchCheck.Text = "自ドメインの一括チェックボタンを有効にする";
            this.InsiderDomainBatchCheck.UseVisualStyleBackColor = true;
            this.InsiderDomainBatchCheck.Click += new System.EventHandler(this.CheckChangedEvent);
            // 
            // OutsiderDomainBatchCheck
            // 
            this.OutsiderDomainBatchCheck.AutoSize = true;
            this.OutsiderDomainBatchCheck.Location = new System.Drawing.Point(19, 329);
            this.OutsiderDomainBatchCheck.Name = "OutsiderDomainBatchCheck";
            this.OutsiderDomainBatchCheck.Size = new System.Drawing.Size(225, 19);
            this.OutsiderDomainBatchCheck.TabIndex = 13;
            this.OutsiderDomainBatchCheck.Text = "他ドメインの一括チェックボタンを有効にする";
            this.OutsiderDomainBatchCheck.UseVisualStyleBackColor = true;
            this.OutsiderDomainBatchCheck.Click += new System.EventHandler(this.CheckChangedEvent);
            // 
            // CountDown
            // 
            this.CountDown.AutoSize = true;
            this.CountDown.Location = new System.Drawing.Point(19, 279);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(266, 19);
            this.CountDown.TabIndex = 15;
            this.CountDown.Text = "[送信]ボタン押下後にカウントダウンを開始する-->";
            this.CountDown.UseVisualStyleBackColor = true;
            this.CountDown.Click += new System.EventHandler(this.CheckChangedEvent);
            // 
            // NoDisplayInsiderDomainOnly
            // 
            this.NoDisplayInsiderDomainOnly.AutoSize = true;
            this.NoDisplayInsiderDomainOnly.Location = new System.Drawing.Point(19, 254);
            this.NoDisplayInsiderDomainOnly.Name = "NoDisplayInsiderDomainOnly";
            this.NoDisplayInsiderDomainOnly.Size = new System.Drawing.Size(308, 19);
            this.NoDisplayInsiderDomainOnly.TabIndex = 16;
            this.NoDisplayInsiderDomainOnly.Text = "自ドメイン宛てのメール送信時は確認ダイアログを表示しない";
            this.NoDisplayInsiderDomainOnly.UseVisualStyleBackColor = true;
            this.NoDisplayInsiderDomainOnly.Click += new System.EventHandler(this.CheckChangedEvent);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "秒";
            // 
            // CountDownTime
            // 
            this.CountDownTime.Enabled = false;
            this.CountDownTime.Location = new System.Drawing.Point(291, 275);
            this.CountDownTime.Name = "CountDownTime";
            this.CountDownTime.Size = new System.Drawing.Size(50, 23);
            this.CountDownTime.TabIndex = 19;
            // 
            // ConfirmAddressConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CountDownTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NoDisplayInsiderDomainOnly);
            this.Controls.Add(this.CountDown);
            this.Controls.Add(this.OutsiderDomainBatchCheck);
            this.Controls.Add(this.InsiderDomainBatchCheck);
            this.Controls.Add(this.AppVersion);
            this.Controls.Add(this.PortingURLLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OriginalURLLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MyDomains);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConfirmAddressConfig";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.CountDownTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.ListView MyDomains;
        private System.Windows.Forms.ColumnHeader colhMyDomain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel OriginalURLLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel PortingURLLink;
        private System.Windows.Forms.Label AppVersion;
        private System.Windows.Forms.CheckBox InsiderDomainBatchCheck;
        private System.Windows.Forms.CheckBox OutsiderDomainBatchCheck;
        private System.Windows.Forms.CheckBox CountDown;
        private System.Windows.Forms.CheckBox NoDisplayInsiderDomainOnly;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CountDownTime;
    }
}
