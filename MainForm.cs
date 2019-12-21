using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PassGenerator
{
    public partial class MainForm : Form
    {
        #region .ctor

        List<char> _alfavitAZ;
        List<char> _alfavitАЯ;
        readonly List<char> _numbers;

        readonly Timer _tmrInvalidate;

        public MainForm()
        {
            InitializeComponent();

            _alfavitAZ = new List<char>();
            _alfavitАЯ = new List<char>();
            _numbers = new List<char>();

            {
                int i = 0;
                for (char ch = 'A', ch1 = 'А'; ch <= 'Z' || ch1 <= 'Я'; ch++, ch1++)
                {
                    if (ch <= 'Z')
                    {
                        _alfavitAZ.Add(ch);
                    }

                    if (ch1 <= 'Я')
                    {
                        _alfavitАЯ.Add(ch1);
                    }

                    if (i < 10)
                    {
                        _numbers.Add(i.ToString()[0]);
                        i++;
                    }
                }
            }

            ApplyAllRegisrers();

            _tmrInvalidate = new Timer {Interval = 1000};
            _tmrInvalidate.Tick += _tmrInvalidate_Tick;
        }


        void ApplyAllRegisrers()
        {
            ApplyRegister(chkRegisterAZ, ref _alfavitAZ);
            ApplyRegister(chkRegisterАЯ, ref _alfavitАЯ);
        }


        void ShowAlfavites()
        {
            txtAlfavitAZ.Text = new StringBuilder().Append(_alfavitAZ.ToArray()).ToString();
            txtAlfavitАЯ.Text = new StringBuilder().Append(_alfavitАЯ.ToArray()).ToString();
            txtNumeric10.Text = new StringBuilder().Append(_numbers.ToArray()).ToString();
        }

        void _tmrInvalidate_Tick(object sender, EventArgs e)
        {
            _tmrInvalidate.Stop();
            chkRandomRatio.Checked = false;
            chkRandomRatio.Checked = true;
        }

       
        private void MainForm_Load(object sender, EventArgs e)
        {
            _tmrInvalidate.Start();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:SharpDeveloper@yandex.ru");
        }
        #endregion

        #region Переключение режимов генерации
        private void rbtnRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RandomSettingsEnabled(true);
            }
        }
        private void rbtnRandom_Click(object sender, EventArgs e)
        {
            SetPreRandomChars();
        }
        private void rbnGUID_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RandomSettingsEnabled(false);
            }
        }
        private void rbnGUID_Click(object sender, EventArgs e)
        {
            txtName.Text = Guid.NewGuid().ToString();
        }
        #endregion

        #region Interface Random Maintain
        private void RandomSettingsEnabled(bool enabled)
        {

            chkRandomRatio.Enabled = enabled;

            
            chkUse10.Enabled = enabled && (GetCountUseChecks() > 1 || !chkUse10.Checked);
            chkUseAZ.Enabled = enabled && (GetCountUseChecks() > 1 || !chkUseAZ.Checked);
            chkUseАЯ.Enabled = enabled && (GetCountUseChecks() > 1 || !chkUseАЯ.Checked);
            chkCustom.Enabled = enabled && (GetCountUseChecks() > 1 || !chkCustom.Checked);
          
            chkRandomCustomChars.Enabled = (!chkRandomRatio.Checked || !chkCustom.Checked) && rbtnRandom.Checked;
            if (chkRandomRatio.Checked && chkCustom.Checked)
            {
                chkRandomCustomChars.Checked = true;
            }

            numUse10.Enabled = (!chkRandomRatio.Checked || !chkUse10.Checked)&&rbtnRandom.Checked;
            numUseAZ.Enabled = (!chkRandomRatio.Checked|| !chkUseAZ.Checked)&&rbtnRandom.Checked;
            numUseАЯ.Enabled = (!chkRandomRatio.Checked|| !chkUseАЯ.Checked)&&rbtnRandom.Checked;
            numUseCustom.Enabled = (!chkRandomRatio.Checked || !chkCustom.Checked) && rbtnRandom.Checked;
            numGenericLenght.Enabled = enabled;

            txtCustomChars.Enabled = enabled;
            txtCurChars.Enabled = enabled;

            btnGenerateRandomName.Enabled = enabled;
            btnGenRandomNameEx.Enabled = enabled;

            
        }

        private void VerifyCheckUse(CheckBox chk)
        {
            if (chkRandomRatio.Checked)
            {
                if (GetCountUseChecks() == 0)
                {
                    chk.Enabled = false;
                }
                else
                {
                    chk.Enabled = true;
                }
            }
        }
        private void chkUseAZ_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRandomRatio.Checked)
            {
                VerifyCheckUse((CheckBox)sender);
                if (!RandomizeRatioCharSet()) chkUseAZ.Checked = true;
            }
            ApplyRandomCharsSettings();
        }
        private void chkUse10_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRandomRatio.Checked)
            {
                VerifyCheckUse((CheckBox)sender);
                if (!RandomizeRatioCharSet()) chkUse10.Checked = true;
            }
            ApplyRandomCharsSettings();
        }

        private void chkUseАЯ_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRandomRatio.Checked)
            {
                VerifyCheckUse((CheckBox)sender);
                if (!RandomizeRatioCharSet()) chkUseАЯ.Checked = true;
            }
            ApplyRandomCharsSettings();
        }
        private void numUseAZ_ValueChanged(object sender, EventArgs e)
        {
           
            ApplyRandomCharsSettings();
        }

        private void numUse10_ValueChanged(object sender, EventArgs e)
        {
            ApplyRandomCharsSettings();
        }

        private void numUseАЯ_ValueChanged(object sender, EventArgs e)
        {
            ApplyRandomCharsSettings();
        }
        private void txtCustomChars_TextChanged(object sender, EventArgs e)
        {
            SetPreRandomChars();
        }
        private void chkCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRandomRatio.Checked)
            {
                VerifyCheckUse((CheckBox)sender);
                if (!RandomizeRatioCharSet()) chkCustom.Checked = true;
            }
            ApplyRandomCharsSettings();
        }
        private void numUseCustom_ValueChanged(object sender, EventArgs e)
        {
            SetPreRandomChars();
        }
        private void chkRandomCustomChars_CheckedChanged(object sender, EventArgs e)
        {
            SetPreRandomChars();
        }

        private void ApplyRandomCharsSettings()
        {
            SetPreRandomChars();
            RandomSettingsEnabled(true);
        }
        private void btnGenRandomNameEx_Click(object sender, EventArgs e)
        {
            PrepareRegister(chkRegisterAZ, chkUseAZ, ref _alfavitAZ);
            PrepareRegister(chkRegisterАЯ, chkUseАЯ, ref _alfavitАЯ);

            RandomizeRatioCharSet();
            SetPreRandomChars();
            GenerateName(new List<char>(txtCurChars.Text.ToCharArray()));
        }

        private void PrepareRegister(CheckBox regState, CheckBox useAlfavit,ref List<char> alfavit)
        {
            if (useAlfavit.Checked && GetRegisterState(regState.CheckState) == RegisterState.Random)
                ApplyRegister(regState, ref alfavit);
        }

        private void chkRandomRatio_CheckedChanged(object sender, EventArgs e)
        {
            RandomSettingsEnabled(true);

            RandomizeRatioCharSet();
        }

        private void numGenericLenght_ValueChanged(object sender, EventArgs e)
        {
            if (chkRandomRatio.Checked) RandomizeRatioCharSet();
        }

        private void txtCurChars_TextChanged(object sender, EventArgs e)
        {
            ShowPassInfo();
        }

        private int GetCountUseChecks()
        {
            int count = 0;

            if (chkUse10.Checked) count++;
            if (chkUseAZ.Checked) count++;
            if (chkUseАЯ.Checked) count++;
            if (chkCustom.Checked) count++;

            numGenericLenght.Minimum = count;
            if (numGenericLenght.Value < numGenericLenght.Minimum)
            {
                numGenericLenght.Value = numGenericLenght.Minimum;
            }

            return count;
        }
        #endregion

        #region Kernel
        private void SetPreRandomChars()
        {
            var preRandomChars = new List<char>();

            txtCurChars.Text = "";

            if (chkUseAZ.Checked)
            {
                preRandomChars.AddRange(
                    GetRandomChars((uint)numUseAZ.Value, _alfavitAZ.ToArray()));
            }

            if (chkUse10.Checked)
            {
                preRandomChars.AddRange(
                    GetRandomChars((uint)numUse10.Value, _numbers.ToArray()));
            }

            if (chkUseАЯ.Checked)
            {
                preRandomChars.AddRange(
                    GetRandomChars((uint)numUseАЯ.Value, _alfavitАЯ.ToArray()));
            }

            if (chkCustom.Checked)
            {
                if (chkRandomCustomChars.Checked && txtCustomChars.Text != "")
                {
                    preRandomChars.AddRange(
                        GetRandomChars((uint)numUseCustom.Value, txtCustomChars.Text.ToCharArray()));
                }
                else
                {
                    preRandomChars.AddRange(txtCustomChars.Text.ToCharArray());
                }
            }

            txtCurChars.Text = new StringBuilder().Append(preRandomChars.ToArray()).ToString();
            ShowPassInfo();
        }
        private void ShowPassInfo()
        {
            lblPassInfo.Text = string.Format("{0} characters long", txtCurChars.Text.Length);
        }
        private void GenerateName(IList<char> preRandomChars)
        {
            var name = new char[preRandomChars.Count];

            int[] randomIndexex = GetRandomIndexes(0, preRandomChars.Count - 1);

            for (int i = 0; i < randomIndexex.Length; i++)
            {
                name[i] = preRandomChars[randomIndexex[i]];
            }

            txtName.Text = new StringBuilder().Append(name).ToString();
        }

        private char[] GetRandomChars(uint count, char[] chars)
        {
            var rchars = new List<char>();
            var r = new Random();
            int rIndex;
            for (int i = 0; i < count; i++)
            {
                rIndex = r.Next(0, chars.Length);
                rchars.Add(chars[rIndex]);
            }

            return rchars.ToArray();
        }
        private int[] GetRandomIndexes(int start, int end)
        {
            if (start > end) throw new ArgumentOutOfRangeException();
            var r = new Random();
            var randomIndexes = new List<int>();
            int count = end - start + 1;
            while (randomIndexes.Count < count)
            {
                int i = r.Next(start, end + 1);
                if (!randomIndexes.Contains(i))
                {
                    randomIndexes.Add(i);
                }
            }

            return randomIndexes.ToArray();
        }


        private void btnGenerateRandomName_Click(object sender, EventArgs e)
        {
            if (txtCurChars.Text != "")
            {
                GenerateName(new List<char>(txtCurChars.Text.ToCharArray()));
            }
            else
            {
                MessageBox.Show("Generate password function be in need of characters from \"current chars\" window", "PassGenerator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool RandomizeRatioCharSet()
        {
            if (!chkRandomRatio.Checked) return true;

            var charset = new List<KeyValuePair<string, int>>();
            if (chkUseAZ.Checked) charset.Add(new KeyValuePair<string, int>(numUseAZ.Name, 1));
            if (chkUseАЯ.Checked) charset.Add(new KeyValuePair<string, int>(numUseАЯ.Name, 1));
            if (chkUse10.Checked) charset.Add(new KeyValuePair<string, int>(numUse10.Name, 1));
            if (chkCustom.Checked && txtCustomChars.Text != "") charset.Add(new KeyValuePair<string, int>(numUseCustom.Name, 1));

            if (charset.Count == 0)
            {
                MessageBox.Show("Randomize ratio need even if one chars set", "PassGenerator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int[] rIndexes = GetRandomIndexes(0, charset.Count - 1);

            var rCharset = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < rIndexes.Length; i++)
            {
                rCharset.Add(charset[rIndexes[i]]);
            }

            var genCount = (short)numGenericLenght.Value;

            var r = new Random();
            //текущее количество незанятых позиций в пароле.
            short curPositionsCount = genCount;
            //текущее количество оставшихся наборов символов 
            //с неприсвоенным значением доли символов в пароле
            int curCharSetsCount = rCharset.Count;
            //текущее максимальное значение доли символов в пароле,
            //которое может быть присвоено 
            //текущему набору символов
            int maxRatioValue;
            for (int i = 0; i < rCharset.Count; i++)
            {
                curCharSetsCount = rCharset.Count - (i + 1);

                if (curCharSetsCount < curPositionsCount)
                {
                    maxRatioValue = curPositionsCount - curCharSetsCount;
                    rCharset[i] = new KeyValuePair<string, int>(rCharset[i].Key,
                        r.Next(1, maxRatioValue));
                }
                else if (curCharSetsCount > curPositionsCount)
                {
                    MessageBox.Show("Generic length less then char sets count");
                    return false;
                }
                ((NumericUpDown)grpOptions.Controls[rCharset[i].Key]).Value = rCharset[i].Value;

                curPositionsCount -= (short)rCharset[i].Value;
            }


            if (curPositionsCount != 0)
            {
                int rCorrectIndex = new Random().Next(0, rCharset.Count - 1);
                rCharset[rCorrectIndex] = new KeyValuePair<string, int>(
                rCharset[rCorrectIndex].Key,
                rCharset[rCorrectIndex].Value + curPositionsCount);

                ((NumericUpDown)grpOptions.Controls[rCharset[rCorrectIndex].Key]).Value = rCharset[rCorrectIndex].Value;

                ShowRandomRatioInfo("CheckSum was corrected", Color.Green);
            }

            //checksum 
            int checksum = 0;

#if DEBUG
            //verify in DEBUG only
            checksum = 0;
            foreach (KeyValuePair<string, int> pair in rCharset)
            {
                checksum += pair.Value;
            }
            if (checksum != genCount)
            {
                ShowRandomRatioInfo("CheckSum NOT passed", Color.Red);
                return false;
            }
#endif

            return true;
        }
        private void ShowRandomRatioInfo(string info, Color color)
        {
            lblRandomRatioInfo.Visible = true;
            lblRandomRatioInfo.Text = info;
            lblRandomRatioInfo.ForeColor = color;
        }
        #endregion

   
        private void chkRegisterAZ_CheckStateChanged(object sender, EventArgs e)
        {
            ApplyRegister((CheckBox)sender, ref _alfavitAZ);
        }

        private void chkRegisterАЯ_CheckStateChanged(object sender, EventArgs e)
        {
            ApplyRegister((CheckBox)sender, ref _alfavitАЯ);
        }

        

        void ApplyRegister(CheckBox chk,ref List<char> alfavit)
        {
            RegisterState regState = GetRegisterState(chk.CheckState);
            alfavit = SetRegister(alfavit, regState);
            switch (regState)
            {
                case RegisterState.Up:
                    chk.Text = "Upper case";
                    break;
                case RegisterState.Down:
                    chk.Text = "Lower case";
                    break;
                case RegisterState.Random:
                    chk.Text = "Case randomize";
                    break;
            }

            ShowAlfavites();
        }


        RegisterState GetRegisterState(CheckState state)
        {
            switch (state)
            {
                case CheckState.Checked:
                    return RegisterState.Up;
                case CheckState.Unchecked:
                    return RegisterState.Down;
                case CheckState.Indeterminate:
                    return RegisterState.Random;
            }

            return RegisterState.Up;
        }

        List<char> SetRegister(IEnumerable<char> inData, RegisterState state)
        {
            var outData = new List<char>();
            var rnd = new Random(Guid.NewGuid().GetHashCode());

            foreach (var ch in inData)
            {
                switch (state)
                {
                    case RegisterState.Up:
                        outData.Add(char.ToUpper(ch));
                        break;
                    case RegisterState.Down:
                        outData.Add(char.ToLower(ch));
                        break;
                    case RegisterState.Random:
                        if (rnd.Next(0, 2) == 0)
                            outData.Add(char.ToLower(ch));
                        else
                            outData.Add(char.ToUpper(ch));
                        break;
                }
            }

            return outData;
        }
    }

    enum RegisterState
    {
        Up,
        Down,
        Random
    }
}