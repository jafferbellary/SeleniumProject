﻿using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIAutomation.Utilities
{
    class TestStartup
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void getUserPwdAndEnv()
        {
            var env = ConfigurationManager.AppSettings["envs"];
            String[] envitems = env.Split(':');

            Form form = new Form();
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();

            TextBox ssoUserName_textBox = new TextBox();
            TextBox ssoPassword_textBox = new TextBox();
            ComboBox env_comboBox = new ComboBox();
            Button buttonOk = new Button();

            form.Text = "Please provide the following information to start the test ";
            label1.Text = "Select the Env :";
            label2.Text = "Enter your login SSO Username :";
            label3.Text = "Enter your login SSO Password :";

            env_comboBox.Name = "Env listbox";
            env_comboBox.BackColor = System.Drawing.Color.LightBlue;
            env_comboBox.ForeColor = System.Drawing.Color.DarkBlue;
            env_comboBox.Size = new System.Drawing.Size(100, 25);

            foreach (String i in envitems)
            {
                env_comboBox.Items.Add(i);
            }

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.BackColor = System.Drawing.Color.LightSalmon;

            label1.SetBounds(9, 20, 372, 15);
            label2.SetBounds(9, 100, 372, 15);
            label3.SetBounds(9, 150, 372, 15);

            ssoUserName_textBox.SetBounds(12, 115, 250, 20);
            ssoPassword_textBox.SetBounds(12, 165, 250, 20);

            env_comboBox.SetBounds(12, 36, 150, 25);

            ssoPassword_textBox.PasswordChar = '*';
            buttonOk.SetBounds(140, 200, 75, 23);

            form.ClientSize = new System.Drawing.Size(400, 250);
            form.Controls.AddRange(new Control[] { label1, label2, label3, ssoUserName_textBox, ssoPassword_textBox,
                buttonOk, label3, env_comboBox });

            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();

            Globalclass.ssoUserName = ssoUserName_textBox.Text;
            Globalclass.ssoPassword = ssoPassword_textBox.Text;
            Globalclass.envToTest = env_comboBox.Text;
            form.Dispose();

            log.Info("User credentials are received.");
        }
    }
}
