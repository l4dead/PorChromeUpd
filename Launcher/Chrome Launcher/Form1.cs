﻿using System;
using System.Windows.Forms;
using System.Globalization;

namespace Chrome_Launcher
{
    public partial class Form1 : Form 
    {
        private readonly string applicationPath = Application.StartupPath;
        public Form1()
        {
            CultureInfo culture = CultureInfo.CurrentUICulture;
            InitializeComponent();
            switch (culture.TwoLetterISOLanguageName)
            {
                case "de":
                    radioButton3.Text = "Das Standard Profil von Google Chrome verwenden";
                    radioButton2.Text = "Für jede Version ein eigenes Profil verwenden";
                    radioButton1.Text = "Ein Profil für alle Versionen verwenden";
                    break;
                case "ru":
                    radioButton3.Text = "Использовать стандартное месторасположение профиля (readme)";
                    radioButton2.Text = "Использовать разные папки для профилей разных версий";
                    radioButton1.Text = "Использовать один профиль для всех версий";
                    break;
                default:
                    radioButton3.Text = "Use the standard profile of Google Chrome";
                    radioButton2.Text = "Use a separate profile for each version";
                    radioButton1.Text = "Use one profile for all versions";
                    break;
            }
        }
        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (radioButton1.Checked)
            {
                System.IO.File.WriteAllText(applicationPath + "\\Chrome\\Profile.txt", "--user-data-dir=\"profile\"");
                this.Close();
            }
            if (radioButton2.Checked)
            {
                System.IO.File.WriteAllText(applicationPath + "\\Chrome\\Profile.txt", "--user-data-dir=\"Chrome\\profile\"");
                this.Close();
            }
            if (radioButton3.Checked)
            {
                System.IO.File.WriteAllText(applicationPath + "\\Chrome\\Profile.txt", "");
                this.Close();
            }
        }
    }
}
