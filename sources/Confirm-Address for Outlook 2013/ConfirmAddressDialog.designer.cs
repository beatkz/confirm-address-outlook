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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DoSend = new System.Windows.Forms.Button();
            this.btn_SendCancel = new System.Windows.Forms.Button();
            this.InternalMailAddressList = new System.Windows.Forms.ListView();
            this.columnHCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExternalMailAddressList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_DoSend
            // 
            resources.ApplyResources(this.btn_DoSend, "btn_DoSend");
            this.btn_DoSend.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_DoSend.Name = "btn_DoSend";
            this.btn_DoSend.UseVisualStyleBackColor = true;
            // 
            // btn_SendCancel
            // 
            resources.ApplyResources(this.btn_SendCancel, "btn_SendCancel");
            this.btn_SendCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_SendCancel.Name = "btn_SendCancel";
            this.btn_SendCancel.UseVisualStyleBackColor = true;
            // 
            // InternalMailAddressList
            // 
            resources.ApplyResources(this.InternalMailAddressList, "InternalMailAddressList");
            this.InternalMailAddressList.CheckBoxes = true;
            this.InternalMailAddressList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHCheck,
            this.columnMailAddress});
            this.InternalMailAddressList.HideSelection = false;
            this.InternalMailAddressList.Name = "InternalMailAddressList";
            this.InternalMailAddressList.UseCompatibleStateImageBehavior = false;
            this.InternalMailAddressList.View = System.Windows.Forms.View.Details;
            this.InternalMailAddressList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.MailAddressList_ColumnClick);
            this.InternalMailAddressList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MailAddressList_ItemCheck);
            // 
            // columnHCheck
            // 
            resources.ApplyResources(this.columnHCheck, "columnHCheck");
            // 
            // columnMailAddress
            // 
            resources.ApplyResources(this.columnMailAddress, "columnMailAddress");
            // 
            // ExternalMailAddressList
            // 
            resources.ApplyResources(this.ExternalMailAddressList, "ExternalMailAddressList");
            this.ExternalMailAddressList.CheckBoxes = true;
            this.ExternalMailAddressList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ExternalMailAddressList.HideSelection = false;
            this.ExternalMailAddressList.Name = "ExternalMailAddressList";
            this.ExternalMailAddressList.UseCompatibleStateImageBehavior = false;
            this.ExternalMailAddressList.View = System.Windows.Forms.View.Details;
            this.ExternalMailAddressList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.MailAddressList_ColumnClick);
            this.ExternalMailAddressList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MailAddressList_ItemCheck);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // ConfirmAddressDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExternalMailAddressList);
            this.Controls.Add(this.InternalMailAddressList);
            this.Controls.Add(this.btn_SendCancel);
            this.Controls.Add(this.btn_DoSend);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DoSend;
        private System.Windows.Forms.Button btn_SendCancel;
        private System.Windows.Forms.ListView InternalMailAddressList;
        private System.Windows.Forms.ColumnHeader columnHCheck;
        private System.Windows.Forms.ColumnHeader columnMailAddress;
        private System.Windows.Forms.ListView ExternalMailAddressList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}