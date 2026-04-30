using System.Collections.Generic;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Linq;
using System.Windows.Forms;
using System;

namespace Confirm_Address_for_Outlook_2013
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(
            object sender, System.EventArgs e)
        {
            Application.ItemSend += new Outlook.ApplicationEvents_11_ItemSendEventHandler(
                                    Application_ItemSend);
            Application.OptionsPagesAdd += Application_OptionsProperty;
        }

        public void Application_ItemSend(
            object Item, ref bool Cancel)
        {
            var result = CheckAddress(Item);

            if (result == DialogResult.OK)
            {
                //メールを送信
            }
            else if (result == DialogResult.Cancel)
            {
                Cancel = true;
            }
        }

        public void Application_OptionsProperty(
            Outlook.PropertyPages Pages)
        {
            Pages.Add(new ConfirmAddressConfig(), "社内ドメイン");
        }

        private DialogResult CheckAddress(object Item)
        {
            var (domainList, isNotDisplay) = LoadSettingsFromRegistry();
            var (senderAddress, internalList, externalList) = CollectRecipientsAndSender(Item, domainList);
            string mailBody = GetMailBodyPreview(Item);
            List<string> attachments = CollectAttachmentNames(Item);

            // Show Confirm Dialog
            DialogResult result;
            if (isNotDisplay && externalList.Count == 0 && internalList.Count > 0)
            {
                result = DialogResult.OK;
            }
            else
            {
                var data = new ConfirmDialogData
                {
                    SenderAddress = senderAddress,
                    InternalList = internalList,
                    ExternalList = externalList,
                    AttachList = attachments,
                    MailBody = mailBody
                };

                var f = new ConfirmAddressDialog();
                result = f.ShowConfirmAddressDialog(data);
                f.Dispose();

                // ダイアログで更新された値を反映（必要に応じて）
                senderAddress = data.SenderAddress;
                internalList = data.InternalList;
                externalList = data.ExternalList;
                attachments = data.AttachList;
                mailBody = data.MailBody;
            }

            return result;
        }

        private (List<string> domainList, bool isNotDisplay) LoadSettingsFromRegistry()
        {
            RegUtil ru = new RegUtil();
            var indomains = ru.LoadRegString("InsiderDomains");
            if (indomains == null)
            {
                indomains = "";
            }

            List<string> domainList = (indomains != "")
                ? indomains.Split(',').ToList() : new List<string> { };

            var isNotDisplayRaw = ru.LoadRegInt("NoDisplayInsiderDomainOnly");
            bool isNotDisplay = Convert.ToBoolean(isNotDisplayRaw);

            return (domainList, isNotDisplay);
        }

        private (string senderAddress, List<string> internalList, List<string> externalList)
            CollectRecipientsAndSender(
            object Item, List<string> domainList)
        {
            List<string> internalList = new List<string> { };
            List<string> externalList = new List<string> { };
            List<string> addressList = new List<string> { };

            var mail = Item as Outlook.MailItem;
            var caC = new ConfirmAddressCore();
            string senderAddress = caC.GetSenderSmtpAddress(mail);
            caC.CollectMailAddress(mail.Recipients, ref addressList);
            caC.Judge(addressList, domainList, internalList, externalList);

            return (senderAddress, internalList, externalList);
        }

        private string GetMailBodyPreview(object Item)
        {
            RegUtil ru = new RegUtil();
            var printLines = ru.LoadRegInt("ConfirmMailBodyLines");
            string mailBody = "";

            var mail = Item as Outlook.MailItem;
            var caC = new ConfirmAddressCore();
            mailBody = caC.GetMailBody(mail.Body, printLines);

            return mailBody;
        }

        private List<string> CollectAttachmentNames(object Item)
        {
            List<string> attachments = new List<string> { };

            var mail = Item as Outlook.MailItem;
            var caC = new ConfirmAddressCore();
            caC.CollectAttachments(mail.Attachments, ref attachments);

            return attachments;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            //注: Outlook はこのイベントを発行しなくなりました。Outlook が
            //    を Outlook のシャットダウン時に実行する必要があります。https://go.microsoft.com/fwlink/?LinkId=506785 をご覧ください
        }

        #region VSTO で生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InternalStartup()
        {
            Startup += new System.EventHandler(ThisAddIn_Startup);
            Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }

    public class ConfirmDialogData
    {
        public string SenderAddress { get; set; }
        public List<string> InternalList { get; set; }
        public List<string> ExternalList { get; set; }
        public List<string> AttachList { get; set; }
        public string MailBody { get; set; }
    }
}
