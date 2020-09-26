using Captcha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EZCaptchaSample
{
    public partial class MainForm : Form
    {

        private string GeneratedCaptcha;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CaptchaGenerator()
        {
            Random rnd = new Random();
            string number = rnd.Next(10000, 99999).ToString();
            EZCaptcha Captcha = new EZCaptcha(number, 100, 39);
            pbxCaptcha.Image = Captcha.Image;
            GeneratedCaptcha = Captcha.Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CaptchaGenerator();
        }

        private void pbxCaptcha_Click(object sender, EventArgs e)
        {
            CaptchaGenerator();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == GeneratedCaptcha)
                MessageBox.Show("Correct answer :)", "EzCaptcha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Incorrect answer :(", "EzCaptcha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
