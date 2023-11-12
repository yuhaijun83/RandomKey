using RandomKey.Properties;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandomKey
{
    public partial class FormMain : Form
    {

        private const string KEY_SET_HALT_UPPERCASE_LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string KEY_SET_HALT_LOWERCASE_LETTERS = "abcdefghijklmnopqrstuvwxyz";
        private const string KEY_SET_HALT_NUMBERS = "1234567890";
        private const string KEY_SET_HALT_SPECIAL_CHARACTERS = "~!@#$%^&*()_+`-={}|[]\\:\";'<>?,./ ";
        private const string KEY_SET_HALT_KATAKANA = "ｱｲｳｴｵｶｷｸｹｺｻｼｽｾｿﾀﾁﾂﾃﾄﾅﾆﾑﾈﾉﾊﾋﾌﾍﾎﾏﾐﾑﾒﾓﾔﾕﾖﾗﾘﾙﾚﾛﾜｵﾝ";

        private const string KEY_SET_FULL_UPPERCASE_LETTERS = "ＡＢＣＤＥＦＧＨＩＪＫＬＭＮＯＰＱＲＳＲＵＶＷＸＹＺ";
        private const string KEY_SET_FULL_LOWERCASE_LETTERS = "ａｂｃｄｅｆｇｈｉｊｋｌｍｎｏｐｑｒｓｔｕｖｗｘｙｚ";
        private const string KEY_SET_FULL_NUMBERS = "１２３４５６７８９０";
        private const string KEY_SET_FULL_SPECIAL_CHARACTERS = "～！＠＃＄％＾＆＊（）＿＋‘－＝｛｝｜［］￥：”；’＜＞？，．／　";
        private const string KEY_SET_FULL_HIRAGANA = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゆよらりるれろわおン";
        private const string KEY_SET_FULL_KATAKANA = "アイウエオカキクケコサシスセソタチツテトナニムネノハヒフヘホマミムメモヤユヨラリルレロワオン";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = "RandomKey " + Resources.RandomKey_Build_Version;

            this.TextBox_Half_UppercaseLetters.Text = KEY_SET_HALT_UPPERCASE_LETTERS;
            this.TextBox_Half_LowercaseLetters.Text = KEY_SET_HALT_LOWERCASE_LETTERS;
            this.TextBox_Half_Numbers.Text = KEY_SET_HALT_NUMBERS;
            this.TextBox_Halt_Special_Characters.Text = KEY_SET_HALT_SPECIAL_CHARACTERS;
            this.TextBox_Halt_Katakana.Text = KEY_SET_HALT_KATAKANA;

            this.TextBox_Full_UppercaseLetters.Text = KEY_SET_FULL_UPPERCASE_LETTERS;
            this.TextBox_Full_LowercaseLetters.Text = KEY_SET_FULL_LOWERCASE_LETTERS;
            this.TextBox_Full_Numbers.Text = KEY_SET_FULL_NUMBERS;
            this.TextBox_Full_Special_Characters.Text = KEY_SET_FULL_SPECIAL_CHARACTERS;
            this.TextBox_Full_Hiragana.Text = KEY_SET_FULL_HIRAGANA;
            this.TextBox_Full_Katakana.Text = KEY_SET_FULL_KATAKANA;

            this.CheckBox_Half_UppercaseLetters.Checked = true;
            this.CheckBox_Half_LowercaseLetters.Checked = true;
            this.CheckBox_Half_Numbers.Checked = true;
            this.CheckBox_Halt_Special_Characters.Checked = true;

            this.RadioButton_KeyLength_8.Checked = true;

            this.GetKeySeedString();
        }

        private void CheckBox_Half_UppercaseLetters_Click(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void CheckBox_Half_LowercaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void CheckBox_Half_Numbers_CheckedChanged(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void CheckBox_Halt_Special_Characters_CheckedChanged(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void CheckBox_Halt_Katakana_CheckedChanged(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void CheckBox_Full_Uppercase_Letters_CheckedChanged(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void CheckBox_Full_Lowercase_Letters_CheckedChanged(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void CheckBox_Full_Numbers_CheckedChanged(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void CheckBox_Full_Special_Characters_CheckedChanged(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void CheckBox_Full_Hiragana_CheckedChanged(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void CheckBox_Full_Katakana_CheckedChanged(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void CheckBox_KeySet_TheOthersChars_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBox_KeySet_TheOthersChars.Checked == true)
            {
                this.TextBox_TheOtherChars.Enabled = true;
                this.TextBox_TheOtherChars.Focus();
            }
            else
            {
                this.TextBox_TheOtherChars.Enabled = false;
                this.TextBox_TheOtherChars.Text = string.Empty;
            }

            this.GetKeySeedString();
        }
        private void TextBox_TheOtherChars_TextChanged(object sender, EventArgs e)
        {
            this.GetKeySeedString();
        }

        private void TextBox_TheOtherChars_Leave(object sender, EventArgs e)
        {
            string strTheOtherChars = this.TextBox_TheOtherChars.Text;

            StringBuilder sb = new StringBuilder();
            foreach (char c in strTheOtherChars)
            {
                if (c == '\r' || c == '\n')
                {
                    ;
                }
                else
                {
                    sb.Append(c);
                }
                this.TextBox_TheOtherChars.Text = sb.ToString();
            }
            this.GetKeySeedString();
        }

        private void RadioButton_KeyLength_6_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_OtherBytes.Text = string.Empty;
        }

        private void RadioButton_KeyLength_8_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_OtherBytes.Text = string.Empty;
        }

        private void RadioButton_KeyLength_12_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_OtherBytes.Text = string.Empty;
        }

        private void RadioButton_KeyLength_16_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_OtherBytes.Text = string.Empty;
        }

        private void RadioButton_KeyLength_24_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_OtherBytes.Text = string.Empty;
        }

        private void RadioButton_KeyLength_32_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_OtherBytes.Text = string.Empty;
        }

        private void RadioButton_KeyLength_36_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_OtherBytes.Text = string.Empty;
        }
        private void RadioButton_KeyLength_48_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_OtherBytes.Text = string.Empty;
        }

        private void RadioButton_KeyLength_OtherBytes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton_KeyLength_OtherBytes.Checked == true)
            {
                this.TextBox_OtherBytes.Enabled = true;
                this.TextBox_OtherBytes.Focus();
            }
            else
            {
                this.TextBox_OtherBytes.Enabled = false;
                this.TextBox_OtherBytes.Text = string.Empty;
            }
        }

        private void TextBox_OtherBytes_TextChanged(object sender, EventArgs e)
        {
            string strOtherBytes = this.TextBox_OtherBytes.Text;
            if (strOtherBytes != string.Empty)
            {
                string strRet = string.Empty;

                char[] charOtherBytes = strOtherBytes.ToCharArray();
                foreach (char cTmp in charOtherBytes)
                {
                    if (cTmp == '0' || cTmp == '1' || cTmp == '2' || cTmp == '3' || cTmp == '4' || cTmp == '5'
                        || cTmp == '6' || cTmp == '7' || cTmp == '8' || cTmp == '9')
                    {
                        strRet += cTmp;
                    }
                }

                if (strRet != string.Empty)
                {
                    this.TextBox_OtherBytes.Text = strRet;
                }
                else
                {
                    this.TextBox_OtherBytes.Text = string.Empty;
                }         
            }
        }

        private void TextBox_OtherBytes_Leave(object sender, EventArgs e)
        {
            string strOtherBytes = this.TextBox_OtherBytes.Text;
            if (strOtherBytes != string.Empty)
            {
                try
                {
                    int iRet = int.Parse(strOtherBytes);
                    this.TextBox_OtherBytes.Text = iRet.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter numbers only !", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    this.TextBox_OtherBytes.Text = string.Empty;
                    this.TextBox_OtherBytes.Focus();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.TextBox_RandomKey.Text = string.Empty;
        }

        private void Btn_CreateKey_Click(object sender, EventArgs e)
        {
            this.TextBox_RandomKey.Text = string.Empty;

            int iKeySize = 0;
            if (this.RadioButton_KeyLength_6.Checked == true)
            {
                iKeySize = 6;
            }
            else if (this.RadioButton_KeyLength_8.Checked == true)
            {
                iKeySize = 8;
            }
            else if (this.RadioButton_KeyLength_12.Checked == true)
            {
                iKeySize = 12;
            }
            else if (this.RadioButton_KeyLength_16.Checked == true)
            {
                iKeySize = 16;
            }
            else if (this.RadioButton_KeyLength_24.Checked == true)
            {
                iKeySize = 24;
            }
            else if (this.RadioButton_KeyLength_32.Checked == true)
            {
                iKeySize = 32;
            }
            else if (this.RadioButton_KeyLength_36.Checked == true)
            {
                iKeySize = 36;
            }
            else if (this.RadioButton_KeyLength_48.Checked == true)
            {
                iKeySize = 48;
            } 
            else if (this.RadioButton_KeyLength_OtherBytes.Checked == true)
            {
                string strOtherBytes = this.TextBox_OtherBytes.Text;
                if (strOtherBytes == string.Empty)
                {
                    MessageBox.Show("Please enter a number !", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    this.TextBox_OtherBytes.Focus();
                    return;
                } 
                else if (strOtherBytes == "0")
                {
                    MessageBox.Show("Please enter a number greater than 0 !", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    this.TextBox_OtherBytes.Focus();
                    return;
                } 
                else
                {
                    iKeySize = int.Parse(strOtherBytes);
                }
            }

            string strKeySeed = this.TextBox_KeySeed.Text;
            int iKeySeedLength = strKeySeed.Length;
            //iKeySeedLength = Encoding.Default.GetByteCount(strKeySeed);

            if (iKeySeedLength == 0) 
            {
                MessageBox.Show("Please select the key set !", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.TextBox_OtherBytes.Focus();
                return;
            }

            int iMixLetterLength = 4;
            int iMaxLetterLength = 0;
            for (int i = 0; i < iKeySeedLength; i++)
            {
                int iLength = Encoding.Default.GetByteCount(strKeySeed[i].ToString());
                if (iLength > iMaxLetterLength)
                {
                    iMaxLetterLength = iLength;
                }
                if (iLength < iMixLetterLength)
                {
                    iMixLetterLength = iLength;
                }
            }
            if (iMixLetterLength == 1 && iMaxLetterLength == 1) {
                ;
            }
            else if (iMixLetterLength == 1 && iMaxLetterLength == 2)
            {
                ;
            }
            else if (iMixLetterLength == 2 && iMaxLetterLength == 2)
            {
                if (iKeySize % 2 != 0)
                {
                    MessageBox.Show("Please enter a multiple of 2 !", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    this.TextBox_OtherBytes.Focus();
                    return;
                }
            }
            else if (iMixLetterLength == 2 && iMaxLetterLength == 3)
            {
                ;
            }

            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            int iRandomKeyLength = 0;
            do
            {
                int index = random.Next(iKeySeedLength);

                int iLength = Encoding.Default.GetByteCount(strKeySeed[index].ToString());
                if (iRandomKeyLength + iLength > iKeySize)
                {
                    continue;
                }
                else
                {
                    sb.Append(strKeySeed[index]);
                    iRandomKeyLength += iLength;
                }

            } while (iRandomKeyLength < iKeySize);

            this.TextBox_RandomKey.Text = sb.ToString();
            this.TextBox_RandomKey.ForeColor = Color.Red;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void GetKeySeedString()
        {
            string strRet = string.Empty;
            if (this.CheckBox_Half_UppercaseLetters.Checked == true)
            {
                strRet += KEY_SET_HALT_UPPERCASE_LETTERS;
            }
            if (this.CheckBox_Half_LowercaseLetters.Checked == true)
            {
                strRet += KEY_SET_HALT_LOWERCASE_LETTERS;
            }
            if (this.CheckBox_Half_Numbers.Checked == true)
            {
                strRet += KEY_SET_HALT_NUMBERS;
            }
            if (this.CheckBox_Halt_Special_Characters.Checked == true)
            {
                strRet += KEY_SET_HALT_SPECIAL_CHARACTERS;
            }
            if (this.CheckBox_Halt_Katakana.Checked == true)
            {
                strRet += KEY_SET_HALT_KATAKANA;
            }
            if (this.CheckBox_Full_Uppercase_Letters.Checked == true)
            {
                strRet += KEY_SET_FULL_UPPERCASE_LETTERS;
            }
            if (this.CheckBox_Full_Lowercase_Letters.Checked == true)
            {
                strRet += KEY_SET_FULL_LOWERCASE_LETTERS;
            }
            if (this.CheckBox_Full_Numbers.Checked == true)
            {
                strRet += KEY_SET_FULL_NUMBERS;
            }
            if (this.CheckBox_Full_Special_Characters.Checked == true)
            {
                strRet += KEY_SET_FULL_SPECIAL_CHARACTERS;
            }
            if (this.CheckBox_Full_Hiragana.Checked == true)
            {
                strRet += KEY_SET_FULL_HIRAGANA;
            }
            if (this.CheckBox_Full_Katakana.Checked == true)
            {
                strRet += KEY_SET_FULL_KATAKANA;
            }
            if (this.CheckBox_KeySet_TheOthersChars.Checked == true)
            {
                strRet += this.TextBox_TheOtherChars.Text;
            }

            this.TextBox_KeySeed.Text = strRet;
        }
    }
}
