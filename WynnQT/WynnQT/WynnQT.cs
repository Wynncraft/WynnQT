using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WynnQT
{
    public partial class WynnQT : Form
    {
        public WynnQT()
        {
            InitializeComponent();
            questSelect.SelectedIndex = 0;
            languageSelect.SelectedIndex = 0;
            fontSize.SelectedIndex = 3;
            fontColor.SelectedIndex = 2;
            backColor.SelectedIndex = 0;
        }
        #region readFiles
        public void readFiles()
        {
            try
            {
                int q = questSelect.SelectedIndex + 1;
                string lang;
                switch (languageSelect.SelectedIndex)
                {
                    case 0:
                        lang = "English";
                        break;
                    case 1:
                        lang = "German";
                        break;
                    case 2:
                        lang = "Spanish";
                        break;
                    case 3:
                        lang = "Portugese";
                        break;
                    case 4:
                        lang = "Latvian";
                        break;
                    case 5:
                        lang = "Swedish";
                        break;
                    case 6:
                        lang = "Chinese";
                        break;
                    case 7:
                        lang = "French";
                        break;
                    case 8:
                        lang = "Dutch";
                        break;
                    case 9:
                        lang = "Korean";
                        break;
                    case 10:
                        lang = "Greek";
                        break;
                    case 11:
                        lang = "Norwegian";
                        break;
                    case 12:
                        lang = "Czech";
                        break;
                    default:
                        lang = "English";
                        break;
                }
                string translation = File.ReadAllText("quests/" + q.ToString() + "/" + lang + ".txt");
                if (translation != "") { trans.Text = translation; } else { trans.Text = "No translation for this quest/language combination yet!"; }
            }
            catch (DirectoryNotFoundException)
            {
                trans.Text = "Translation file missing or corrupt!";
            }
            catch (FileNotFoundException)
            {
                trans.Text = "Translation file missing or corrupt!";
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
            readFiles();
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
                trans.Font = new System.Drawing.Font("Cambria", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
