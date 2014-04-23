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
    }
}
