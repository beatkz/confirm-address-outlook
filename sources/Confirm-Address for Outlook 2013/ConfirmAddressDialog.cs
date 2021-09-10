using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Confirm_Address_for_Outlook_2013
{
    public partial class ConfirmAddressDialog : Form
    {
        private List<String> internalList = new List<string> { };
        private List<String> externalList = new List<string> { };
        private List<String> attachList = new List<string> { };
        private string mailBody;

        private bool isInsiderMailAddressAllChecked = false;
        private bool isOutsiderMailAddressAllChecked = false;
        private bool isAttachmentFilesAllChecked = false;

        private bool bcInsiderMail;
        private bool bcOutsiderMail;
        private bool bcAttachment;
        private bool isMailBodyConfirm;

        private int limit;
        private bool countdown_running = false;


        public ConfirmAddressDialog()
        {
            InitializeComponent();
        }

        public DialogResult ShowConfirmAddressDialog(
            ref List<string> internalList, 
            ref List<string> externalList,
            ref List<string> attachList,
            ref string mailBody)
        {
            this.internalList = internalList;
            this.externalList = externalList;
            this.attachList = attachList;
            this.mailBody = mailBody;

            var result = ShowDialog();

            return result;
        }

        private void AddListViewItem(
            ref List<string> wantToAddList, 
            ref ListView willAddListView
            ) {
            for (int count = 0; count < wantToAddList.Count; count++)
            {
                ListViewItem item = new ListViewItem();
                item.Checked = false;
                item.SubItems.Add(wantToAddList[count]);
                willAddListView.Items.Add(item);
            }
        }

        private void SettingsfromRegistrySettings()
        {
            RegUtil ru = new RegUtil();
            bcInsiderMail = Convert.ToBoolean(ru.LoadRegInt("InsiderDomainBatchCheck"));
            InternalMailAddressList.Columns[0].Text = bcInsiderMail ? "✓" : "";
            bcOutsiderMail = Convert.ToBoolean(ru.LoadRegInt("OutsiderDomainBatchCheck"));
            ExternalMailAddressList.Columns[0].Text = bcOutsiderMail ? "✓" : "";
            bcAttachment = Convert.ToBoolean(ru.LoadRegInt("AttachmentBatchCheck"));
            AttachmentList.Columns[0].Text = bcAttachment ? "✓" : "";

            isMailBodyConfirm = Convert.ToBoolean(ru.LoadRegInt("ConfirmMailBody"));
            pnlMailBody.Visible = isMailBodyConfirm;
        }

        private void ConfirmAddressDialog_Load(object sender, EventArgs e)
        {
            SettingsfromRegistrySettings();
            AddListViewItem(ref internalList, ref InternalMailAddressList);
            AddListViewItem(ref externalList, ref ExternalMailAddressList);
            if(attachList.Count > 0)
            {
                AddListViewItem(ref attachList, ref AttachmentList);
                pnlAttach.Visible = true;
                AttachmentList.AutoResizeColumn(
                    1, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            if(internalList.Count > 0)
            {
                InternalMailAddressList.AutoResizeColumn(
                    1, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            if(externalList.Count > 0)
            {
                ExternalMailAddressList.AutoResizeColumn(
                    1, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            mailBodyBox.Text = isMailBodyConfirm ? mailBody : "";
        }

        private void ConfirmAddressDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            internalList.Clear();
            externalList.Clear();
            InternalMailAddressList.Items.Clear();
            ExternalMailAddressList.Items.Clear();
            mailBodyBox.Text = "";
        }

        private void MailAddressList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            CheckAllChecked();
        }

        private void ConfirmMailBody_CheckedChanged(object sender, EventArgs e)
        {
            CheckAllChecked();
        }

        private void CheckAllChecked()
        {
            var internalConfirmed = true;
            var externalConfirmed = true;
            var attachFileConfirmed = true;
            var mailHeadConfirmed = true;

            var id_checkboxes = InternalMailAddressList.Items;
            if (id_checkboxes.Count > 0)
            {
                for (var i = 0; i < id_checkboxes.Count; i++)
                {
                    if (!id_checkboxes[i].Checked)
                    {
                        internalConfirmed = false;
                    }
                }
            }

            var ed_checkboxes = ExternalMailAddressList.Items;
            if (ed_checkboxes.Count > 0)
            {
                for (var i = 0; i < ed_checkboxes.Count; i++)
                {
                    if (!ed_checkboxes[i].Checked)
                    {
                        externalConfirmed = false;
                    }
                }
            }

            var atf_checkboxes = AttachmentList.Items;
            if (atf_checkboxes.Count > 0)
            {
                for (var i = 0; i < atf_checkboxes.Count; i++)
                {
                    if (!atf_checkboxes[i].Checked)
                    {
                        attachFileConfirmed = false;
                    }
                }
            }

            if (isMailBodyConfirm)
            {
                mailHeadConfirmed = ConfirmMailBody.Checked;
            }

            btn_DoSend.Enabled = internalConfirmed && externalConfirmed && attachFileConfirmed && mailHeadConfirmed;
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
                else if (((ListView)sender).Name == "AttachmentList" && bcAttachment)
                {
                    isAttachmentFilesAllChecked = !isAttachmentFilesAllChecked;
                    for (int i = 0; i < AttachmentList.Items.Count; i++)
                    {
                        AttachmentList.Items[i].Checked = isAttachmentFilesAllChecked;
                    }
                }
            }
        }

        private void btn_DoSend_Click(object sender, EventArgs e)
        {
            RegUtil ru = new RegUtil();
            var isCountDownRaw = ru.LoadRegInt("CountDown");
            bool isCountDown = Convert.ToBoolean(isCountDownRaw);

            if (isCountDown && !countdown_running)
            {
                var countDownTime = ru.LoadRegInt("CountDownTime");
                limit = countDownTime;
                counterLabel.Text = limit.ToString();

                CountdownPanel.Visible = true;
                Timer timer = new Timer();
                timer.Tick += new EventHandler(Countdown);
                timer.Interval = 1000;
                timer.Start();
                countdown_running = true;
            } else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void Countdown(object sender, EventArgs e)
        {
            limit--;
            if (limit < 0)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                counterLabel.Text = limit.ToString();
            }
        }
    }
}
