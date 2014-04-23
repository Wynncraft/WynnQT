namespace WynnQT
{
    partial class WynnQT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WynnQT));
            this.quest = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.Label();
            this.questSelect = new System.Windows.Forms.ComboBox();
            this.languageSelect = new System.Windows.Forms.ComboBox();
            this.trans = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quest
            // 
            this.quest.AutoSize = true;
            this.quest.Font = new System.Drawing.Font("Minecraft", 18.75F, System.Drawing.FontStyle.Bold);
            this.quest.ForeColor = System.Drawing.Color.White;
            this.quest.Location = new System.Drawing.Point(12, 9);
            this.quest.Name = "quest";
            this.quest.Size = new System.Drawing.Size(106, 25);
            this.quest.TabIndex = 0;
            this.quest.Text = "Quest";
            // 
            // language
            // 
            this.language.AutoSize = true;
            this.language.Font = new System.Drawing.Font("Minecraft", 18.75F, System.Drawing.FontStyle.Bold);
            this.language.ForeColor = System.Drawing.Color.White;
            this.language.Location = new System.Drawing.Point(320, 9);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(172, 25);
            this.language.TabIndex = 1;
            this.language.Text = "Language";
            // 
            // questSelect
            // 
            this.questSelect.DropDownHeight = 136;
            this.questSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questSelect.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic);
            this.questSelect.FormattingEnabled = true;
            this.questSelect.IntegralHeight = false;
            this.questSelect.Items.AddRange(new object[] {
            "#1 King\'s Recruit",
            "#2 Enzan\'s Brother",
            "#3 Prison Story",
            "#4 Cook Assistant",
            "#5 Spider Cave",
            "#6 Underwater",
            "#7 Mushroom Man",
            "#8 Creeper Inflitration",
            "#9 Potion Making",
            "#10 A Confused Farmer",
            "#11 Maltic\'s Well",
            "#12 Grave Digger",
            "#13 The Tower of Amnesia",
            "#14 Cluck Cluck",
            "#15 Mansion Delivery",
            "#16 The Angry Village",
            "#17 Sister City",
            "#18 Lost Tower",
            "#19 Drought Sand",
            "#20 Stable Story",
            "#21 Wrath of the Mummy",
            "#22 Ice Nations",
            "#23 Underice",
            "#24 Bob\'s Lost Soul",
            "#25 House of Twain",
            "#26 Jungle Fever ",
            "#27 Zhight Island",
            "#28 The Passage",
            "#29 Beneath the Depths",
            "#30 Temple of Legends",
            "#31 Reincarnation"});
            this.questSelect.Location = new System.Drawing.Point(17, 49);
            this.questSelect.MaxDropDownItems = 14;
            this.questSelect.Name = "questSelect";
            this.questSelect.Size = new System.Drawing.Size(276, 27);
            this.questSelect.TabIndex = 2;
            this.questSelect.SelectedIndexChanged += new System.EventHandler(this.questSelect_SelectedIndexChanged);
            // 
            // languageSelect
            // 
            this.languageSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageSelect.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageSelect.FormattingEnabled = true;
            this.languageSelect.Items.AddRange(new object[] {
            "English",
            "German/Deutsch",
            "Spanish/Español",
            "Portugese/Português",
            "Latvian/Latvija",
            "Swedish/Svensk",
            "Mandarin/中文",
            "French/Français",
            "Dutch/Nederlands",
            "Korean/한국의",
            "Greek/ελληνικά",
            "Norwegian/Norsk",
            "Czech/čeština"});
            this.languageSelect.Location = new System.Drawing.Point(325, 49);
            this.languageSelect.Name = "languageSelect";
            this.languageSelect.Size = new System.Drawing.Size(184, 27);
            this.languageSelect.TabIndex = 3;
            this.languageSelect.SelectedIndexChanged += new System.EventHandler(this.languageSelect_SelectedIndexChanged);
            // 
            // trans
            // 
            this.trans.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trans.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trans.ForeColor = System.Drawing.Color.Silver;
            this.trans.Location = new System.Drawing.Point(12, 102);
            this.trans.Multiline = true;
            this.trans.Name = "trans";
            this.trans.ReadOnly = true;
            this.trans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.trans.Size = new System.Drawing.Size(761, 225);
            this.trans.TabIndex = 4;
            this.trans.Text = "Translation";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 8F);
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(515, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(258, 64);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // WynnQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(785, 339);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trans);
            this.Controls.Add(this.languageSelect);
            this.Controls.Add(this.questSelect);
            this.Controls.Add(this.language);
            this.Controls.Add(this.quest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WynnQT";
            this.Text = "WynnQT v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quest;
        private System.Windows.Forms.Label language;
        private System.Windows.Forms.ComboBox questSelect;
        private System.Windows.Forms.ComboBox languageSelect;
        private System.Windows.Forms.TextBox trans;
        private System.Windows.Forms.TextBox textBox1;
    }
}

