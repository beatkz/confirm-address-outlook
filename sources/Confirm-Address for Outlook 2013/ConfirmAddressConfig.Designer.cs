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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmAddressConfig));
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CountDownTime)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            resources.ApplyResources(this.BtnAdd, "BtnAdd");
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            resources.ApplyResources(this.BtnEdit, "BtnEdit");
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnRemove
            // 
            resources.ApplyResources(this.BtnRemove, "BtnRemove");
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // MyDomains
            // 
            resources.ApplyResources(this.MyDomains, "MyDomains");
            this.MyDomains.AllowColumnReorder = true;
            this.MyDomains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colhMyDomain});
            this.MyDomains.HideSelection = false;
            this.MyDomains.Name = "MyDomains";
            this.MyDomains.UseCompatibleStateImageBehavior = false;
            this.MyDomains.View = System.Windows.Forms.View.Details;
            // 
            // colhMyDomain
            // 
            resources.ApplyResources(this.colhMyDomain, "colhMyDomain");
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // OriginalURLLink
            // 
            resources.ApplyResources(this.OriginalURLLink, "OriginalURLLink");
            this.OriginalURLLink.Name = "OriginalURLLink";
            this.OriginalURLLink.TabStop = true;
            this.OriginalURLLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OriginalURLLink_LinkClicked);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // PortingURLLink
            // 
            resources.ApplyResources(this.PortingURLLink, "PortingURLLink");
            this.PortingURLLink.Name = "PortingURLLink";
            this.PortingURLLink.TabStop = true;
            this.PortingURLLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OriginalURLLink_LinkClicked);
            // 
            // AppVersion
            // 
            resources.ApplyResources(this.AppVersion, "AppVersion");
            this.AppVersion.Name = "AppVersion";
            // 
            // InsiderDomainBatchCheck
            // 
            resources.ApplyResources(this.InsiderDomainBatchCheck, "InsiderDomainBatchCheck");
            this.InsiderDomainBatchCheck.Name = "InsiderDomainBatchCheck";
            this.InsiderDomainBatchCheck.UseVisualStyleBackColor = true;
            this.InsiderDomainBatchCheck.Click += new System.EventHandler(this.CheckChangedEvent);
            // 
            // OutsiderDomainBatchCheck
            // 
            resources.ApplyResources(this.OutsiderDomainBatchCheck, "OutsiderDomainBatchCheck");
            this.OutsiderDomainBatchCheck.Name = "OutsiderDomainBatchCheck";
            this.OutsiderDomainBatchCheck.UseVisualStyleBackColor = true;
            this.OutsiderDomainBatchCheck.Click += new System.EventHandler(this.CheckChangedEvent);
            // 
            // CountDown
            // 
            resources.ApplyResources(this.CountDown, "CountDown");
            this.CountDown.Name = "CountDown";
            this.CountDown.UseVisualStyleBackColor = true;
            this.CountDown.Click += new System.EventHandler(this.CheckChangedEvent);
            // 
            // NoDisplayInsiderDomainOnly
            // 
            resources.ApplyResources(this.NoDisplayInsiderDomainOnly, "NoDisplayInsiderDomainOnly");
            this.NoDisplayInsiderDomainOnly.Name = "NoDisplayInsiderDomainOnly";
            this.NoDisplayInsiderDomainOnly.UseVisualStyleBackColor = true;
            this.NoDisplayInsiderDomainOnly.Click += new System.EventHandler(this.CheckChangedEvent);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // CountDownTime
            // 
            resources.ApplyResources(this.CountDownTime, "CountDownTime");
            this.CountDownTime.Name = "CountDownTime";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ConfirmAddressConfig
            // 
            resources.ApplyResources(this, "$this");
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
            this.Name = "ConfirmAddressConfig";
            ((System.ComponentModel.ISupportInitialize)(this.CountDownTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label1;
    }
}
