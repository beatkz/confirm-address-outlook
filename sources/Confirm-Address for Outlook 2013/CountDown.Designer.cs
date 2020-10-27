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
            this.counterLabel = new System.Windows.Forms.Label();
            this.CountDownMsg1 = new System.Windows.Forms.Label();
            this.CountDownMsg2 = new System.Windows.Forms.Label();
            this.doOK = new System.Windows.Forms.Button();
            this.doCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.counterLabel.Location = new System.Drawing.Point(105, 7);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(27, 31);
            this.counterLabel.TabIndex = 0;
            this.counterLabel.Text = "0";
            // 
            // CountDownMsg1
            // 
            this.CountDownMsg1.AutoSize = true;
            this.CountDownMsg1.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CountDownMsg1.Location = new System.Drawing.Point(12, 7);
            this.CountDownMsg1.Name = "CountDownMsg1";
            this.CountDownMsg1.Size = new System.Drawing.Size(56, 31);
            this.CountDownMsg1.TabIndex = 1;
            this.CountDownMsg1.Text = "あと";
            // 
            // CountDownMsg2
            // 
            this.CountDownMsg2.AutoSize = true;
            this.CountDownMsg2.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CountDownMsg2.Location = new System.Drawing.Point(190, 7);
            this.CountDownMsg2.Name = "CountDownMsg2";
            this.CountDownMsg2.Size = new System.Drawing.Size(182, 31);
            this.CountDownMsg2.TabIndex = 2;
            this.CountDownMsg2.Text = "秒で送信します。";
            // 
            // doOK
            // 
            this.doOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.doOK.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.doOK.Location = new System.Drawing.Point(177, 53);
            this.doOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doOK.Name = "doOK";
            this.doOK.Size = new System.Drawing.Size(78, 29);
            this.doOK.TabIndex = 3;
            this.doOK.Text = "送信";
            this.doOK.UseVisualStyleBackColor = true;
            // 
            // doCancel
            // 
            this.doCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.doCancel.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.doCancel.Location = new System.Drawing.Point(261, 53);
            this.doCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doCancel.Name = "doCancel";
            this.doCancel.Size = new System.Drawing.Size(105, 29);
            this.doCancel.TabIndex = 4;
            this.doCancel.Text = "キャンセル";
            this.doCancel.UseVisualStyleBackColor = true;
            // 
            // CountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 92);
            this.Controls.Add(this.doCancel);
            this.Controls.Add(this.doOK);
            this.Controls.Add(this.CountDownMsg2);
            this.Controls.Add(this.CountDownMsg1);
            this.Controls.Add(this.counterLabel);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountDown";
            this.ShowIcon = false;
            this.Text = "カウントダウン";
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