using System;
using System.Windows.Forms;

namespace Confirm_Address_for_Outlook_2013
{
    public partial class CountDown : Form
    {
        private int limit;

        public CountDown()
        {
            InitializeComponent();
        }

        public DialogResult ShowCountDown(int countDownTime)
        {
            var time = countDownTime;
            limit = time;

            counterLabel.Text = limit.ToString();

            var result = ShowDialog();

            return result;
        }

        private void CountDown_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler(Countdown);
            timer.Interval = 1000;
            timer.Start();
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

        private void CountDownMsg2_Click(object sender, EventArgs e)
        {

        }
    }
}
