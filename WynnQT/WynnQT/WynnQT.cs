using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace WynnQT
{
    public partial class WynnQT : Form
    {
        public WynnQT()
        {
            InitializeComponent();
            textBox1.RightToLeft = RightToLeft.Yes;
            string[] langs = File.ReadAllLines("quests/info/langs.txt"); languageSelect.Items.AddRange(langs);
            string[] quests = File.ReadAllLines("quests/info/quests.txt"); questSelect.Items.AddRange(quests);
            languageSelect.SelectedIndex = 0;
            questSelect.SelectedIndex = 0;
            fontSize.SelectedIndex = 3;
            fontColor.SelectedIndex = 2;
            backColor.SelectedIndex = 0;
            textBox1.RightToLeft = RightToLeft.No;
        }
        #region readFiles
        public void readFiles()
        {
            string[] langs = File.ReadAllLines("quests/info/langs.txt");
            string[] quests = File.ReadAllLines("quests/info/quests.txt");
            try
            {
                string translation = File.ReadAllText("quests/" + quests[questSelect.SelectedIndex] + "/" + langs[languageSelect.SelectedIndex] + ".txt");
                if (translation != "") { trans.Text = translation; } else { trans.Text = "No translation for this quest/language combination yet!"; }
                if (langs[languageSelect.SelectedIndex] == "Hebrew") { trans.RightToLeft = RightToLeft.Yes; }
                else { trans.RightToLeft = RightToLeft.No; }
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory("quests/" + quests[questSelect.SelectedIndex]);
                File.WriteAllText("quests/" + quests[questSelect.SelectedIndex] + "/" + langs[languageSelect.SelectedIndex] + ".txt", "", System.Text.Encoding.UTF8);
                readFiles();
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText("quests/" + quests[questSelect.SelectedIndex] + "/" + langs[languageSelect.SelectedIndex] + ".txt", "", System.Text.Encoding.UTF8);
                readFiles();
            }
        }
        #endregion
        #region comboBoxChanged
        private void questSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            readFiles();
        }
        private void languageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.RightToLeft == RightToLeft.Yes) { }
            else { readFiles(); }
        }
        #endregion
        #region fontChange
        public void fontStyleChange()
        {
            string fcolor = Color.White.ToString();
            string bcolor = Color.Black.ToString();
                int size = 11;
                switch (fontSize.SelectedIndex)
                {
                    case 0: size = 8; break;
                    case 1: size = 9; break;
                    case 2: size = 10; break;
                    case 3: size = 11; break;
                    case 4: size = 12; break;
                    case 5: size = 14; break;
                    case 6: size = 16; break;
                    case 7: size = 18; break;
                    
                }
                switch (fontColor.SelectedIndex)
                {
                    case 0: trans.ForeColor = Color.Black; break;
                    case 1: trans.ForeColor = Color.Gray; break;
                    case 2: trans.ForeColor = Color.White; break;
                    case 3: trans.ForeColor = Color.Red; break;
                    case 4: trans.ForeColor = Color.Orange; break;
                    case 5: trans.ForeColor = Color.Yellow; break;
                    case 6: trans.ForeColor = Color.Green; break;
                    case 7: trans.ForeColor = Color.Aqua; break;
                    case 8: trans.ForeColor = Color.Blue; break;
                    case 9: trans.ForeColor = Color.Indigo; break;
                    case 10: trans.ForeColor = Color.Violet; break;
                    case 11: trans.ForeColor = Color.Pink; break;
                }
                switch (backColor.SelectedIndex)
                {
                    case 0: trans.BackColor = Color.Black; break;
                    case 1: trans.BackColor = Color.Gray; break;
                    case 2: trans.BackColor = Color.White; break;
                    case 3: trans.BackColor = Color.Red; break;
                    case 4: trans.BackColor = Color.Orange; break;
                    case 5: trans.BackColor = Color.Yellow; break;
                    case 6: trans.BackColor = Color.Green; break;
                    case 7: trans.BackColor = Color.Aqua; break;
                    case 8: trans.BackColor = Color.Blue; break;
                    case 9: trans.BackColor = Color.Indigo; break;
                    case 10: trans.BackColor = Color.Violet; break;
                    case 11: trans.BackColor = Color.Pink; break;
                }
                trans.Font = new Font("Cambria", size, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                trans.Update();
            readFiles();
        }
        private void fontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontStyleChange();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontStyleChange();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontStyleChange();
        }
        #endregion
    }
}
