namespace Confirm_Address_for_Outlook_2013
{
    partial class ConfirmAddressDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmAddressDialog));
            this.confirm_message = new System.Windows.Forms.Label();
            this.btn_DoSend = new System.Windows.Forms.Button();
            this.btn_SendCancel = new System.Windows.Forms.Button();
            this.InternalMailAddressList = new System.Windows.Forms.ListView();
            this.columnBatchCheckMy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMyMailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExternalMailAddressList = new System.Windows.Forms.ListView();
            this.columnBatchCheckOther = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOtherMailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConfirmMailBody = new System.Windows.Forms.CheckBox();
            this.mailBodyBox = new System.Windows.Forms.TextBox();
            this.CountdownPanel = new System.Windows.Forms.Panel();
            this.CountDownMsg2 = new System.Windows.Forms.Label();
            this.CountDownMsg1 = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMailBody = new System.Windows.Forms.Panel();
            this.AttachedFilenameList = new System.Windows.Forms.ListView();
            this.columnBatchCheckAttach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAttachedFileNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountdownPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlMailBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirm_message
            // 
            resources.ApplyResources(this.confirm_message, "confirm_message");
            this.confirm_message.Name = "confirm_message";
            // 
            // btn_DoSend
            // 
            resources.ApplyResources(this.btn_DoSend, "btn_DoSend");
            this.btn_DoSend.Name = "btn_DoSend";
            this.btn_DoSend.UseVisualStyleBackColor = true;
            this.btn_DoSend.Click += new System.EventHandler(this.btn_DoSend_Click);
            // 
            // btn_SendCancel
            // 
            this.btn_SendCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btn_SendCancel, "btn_SendCancel");
            this.btn_SendCancel.Name = "btn_SendCancel";
            this.btn_SendCancel.UseVisualStyleBackColor = true;
            // 
            // InternalMailAddressList
            // 
            this.InternalMailAddressList.CheckBoxes = true;
            this.InternalMailAddressList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBatchCheckMy,
            this.columnMyMailAddress});
            resources.ApplyResources(this.InternalMailAddressList, "InternalMailAddressList");
            this.InternalMailAddressList.HideSelection = false;
            this.InternalMailAddressList.Name = "InternalMailAddressList";
            this.InternalMailAddressList.UseCompatibleStateImageBehavior = false;
            this.InternalMailAddressList.View = System.Windows.Forms.View.Details;
            this.InternalMailAddressList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.MailAddressList_ColumnClick);
            this.InternalMailAddressList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.MailAddressList_ItemChecked);
            // 
            // columnBatchCheckMy
            // 
            resources.ApplyResources(this.columnBatchCheckMy, "columnBatchCheckMy");
            // 
            // columnMyMailAddress
            // 
            resources.ApplyResources(this.columnMyMailAddress, "columnMyMailAddress");
            // 
            // ExternalMailAddressList
            // 
            this.ExternalMailAddressList.CheckBoxes = true;
            this.ExternalMailAddressList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBatchCheckOther,
            this.columnOtherMailAddress});
            resources.ApplyResources(this.ExternalMailAddressList, "ExternalMailAddressList");
            this.ExternalMailAddressList.HideSelection = false;
            this.ExternalMailAddressList.Name = "ExternalMailAddressList";
            this.ExternalMailAddressList.UseCompatibleStateImageBehavior = false;
            this.ExternalMailAddressList.View = System.Windows.Forms.View.Details;
            this.ExternalMailAddressList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.MailAddressList_ColumnClick);
            this.ExternalMailAddressList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.MailAddressList_ItemChecked);
            // 
            // columnBatchCheckOther
            // 
            resources.ApplyResources(this.columnBatchCheckOther, "columnBatchCheckOther");
            // 
            // columnOtherMailAddress
            // 
            resources.ApplyResources(this.columnOtherMailAddress, "columnOtherMailAddress");
            // 
            // ConfirmMailBody
            // 
            resources.ApplyResources(this.ConfirmMailBody, "ConfirmMailBody");
            this.ConfirmMailBody.Name = "ConfirmMailBody";
            this.ConfirmMailBody.UseVisualStyleBackColor = true;
            this.ConfirmMailBody.CheckedChanged += new System.EventHandler(this.ConfirmMailBody_CheckedChanged);
            // 
            // mailBodyBox
            // 
            resources.ApplyResources(this.mailBodyBox, "mailBodyBox");
            this.mailBodyBox.Name = "mailBodyBox";
            this.mailBodyBox.ReadOnly = true;
            // 
            // CountdownPanel
            // 
            this.CountdownPanel.Controls.Add(this.CountDownMsg2);
            this.CountdownPanel.Controls.Add(this.CountDownMsg1);
            this.CountdownPanel.Controls.Add(this.counterLabel);
            resources.ApplyResources(this.CountdownPanel, "CountdownPanel");
            this.CountdownPanel.Name = "CountdownPanel";
            // 
            // CountDownMsg2
            // 
            resources.ApplyResources(this.CountDownMsg2, "CountDownMsg2");
            this.CountDownMsg2.Name = "CountDownMsg2";
            // 
            // CountDownMsg1
            // 
            resources.ApplyResources(this.CountDownMsg1, "CountDownMsg1");
            this.CountDownMsg1.Name = "CountDownMsg1";
            // 
            // counterLabel
            // 
            resources.ApplyResources(this.counterLabel, "counterLabel");
            this.counterLabel.Name = "counterLabel";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.InternalMailAddressList);
            this.flowLayoutPanel1.Controls.Add(this.ExternalMailAddressList);
            this.flowLayoutPanel1.Controls.Add(this.pnlMailBody);
            this.flowLayoutPanel1.Controls.Add(this.AttachedFilenameList);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // pnlMailBody
            // 
            this.pnlMailBody.Controls.Add(this.ConfirmMailBody);
            this.pnlMailBody.Controls.Add(this.mailBodyBox);
            resources.ApplyResources(this.pnlMailBody, "pnlMailBody");
            this.pnlMailBody.Name = "pnlMailBody";
            // 
            // AttachedFilenameList
            // 
            this.AttachedFilenameList.CheckBoxes = true;
            this.AttachedFilenameList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBatchCheckAttach,
            this.columnAttachedFileNames});
            resources.ApplyResources(this.AttachedFilenameList, "AttachedFilenameList");
            this.AttachedFilenameList.HideSelection = false;
            this.AttachedFilenameList.Name = "AttachedFilenameList";
            this.AttachedFilenameList.UseCompatibleStateImageBehavior = false;
            this.AttachedFilenameList.View = System.Windows.Forms.View.Details;
            // 
            // columnBatchCheckAttach
            // 
            resources.ApplyResources(this.columnBatchCheckAttach, "columnBatchCheckAttach");
            // 
            // columnAttachedFileNames
            // 
            resources.ApplyResources(this.columnAttachedFileNames, "columnAttachedFileNames");
            // 
            // ConfirmAddressDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.CountdownPanel);
            this.Controls.Add(this.btn_SendCancel);
            this.Controls.Add(this.btn_DoSend);
            this.Controls.Add(this.confirm_message);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmAddressDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmAddressDialog_FormClosing);
            this.Load += new System.EventHandler(this.ConfirmAddressDialog_Load);
            this.CountdownPanel.ResumeLayout(false);
            this.CountdownPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlMailBody.ResumeLayout(false);
            this.pnlMailBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirm_message;
        private System.Windows.Forms.Button btn_DoSend;
        private System.Windows.Forms.Button btn_SendCancel;
        private System.Windows.Forms.ListView InternalMailAddressList;
        private System.Windows.Forms.ColumnHeader columnBatchCheckMy;
        private System.Windows.Forms.ColumnHeader columnMyMailAddress;
        private System.Windows.Forms.ListView ExternalMailAddressList;
        private System.Windows.Forms.ColumnHeader columnBatchCheckOther;
        private System.Windows.Forms.ColumnHeader columnOtherMailAddress;
        private System.Windows.Forms.CheckBox ConfirmMailBody;
        private System.Windows.Forms.TextBox mailBodyBox;
        private System.Windows.Forms.Panel CountdownPanel;
        private System.Windows.Forms.Label CountDownMsg2;
        private System.Windows.Forms.Label CountDownMsg1;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlMailBody;
        private System.Windows.Forms.ListView AttachedFilenameList;
        private System.Windows.Forms.ColumnHeader columnBatchCheckAttach;
        private System.Windows.Forms.ColumnHeader columnAttachedFileNames;
    }
}