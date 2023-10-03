using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class mainForm : Form
    {
        private Label preSelectLabel;
        private ComboBox preSelectComboBox;
        private Label lengthLabel;
        private NumericUpDown lengthNum;
        private GroupBox optionsGroup;
        private CheckBox specialCharsCheckBox;
        private CheckBox numbersCheckBox;
        private CheckBox uppercaseCheckBox;
        private CheckBox lowercaseCheckBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button generateButton;
        private LinkLabel aboutLink;
        private Button copyButton;
        private TableLayoutPanel mainTabLayout;

        public mainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainTabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.preSelectComboBox = new System.Windows.Forms.ComboBox();
            this.preSelectLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthNum = new System.Windows.Forms.NumericUpDown();
            this.optionsGroup = new System.Windows.Forms.GroupBox();
            this.specialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.uppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.lowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.mainTabLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNum)).BeginInit();
            this.optionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabLayout
            // 
            this.mainTabLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainTabLayout.AutoSize = true;
            this.mainTabLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTabLayout.ColumnCount = 2;
            this.mainTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTabLayout.Controls.Add(this.preSelectComboBox, 1, 0);
            this.mainTabLayout.Controls.Add(this.preSelectLabel, 0, 0);
            this.mainTabLayout.Controls.Add(this.lengthLabel, 0, 1);
            this.mainTabLayout.Controls.Add(this.lengthNum, 1, 1);
            this.mainTabLayout.Controls.Add(this.optionsGroup, 0, 2);
            this.mainTabLayout.Controls.Add(this.passwordLabel, 0, 3);
            this.mainTabLayout.Controls.Add(this.generateButton, 0, 4);
            this.mainTabLayout.Controls.Add(this.passwordTextBox, 1, 3);
            this.mainTabLayout.Controls.Add(this.copyButton, 1, 4);
            this.mainTabLayout.Location = new System.Drawing.Point(12, 12);
            this.mainTabLayout.Name = "mainTabLayout";
            this.mainTabLayout.RowCount = 5;
            this.mainTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTabLayout.Size = new System.Drawing.Size(270, 176);
            this.mainTabLayout.TabIndex = 0;
            // 
            // preSelectComboBox
            // 
            this.preSelectComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preSelectComboBox.FormattingEnabled = true;
            this.preSelectComboBox.Items.AddRange(new object[] {
            "",
            "PIN Code",
            "Bank Code",
            "WPA Key"});
            this.preSelectComboBox.Location = new System.Drawing.Point(113, 3);
            this.preSelectComboBox.Name = "preSelectComboBox";
            this.preSelectComboBox.Size = new System.Drawing.Size(150, 21);
            this.preSelectComboBox.TabIndex = 1;
            this.preSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.preSelectComboBox_SelectedIndexChanged);
            // 
            // preSelectLabel
            // 
            this.preSelectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preSelectLabel.AutoSize = true;
            this.preSelectLabel.Location = new System.Drawing.Point(15, 7);
            this.preSelectLabel.Name = "preSelectLabel";
            this.preSelectLabel.Size = new System.Drawing.Size(76, 13);
            this.preSelectLabel.TabIndex = 0;
            this.preSelectLabel.Text = "Pre-Selection :";
            // 
            // lengthLabel
            // 
            this.lengthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(7, 33);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(91, 13);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Password length :";
            // 
            // lengthNum
            // 
            this.lengthNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lengthNum.Location = new System.Drawing.Point(113, 30);
            this.lengthNum.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.lengthNum.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.lengthNum.Name = "lengthNum";
            this.lengthNum.Size = new System.Drawing.Size(150, 20);
            this.lengthNum.TabIndex = 3;
            this.lengthNum.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // optionsGroup
            // 
            this.optionsGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainTabLayout.SetColumnSpan(this.optionsGroup, 2);
            this.optionsGroup.Controls.Add(this.specialCharsCheckBox);
            this.optionsGroup.Controls.Add(this.numbersCheckBox);
            this.optionsGroup.Controls.Add(this.uppercaseCheckBox);
            this.optionsGroup.Controls.Add(this.lowercaseCheckBox);
            this.optionsGroup.Location = new System.Drawing.Point(35, 56);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Size = new System.Drawing.Size(200, 60);
            this.optionsGroup.TabIndex = 4;
            this.optionsGroup.TabStop = false;
            this.optionsGroup.Text = "Options";
            // 
            // specialCharsCheckBox
            // 
            this.specialCharsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.specialCharsCheckBox.AutoSize = true;
            this.specialCharsCheckBox.Location = new System.Drawing.Point(114, 37);
            this.specialCharsCheckBox.Name = "specialCharsCheckBox";
            this.specialCharsCheckBox.Size = new System.Drawing.Size(90, 17);
            this.specialCharsCheckBox.TabIndex = 3;
            this.specialCharsCheckBox.Text = "Special chars";
            this.specialCharsCheckBox.UseVisualStyleBackColor = true;
            this.specialCharsCheckBox.CheckedChanged += new System.EventHandler(this.specialCharsCheckBox_CheckedChanged);
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.Checked = true;
            this.numbersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbersCheckBox.Location = new System.Drawing.Point(6, 37);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(68, 17);
            this.numbersCheckBox.TabIndex = 2;
            this.numbersCheckBox.Text = "Numbers";
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            this.numbersCheckBox.CheckedChanged += new System.EventHandler(this.numbersCheckBox_CheckedChanged);
            // 
            // uppercaseCheckBox
            // 
            this.uppercaseCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uppercaseCheckBox.AutoSize = true;
            this.uppercaseCheckBox.Checked = true;
            this.uppercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uppercaseCheckBox.Location = new System.Drawing.Point(114, 19);
            this.uppercaseCheckBox.Name = "uppercaseCheckBox";
            this.uppercaseCheckBox.Size = new System.Drawing.Size(78, 17);
            this.uppercaseCheckBox.TabIndex = 1;
            this.uppercaseCheckBox.Text = "Uppercase";
            this.uppercaseCheckBox.UseVisualStyleBackColor = true;
            this.uppercaseCheckBox.CheckedChanged += new System.EventHandler(this.uppercaseCheckBox_CheckedChanged);
            // 
            // lowercaseCheckBox
            // 
            this.lowercaseCheckBox.AutoSize = true;
            this.lowercaseCheckBox.Checked = true;
            this.lowercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowercaseCheckBox.Location = new System.Drawing.Point(6, 19);
            this.lowercaseCheckBox.Name = "lowercaseCheckBox";
            this.lowercaseCheckBox.Size = new System.Drawing.Size(78, 17);
            this.lowercaseCheckBox.TabIndex = 0;
            this.lowercaseCheckBox.Text = "Lowercase";
            this.lowercaseCheckBox.UseVisualStyleBackColor = true;
            this.lowercaseCheckBox.CheckedChanged += new System.EventHandler(this.lowercaseCheckBox_CheckedChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(23, 125);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password :";
            // 
            // generateButton
            // 
            this.generateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateButton.Location = new System.Drawing.Point(3, 148);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 25);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(109, 122);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(158, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // copyButton
            // 
            this.copyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyButton.Enabled = false;
            this.copyButton.Location = new System.Drawing.Point(113, 148);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(150, 25);
            this.copyButton.TabIndex = 8;
            this.copyButton.Text = "Copy to Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // aboutLink
            // 
            this.aboutLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutLink.AutoSize = true;
            this.aboutLink.Location = new System.Drawing.Point(241, 239);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(44, 13);
            this.aboutLink.TabIndex = 1;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "About...";
            this.aboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLink_LinkClicked);
            // 
            // mainForm
            // 
            this.AccessibleDescription = "Main Window";
            this.ClientSize = new System.Drawing.Size(294, 261);
            this.Controls.Add(this.aboutLink);
            this.Controls.Add(this.mainTabLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Password Generator";
            this.mainTabLayout.ResumeLayout(false);
            this.mainTabLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNum)).EndInit();
            this.optionsGroup.ResumeLayout(false);
            this.optionsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Events
        private void preSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (preSelectComboBox.SelectedItem.ToString())
            {
                case "PIN Code":
                {
                    lengthNum.Value = 4;
                    lowercaseCheckBox.Checked = false;
                    uppercaseCheckBox.Checked = false;
                    numbersCheckBox.Checked = true;
                    specialCharsCheckBox.Checked = false;
                    break;
                }
                case "Bank Code":
                {
                    lengthNum.Value = 6;
                    lowercaseCheckBox.Checked = false;
                    uppercaseCheckBox.Checked = false;
                    numbersCheckBox.Checked = true;
                    specialCharsCheckBox.Checked = false;
                    break;
                }
                case "WPA Key":
                {
                    lengthNum.Value = 32;
                    lowercaseCheckBox.Checked = true;
                    uppercaseCheckBox.Checked = true;
                    numbersCheckBox.Checked = true;
                    specialCharsCheckBox.Checked = true;
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
        private void lowercaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lowercaseCheckBox.Checked)
            {
                generateButton.Enabled = true;
            }
            else
            {
                if (GetNbCheckedBoxes() == 0)
                    generateButton.Enabled = false;
            }
        }

        private void uppercaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uppercaseCheckBox.Checked)
            {
                generateButton.Enabled = true;
            }
            else
            {
                if (GetNbCheckedBoxes() == 0)
                    generateButton.Enabled = false;
            }
        }

        private void numbersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (numbersCheckBox.Checked)
            {
                generateButton.Enabled = true;
            }
            else
            {
                if (GetNbCheckedBoxes() == 0)
                    generateButton.Enabled = false;
            }
        }

        private void specialCharsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (specialCharsCheckBox.Checked)
            {
                generateButton.Enabled = true;
            }
            else
            {
                if (GetNbCheckedBoxes() == 0)
                    generateButton.Enabled = false;
            }
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            string generatedPassword = "";
            List<char> possibleChars = new List<char>();

            if (lowercaseCheckBox.Checked)
                possibleChars.AddRange(lowercaseChars);

            if (uppercaseCheckBox.Checked)
                possibleChars.AddRange(uppercaseChars);

            if (numbersCheckBox.Checked)
                possibleChars.AddRange(numberChars);

            if (specialCharsCheckBox.Checked)
                possibleChars.AddRange(specialChars);

            var random = new Random();

            for (int i = 0; i < lengthNum.Value; i++)
                generatedPassword += possibleChars[random.Next(possibleChars.Count)];

            passwordTextBox.Text = generatedPassword;

            copyButton.Enabled = true;
        }
        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordTextBox.Text);
        }
        private void aboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        // Functions
        private uint GetNbCheckedBoxes()
        {
            uint nbBoxesChecked = 0;

            if (lowercaseCheckBox.Checked)
                nbBoxesChecked++;

            if (uppercaseCheckBox.Checked)
                nbBoxesChecked++;

            if (numbersCheckBox.Checked)
                nbBoxesChecked++;

            if (specialCharsCheckBox.Checked)
                nbBoxesChecked++;

            return nbBoxesChecked;
        }

        // Hard-coded lists of characters

        private List<char> lowercaseChars = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private List<char> uppercaseChars = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private List<char> numberChars = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private List<char> specialChars = new List<char> { '@', '&', '#', '%', ',', '.', '!', '?', '-', '_', '\'' };
    }
}
