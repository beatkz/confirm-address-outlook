using System.Collections.Generic;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;
using System.Linq;

namespace Confirm_Address_for_Outlook_2013
{
    public class ConfirmAddressCore
    {
        public string getMailBody(string rawBody, long printLines)
        {
            string mailbody = "";
            string[] del = { "\n" };

            string[] splitedBody = rawBody.Split(del,System.StringSplitOptions.None);
            
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

        public List<string> getDomainList(string domains)
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

        private void AddressListfromAddressEntry(
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
                smtpAddress = SMTPAddressfromExchangeX400Address(entry);
                System.Diagnostics.Debug.WriteLine(
                    "メールアドレス：" + smtpAddress);
                AddressList.Add(smtpAddress);
            }
            else
            {
                AddressList.Add(entry.Address);
            }
        }

        private string SMTPAddressfromExchangeX400Address(Outlook.AddressEntry entry)
        {
            string smtpAddress = null;
            if (entry != null)
            {
                object user = entry.GetType().InvokeMember(
                    "GetExchangeUser", 
                    System.Reflection.BindingFlags.InvokeMethod, 
                    null, entry, new object[] { });
                if (user != null)
                {
                    try
                    {
                        smtpAddress = user.GetType().InvokeMember(
                            "PrimarySmtpAddress",
                            System.Reflection.BindingFlags.GetProperty,
                            null, user, new object[] { }).ToString();
                    }
                    finally
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

        private static string LowerCasedDomainfromDomainList(
            List<string> domainList,
            int j){
            return domainList[j].ToLower();
        }
    }
}
