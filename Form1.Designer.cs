
using Microsoft.Win32;
using System;

namespace botwithui
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.BotSettingsLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.CmdOutputCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BotConsoleGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveLogButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InsertYourTokenLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ConfigGroupBox.SuspendLayout();
            this.BotConsoleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotSettingsLabel
            // 
            this.BotSettingsLabel.AutoSize = true;
            this.BotSettingsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotSettingsLabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BotSettingsLabel.Location = new System.Drawing.Point(217, 35);
            this.BotSettingsLabel.Name = "BotSettingsLabel";
            this.BotSettingsLabel.Size = new System.Drawing.Size(260, 47);
            this.BotSettingsLabel.TabIndex = 0;
            this.BotSettingsLabel.Text = "Bot control panel";
            this.BotSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(398, 152);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(74, 32);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // ConfigGroupBox
            // 
            this.ConfigGroupBox.Controls.Add(this.CmdOutputCheckBox);
            this.ConfigGroupBox.Controls.Add(this.checkBox1);
            this.ConfigGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigGroupBox.Location = new System.Drawing.Point(220, 202);
            this.ConfigGroupBox.Name = "ConfigGroupBox";
            this.ConfigGroupBox.Size = new System.Drawing.Size(242, 103);
            this.ConfigGroupBox.TabIndex = 3;
            this.ConfigGroupBox.TabStop = false;
            this.ConfigGroupBox.Text = "Bot config";
            // 
            // CmdOutputCheckBox
            // 
            this.CmdOutputCheckBox.AutoSize = true;
            this.CmdOutputCheckBox.Location = new System.Drawing.Point(7, 44);
            this.CmdOutputCheckBox.Name = "CmdOutputCheckBox";
            this.CmdOutputCheckBox.Size = new System.Drawing.Size(119, 17);
            this.CmdOutputCheckBox.TabIndex = 1;
            this.CmdOutputCheckBox.Text = "Cmd output window";
            this.CmdOutputCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "!ping";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BotConsoleGroupBox
            // 
            this.BotConsoleGroupBox.Controls.Add(this.SaveLogButton);
            this.BotConsoleGroupBox.Controls.Add(this.textBox2);
            this.BotConsoleGroupBox.Controls.Add(this.pictureBox1);
            this.BotConsoleGroupBox.Location = new System.Drawing.Point(220, 311);
            this.BotConsoleGroupBox.Name = "BotConsoleGroupBox";
            this.BotConsoleGroupBox.Size = new System.Drawing.Size(252, 184);
            this.BotConsoleGroupBox.TabIndex = 4;
            this.BotConsoleGroupBox.TabStop = false;
            this.BotConsoleGroupBox.Text = "Bot console";
            // 
            // SaveLogButton
            // 
            this.SaveLogButton.Location = new System.Drawing.Point(6, 143);
            this.SaveLogButton.Name = "SaveLogButton";
            this.SaveLogButton.Size = new System.Drawing.Size(165, 25);
            this.SaveLogButton.TabIndex = 6;
            this.SaveLogButton.Text = "Save console output as file...";
            this.SaveLogButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(235, 109);
            this.textBox2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::botwithui.Properties.Resources.senko_loaf;
            this.pictureBox1.Location = new System.Drawing.Point(177, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InsertYourTokenLabel
            // 
            this.InsertYourTokenLabel.AutoSize = true;
            this.InsertYourTokenLabel.Location = new System.Drawing.Point(224, 148);
            this.InsertYourTokenLabel.Name = "InsertYourTokenLabel";
            this.InsertYourTokenLabel.Size = new System.Drawing.Size(131, 13);
            this.InsertYourTokenLabel.TabIndex = 7;
            this.InsertYourTokenLabel.Text = "Insert your bot token here:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(373, 148);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(19, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(?)";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::botwithui.Properties.Resources.settings;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(407, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::botwithui.Properties.Resources.lang;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(443, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(187)))));
            this.BackgroundImage = global::botwithui.Properties.Resources._58d24e9faa15315af5831fd1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 507);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.InsertYourTokenLabel);
            this.Controls.Add(this.BotConsoleGroupBox);
            this.Controls.Add(this.ConfigGroupBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BotSettingsLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.Text = "Bot control panel";
            this.ConfigGroupBox.ResumeLayout(false);
            this.ConfigGroupBox.PerformLayout();
            this.BotConsoleGroupBox.ResumeLayout(false);
            this.BotConsoleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BotSettingsLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox ConfigGroupBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox BotConsoleGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SaveLogButton;
        private System.Windows.Forms.Label InsertYourTokenLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox CmdOutputCheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private string savedToken;
    }
}

