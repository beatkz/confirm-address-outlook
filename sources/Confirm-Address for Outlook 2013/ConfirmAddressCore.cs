using System.Collections.Generic;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;
using System.Linq;
using System;
using Newtonsoft.Json;
using System.IO;

namespace Confirm_Address_for_Outlook_2013
{
    public class ConfirmAddressCore
    {
        public string GetMailBody(string rawBody, long printLines)
        {
            string mailbody = "";
            string[] del = { "\n" };

            string[] splitedBody = rawBody.Split(del, System.StringSplitOptions.None);
            
            if(splitedBody.Length < printLines)
            {
                printLines = (long)splitedBody.Length;
            }

            for (var i=0; i<printLines; i++)
            {
                mailbody += splitedBody[i] + "\n";
            }

            return mailbody;
        }

        public List<string> GetDomainList(string domains)
        {
            if (domains == null || domains.Length == 0)
            {
                return new List<string> { };
            } else {
                return domains.Split(',').ToList();
            }
        }

        public void CollectMailAddress(
            Outlook.Recipients reci, 
            ref List<string>addressList)
        {
            addressList.Clear();
            if (reci != null)
            {
                foreach (Outlook.Recipient item in reci)
                {
                    AddressListfromAddressEntry(
                        ref addressList, item.AddressEntry);
                }
            }
        }

        public void AddressListfromAddressEntry(
            ref List<string> AddressList,
            Outlook.AddressEntry entry)
        {
            string smtpAddress = null;
            System.Diagnostics.Debug.WriteLine(
                "現在処理中のメールアドレス：" + entry.Address);
            System.Diagnostics.Debug.WriteLine(
                "現在処理中のメールアドレスタイプ：" + entry.Type);

            if (entry.Type == "EX")
            {
                // まず配布リストを検索
                smtpAddress = SMTPAddressfromDistroListX400Address(entry);
                if (!string.IsNullOrEmpty(smtpAddress))
                {
                    System.Diagnostics.Debug.WriteLine(
                        "配布リストのメールアドレス：" + smtpAddress);
                    AddressList.Add(smtpAddress);
                    return;
                }
                // 次にX400アドレスユーザーを検索
                smtpAddress = SMTPAddressfromExchangeX400Address(entry);
                if (!string.IsNullOrEmpty(smtpAddress))
                {
                    System.Diagnostics.Debug.WriteLine(
                        "メールボックスのメールアドレス：" + smtpAddress);
                    AddressList.Add(smtpAddress);
                    return;
                }
            }
            else
            {
                AddressList.Add(entry.Address);
            }
        }

        private void LogErrorAsJson(string message, string stackTrace, string x400Address, string methodName)
        {
            var errorLog = new
            {
                timestamp = DateTime.Now,
                level = "ERROR",
                message,
                stackTrace,
                x400Address,
                methodName
            };

            string jsonLog = JsonConvert.SerializeObject(errorLog, Formatting.Indented);
            
            string logFilePath = Environment.SpecialFolder.DesktopDirectory + "\\ConfirmAddressErrorLog.json";

            File.AppendAllText(logFilePath, jsonLog + Environment.NewLine);
        }

        private string SMTPAddressfromDistroListX400Address(Outlook.AddressEntry entry)
        {
            string smtpAddress = null;
            if (entry != null)
            {
                System.Diagnostics.Debug.WriteLine($"[{DateTime.Now}] 変換開始: X400アドレス = {entry.Address}");
                object dl = null;
                try
                {
                    dl = entry.GetType().InvokeMember(
                        "GetExchangeDistributionList",
                        System.Reflection.BindingFlags.InvokeMethod,
                        null, entry, new object[] { });
                    if (dl != null)
                    {
                        smtpAddress = dl.GetType().InvokeMember(
                            "PrimarySmtpAddress",
                            System.Reflection.BindingFlags.GetProperty,
                            null, dl, new object[] { }).ToString();
                        System.Diagnostics.Debug.WriteLine($"[{DateTime.Now}] 変換成功: SMTPアドレス = {smtpAddress}");
                    }
                }
                catch (Exception ex)
                {
                    LogErrorAsJson(ex.Message, ex.StackTrace, entry.Address, nameof(SMTPAddressfromDistroListX400Address));
                    smtpAddress = string.Empty;
                }
                finally
                {
                    if (dl != null)
                    {
                        Marshal.ReleaseComObject(dl);
                    }
                }
            }
            else
            {
                smtpAddress = string.Empty;
            }
            return smtpAddress;
        }


