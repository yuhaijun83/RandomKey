namespace RandomKey
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.NotifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GroupBox_KeySet = new System.Windows.Forms.GroupBox();
            this.Label_KeySet_TheOthersChars2 = new System.Windows.Forms.Label();
            this.Label_KeySet_TheOthersChars1 = new System.Windows.Forms.Label();
            this.TextBox_TheOtherChars = new System.Windows.Forms.TextBox();
            this.CheckBox_KeySet_TheOthersChars = new System.Windows.Forms.CheckBox();
            this.CheckBox_Full_Katakana = new System.Windows.Forms.CheckBox();
            this.CheckBox_Full_Hiragana = new System.Windows.Forms.CheckBox();
            this.CheckBox_Halt_Katakana = new System.Windows.Forms.CheckBox();
            this.CheckBox_Full_Special_Characters = new System.Windows.Forms.CheckBox();
            this.CheckBox_Halt_Special_Characters = new System.Windows.Forms.CheckBox();
            this.TextBox_Full_Katakana = new System.Windows.Forms.TextBox();
            this.TextBox_Full_Hiragana = new System.Windows.Forms.TextBox();
            this.TextBox_Full_Special_Characters = new System.Windows.Forms.TextBox();
            this.TextBox_Halt_Katakana = new System.Windows.Forms.TextBox();
            this.TextBox_Full_Numbers = new System.Windows.Forms.TextBox();
            this.TextBox_Halt_Special_Characters = new System.Windows.Forms.TextBox();
            this.TextBox_Full_LowercaseLetters = new System.Windows.Forms.TextBox();
            this.TextBox_Half_Numbers = new System.Windows.Forms.TextBox();
            this.TextBox_Full_UppercaseLetters = new System.Windows.Forms.TextBox();
            this.TextBox_Half_LowercaseLetters = new System.Windows.Forms.TextBox();
            this.CheckBox_Full_Lowercase_Letters = new System.Windows.Forms.CheckBox();
            this.TextBox_Half_UppercaseLetters = new System.Windows.Forms.TextBox();
            this.CheckBox_Full_Uppercase_Letters = new System.Windows.Forms.CheckBox();
            this.CheckBox_Half_LowercaseLetters = new System.Windows.Forms.CheckBox();
            this.CheckBox_Full_Numbers = new System.Windows.Forms.CheckBox();
            this.CheckBox_Half_UppercaseLetters = new System.Windows.Forms.CheckBox();
            this.CheckBox_Half_Numbers = new System.Windows.Forms.CheckBox();
            this.GroupBox_KeyLength = new System.Windows.Forms.GroupBox();
            this.Label_TheNumberOnly = new System.Windows.Forms.Label();
            this.TextBox_OtherBytes = new System.Windows.Forms.TextBox();
            this.RadioButton_KeyLength_OtherBytes = new System.Windows.Forms.RadioButton();
            this.RadioButton_KeyLength_48 = new System.Windows.Forms.RadioButton();
            this.RadioButton_KeyLength_36 = new System.Windows.Forms.RadioButton();
            this.RadioButton_KeyLength_32 = new System.Windows.Forms.RadioButton();
            this.RadioButton_KeyLength_24 = new System.Windows.Forms.RadioButton();
            this.RadioButton_KeyLength_16 = new System.Windows.Forms.RadioButton();
            this.RadioButton_KeyLength_12 = new System.Windows.Forms.RadioButton();
            this.RadioButton_KeyLength_8 = new System.Windows.Forms.RadioButton();
            this.RadioButton_KeyLength_6 = new System.Windows.Forms.RadioButton();
            this.Btn_CreateKey = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.TextBox_KeySeed = new System.Windows.Forms.TextBox();
            this.GroupBox_KeySeed = new System.Windows.Forms.GroupBox();
            this.GroupBox_RandomKey = new System.Windows.Forms.GroupBox();
            this.TextBox_RandomKey = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripMain.SuspendLayout();
            this.GroupBox_KeySet.SuspendLayout();
            this.GroupBox_KeyLength.SuspendLayout();
            this.GroupBox_KeySeed.SuspendLayout();
            this.GroupBox_RandomKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIconMain
            // 
            this.NotifyIconMain.ContextMenuStrip = this.ContextMenuStripMain;
            this.NotifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIconMain.Icon")));
            this.NotifyIconMain.Text = "RandomKey";
            this.NotifyIconMain.Visible = true;
            // 
            // ContextMenuStripMain
            // 
            this.ContextMenuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Exit});
            this.ContextMenuStripMain.Name = "ContextMenuStripMain";
            this.ContextMenuStripMain.Size = new System.Drawing.Size(211, 56);
            // 
            // GroupBox_KeySet
            // 
            this.GroupBox_KeySet.Controls.Add(this.Label_KeySet_TheOthersChars2);
            this.GroupBox_KeySet.Controls.Add(this.Label_KeySet_TheOthersChars1);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_TheOtherChars);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_KeySet_TheOthersChars);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_Full_Katakana);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_Full_Hiragana);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_Halt_Katakana);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_Full_Special_Characters);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_Halt_Special_Characters);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_Full_Katakana);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_Full_Hiragana);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_Full_Special_Characters);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_Halt_Katakana);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_Full_Numbers);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_Halt_Special_Characters);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_Full_LowercaseLetters);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_Half_Numbers);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_Full_UppercaseLetters);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_Half_LowercaseLetters);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_Full_Lowercase_Letters);
            this.GroupBox_KeySet.Controls.Add(this.TextBox_Half_UppercaseLetters);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_Full_Uppercase_Letters);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_Half_LowercaseLetters);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_Full_Numbers);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_Half_UppercaseLetters);
            this.GroupBox_KeySet.Controls.Add(this.CheckBox_Half_Numbers);
            this.GroupBox_KeySet.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_KeySet.Name = "GroupBox_KeySet";
            this.GroupBox_KeySet.Size = new System.Drawing.Size(743, 512);
            this.GroupBox_KeySet.TabIndex = 1;
            this.GroupBox_KeySet.TabStop = false;
            this.GroupBox_KeySet.Text = "Key Set";
            // 
            // Label_KeySet_TheOthersChars2
            // 
            this.Label_KeySet_TheOthersChars2.AutoSize = true;
            this.Label_KeySet_TheOthersChars2.Location = new System.Drawing.Point(47, 459);
            this.Label_KeySet_TheOthersChars2.Name = "Label_KeySet_TheOthersChars2";
            this.Label_KeySet_TheOthersChars2.Size = new System.Drawing.Size(199, 15);
            this.Label_KeySet_TheOthersChars2.TabIndex = 10;
            this.Label_KeySet_TheOthersChars2.Text = "4Byte Single Characters)";
            // 
            // Label_KeySet_TheOthersChars1
            // 
            this.Label_KeySet_TheOthersChars1.AutoSize = true;
            this.Label_KeySet_TheOthersChars1.Location = new System.Drawing.Point(35, 444);
            this.Label_KeySet_TheOthersChars1.Name = "Label_KeySet_TheOthersChars1";
            this.Label_KeySet_TheOthersChars1.Size = new System.Drawing.Size(175, 15);
            this.Label_KeySet_TheOthersChars1.TabIndex = 10;
            this.Label_KeySet_TheOthersChars1.Text = "(Don\'t Input 3Byte OR";
            // 
            // TextBox_TheOtherChars
            // 
            this.TextBox_TheOtherChars.Enabled = false;
            this.TextBox_TheOtherChars.Location = new System.Drawing.Point(252, 420);
            this.TextBox_TheOtherChars.MaxLength = 1000;
            this.TextBox_TheOtherChars.Multiline = true;
            this.TextBox_TheOtherChars.Name = "TextBox_TheOtherChars";
            this.TextBox_TheOtherChars.Size = new System.Drawing.Size(480, 82);
            this.TextBox_TheOtherChars.TabIndex = 14;
            this.TextBox_TheOtherChars.TextChanged += new System.EventHandler(this.TextBox_TheOtherChars_TextChanged);
            this.TextBox_TheOtherChars.Leave += new System.EventHandler(this.TextBox_TheOtherChars_Leave);
            // 
            // CheckBox_KeySet_TheOthersChars
            // 
            this.CheckBox_KeySet_TheOthersChars.AutoSize = true;
            this.CheckBox_KeySet_TheOthersChars.Location = new System.Drawing.Point(21, 422);
            this.CheckBox_KeySet_TheOthersChars.Name = "CheckBox_KeySet_TheOthersChars";
            this.CheckBox_KeySet_TheOthersChars.Size = new System.Drawing.Size(165, 19);
            this.CheckBox_KeySet_TheOthersChars.TabIndex = 13;
            this.CheckBox_KeySet_TheOthersChars.Text = "The Others Chars:";
            this.CheckBox_KeySet_TheOthersChars.UseVisualStyleBackColor = true;
            this.CheckBox_KeySet_TheOthersChars.CheckedChanged += new System.EventHandler(this.CheckBox_KeySet_TheOthersChars_CheckedChanged);
            // 
            // CheckBox_Full_Katakana
            // 
            this.CheckBox_Full_Katakana.AutoSize = true;
            this.CheckBox_Full_Katakana.Location = new System.Drawing.Point(21, 376);
            this.CheckBox_Full_Katakana.Name = "CheckBox_Full_Katakana";
            this.CheckBox_Full_Katakana.Size = new System.Drawing.Size(141, 19);
            this.CheckBox_Full_Katakana.TabIndex = 12;
            this.CheckBox_Full_Katakana.Text = "Full Katakana:";
            this.CheckBox_Full_Katakana.UseVisualStyleBackColor = true;
            this.CheckBox_Full_Katakana.CheckedChanged += new System.EventHandler(this.CheckBox_Full_Katakana_CheckedChanged);
            // 
            // CheckBox_Full_Hiragana
            // 
            this.CheckBox_Full_Hiragana.AutoSize = true;
            this.CheckBox_Full_Hiragana.Location = new System.Drawing.Point(21, 331);
            this.CheckBox_Full_Hiragana.Name = "CheckBox_Full_Hiragana";
            this.CheckBox_Full_Hiragana.Size = new System.Drawing.Size(141, 19);
            this.CheckBox_Full_Hiragana.TabIndex = 11;
            this.CheckBox_Full_Hiragana.Text = "Full Hiragana:";
            this.CheckBox_Full_Hiragana.UseVisualStyleBackColor = true;
            this.CheckBox_Full_Hiragana.CheckedChanged += new System.EventHandler(this.CheckBox_Full_Hiragana_CheckedChanged);
            // 
            // CheckBox_Halt_Katakana
            // 
            this.CheckBox_Halt_Katakana.AutoSize = true;
            this.CheckBox_Halt_Katakana.Location = new System.Drawing.Point(21, 153);
            this.CheckBox_Halt_Katakana.Name = "CheckBox_Halt_Katakana";
            this.CheckBox_Halt_Katakana.Size = new System.Drawing.Size(141, 19);
            this.CheckBox_Halt_Katakana.TabIndex = 6;
            this.CheckBox_Halt_Katakana.Text = "Halt Katakana:";
            this.CheckBox_Halt_Katakana.UseVisualStyleBackColor = true;
            this.CheckBox_Halt_Katakana.CheckedChanged += new System.EventHandler(this.CheckBox_Halt_Katakana_CheckedChanged);
            // 
            // CheckBox_Full_Special_Characters
            // 
            this.CheckBox_Full_Special_Characters.AutoSize = true;
            this.CheckBox_Full_Special_Characters.Location = new System.Drawing.Point(21, 284);
            this.CheckBox_Full_Special_Characters.Name = "CheckBox_Full_Special_Characters";
            this.CheckBox_Full_Special_Characters.Size = new System.Drawing.Size(221, 19);
            this.CheckBox_Full_Special_Characters.TabIndex = 10;
            this.CheckBox_Full_Special_Characters.Text = "Full Special Characters:";
            this.CheckBox_Full_Special_Characters.UseVisualStyleBackColor = true;
            this.CheckBox_Full_Special_Characters.CheckedChanged += new System.EventHandler(this.CheckBox_Full_Special_Characters_CheckedChanged);
            // 
            // CheckBox_Halt_Special_Characters
            // 
            this.CheckBox_Halt_Special_Characters.AutoSize = true;
            this.CheckBox_Halt_Special_Characters.Location = new System.Drawing.Point(21, 122);
            this.CheckBox_Halt_Special_Characters.Name = "CheckBox_Halt_Special_Characters";
            this.CheckBox_Halt_Special_Characters.Size = new System.Drawing.Size(221, 19);
            this.CheckBox_Halt_Special_Characters.TabIndex = 5;
            this.CheckBox_Halt_Special_Characters.Text = "Halt Special Characters:";
            this.CheckBox_Halt_Special_Characters.UseVisualStyleBackColor = true;
            this.CheckBox_Halt_Special_Characters.CheckedChanged += new System.EventHandler(this.CheckBox_Halt_Special_Characters_CheckedChanged);
            // 
            // TextBox_Full_Katakana
            // 
            this.TextBox_Full_Katakana.Location = new System.Drawing.Point(252, 367);
            this.TextBox_Full_Katakana.Multiline = true;
            this.TextBox_Full_Katakana.Name = "TextBox_Full_Katakana";
            this.TextBox_Full_Katakana.ReadOnly = true;
            this.TextBox_Full_Katakana.Size = new System.Drawing.Size(480, 40);
            this.TextBox_Full_Katakana.TabIndex = 5;
            this.TextBox_Full_Katakana.TabStop = false;
            // 
            // TextBox_Full_Hiragana
            // 
            this.TextBox_Full_Hiragana.Location = new System.Drawing.Point(252, 321);
            this.TextBox_Full_Hiragana.Multiline = true;
            this.TextBox_Full_Hiragana.Name = "TextBox_Full_Hiragana";
            this.TextBox_Full_Hiragana.ReadOnly = true;
            this.TextBox_Full_Hiragana.Size = new System.Drawing.Size(480, 40);
            this.TextBox_Full_Hiragana.TabIndex = 5;
            this.TextBox_Full_Hiragana.TabStop = false;
            // 
            // TextBox_Full_Special_Characters
            // 
            this.TextBox_Full_Special_Characters.Location = new System.Drawing.Point(252, 275);
            this.TextBox_Full_Special_Characters.Multiline = true;
            this.TextBox_Full_Special_Characters.Name = "TextBox_Full_Special_Characters";
            this.TextBox_Full_Special_Characters.ReadOnly = true;
            this.TextBox_Full_Special_Characters.Size = new System.Drawing.Size(480, 40);
            this.TextBox_Full_Special_Characters.TabIndex = 5;
            this.TextBox_Full_Special_Characters.TabStop = false;
            // 
            // TextBox_Halt_Katakana
            // 
            this.TextBox_Halt_Katakana.Location = new System.Drawing.Point(252, 151);
            this.TextBox_Halt_Katakana.Name = "TextBox_Halt_Katakana";
            this.TextBox_Halt_Katakana.ReadOnly = true;
            this.TextBox_Halt_Katakana.Size = new System.Drawing.Size(480, 25);
            this.TextBox_Halt_Katakana.TabIndex = 5;
            this.TextBox_Halt_Katakana.TabStop = false;
            // 
            // TextBox_Full_Numbers
            // 
            this.TextBox_Full_Numbers.Location = new System.Drawing.Point(252, 244);
            this.TextBox_Full_Numbers.Name = "TextBox_Full_Numbers";
            this.TextBox_Full_Numbers.ReadOnly = true;
            this.TextBox_Full_Numbers.Size = new System.Drawing.Size(480, 25);
            this.TextBox_Full_Numbers.TabIndex = 5;
            this.TextBox_Full_Numbers.TabStop = false;
            // 
            // TextBox_Halt_Special_Characters
            // 
            this.TextBox_Halt_Special_Characters.Location = new System.Drawing.Point(252, 120);
            this.TextBox_Halt_Special_Characters.Name = "TextBox_Halt_Special_Characters";
            this.TextBox_Halt_Special_Characters.ReadOnly = true;
            this.TextBox_Halt_Special_Characters.Size = new System.Drawing.Size(480, 25);
            this.TextBox_Halt_Special_Characters.TabIndex = 5;
            this.TextBox_Halt_Special_Characters.TabStop = false;
            // 
            // TextBox_Full_LowercaseLetters
            // 
            this.TextBox_Full_LowercaseLetters.Location = new System.Drawing.Point(252, 213);
            this.TextBox_Full_LowercaseLetters.Name = "TextBox_Full_LowercaseLetters";
            this.TextBox_Full_LowercaseLetters.ReadOnly = true;
            this.TextBox_Full_LowercaseLetters.Size = new System.Drawing.Size(480, 25);
            this.TextBox_Full_LowercaseLetters.TabIndex = 5;
            this.TextBox_Full_LowercaseLetters.TabStop = false;
            // 
            // TextBox_Half_Numbers
            // 
            this.TextBox_Half_Numbers.Location = new System.Drawing.Point(252, 89);
            this.TextBox_Half_Numbers.Name = "TextBox_Half_Numbers";
            this.TextBox_Half_Numbers.ReadOnly = true;
            this.TextBox_Half_Numbers.Size = new System.Drawing.Size(480, 25);
            this.TextBox_Half_Numbers.TabIndex = 5;
            this.TextBox_Half_Numbers.TabStop = false;
            // 
            // TextBox_Full_UppercaseLetters
            // 
            this.TextBox_Full_UppercaseLetters.Location = new System.Drawing.Point(252, 182);
            this.TextBox_Full_UppercaseLetters.Name = "TextBox_Full_UppercaseLetters";
            this.TextBox_Full_UppercaseLetters.ReadOnly = true;
            this.TextBox_Full_UppercaseLetters.Size = new System.Drawing.Size(480, 25);
            this.TextBox_Full_UppercaseLetters.TabIndex = 5;
            this.TextBox_Full_UppercaseLetters.TabStop = false;
            // 
            // TextBox_Half_LowercaseLetters
            // 
            this.TextBox_Half_LowercaseLetters.Location = new System.Drawing.Point(252, 58);
            this.TextBox_Half_LowercaseLetters.Name = "TextBox_Half_LowercaseLetters";
            this.TextBox_Half_LowercaseLetters.ReadOnly = true;
            this.TextBox_Half_LowercaseLetters.Size = new System.Drawing.Size(480, 25);
            this.TextBox_Half_LowercaseLetters.TabIndex = 5;
            this.TextBox_Half_LowercaseLetters.TabStop = false;
            // 
            // CheckBox_Full_Lowercase_Letters
            // 
            this.CheckBox_Full_Lowercase_Letters.AutoSize = true;
            this.CheckBox_Full_Lowercase_Letters.Location = new System.Drawing.Point(21, 217);
            this.CheckBox_Full_Lowercase_Letters.Name = "CheckBox_Full_Lowercase_Letters";
            this.CheckBox_Full_Lowercase_Letters.Size = new System.Drawing.Size(213, 19);
            this.CheckBox_Full_Lowercase_Letters.TabIndex = 8;
            this.CheckBox_Full_Lowercase_Letters.Text = "Full Lowercase Letters:";
            this.CheckBox_Full_Lowercase_Letters.UseVisualStyleBackColor = true;
            this.CheckBox_Full_Lowercase_Letters.CheckedChanged += new System.EventHandler(this.CheckBox_Full_Lowercase_Letters_CheckedChanged);
            // 
            // TextBox_Half_UppercaseLetters
            // 
            this.TextBox_Half_UppercaseLetters.Location = new System.Drawing.Point(252, 27);
            this.TextBox_Half_UppercaseLetters.Name = "TextBox_Half_UppercaseLetters";
            this.TextBox_Half_UppercaseLetters.ReadOnly = true;
            this.TextBox_Half_UppercaseLetters.Size = new System.Drawing.Size(480, 25);
            this.TextBox_Half_UppercaseLetters.TabIndex = 5;
            this.TextBox_Half_UppercaseLetters.TabStop = false;
            // 
            // CheckBox_Full_Uppercase_Letters
            // 
            this.CheckBox_Full_Uppercase_Letters.AutoSize = true;
            this.CheckBox_Full_Uppercase_Letters.Location = new System.Drawing.Point(21, 186);
            this.CheckBox_Full_Uppercase_Letters.Name = "CheckBox_Full_Uppercase_Letters";
            this.CheckBox_Full_Uppercase_Letters.Size = new System.Drawing.Size(213, 19);
            this.CheckBox_Full_Uppercase_Letters.TabIndex = 7;
            this.CheckBox_Full_Uppercase_Letters.Text = "Full Uppercase Letters:";
            this.CheckBox_Full_Uppercase_Letters.UseVisualStyleBackColor = true;
            this.CheckBox_Full_Uppercase_Letters.CheckedChanged += new System.EventHandler(this.CheckBox_Full_Uppercase_Letters_CheckedChanged);
            // 
            // CheckBox_Half_LowercaseLetters
            // 
            this.CheckBox_Half_LowercaseLetters.AutoSize = true;
            this.CheckBox_Half_LowercaseLetters.Location = new System.Drawing.Point(21, 60);
            this.CheckBox_Half_LowercaseLetters.Name = "CheckBox_Half_LowercaseLetters";
            this.CheckBox_Half_LowercaseLetters.Size = new System.Drawing.Size(213, 19);
            this.CheckBox_Half_LowercaseLetters.TabIndex = 3;
            this.CheckBox_Half_LowercaseLetters.Text = "Half Lowercase Letters:";
            this.CheckBox_Half_LowercaseLetters.UseVisualStyleBackColor = true;
            this.CheckBox_Half_LowercaseLetters.CheckedChanged += new System.EventHandler(this.CheckBox_Half_LowercaseLetters_CheckedChanged);
            // 
            // CheckBox_Full_Numbers
            // 
            this.CheckBox_Full_Numbers.AutoSize = true;
            this.CheckBox_Full_Numbers.Location = new System.Drawing.Point(21, 248);
            this.CheckBox_Full_Numbers.Name = "CheckBox_Full_Numbers";
            this.CheckBox_Full_Numbers.Size = new System.Drawing.Size(133, 19);
            this.CheckBox_Full_Numbers.TabIndex = 9;
            this.CheckBox_Full_Numbers.Text = "Full Numbers:";
            this.CheckBox_Full_Numbers.UseVisualStyleBackColor = true;
            this.CheckBox_Full_Numbers.CheckedChanged += new System.EventHandler(this.CheckBox_Full_Numbers_CheckedChanged);
            // 
            // CheckBox_Half_UppercaseLetters
            // 
            this.CheckBox_Half_UppercaseLetters.AutoSize = true;
            this.CheckBox_Half_UppercaseLetters.Location = new System.Drawing.Point(21, 29);
            this.CheckBox_Half_UppercaseLetters.Name = "CheckBox_Half_UppercaseLetters";
            this.CheckBox_Half_UppercaseLetters.Size = new System.Drawing.Size(213, 19);
            this.CheckBox_Half_UppercaseLetters.TabIndex = 2;
            this.CheckBox_Half_UppercaseLetters.Text = "Half Uppercase Letters:";
            this.CheckBox_Half_UppercaseLetters.UseVisualStyleBackColor = true;
            this.CheckBox_Half_UppercaseLetters.Click += new System.EventHandler(this.CheckBox_Half_UppercaseLetters_Click);
            // 
            // CheckBox_Half_Numbers
            // 
            this.CheckBox_Half_Numbers.AutoSize = true;
            this.CheckBox_Half_Numbers.Location = new System.Drawing.Point(21, 91);
            this.CheckBox_Half_Numbers.Name = "CheckBox_Half_Numbers";
            this.CheckBox_Half_Numbers.Size = new System.Drawing.Size(133, 19);
            this.CheckBox_Half_Numbers.TabIndex = 4;
            this.CheckBox_Half_Numbers.Text = "Half Numbers:";
            this.CheckBox_Half_Numbers.UseVisualStyleBackColor = true;
            this.CheckBox_Half_Numbers.CheckedChanged += new System.EventHandler(this.CheckBox_Half_Numbers_CheckedChanged);
            // 
            // GroupBox_KeyLength
            // 
            this.GroupBox_KeyLength.Controls.Add(this.Label_TheNumberOnly);
            this.GroupBox_KeyLength.Controls.Add(this.TextBox_OtherBytes);
            this.GroupBox_KeyLength.Controls.Add(this.RadioButton_KeyLength_OtherBytes);
            this.GroupBox_KeyLength.Controls.Add(this.RadioButton_KeyLength_48);
            this.GroupBox_KeyLength.Controls.Add(this.RadioButton_KeyLength_36);
            this.GroupBox_KeyLength.Controls.Add(this.RadioButton_KeyLength_32);
            this.GroupBox_KeyLength.Controls.Add(this.RadioButton_KeyLength_24);
            this.GroupBox_KeyLength.Controls.Add(this.RadioButton_KeyLength_16);
            this.GroupBox_KeyLength.Controls.Add(this.RadioButton_KeyLength_12);
            this.GroupBox_KeyLength.Controls.Add(this.RadioButton_KeyLength_8);
            this.GroupBox_KeyLength.Controls.Add(this.RadioButton_KeyLength_6);
            this.GroupBox_KeyLength.Location = new System.Drawing.Point(761, 12);
            this.GroupBox_KeyLength.Name = "GroupBox_KeyLength";
            this.GroupBox_KeyLength.Size = new System.Drawing.Size(428, 125);
            this.GroupBox_KeyLength.TabIndex = 15;
            this.GroupBox_KeyLength.TabStop = false;
            this.GroupBox_KeyLength.Text = "Key Length (Not The Calculation Method Of UTF-8)";
            // 
            // Label_TheNumberOnly
            // 
            this.Label_TheNumberOnly.AutoSize = true;
            this.Label_TheNumberOnly.Location = new System.Drawing.Point(211, 95);
            this.Label_TheNumberOnly.Name = "Label_TheNumberOnly";
            this.Label_TheNumberOnly.Size = new System.Drawing.Size(191, 15);
            this.Label_TheNumberOnly.TabIndex = 2;
            this.Label_TheNumberOnly.Text = "(Input The Number Only)";
            // 
            // TextBox_OtherBytes
            // 
            this.TextBox_OtherBytes.Enabled = false;
            this.TextBox_OtherBytes.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_OtherBytes.Location = new System.Drawing.Point(157, 89);
            this.TextBox_OtherBytes.MaxLength = 3;
            this.TextBox_OtherBytes.Name = "TextBox_OtherBytes";
            this.TextBox_OtherBytes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox_OtherBytes.Size = new System.Drawing.Size(48, 25);
            this.TextBox_OtherBytes.TabIndex = 25;
            this.TextBox_OtherBytes.TextChanged += new System.EventHandler(this.TextBox_OtherBytes_TextChanged);
            this.TextBox_OtherBytes.Leave += new System.EventHandler(this.TextBox_OtherBytes_Leave);
            // 
            // RadioButton_KeyLength_OtherBytes
            // 
            this.RadioButton_KeyLength_OtherBytes.AutoSize = true;
            this.RadioButton_KeyLength_OtherBytes.Location = new System.Drawing.Point(15, 90);
            this.RadioButton_KeyLength_OtherBytes.Name = "RadioButton_KeyLength_OtherBytes";
            this.RadioButton_KeyLength_OtherBytes.Size = new System.Drawing.Size(124, 19);
            this.RadioButton_KeyLength_OtherBytes.TabIndex = 24;
            this.RadioButton_KeyLength_OtherBytes.TabStop = true;
            this.RadioButton_KeyLength_OtherBytes.Text = "Other Bytes:";
            this.RadioButton_KeyLength_OtherBytes.UseVisualStyleBackColor = true;
            this.RadioButton_KeyLength_OtherBytes.CheckedChanged += new System.EventHandler(this.RadioButton_KeyLength_OtherBytes_CheckedChanged);
            // 
            // RadioButton_KeyLength_48
            // 
            this.RadioButton_KeyLength_48.AutoSize = true;
            this.RadioButton_KeyLength_48.Location = new System.Drawing.Point(309, 59);
            this.RadioButton_KeyLength_48.Name = "RadioButton_KeyLength_48";
            this.RadioButton_KeyLength_48.Size = new System.Drawing.Size(92, 19);
            this.RadioButton_KeyLength_48.TabIndex = 23;
            this.RadioButton_KeyLength_48.TabStop = true;
            this.RadioButton_KeyLength_48.Text = "48 Bytes";
            this.RadioButton_KeyLength_48.UseVisualStyleBackColor = true;
            this.RadioButton_KeyLength_48.CheckedChanged += new System.EventHandler(this.RadioButton_KeyLength_48_CheckedChanged);
            // 
            // RadioButton_KeyLength_36
            // 
            this.RadioButton_KeyLength_36.AutoSize = true;
            this.RadioButton_KeyLength_36.Location = new System.Drawing.Point(211, 59);
            this.RadioButton_KeyLength_36.Name = "RadioButton_KeyLength_36";
            this.RadioButton_KeyLength_36.Size = new System.Drawing.Size(92, 19);
            this.RadioButton_KeyLength_36.TabIndex = 22;
            this.RadioButton_KeyLength_36.TabStop = true;
            this.RadioButton_KeyLength_36.Text = "36 Bytes";
            this.RadioButton_KeyLength_36.UseVisualStyleBackColor = true;
            this.RadioButton_KeyLength_36.CheckedChanged += new System.EventHandler(this.RadioButton_KeyLength_36_CheckedChanged);
            // 
            // RadioButton_KeyLength_32
            // 
            this.RadioButton_KeyLength_32.AutoSize = true;
            this.RadioButton_KeyLength_32.Location = new System.Drawing.Point(113, 59);
            this.RadioButton_KeyLength_32.Name = "RadioButton_KeyLength_32";
            this.RadioButton_KeyLength_32.Size = new System.Drawing.Size(92, 19);
            this.RadioButton_KeyLength_32.TabIndex = 21;
            this.RadioButton_KeyLength_32.TabStop = true;
            this.RadioButton_KeyLength_32.Text = "32 Bytes";
            this.RadioButton_KeyLength_32.UseVisualStyleBackColor = true;
            this.RadioButton_KeyLength_32.CheckedChanged += new System.EventHandler(this.RadioButton_KeyLength_32_CheckedChanged);
            // 
            // RadioButton_KeyLength_24
            // 
            this.RadioButton_KeyLength_24.AutoSize = true;
            this.RadioButton_KeyLength_24.Location = new System.Drawing.Point(15, 59);
            this.RadioButton_KeyLength_24.Name = "RadioButton_KeyLength_24";
            this.RadioButton_KeyLength_24.Size = new System.Drawing.Size(92, 19);
            this.RadioButton_KeyLength_24.TabIndex = 20;
            this.RadioButton_KeyLength_24.TabStop = true;
            this.RadioButton_KeyLength_24.Text = "24 Bytes";
            this.RadioButton_KeyLength_24.UseVisualStyleBackColor = true;
            this.RadioButton_KeyLength_24.CheckedChanged += new System.EventHandler(this.RadioButton_KeyLength_24_CheckedChanged);
            // 
            // RadioButton_KeyLength_16
            // 
            this.RadioButton_KeyLength_16.AutoSize = true;
            this.RadioButton_KeyLength_16.Location = new System.Drawing.Point(309, 29);
            this.RadioButton_KeyLength_16.Name = "RadioButton_KeyLength_16";
            this.RadioButton_KeyLength_16.Size = new System.Drawing.Size(92, 19);
            this.RadioButton_KeyLength_16.TabIndex = 19;
            this.RadioButton_KeyLength_16.TabStop = true;
            this.RadioButton_KeyLength_16.Text = "16 Bytes";
            this.RadioButton_KeyLength_16.UseVisualStyleBackColor = true;
            this.RadioButton_KeyLength_16.CheckedChanged += new System.EventHandler(this.RadioButton_KeyLength_16_CheckedChanged);
            // 
            // RadioButton_KeyLength_12
            // 
            this.RadioButton_KeyLength_12.AutoSize = true;
            this.RadioButton_KeyLength_12.Location = new System.Drawing.Point(211, 29);
            this.RadioButton_KeyLength_12.Name = "RadioButton_KeyLength_12";
            this.RadioButton_KeyLength_12.Size = new System.Drawing.Size(92, 19);
            this.RadioButton_KeyLength_12.TabIndex = 18;
            this.RadioButton_KeyLength_12.TabStop = true;
            this.RadioButton_KeyLength_12.Text = "12 Bytes";
            this.RadioButton_KeyLength_12.UseVisualStyleBackColor = true;
            this.RadioButton_KeyLength_12.CheckedChanged += new System.EventHandler(this.RadioButton_KeyLength_12_CheckedChanged);
            // 
            // RadioButton_KeyLength_8
            // 
            this.RadioButton_KeyLength_8.AutoSize = true;
            this.RadioButton_KeyLength_8.Location = new System.Drawing.Point(113, 29);
            this.RadioButton_KeyLength_8.Name = "RadioButton_KeyLength_8";
            this.RadioButton_KeyLength_8.Size = new System.Drawing.Size(92, 19);
            this.RadioButton_KeyLength_8.TabIndex = 17;
            this.RadioButton_KeyLength_8.TabStop = true;
            this.RadioButton_KeyLength_8.Text = " 8 Bytes";
            this.RadioButton_KeyLength_8.UseVisualStyleBackColor = true;
            this.RadioButton_KeyLength_8.CheckedChanged += new System.EventHandler(this.RadioButton_KeyLength_8_CheckedChanged);
            // 
            // RadioButton_KeyLength_6
            // 
            this.RadioButton_KeyLength_6.AutoSize = true;
            this.RadioButton_KeyLength_6.Location = new System.Drawing.Point(15, 28);
            this.RadioButton_KeyLength_6.Name = "RadioButton_KeyLength_6";
            this.RadioButton_KeyLength_6.Size = new System.Drawing.Size(92, 19);
            this.RadioButton_KeyLength_6.TabIndex = 16;
            this.RadioButton_KeyLength_6.TabStop = true;
            this.RadioButton_KeyLength_6.Text = " 6 Bytes";
            this.RadioButton_KeyLength_6.UseVisualStyleBackColor = true;
            this.RadioButton_KeyLength_6.CheckedChanged += new System.EventHandler(this.RadioButton_KeyLength_6_CheckedChanged);
            // 
            // Btn_CreateKey
            // 
            this.Btn_CreateKey.Location = new System.Drawing.Point(303, 17);
            this.Btn_CreateKey.Name = "Btn_CreateKey";
            this.Btn_CreateKey.Size = new System.Drawing.Size(119, 38);
            this.Btn_CreateKey.TabIndex = 30;
            this.Btn_CreateKey.Text = "Create Key";
            this.Btn_CreateKey.UseVisualStyleBackColor = true;
            this.Btn_CreateKey.Click += new System.EventHandler(this.Btn_CreateKey_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(157, 17);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(119, 38);
            this.Btn_Clear.TabIndex = 29;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // TextBox_KeySeed
            // 
            this.TextBox_KeySeed.Location = new System.Drawing.Point(6, 24);
            this.TextBox_KeySeed.Multiline = true;
            this.TextBox_KeySeed.Name = "TextBox_KeySeed";
            this.TextBox_KeySeed.ReadOnly = true;
            this.TextBox_KeySeed.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextBox_KeySeed.Size = new System.Drawing.Size(416, 144);
            this.TextBox_KeySeed.TabIndex = 27;
            // 
            // GroupBox_KeySeed
            // 
            this.GroupBox_KeySeed.Controls.Add(this.TextBox_KeySeed);
            this.GroupBox_KeySeed.Location = new System.Drawing.Point(761, 143);
            this.GroupBox_KeySeed.Name = "GroupBox_KeySeed";
            this.GroupBox_KeySeed.Size = new System.Drawing.Size(428, 180);
            this.GroupBox_KeySeed.TabIndex = 26;
            this.GroupBox_KeySeed.TabStop = false;
            this.GroupBox_KeySeed.Text = "Key Seed";
            // 
            // GroupBox_RandomKey
            // 
            this.GroupBox_RandomKey.Controls.Add(this.TextBox_RandomKey);
            this.GroupBox_RandomKey.Controls.Add(this.Btn_CreateKey);
            this.GroupBox_RandomKey.Controls.Add(this.BtnExit);
            this.GroupBox_RandomKey.Controls.Add(this.Btn_Clear);
            this.GroupBox_RandomKey.Location = new System.Drawing.Point(761, 329);
            this.GroupBox_RandomKey.Name = "GroupBox_RandomKey";
            this.GroupBox_RandomKey.Size = new System.Drawing.Size(428, 195);
            this.GroupBox_RandomKey.TabIndex = 6;
            this.GroupBox_RandomKey.TabStop = false;
            this.GroupBox_RandomKey.Text = "Random Key";
            // 
            // TextBox_RandomKey
            // 
            this.TextBox_RandomKey.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_RandomKey.Location = new System.Drawing.Point(6, 61);
            this.TextBox_RandomKey.Multiline = true;
            this.TextBox_RandomKey.Name = "TextBox_RandomKey";
            this.TextBox_RandomKey.ReadOnly = true;
            this.TextBox_RandomKey.Size = new System.Drawing.Size(416, 124);
            this.TextBox_RandomKey.TabIndex = 31;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(6, 17);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(119, 38);
            this.BtnExit.TabIndex = 28;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(210, 24);
            this.ToolStripMenuItem_Exit.Text = "Exit";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 541);
            this.Controls.Add(this.GroupBox_RandomKey);
            this.Controls.Add(this.GroupBox_KeySeed);
            this.Controls.Add(this.GroupBox_KeyLength);
            this.Controls.Add(this.GroupBox_KeySet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandomKey";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ContextMenuStripMain.ResumeLayout(false);
            this.GroupBox_KeySet.ResumeLayout(false);
            this.GroupBox_KeySet.PerformLayout();
            this.GroupBox_KeyLength.ResumeLayout(false);
            this.GroupBox_KeyLength.PerformLayout();
            this.GroupBox_KeySeed.ResumeLayout(false);
            this.GroupBox_KeySeed.PerformLayout();
            this.GroupBox_RandomKey.ResumeLayout(false);
            this.GroupBox_RandomKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyIconMain;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripMain;
        private System.Windows.Forms.GroupBox GroupBox_KeySet;
        private System.Windows.Forms.CheckBox CheckBox_Half_LowercaseLetters;
        private System.Windows.Forms.CheckBox CheckBox_Half_UppercaseLetters;
        private System.Windows.Forms.TextBox TextBox_Half_UppercaseLetters;
        private System.Windows.Forms.CheckBox CheckBox_Half_Numbers;
        private System.Windows.Forms.TextBox TextBox_Half_Numbers;
        private System.Windows.Forms.TextBox TextBox_Half_LowercaseLetters;
        private System.Windows.Forms.CheckBox CheckBox_Halt_Special_Characters;
        private System.Windows.Forms.TextBox TextBox_Halt_Special_Characters;
        private System.Windows.Forms.CheckBox CheckBox_Halt_Katakana;
        private System.Windows.Forms.TextBox TextBox_Halt_Katakana;
        private System.Windows.Forms.CheckBox CheckBox_Full_Hiragana;
        private System.Windows.Forms.CheckBox CheckBox_Full_Special_Characters;
        private System.Windows.Forms.TextBox TextBox_Full_Hiragana;
        private System.Windows.Forms.TextBox TextBox_Full_Special_Characters;
        private System.Windows.Forms.TextBox TextBox_Full_Numbers;
        private System.Windows.Forms.TextBox TextBox_Full_LowercaseLetters;
        private System.Windows.Forms.TextBox TextBox_Full_UppercaseLetters;
        private System.Windows.Forms.CheckBox CheckBox_Full_Lowercase_Letters;
        private System.Windows.Forms.CheckBox CheckBox_Full_Uppercase_Letters;
        private System.Windows.Forms.CheckBox CheckBox_Full_Numbers;
        private System.Windows.Forms.CheckBox CheckBox_Full_Katakana;
        private System.Windows.Forms.TextBox TextBox_Full_Katakana;
        private System.Windows.Forms.GroupBox GroupBox_KeyLength;
        private System.Windows.Forms.RadioButton RadioButton_KeyLength_16;
        private System.Windows.Forms.RadioButton RadioButton_KeyLength_12;
        private System.Windows.Forms.RadioButton RadioButton_KeyLength_8;
        private System.Windows.Forms.RadioButton RadioButton_KeyLength_6;
        private System.Windows.Forms.RadioButton RadioButton_KeyLength_24;
        private System.Windows.Forms.RadioButton RadioButton_KeyLength_36;
        private System.Windows.Forms.RadioButton RadioButton_KeyLength_48;
        private System.Windows.Forms.RadioButton RadioButton_KeyLength_OtherBytes;
        private System.Windows.Forms.TextBox TextBox_OtherBytes;
        private System.Windows.Forms.RadioButton RadioButton_KeyLength_32;
        private System.Windows.Forms.Button Btn_CreateKey;
        private System.Windows.Forms.CheckBox CheckBox_KeySet_TheOthersChars;
        private System.Windows.Forms.TextBox TextBox_TheOtherChars;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.TextBox TextBox_KeySeed;
        private System.Windows.Forms.GroupBox GroupBox_KeySeed;
        private System.Windows.Forms.GroupBox GroupBox_RandomKey;
        private System.Windows.Forms.TextBox TextBox_RandomKey;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label Label_TheNumberOnly;
        private System.Windows.Forms.Label Label_KeySet_TheOthersChars1;
        private System.Windows.Forms.Label Label_KeySet_TheOthersChars2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
    }
}

