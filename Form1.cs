using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botwithui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public int lang;
        private void button4_Click(object sender, EventArgs e)
        {
            if (lang == 0)  // if current language is english
            {
                this.label1.Text = "Настройки бота";
                this.label2.Text = "Вставьте ваш токен: ";
                this.groupBox1.Text = "Конфиг";
                this.groupBox2.Text = "Консоль бота";
                this.button1.Text = "Start!";
                this.button2.Text = "Сохранить лог консоли...";
                this.checkBox2.Text = "Отдельное окно консоли";
                this.Text = "Настройки бота";
                lang = 1;
            } else if (lang == 1)
            { //  if current language is russian
                this.label1.Text = "Bot settings";
                this.label2.Text = "Insert your token: ";
                this.groupBox1.Text = "Config";
                this.groupBox2.Text = "Bot console";
                this.button1.Text = "Start!";
                this.button2.Text = "Save output as file...";
                this.checkBox2.Text = "Cmd output window";
                this.Text = "Bot control panel";
                lang = 0;
            } else
            {
                this.label1.Text = "Bot settings";
                this.label2.Text = "Insert your token: ";
                this.groupBox1.Text = "Config";
                this.groupBox2.Text = "Bot console";
                this.button1.Text = "Start!";
                this.button2.Text = "Save output as file...";
                this.checkBox2.Text = "Cmd output window";
                this.Text = "Bot control panel";
                lang = 0;
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
