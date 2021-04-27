using Xunit;
using Confirm_Address_for_Outlook_2013;
using System.Collections.Generic;

namespace CA_Outlook_xUnitTest
{
    public class ConfirmAddressCoreTests
    {
        [Fact]
        public void TestJudge_domainListIsNull()
        {
            List<string> addressList = new List<string>
                { 
                    "aaa@me.com", 
                    "bbb@me.com" 
                };
            List<string> domainList = new List<string>();
            List<string> insiders = new List<string>();
            List<string> outsiders = new List<string>();

            ConfirmAddressCore cac = new ConfirmAddressCore();
            cac.Judge(addressList, domainList, insiders, outsiders);
            Assert.Empty(insiders);
            Assert.Equal(2, outsiders.Count);
        }

        [Fact]
        public void TestJudge_onlyInsiders()
        {
            List<string> addressList = new List<string>
                { 
                    "aaa@me.com", 
                    "bbb@me.com" 
                };
            List<string> domainList = new List<string> { "me.com" };
            List<string> insiders = new List<string>();
            List<string> outsiders = new List<string>();

            ConfirmAddressCore cac = new ConfirmAddressCore();
            cac.Judge(addressList, domainList, insiders, outsiders);
            Assert.Equal(2, insiders.Count);
            Assert.Empty(outsiders);
        }

        [Fact]
        public void TestJudge_onlyOutsiders()
        {
            List<string> addressList = new List<string>
                { 
                    "aaa@out.com", 
                    "bbb@out.com" 
                };
            List<string> domainList = new List<string> { "me.com" };
            List<string> insiders = new List<string>();
            List<string> outsiders = new List<string>();

            ConfirmAddressCore cac = new ConfirmAddressCore();
            cac.Judge(addressList, domainList, insiders, outsiders);
            Assert.Empty(insiders);
            Assert.Equal(2, outsiders.Count);
        }

        [Fact]
        public void TestJudge_InAndOutsiders()
        {
            List<string> addressList = new List<string> 
                { 
                    "zzz@me.com", 
                    "aaa@out.com", 
                    "bbb@out.com", 
                    "ccc@me.com"
                };
            List<string> domainList = new List<string> { "me.com" };
            List<string> insiders = new List<string>();
            List<string> outsiders = new List<string>();

            ConfirmAddressCore cac = new ConfirmAddressCore();
            cac.Judge(addressList, domainList, insiders, outsiders);
            Assert.Equal(2, insiders.Count);
            Assert.Equal(2, outsiders.Count);
        }

        [Fact]
        public void TestJudge_UpperCase()
        {
            List<string> addressList = new List<string>
                {
                    "TARO@ME.COM"
                };
            List<string> domainList = new List<string> { "me.com" };
            List<string> insiders = new List<string>();
            List<string> outsiders = new List<string>();

            ConfirmAddressCore cac = new ConfirmAddressCore();
            cac.Judge(addressList, domainList, insiders, outsiders);
            Assert.Single(insiders);
            Assert.Empty(outsiders);
        }

        [Fact]
        public void TestJudge_OutSiderNameLooksLikeInSiderDomainName()
        {
            List<string> addressList = new List<string>
                {
                    "me.com@outsider.com",
                    "bbb@me.com"
                };
            List<string> domainList = new List<string> { "me.com" };
            List<string> insiders = new List<string>();
            List<string> outsiders = new List<string>();

            ConfirmAddressCore cac = new ConfirmAddressCore();
            cac.Judge(addressList, domainList, insiders, outsiders);
            Assert.Single(insiders);
            Assert.Single(outsiders);
        }

        [Fact]
        public void TestGetDomainList()
        {
            string indomains = "gmail.com,me.com";

            ConfirmAddressCore cac = new ConfirmAddressCore();
            List<string> domainList = cac.getDomainList(indomains);

            Assert.Equal(2, domainList.Count);
        }

        [Fact]
        public void TestGetDomainList_listInEmpty()
        {
            string indomains = "";

            ConfirmAddressCore cac = new ConfirmAddressCore();
            List<string> domainList = cac.getDomainList(indomains);

            Assert.Empty(domainList);
        }

        [Fact]
        public void TestGetDomainList_listInNull()
        {
            string indomains = null;

            ConfirmAddressCore cac = new ConfirmAddressCore();
            List<string> domainList = cac.getDomainList(indomains);

            Assert.Empty(domainList);
        }

        [Fact]
        public void TestgetMailBodyIn3Lines()
        {
            string rawBody = "››Š”®‰ïĞ\n~~—l\n\n‚¨¢˜b‚É‚È‚Á‚Ä‚¨‚è‚Ü‚·B\nŠ”®‰ïĞ‚Ì¢¢‚Å‚·B";
            long printRows = 3;

            ConfirmAddressCore cac = new ConfirmAddressCore();
            string printBody = cac.getMailBody(rawBody, printRows);

            Assert.Equal("››Š”®‰ïĞ\n~~—l\n\n", printBody);
        }

        [Fact]
        public void TestgetMailBodyIn5Lines()
        {
            string rawBody = "››Š”®‰ïĞ\n~~—l\n\n‚¨¢˜b‚É‚È‚Á‚Ä‚¨‚è‚Ü‚·B\nŠ”®‰ïĞ‚Ì¢¢‚Å‚·B";
            long printRows = 5;

            ConfirmAddressCore cac = new ConfirmAddressCore();
            string printBody = cac.getMailBody(rawBody, printRows);

            Assert.Equal("››Š”®‰ïĞ\n~~—l\n\n‚¨¢˜b‚É‚È‚Á‚Ä‚¨‚è‚Ü‚·B\nŠ”®‰ïĞ‚Ì¢¢‚Å‚·B\n", printBody);
        }

        [Fact]
        public void TestgetMailBodyLessThan5Lines()
        {
            string rawBody = "››Š”®‰ïĞ\n~~—l";
            long printRows = 5;

            ConfirmAddressCore cac = new ConfirmAddressCore();
            string printBody = cac.getMailBody(rawBody, printRows);

            Assert.Equal("››Š”®‰ïĞ\n~~—l\n", printBody);
        }

    }
}
