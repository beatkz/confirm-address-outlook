using System.Windows.Forms;

namespace Confirm_Address_for_Outlook_2013
{
    public partial class ConfirmAddressDomainForm : Form
    {
        private string _input_domain = "";
        public string domain = "";

        public ConfirmAddressDomainForm()
        {
            InitializeComponent();
        }
        private void ConfirmAddressDomainForm_Load(object sender, System.EventArgs e)
        {
            txtMyDomain.Text = domain;
        }

        private void Accept_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            _input_domain = txtMyDomain.Text;
            this.Close();
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public string getInputDomain()
        {
            return _input_domain;
        }
    }
}
