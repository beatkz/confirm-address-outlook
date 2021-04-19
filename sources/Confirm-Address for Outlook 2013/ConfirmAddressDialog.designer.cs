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
            this.SuspendLayout();
            // 
            // confirm_message
            // 
            resources.ApplyResources(this.confirm_message, "confirm_message");
            this.confirm_message.Name = "confirm_message";
            // 
            // btn_DoSend
            // 
            this.btn_DoSend.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btn_DoSend, "btn_DoSend");
            this.btn_DoSend.Name = "btn_DoSend";
            this.btn_DoSend.UseVisualStyleBackColor = true;
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
            this.InternalMailAddressList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MailAddressList_ItemCheck);
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
            this.ExternalMailAddressList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MailAddressList_ItemCheck);
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
            // 
            // ConfirmAddressDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mailBodyBox);
            this.Controls.Add(this.ConfirmMailBody);
            this.Controls.Add(this.ExternalMailAddressList);
            this.Controls.Add(this.InternalMailAddressList);
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
    }
}