        private string SMTPAddressfromExchangeX400Address(Outlook.AddressEntry entry)
        {
            string smtpAddress = null;
            if (entry != null)
            {
                System.Diagnostics.Debug.WriteLine($"[{DateTime.Now}] 変換開始: X400アドレス = {entry.Address}");
                object user = null;
                try
                {
                    user = entry.GetType().InvokeMember(
                        "GetExchangeUser",
                        System.Reflection.BindingFlags.InvokeMethod,
                        null, entry, new object[] { });
                    if (user != null)
                    {
                        smtpAddress = user.GetType().InvokeMember(
                            "PrimarySmtpAddress",
                            System.Reflection.BindingFlags.GetProperty,
                            null, user, new object[] { }).ToString();
                        System.Diagnostics.Debug.WriteLine($"[{DateTime.Now}] 変換成功: SMTPアドレス = {smtpAddress}");
                    }
                }
                catch (Exception ex)
                {
                    LogErrorAsJson(ex.Message, ex.StackTrace, entry.Address, nameof(SMTPAddressfromExchangeX400Address));
                    smtpAddress = string.Empty;
                }
                finally
                {
                    if (user != null)
                    {
                        Marshal.ReleaseComObject(user);
                    }
                }
            }
            else
            {
                smtpAddress = string.Empty;
            }
            return smtpAddress;
        }

        public void Judge(
            List<string> addressList,
            List<string> domainList,
            List<string> yourDomainAddress,
            List<string> otherDomainAddress){
            //ドメインリストが空の場合はすべて外部ドメインとみなす
            if (domainList.Count == 0)
            {
                AssumeOtherDomainAddress(
                    addressList, otherDomainAddress);
                return;
            }
            //ドメインリストと照合して内部・外部ドメインを振り分ける
            SortAddressBetweenInternalAndExternal(
                addressList, domainList, 
                yourDomainAddress, otherDomainAddress);
        }

        private void AssumeOtherDomainAddress(
            List<string> addressList,
            List<string> otherDomainAddress){
            for (var i = 0; i < addressList.Count; i++){
                var address = addressList[i];
                otherDomainAddress.Add(address);
            }
        }

        private void SortAddressBetweenInternalAndExternal(
            List<string> addressList,
            List<string> domainList,
            List<string> yourDomainAddress,
            List<string> otherDomainAddress){
            for (var i = 0; i < addressList.Count; i++){
                var address = addressList[i];
                if (address.Length == 0){
                    continue;
                }
                var domain = address.Substring(address.IndexOf("@")).ToLower();
                var match = false;
                for (var j = 0; j < domainList.Count; j++){
                    string insiderDomain = LowerCasedDomainfromDomainList(domainList, j);
                    if (domain.IndexOf(insiderDomain) != -1){
                        match = true;
                    }
                }
                if (match){
                    yourDomainAddress.Add(address);
                }else{
                    otherDomainAddress.Add(address);
                }
            }
        }

        public void CollectAttachments(
            Outlook.Attachments att,
            ref List<string> attList)
        {
            foreach (Outlook.Attachment item in att)
            {
                attList.Add(item.FileName);
            }
        }
        private static string LowerCasedDomainfromDomainList(
            List<string> domainList,
            int j){
            return domainList[j].ToLower();
        }
    }
}
