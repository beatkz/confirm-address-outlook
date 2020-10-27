using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Confirm_Address_for_Outlook_2013
{
    public partial class ConfirmAddressDialog : Form
    {
        private List<String> internalList = new List<string> { };
        private List<String> externalList = new List<string> { };
        private long fullEmailAddressCount = new long();
        private long fullEmailAddressCheckedCount = new long();
        private bool isInsiderMailAddressAllChecked = false;
        private bool isOutsiderMailAddressAllChecked = false;

        private bool bcInsiderMail;
        private bool bcOutsiderMail;


        public ConfirmAddressDialog()
        {
            InitializeComponent();
        }

        public DialogResult ShowConfirmAddressDialog(ref List<string> internalList, ref List<string> externalList)
        {
            this.internalList = internalList;
            this.externalList = externalList;

            var result = ShowDialog();

            return result;
        }

        private void AddListViewItem(ref List<string> wantToAddList, ref ListView willAddListView) {
            for (int count = 0; count < wantToAddList.Count; count++)
            {
                ListViewItem item = new ListViewItem();
                item.Checked = false;
                item.SubItems.Add(wantToAddList[count]);
                willAddListView.Items.Add(item);
            }
        }

        private void BatchCheckButtonSettingfromRegistrySettings()
        {
            RegUtil ru = new RegUtil();
            bcInsiderMail = Convert.ToBoolean(ru.LoadRegInt("InsiderDomainBatchCheck"));
            InternalMailAddressList.Columns[0].Text = bcInsiderMail ? "✓" : "";
            bcOutsiderMail = Convert.ToBoolean(ru.LoadRegInt("OutsiderDomainBatchCheck"));
            ExternalMailAddressList.Columns[0].Text = bcOutsiderMail ? "✓" : "";
        }

        private void ConfirmAddressDialog_Load(object sender, EventArgs e)
        {
            AddListViewItem(ref internalList, ref InternalMailAddressList);
            AddListViewItem(ref externalList, ref ExternalMailAddressList);

            BatchCheckButtonSettingfromRegistrySettings();
            
            fullEmailAddressCount = InternalMailAddressList.Items.Count + ExternalMailAddressList.Items.Count;
            fullEmailAddressCheckedCount = 0;
        }

        private void ConfirmAddressDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            internalList.Clear();
            externalList.Clear();
            InternalMailAddressList.Items.Clear();
            ExternalMailAddressList.Items.Clear();
        }

        private void MailAddressList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked){
                fullEmailAddressCheckedCount++;
            } else if(e.NewValue == CheckState.Unchecked){
                fullEmailAddressCheckedCount--;
            }

            if (fullEmailAddressCount - fullEmailAddressCheckedCount == 0)
            {
                btn_DoSend.Enabled = true;
            }
            else
            {
                btn_DoSend.Enabled = false;
            }

        }

        private void MailAddressList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            const int ALL_CHECK_MAIL_ADDRESS = 0;
            if (e.Column == ALL_CHECK_MAIL_ADDRESS)
            {
                if(((ListView)sender).Name == "InternalMailAddressList" && bcInsiderMail)
                {
                    isInsiderMailAddressAllChecked = !isInsiderMailAddressAllChecked;
                    for (int i = 0; i < InternalMailAddressList.Items.Count; i++)
                    {
                        InternalMailAddressList.Items[i].Checked = isInsiderMailAddressAllChecked;
                    }
                }
                else if(((ListView)sender).Name == "ExternalMailAddressList" && bcOutsiderMail)
                {
                    isOutsiderMailAddressAllChecked = !isOutsiderMailAddressAllChecked;
                    for (int i = 0; i < ExternalMailAddressList.Items.Count; i++)
                    {
                        ExternalMailAddressList.Items[i].Checked = isOutsiderMailAddressAllChecked;
                    }
                }
                
            }
        }
    }
}
