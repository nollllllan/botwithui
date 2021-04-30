using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Linq;
using System.Xml;

namespace botwithui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                var savedToken = Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\blek", "TOKEN", "token").ToString();
            }
            catch
            {
                Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\blek", "TOKEN", "");
                savedToken = "token";
            }

            if (savedToken == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\blek", "TOKEN", "");
                savedToken = "token";
            }

            textBox1.Text = savedToken;
            ChangeLanguage();
        }

        private static readonly string[] LanguageArray = { "English", "Russian" };
        private static int CurrentLanguageIndex { get; set; } = Array.IndexOf(LanguageArray, ConfigurationManager.AppSettings["Language"]);

        private void ChangeLanguage()
        {
            var xDoc = new XmlDocument();
            xDoc.Load($"Language/{LanguageArray[CurrentLanguageIndex]}.xml");
            var xmlNodes = xDoc.DocumentElement?.ChildNodes.Cast<XmlNode>().ToList();

            foreach (Control control in Controls)
            {
                if (control.HasChildren)
                    ChangeChildControlLanguage(control, xmlNodes);

                control.Text = xmlNodes?.FirstOrDefault(x => x.Name == control.Name)?.InnerText ?? control.Text;
            }

            Text = xmlNodes?.FirstOrDefault(x => x.Name == "FormText")?.InnerText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            settings["Language"].Value = LanguageArray[LanguageArray.Length == CurrentLanguageIndex + 1 ? CurrentLanguageIndex = 0 : ++CurrentLanguageIndex];
            configFile.Save();
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            ChangeLanguage();
        }

        private static void ChangeChildControlLanguage(Control parentControl, List<XmlNode> nodes)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control.HasChildren)
                    ChangeChildControlLanguage(control, nodes);

                control.Text = nodes?.FirstOrDefault(x => x.Name == control.Name)?.InnerText ?? control.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\blek", "TOKEN", this.textBox1.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form aboutWindow = new Form2();
            aboutWindow.Show();
        }
    }
}
