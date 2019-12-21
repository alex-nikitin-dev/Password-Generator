namespace PassGenerator
{
    partial class MainForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbnGUID = new System.Windows.Forms.RadioButton();
            this.rbtnRandom = new System.Windows.Forms.RadioButton();
            this.chkUseAZ = new System.Windows.Forms.CheckBox();
            this.chkUse10 = new System.Windows.Forms.CheckBox();
            this.numUseAZ = new System.Windows.Forms.NumericUpDown();
            this.numUse10 = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateRandomName = new System.Windows.Forms.Button();
            this.numUseАЯ = new System.Windows.Forms.NumericUpDown();
            this.chkUseАЯ = new System.Windows.Forms.CheckBox();
            this.txtCurChars = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCustom = new System.Windows.Forms.CheckBox();
            this.txtCustomChars = new System.Windows.Forms.TextBox();
            this.chkRandomCustomChars = new System.Windows.Forms.CheckBox();
            this.btnGenRandomNameEx = new System.Windows.Forms.Button();
            this.chkRandomRatio = new System.Windows.Forms.CheckBox();
            this.numGenericLenght = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRandomRatioInfo = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkRegisterАЯ = new System.Windows.Forms.CheckBox();
            this.chkRegisterAZ = new System.Windows.Forms.CheckBox();
            this.lblPassInfo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlfavitAZ = new System.Windows.Forms.TextBox();
            this.txtAlfavitАЯ = new System.Windows.Forms.TextBox();
            this.txtNumeric10 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numUseCustom = new System.Windows.Forms.NumericUpDown();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numUseAZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUse10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUseАЯ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenericLenght)).BeginInit();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUseCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.LightGray;
            this.btnExit.Location = new System.Drawing.Point(604, 605);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightGray;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(17, 52);
            this.txtName.Name = "txtName";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtName.Size = new System.Drawing.Size(711, 29);
            this.txtName.TabIndex = 3;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(316, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // rbnGUID
            // 
            this.rbnGUID.AutoSize = true;
            this.rbnGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbnGUID.Location = new System.Drawing.Point(24, 29);
            this.rbnGUID.Name = "rbnGUID";
            this.rbnGUID.Size = new System.Drawing.Size(322, 17);
            this.rbnGUID.TabIndex = 5;
            this.rbnGUID.Text = "GUID(Create password by Globally Unique Identifier)";
            this.rbnGUID.UseVisualStyleBackColor = true;
            this.rbnGUID.Click += new System.EventHandler(this.rbnGUID_Click);
            this.rbnGUID.CheckedChanged += new System.EventHandler(this.rbnGUID_CheckedChanged);
            // 
            // rbtnRandom
            // 
            this.rbtnRandom.AutoSize = true;
            this.rbtnRandom.Checked = true;
            this.rbtnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnRandom.Location = new System.Drawing.Point(24, 52);
            this.rbtnRandom.Name = "rbtnRandom";
            this.rbtnRandom.Size = new System.Drawing.Size(71, 17);
            this.rbtnRandom.TabIndex = 6;
            this.rbtnRandom.TabStop = true;
            this.rbtnRandom.Text = "Random";
            this.rbtnRandom.UseVisualStyleBackColor = true;
            this.rbtnRandom.Click += new System.EventHandler(this.rbtnRandom_Click);
            this.rbtnRandom.CheckedChanged += new System.EventHandler(this.rbtnRandom_CheckedChanged);
            // 
            // chkUseAZ
            // 
            this.chkUseAZ.AutoSize = true;
            this.chkUseAZ.Checked = true;
            this.chkUseAZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseAZ.Location = new System.Drawing.Point(51, 151);
            this.chkUseAZ.Name = "chkUseAZ";
            this.chkUseAZ.Size = new System.Drawing.Size(71, 17);
            this.chkUseAZ.TabIndex = 7;
            this.chkUseAZ.Text = "Use A - Z";
            this.chkUseAZ.UseVisualStyleBackColor = true;
            this.chkUseAZ.CheckedChanged += new System.EventHandler(this.chkUseAZ_CheckedChanged);
            // 
            // chkUse10
            // 
            this.chkUse10.AutoSize = true;
            this.chkUse10.Checked = true;
            this.chkUse10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUse10.Location = new System.Drawing.Point(51, 203);
            this.chkUse10.Name = "chkUse10";
            this.chkUse10.Size = new System.Drawing.Size(69, 17);
            this.chkUse10.TabIndex = 8;
            this.chkUse10.Text = "Use 1 - 0";
            this.chkUse10.UseVisualStyleBackColor = true;
            this.chkUse10.CheckedChanged += new System.EventHandler(this.chkUse10_CheckedChanged);
            // 
            // numUseAZ
            // 
            this.numUseAZ.BackColor = System.Drawing.Color.LightGray;
            this.numUseAZ.Enabled = false;
            this.numUseAZ.Location = new System.Drawing.Point(148, 149);
            this.numUseAZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUseAZ.Name = "numUseAZ";
            this.numUseAZ.Size = new System.Drawing.Size(120, 20);
            this.numUseAZ.TabIndex = 12;
            this.numUseAZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUseAZ.ValueChanged += new System.EventHandler(this.numUseAZ_ValueChanged);
            // 
            // numUse10
            // 
            this.numUse10.BackColor = System.Drawing.Color.LightGray;
            this.numUse10.Enabled = false;
            this.numUse10.Location = new System.Drawing.Point(148, 201);
            this.numUse10.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUse10.Name = "numUse10";
            this.numUse10.Size = new System.Drawing.Size(120, 20);
            this.numUse10.TabIndex = 13;
            this.numUse10.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUse10.ValueChanged += new System.EventHandler(this.numUse10_ValueChanged);
            // 
            // btnGenerateRandomName
            // 
            this.btnGenerateRandomName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateRandomName.ForeColor = System.Drawing.Color.Silver;
            this.btnGenerateRandomName.Location = new System.Drawing.Point(224, 423);
            this.btnGenerateRandomName.Name = "btnGenerateRandomName";
            this.btnGenerateRandomName.Size = new System.Drawing.Size(262, 22);
            this.btnGenerateRandomName.TabIndex = 14;
            this.btnGenerateRandomName.Text = "Generate random pass without new chars";
            this.btnGenerateRandomName.UseVisualStyleBackColor = false;
            this.btnGenerateRandomName.Click += new System.EventHandler(this.btnGenerateRandomName_Click);
            // 
            // numUseАЯ
            // 
            this.numUseАЯ.BackColor = System.Drawing.Color.LightGray;
            this.numUseАЯ.Enabled = false;
            this.numUseАЯ.Location = new System.Drawing.Point(148, 175);
            this.numUseАЯ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUseАЯ.Name = "numUseАЯ";
            this.numUseАЯ.Size = new System.Drawing.Size(120, 20);
            this.numUseАЯ.TabIndex = 17;
            this.numUseАЯ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUseАЯ.ValueChanged += new System.EventHandler(this.numUseАЯ_ValueChanged);
            // 
            // chkUseАЯ
            // 
            this.chkUseАЯ.AutoSize = true;
            this.chkUseАЯ.Location = new System.Drawing.Point(51, 177);
            this.chkUseАЯ.Name = "chkUseАЯ";
            this.chkUseАЯ.Size = new System.Drawing.Size(72, 17);
            this.chkUseАЯ.TabIndex = 16;
            this.chkUseАЯ.Text = "Use А - Я";
            this.chkUseАЯ.UseVisualStyleBackColor = true;
            this.chkUseАЯ.CheckedChanged += new System.EventHandler(this.chkUseАЯ_CheckedChanged);
            // 
            // txtCurChars
            // 
            this.txtCurChars.BackColor = System.Drawing.Color.LightGray;
            this.txtCurChars.Location = new System.Drawing.Point(218, 295);
            this.txtCurChars.Multiline = true;
            this.txtCurChars.Name = "txtCurChars";
            this.txtCurChars.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCurChars.Size = new System.Drawing.Size(275, 72);
            this.txtCurChars.TabIndex = 18;
            this.txtCurChars.TextChanged += new System.EventHandler(this.txtCurChars_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Current chars:";
            // 
            // chkCustom
            // 
            this.chkCustom.AutoSize = true;
            this.chkCustom.Location = new System.Drawing.Point(51, 229);
            this.chkCustom.Name = "chkCustom";
            this.chkCustom.Size = new System.Drawing.Size(61, 17);
            this.chkCustom.TabIndex = 20;
            this.chkCustom.Text = "Custom";
            this.chkCustom.UseVisualStyleBackColor = true;
            this.chkCustom.CheckedChanged += new System.EventHandler(this.chkCustom_CheckedChanged);
            // 
            // txtCustomChars
            // 
            this.txtCustomChars.BackColor = System.Drawing.Color.LightGray;
            this.txtCustomChars.Location = new System.Drawing.Point(277, 229);
            this.txtCustomChars.Name = "txtCustomChars";
            this.txtCustomChars.Size = new System.Drawing.Size(150, 20);
            this.txtCustomChars.TabIndex = 21;
            this.txtCustomChars.Text = "~!@#$%^&*()}{][";
            this.txtCustomChars.TextChanged += new System.EventHandler(this.txtCustomChars_TextChanged);
            // 
            // chkRandomCustomChars
            // 
            this.chkRandomCustomChars.AutoSize = true;
            this.chkRandomCustomChars.Checked = true;
            this.chkRandomCustomChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomCustomChars.Location = new System.Drawing.Point(433, 232);
            this.chkRandomCustomChars.Name = "chkRandomCustomChars";
            this.chkRandomCustomChars.Size = new System.Drawing.Size(132, 17);
            this.chkRandomCustomChars.TabIndex = 22;
            this.chkRandomCustomChars.Text = "Random custom chars";
            this.chkRandomCustomChars.UseVisualStyleBackColor = true;
            this.chkRandomCustomChars.CheckedChanged += new System.EventHandler(this.chkRandomCustomChars_CheckedChanged);
            // 
            // btnGenRandomNameEx
            // 
            this.btnGenRandomNameEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenRandomNameEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenRandomNameEx.ForeColor = System.Drawing.Color.Tomato;
            this.btnGenRandomNameEx.Location = new System.Drawing.Point(224, 451);
            this.btnGenRandomNameEx.Name = "btnGenRandomNameEx";
            this.btnGenRandomNameEx.Size = new System.Drawing.Size(262, 45);
            this.btnGenRandomNameEx.TabIndex = 23;
            this.btnGenRandomNameEx.Text = "Generate random password";
            this.btnGenRandomNameEx.UseVisualStyleBackColor = false;
            this.btnGenRandomNameEx.Click += new System.EventHandler(this.btnGenRandomNameEx_Click);
            // 
            // chkRandomRatio
            // 
            this.chkRandomRatio.AutoSize = true;
            this.chkRandomRatio.Checked = true;
            this.chkRandomRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomRatio.Location = new System.Drawing.Point(51, 101);
            this.chkRandomRatio.Name = "chkRandomRatio";
            this.chkRandomRatio.Size = new System.Drawing.Size(89, 17);
            this.chkRandomRatio.TabIndex = 24;
            this.chkRandomRatio.Text = "Random ratio";
            this.chkRandomRatio.UseVisualStyleBackColor = true;
            this.chkRandomRatio.CheckedChanged += new System.EventHandler(this.chkRandomRatio_CheckedChanged);
            // 
            // numGenericLenght
            // 
            this.numGenericLenght.BackColor = System.Drawing.Color.LightGray;
            this.numGenericLenght.Location = new System.Drawing.Point(148, 101);
            this.numGenericLenght.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numGenericLenght.Name = "numGenericLenght";
            this.numGenericLenght.Size = new System.Drawing.Size(120, 20);
            this.numGenericLenght.TabIndex = 25;
            this.numGenericLenght.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numGenericLenght.ValueChanged += new System.EventHandler(this.numGenericLenght_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Count:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Char set:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "(Generic lenght)";
            // 
            // lblRandomRatioInfo
            // 
            this.lblRandomRatioInfo.AutoSize = true;
            this.lblRandomRatioInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRandomRatioInfo.Location = new System.Drawing.Point(362, 103);
            this.lblRandomRatioInfo.Name = "lblRandomRatioInfo";
            this.lblRandomRatioInfo.Size = new System.Drawing.Size(29, 13);
            this.lblRandomRatioInfo.TabIndex = 29;
            this.lblRandomRatioInfo.Text = "Info";
            this.lblRandomRatioInfo.Visible = false;
            // 
            // grpOptions
            // 
            this.grpOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpOptions.Controls.Add(this.chkRegisterАЯ);
            this.grpOptions.Controls.Add(this.chkRegisterAZ);
            this.grpOptions.Controls.Add(this.lblPassInfo);
            this.grpOptions.Controls.Add(this.label10);
            this.grpOptions.Controls.Add(this.label9);
            this.grpOptions.Controls.Add(this.label8);
            this.grpOptions.Controls.Add(this.btnGenRandomNameEx);
            this.grpOptions.Controls.Add(this.txtAlfavitAZ);
            this.grpOptions.Controls.Add(this.txtAlfavitАЯ);
            this.grpOptions.Controls.Add(this.txtNumeric10);
            this.grpOptions.Controls.Add(this.label3);
            this.grpOptions.Controls.Add(this.btnGenerateRandomName);
            this.grpOptions.Controls.Add(this.label1);
            this.grpOptions.Controls.Add(this.numUseCustom);
            this.grpOptions.Controls.Add(this.rbnGUID);
            this.grpOptions.Controls.Add(this.lblRandomRatioInfo);
            this.grpOptions.Controls.Add(this.rbtnRandom);
            this.grpOptions.Controls.Add(this.label7);
            this.grpOptions.Controls.Add(this.chkUseAZ);
            this.grpOptions.Controls.Add(this.label6);
            this.grpOptions.Controls.Add(this.chkUse10);
            this.grpOptions.Controls.Add(this.label5);
            this.grpOptions.Controls.Add(this.numUseAZ);
            this.grpOptions.Controls.Add(this.numGenericLenght);
            this.grpOptions.Controls.Add(this.numUse10);
            this.grpOptions.Controls.Add(this.chkRandomRatio);
            this.grpOptions.Controls.Add(this.chkUseАЯ);
            this.grpOptions.Controls.Add(this.numUseАЯ);
            this.grpOptions.Controls.Add(this.chkRandomCustomChars);
            this.grpOptions.Controls.Add(this.txtCurChars);
            this.grpOptions.Controls.Add(this.txtCustomChars);
            this.grpOptions.Controls.Add(this.label4);
            this.grpOptions.Controls.Add(this.chkCustom);
            this.grpOptions.ForeColor = System.Drawing.Color.Silver;
            this.grpOptions.Location = new System.Drawing.Point(17, 97);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(711, 502);
            this.grpOptions.TabIndex = 30;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkRegisterАЯ
            // 
            this.chkRegisterАЯ.AutoSize = true;
            this.chkRegisterАЯ.Checked = true;
            this.chkRegisterАЯ.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkRegisterАЯ.Location = new System.Drawing.Point(571, 177);
            this.chkRegisterАЯ.Name = "chkRegisterАЯ";
            this.chkRegisterАЯ.Size = new System.Drawing.Size(81, 17);
            this.chkRegisterАЯ.TabIndex = 41;
            this.chkRegisterАЯ.Text = "Lower case";
            this.chkRegisterАЯ.ThreeState = true;
            this.chkRegisterАЯ.UseVisualStyleBackColor = true;
            this.chkRegisterАЯ.CheckStateChanged += new System.EventHandler(this.chkRegisterАЯ_CheckStateChanged);

            // 
            // chkRegisterAZ
            // 
            this.chkRegisterAZ.AutoSize = true;
            this.chkRegisterAZ.Checked = true;
            this.chkRegisterAZ.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkRegisterAZ.Location = new System.Drawing.Point(571, 150);
            this.chkRegisterAZ.Name = "chkRegisterAZ";
            this.chkRegisterAZ.Size = new System.Drawing.Size(81, 17);
            this.chkRegisterAZ.TabIndex = 40;
            this.chkRegisterAZ.Text = "Lower case";
            this.chkRegisterAZ.ThreeState = true;
            this.chkRegisterAZ.UseVisualStyleBackColor = true;
            this.chkRegisterAZ.CheckStateChanged += new System.EventHandler(this.chkRegisterAZ_CheckStateChanged);

            // 
            // lblPassInfo
            // 
            this.lblPassInfo.AutoSize = true;
            this.lblPassInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassInfo.ForeColor = System.Drawing.Color.Tomato;
            this.lblPassInfo.Location = new System.Drawing.Point(352, 387);
            this.lblPassInfo.Name = "lblPassInfo";
            this.lblPassInfo.Size = new System.Drawing.Size(12, 17);
            this.lblPassInfo.TabIndex = 39;
            this.lblPassInfo.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(218, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "password features:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(43, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Step III";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Visual:";
            // 
            // txtAlfavitAZ
            // 
            this.txtAlfavitAZ.BackColor = System.Drawing.Color.LightGray;
            this.txtAlfavitAZ.Location = new System.Drawing.Point(277, 149);
            this.txtAlfavitAZ.Name = "txtAlfavitAZ";
            this.txtAlfavitAZ.ReadOnly = true;
            this.txtAlfavitAZ.Size = new System.Drawing.Size(288, 20);
            this.txtAlfavitAZ.TabIndex = 35;
            // 
            // txtAlfavitАЯ
            // 
            this.txtAlfavitАЯ.BackColor = System.Drawing.Color.LightGray;
            this.txtAlfavitАЯ.Location = new System.Drawing.Point(277, 175);
            this.txtAlfavitАЯ.Name = "txtAlfavitАЯ";
            this.txtAlfavitАЯ.ReadOnly = true;
            this.txtAlfavitАЯ.Size = new System.Drawing.Size(288, 20);
            this.txtAlfavitАЯ.TabIndex = 34;
            // 
            // txtNumeric10
            // 
            this.txtNumeric10.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeric10.Location = new System.Drawing.Point(277, 200);
            this.txtNumeric10.Name = "txtNumeric10";
            this.txtNumeric10.ReadOnly = true;
            this.txtNumeric10.Size = new System.Drawing.Size(288, 20);
            this.txtNumeric10.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Step II";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Step I";
            // 
            // numUseCustom
            // 
            this.numUseCustom.BackColor = System.Drawing.Color.LightGray;
            this.numUseCustom.Location = new System.Drawing.Point(148, 229);
            this.numUseCustom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUseCustom.Name = "numUseCustom";
            this.numUseCustom.Size = new System.Drawing.Size(120, 20);
            this.numUseCustom.TabIndex = 30;
            this.numUseCustom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUseCustom.ValueChanged += new System.EventHandler(this.numUseCustom_ValueChanged);
            // 
            // lnkAbout
            // 
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lnkAbout.Location = new System.Drawing.Point(656, 9);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(72, 13);
            this.lnkAbout.TabIndex = 31;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "Mail to Author";
            this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(740, 640);
            this.Controls.Add(this.lnkAbout);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Password Creator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUseAZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUse10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUseАЯ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenericLenght)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUseCustom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbnGUID;
        private System.Windows.Forms.RadioButton rbtnRandom;
        private System.Windows.Forms.CheckBox chkUseAZ;
        private System.Windows.Forms.CheckBox chkUse10;
        private System.Windows.Forms.NumericUpDown numUseAZ;
        private System.Windows.Forms.NumericUpDown numUse10;
        private System.Windows.Forms.Button btnGenerateRandomName;
        private System.Windows.Forms.NumericUpDown numUseАЯ;
        private System.Windows.Forms.CheckBox chkUseАЯ;
        private System.Windows.Forms.TextBox txtCurChars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCustom;
        private System.Windows.Forms.TextBox txtCustomChars;
        private System.Windows.Forms.CheckBox chkRandomCustomChars;
        private System.Windows.Forms.Button btnGenRandomNameEx;
        private System.Windows.Forms.CheckBox chkRandomRatio;
        private System.Windows.Forms.NumericUpDown numGenericLenght;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRandomRatioInfo;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.NumericUpDown numUseCustom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlfavitAZ;
        private System.Windows.Forms.TextBox txtAlfavitАЯ;
        private System.Windows.Forms.TextBox txtNumeric10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPassInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lnkAbout;
        private System.Windows.Forms.CheckBox chkRegisterАЯ;
        private System.Windows.Forms.CheckBox chkRegisterAZ;
    }
}

