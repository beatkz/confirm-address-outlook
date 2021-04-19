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
            object sender,
            System.EventArgs e)
        {
            Application.ItemSend += new Outlook.ApplicationEvents_11_ItemSendEventHandler(
                                    Application_ItemSend);
            Application.OptionsPagesAdd += Application_OptionsProperty;
        }

        public void Application_ItemSend(
            object Item,
            ref bool Cancel)
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

        public void Application_OptionsProperty(Outlook.PropertyPages Pages)
        {
            Pages.Add(new ConfirmAddressConfig(), "社内ドメイン");
        }

        private DialogResult CheckAddress(object Item)
        {
            List<string> internalList = new List<string> { };
            List<string> externalList = new List<string> { };
            List<string> addressList = new List<string> { };
            string mailBody;

            RegUtil ru = new RegUtil();
            var indomains = ru.LoadRegString("InsiderDomains");
            if (indomains == null)
            {
                indomains = "";
            }
            List<string> domainList = (indomains != "")
            ? indomains.Split(',').ToList() : null;

            if (domainList == null)
            {
                domainList = new List<string> { };
            }

            var mail = Item as Outlook.MailItem;
            var caC = new ConfirmAddressCore();
            caC.CollectMailAddress(
                mail.Recipients,
                ref addressList);

            caC.Judge(
                addressList,
                domainList,
                internalList,
                externalList);

            var printLines = ru.LoadRegInt("ConfirmMailBodyLines");
            mailBody = caC.getMailBody(mail.Body, printLines);

            var isNotDisplayRaw = ru.LoadRegInt("NoDisplayInsiderDomainOnly");
            bool isNotDisplay = Convert.ToBoolean(isNotDisplayRaw);

            DialogResult result;

            if (isNotDisplay && externalList.Count == 0 && internalList.Count > 0)
            {
                result = DialogResult.OK;
            }
            else
            {
                var f = new ConfirmAddressDialog();

                result = f.ShowConfirmAddressDialog(
                    ref internalList,
                    ref externalList,
                    ref mailBody);
                f.Dispose();
            }

            return result;
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
}
