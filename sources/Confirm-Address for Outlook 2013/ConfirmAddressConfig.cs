using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Deployment.Application;

namespace Confirm_Address_for_Outlook_2013
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class ConfirmAddressConfig : UserControl,
        Microsoft.Office.Interop.Outlook.PropertyPage
    {
        private Microsoft.Office.Interop.Outlook.PropertyPageSite _propertyPageSite;

        private List<string> domainList;
        private const string regPath = @"HKEY_CURRENT_USER\Software\Meatian\Confirm-Address for Outlook";

        public ConfirmAddressConfig()
        {
            InitializeComponent();
            LoadFromSettingDefault();
        }

        protected override void OnLoad(EventArgs e)
        {
            // プロパティ変更の通知先を得ます
            // => リフレクションを利用して .NET ライブラリ中の
            // System.Windows.Forms.UnsafeNativeMethods.IOleObject
            //クラスにある GetClientSite メソッドを呼び出します。
            Type type = typeof(System.Object);
            string assembly = type.Assembly.CodeBase.Replace("mscorlib.dll", "System.Windows.Forms.dll");
            assembly = assembly.Replace("file:///", "");

            string assemblyName = System.Reflection.AssemblyName.GetAssemblyName(assembly).FullName;
            Type unsafeNativeMethods = Type.GetType(
                System.Reflection.Assembly.CreateQualifiedName(
                    assemblyName, "System.Windows.Forms.UnsafeNativeMethods")
                    );

            Type oleObj = unsafeNativeMethods.GetNestedType("IOleObject");
            System.Reflection.MethodInfo methodInfo = oleObj.GetMethod("GetClientSite");
            _propertyPageSite = methodInfo.Invoke(this, null) as Microsoft.Office.Interop.Outlook.PropertyPageSite;
        }


        private void LoadFromSettingDefault()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                AppVersion.Text = "Version: " + ad.CurrentVersion.ToString();
            }

            RegUtil ru = new RegUtil();

            // 組織内ドメイン
            var indomains = ru.LoadRegString("InsiderDomains");

            domainList = (indomains != "") ? indomains.Split(',').ToList() : null;
            if (domainList == null)
            {
                domainList = new List<string>();
            }
            else
            {
                for (var i = 0; i < domainList.Count; i++)
                {
                    MyDomains.Items.Add(domainList[i]);
                }
            }

            // 自ドメイン宛てのみの場合に確認ダイアログなし
            var isNoDisplayInsiderDomainOnly = ru.LoadRegInt("NoDisplayInsiderDomainOnly");
            NoDisplayInsiderDomainOnly.Checked = Convert.ToBoolean(isNoDisplayInsiderDomainOnly);

            // カウントダウン
            var isCountDown = ru.LoadRegInt("CountDown");
            CountDown.Checked = Convert.ToBoolean(isCountDown);
            var countDownSec = ru.LoadRegInt("CountDownTime");
            CountDownTime.Enabled = CountDown.Checked;
            CountDownTime.Value = countDownSec;

            // 本文冒頭行表示
            var isConfirmMailBody = ru.LoadRegInt("ConfirmMailBody");
            ConfirmMailBody.Checked = Convert.ToBoolean(isConfirmMailBody);
            var confirmMailBodyRows = ru.LoadRegInt("ConfirmMailBodyLines");
            ConfirmMailBodyLines.Enabled = ConfirmMailBody.Checked;
            ConfirmMailBodyLines.Value = confirmMailBodyRows;


            // 自ドメイン・他ドメイン一括チェックボタン
            var isInsiderDomainBatchCheck = ru.LoadRegInt("InsiderDomainBatchCheck");
            InsiderDomainBatchCheck.Checked = Convert.ToBoolean(isInsiderDomainBatchCheck);

            var isOutsiderDomainBatchCheck = ru.LoadRegInt("OutsiderDomainBatchCheck");
            OutsiderDomainBatchCheck.Checked = Convert.ToBoolean(isOutsiderDomainBatchCheck);

        }

        public void GetPageInfo(ref string HelpFile, ref int HelpContext)
        {
            throw new NotImplementedException();
        }

        private void ReloadDomainList()
        {
            domainList.Clear();

            for (var i = 0; i < MyDomains.Items.Count; i++)
            {
                domainList.Add(MyDomains.Items[i].Text);
            }
        }

        public void Apply()
        {
            ReloadDomainList();

            Microsoft.Win32.Registry.SetValue(
                regPath, "InsiderDomains",
                string.Join(",", domainList));

            Microsoft.Win32.Registry.SetValue(
                regPath, "NoDisplayInsiderDomainOnly",
                NoDisplayInsiderDomainOnly.Checked,
                Microsoft.Win32.RegistryValueKind.DWord);

            Microsoft.Win32.Registry.SetValue(
                regPath, "CountDown",
                CountDown.Checked,
                Microsoft.Win32.RegistryValueKind.DWord);

            Microsoft.Win32.Registry.SetValue(
                regPath, "CountDownTime",
                CountDownTime.Value,
                Microsoft.Win32.RegistryValueKind.DWord);
            
            Microsoft.Win32.Registry.SetValue(
                regPath, "ConfirmMailBody",
                ConfirmMailBody.Checked,
                Microsoft.Win32.RegistryValueKind.DWord);

            Microsoft.Win32.Registry.SetValue(
                regPath, "ConfirmMailBodyLines",
                ConfirmMailBodyLines.Value,
                Microsoft.Win32.RegistryValueKind.DWord);

            Microsoft.Win32.Registry.SetValue(
                regPath, "InsiderDomainBatchCheck",
                InsiderDomainBatchCheck.Checked,
                Microsoft.Win32.RegistryValueKind.DWord);

            Microsoft.Win32.Registry.SetValue(
                regPath, "OutsiderDomainBatchCheck",
                OutsiderDomainBatchCheck.Checked,
                Microsoft.Win32.RegistryValueKind.DWord);
        }

        bool isUpdate = false;

        private bool CheckSettingsUpdate()
        {
            RegUtil ru = new RegUtil();
            var indomains = ru.LoadRegString("InsiderDomains");
            List<string> mdl = (indomains != "") ? indomains.Split(',').ToList() : null;
            if (MyDomains.Items == null || mdl == null || MyDomains.Items.Count != mdl.Count)
            {
                isUpdate = true;
            }
            else
            {
                for (var i = 0; i < MyDomains.Items.Count; i++)
                {
                    if (!MyDomains.Items[i].Text.Equals(mdl[i]))
                    {
                        isUpdate = true;
                        break;
                    }
                }
            }

            int[,] settings = {
                {ru.LoadRegInt("NoDisplayInsiderDomainOnly"),
                    Convert.ToInt32(NoDisplayInsiderDomainOnly.Checked)},
                {ru.LoadRegInt("CountDown"),
                    Convert.ToInt32(CountDown.Checked) },
                {ru.LoadRegInt("CountDownTime"),
                    Convert.ToInt32(CountDownTime.Value)},
                {ru.LoadRegInt("ConfirmMailBody"),
                    Convert.ToInt32(ConfirmMailBody.Checked) },
                {ru.LoadRegInt("ConfirmMailBodyLines"),
                    Convert.ToInt32(ConfirmMailBodyLines.Value)},
                {ru.LoadRegInt("InsiderDomainBatchCheck"),
                    Convert.ToInt32(InsiderDomainBatchCheck.Checked)},
                {ru.LoadRegInt("OutsiderDomainBatchCheck"),
                    Convert.ToInt32(OutsiderDomainBatchCheck.Checked)}
            };

            int iLen = settings.GetLength(0);

            for (int i = 0; i < iLen; i++)
            {
                if (settings[i, 0] != settings[i, 1])
                {
                    isUpdate = true;
                }
            }
            return isUpdate;
        }

        public bool Dirty
        {
            get
            {
                return CheckSettingsUpdate();
            }
        }

        private void CheckChangedEvent(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Name == "CountDown")
            {
                CountDownTime.Enabled = ((CheckBox)sender).Checked;
            }

            if (((CheckBox)sender).Name == "ConfirmMailBody")
            {
                ConfirmMailBodyLines.Enabled = ((CheckBox)sender).Checked;
            }

            if (CheckSettingsUpdate())
            {
                if (_propertyPageSite != null)
                {
                    _propertyPageSite.OnStatusChange();
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            /*string usdomainName = Interaction.InputBox(
                "ドメイン名を入力してください\n(例：confirmaddress.jp)",
                "ドメイン名の入力", "");*/
            ConfirmAddressDomainForm df = new ConfirmAddressDomainForm();
            if(df.ShowDialog() == DialogResult.OK)
            {
                string usdomainName = df.getInputDomain();
                MyDomainsPostProcess(usdomainName, -1);
            }
            df.Dispose();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ListView lv = MyDomains;
            ConfirmAddressDomainForm df = new ConfirmAddressDomainForm();
            df.domain = lv.FocusedItem.Text;
            if(df.ShowDialog() == DialogResult.OK)
            {
                string usdomainName = df.getInputDomain();
                MyDomainsPostProcess(usdomainName, lv.FocusedItem.Index);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            ListView lv = MyDomains;
            string ToBeRemovedDomain;
            ToBeRemovedDomain = lv.FocusedItem.Text;

            const string V = "このドメインを削除しますか？\n\n";
            DialogResult result = MessageBox.Show(
                V + ToBeRemovedDomain,
                "削除確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lv.FocusedItem.Remove();
                if (_propertyPageSite != null)
                {
                    _propertyPageSite.OnStatusChange();
                }
            }
        }

        private void MyDomainsPostProcess(string usdomainName, int index)
        {
            //余計なスペースを除去する
            string sdomainName = usdomainName.Replace(" ", "").Replace("　", "");

            if (sdomainName.Length > 0)
            {
                ListView lv = MyDomains;

                //重複確認
                foreach (ListViewItem lvi in lv.Items)
                {
                    if (lvi.Index != index && lvi.Text == sdomainName)
                    {
                        MessageBox.Show(
                            "同じドメインが既にあります",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }
                }

                if (index == -1)
                {
                    lv.Items.Add(sdomainName);
                }
                else
                {
                    lv.Items[index].Text = sdomainName;
                }

                if (_propertyPageSite != null)
                {
                    _propertyPageSite.OnStatusChange();
                }
            }
        }

        private void OriginalURLLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(OriginalURLLink.Text);
        }

        private void ValueChangedEvent(object sender, EventArgs e)
        {
            if (CheckSettingsUpdate())
            {
                if (_propertyPageSite != null)
                {
                    _propertyPageSite.OnStatusChange();
                }
            }

        }
    }
}
