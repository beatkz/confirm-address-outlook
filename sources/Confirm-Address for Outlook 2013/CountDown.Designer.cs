namespace Confirm_Address_for_Outlook_2013
{
    partial class CountDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountDown));
            this.counterLabel = new System.Windows.Forms.Label();
            this.CountDownMsg1 = new System.Windows.Forms.Label();
            this.CountDownMsg2 = new System.Windows.Forms.Label();
            this.doOK = new System.Windows.Forms.Button();
            this.doCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // counterLabel
            // 
            resources.ApplyResources(this.counterLabel, "counterLabel");
            this.counterLabel.Name = "counterLabel";
            // 
            // CountDownMsg1
            // 
            resources.ApplyResources(this.CountDownMsg1, "CountDownMsg1");
            this.CountDownMsg1.Name = "CountDownMsg1";
            // 
            // CountDownMsg2
            // 
            resources.ApplyResources(this.CountDownMsg2, "CountDownMsg2");
            this.CountDownMsg2.Name = "CountDownMsg2";
            this.CountDownMsg2.Click += new System.EventHandler(this.CountDownMsg2_Click);
            // 
            // doOK
            // 
            resources.ApplyResources(this.doOK, "doOK");
            this.doOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.doOK.Name = "doOK";
            this.doOK.UseVisualStyleBackColor = true;
            // 
            // doCancel
            // 
            resources.ApplyResources(this.doCancel, "doCancel");
            this.doCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.doCancel.Name = "doCancel";
            this.doCancel.UseVisualStyleBackColor = true;
            // 
            // CountDown
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doCancel);
            this.Controls.Add(this.doOK);
            this.Controls.Add(this.CountDownMsg2);
            this.Controls.Add(this.CountDownMsg1);
            this.Controls.Add(this.counterLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountDown";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.CountDown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label CountDownMsg1;
        private System.Windows.Forms.Label CountDownMsg2;
        private System.Windows.Forms.Button doOK;
        private System.Windows.Forms.Button doCancel;
    }
}