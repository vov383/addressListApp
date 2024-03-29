﻿namespace addressListApp
{
    partial class InsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertForm));
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxHpNum = new System.Windows.Forms.TextBox();
            this.label_hp = new System.Windows.Forms.Label();
            this.textBoxComNum = new System.Windows.Forms.TextBox();
            this.label_com_num = new System.Windows.Forms.Label();
            this.textBoxPositionRank = new System.Windows.Forms.TextBox();
            this.label_rank = new System.Windows.Forms.Label();
            this.textBoxDept = new System.Windows.Forms.TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.label_dept = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.btnInsertSubmit = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.deptLabel = new System.Windows.Forms.Label();
            this.deptCBox = new System.Windows.Forms.ComboBox();
            this.rankLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBoxGender.Location = new System.Drawing.Point(60, 80);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(100, 20);
            this.comboBoxGender.TabIndex = 15;
            this.comboBoxGender.Enter += new System.EventHandler(this.comboBoxGender_Enter);
            // 
            // textBoxHpNum
            // 
            this.textBoxHpNum.Location = new System.Drawing.Point(237, 144);
            this.textBoxHpNum.Name = "textBoxHpNum";
            this.textBoxHpNum.Size = new System.Drawing.Size(100, 21);
            this.textBoxHpNum.TabIndex = 28;
            // 
            // label_hp
            // 
            this.label_hp.AutoSize = true;
            this.label_hp.Location = new System.Drawing.Point(210, 150);
            this.label_hp.Name = "label_hp";
            this.label_hp.Size = new System.Drawing.Size(21, 12);
            this.label_hp.TabIndex = 19;
            this.label_hp.Text = "HP";
            // 
            // textBoxComNum
            // 
            this.textBoxComNum.Location = new System.Drawing.Point(237, 112);
            this.textBoxComNum.Name = "textBoxComNum";
            this.textBoxComNum.Size = new System.Drawing.Size(100, 21);
            this.textBoxComNum.TabIndex = 27;
            // 
            // label_com_num
            // 
            this.label_com_num.AutoSize = true;
            this.label_com_num.Location = new System.Drawing.Point(178, 115);
            this.label_com_num.Name = "label_com_num";
            this.label_com_num.Size = new System.Drawing.Size(53, 12);
            this.label_com_num.TabIndex = 20;
            this.label_com_num.Text = "회사번호";
            // 
            // textBoxPositionRank
            // 
            this.textBoxPositionRank.Location = new System.Drawing.Point(60, 168);
            this.textBoxPositionRank.Name = "textBoxPositionRank";
            this.textBoxPositionRank.Size = new System.Drawing.Size(100, 21);
            this.textBoxPositionRank.TabIndex = 21;
            // 
            // label_rank
            // 
            this.label_rank.AutoSize = true;
            this.label_rank.Location = new System.Drawing.Point(21, 174);
            this.label_rank.Name = "label_rank";
            this.label_rank.Size = new System.Drawing.Size(29, 12);
            this.label_rank.TabIndex = 22;
            this.label_rank.Text = "직책";
            // 
            // textBoxDept
            // 
            this.textBoxDept.Location = new System.Drawing.Point(60, 113);
            this.textBoxDept.Name = "textBoxDept";
            this.textBoxDept.Size = new System.Drawing.Size(100, 21);
            this.textBoxDept.TabIndex = 18;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(202, 52);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(29, 12);
            this.label_age.TabIndex = 23;
            this.label_age.Text = "나이";
            // 
            // label_dept
            // 
            this.label_dept.AutoSize = true;
            this.label_dept.Location = new System.Drawing.Point(21, 118);
            this.label_dept.Name = "label_dept";
            this.label_dept.Size = new System.Drawing.Size(29, 12);
            this.label_dept.TabIndex = 24;
            this.label_dept.Text = "부서";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(237, 47);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 21);
            this.textBoxAge.TabIndex = 16;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(237, 78);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 21);
            this.textBoxAddress.TabIndex = 17;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(202, 81);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(29, 12);
            this.label_address.TabIndex = 25;
            this.label_address.Text = "주소";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(19, 80);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(29, 12);
            this.label_gender.TabIndex = 26;
            this.label_gender.Text = "성별";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(60, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 14;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(21, 52);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 29;
            this.label_name.Text = "이름";
            // 
            // btnInsertSubmit
            // 
            this.btnInsertSubmit.Location = new System.Drawing.Point(60, 239);
            this.btnInsertSubmit.Name = "btnInsertSubmit";
            this.btnInsertSubmit.Size = new System.Drawing.Size(100, 33);
            this.btnInsertSubmit.TabIndex = 30;
            this.btnInsertSubmit.Text = "추가";
            this.btnInsertSubmit.UseVisualStyleBackColor = true;
            this.btnInsertSubmit.Click += new System.EventHandler(this.btnInsertSubmit_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(237, 191);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 21);
            this.textBoxEmail.TabIndex = 32;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(190, 196);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(41, 12);
            this.label_email.TabIndex = 31;
            this.label_email.Text = "이메일";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(141, 24);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(237, 239);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 33);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Location = new System.Drawing.Point(21, 144);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(35, 12);
            this.deptLabel.TabIndex = 33;
            this.deptLabel.Text = "부서2";
            // 
            // deptCBox
            // 
            this.deptCBox.FormattingEnabled = true;
            this.deptCBox.Location = new System.Drawing.Point(60, 140);
            this.deptCBox.Name = "deptCBox";
            this.deptCBox.Size = new System.Drawing.Size(100, 20);
            this.deptCBox.TabIndex = 34;
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(19, 204);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(35, 12);
            this.rankLabel.TabIndex = 35;
            this.rankLabel.Text = "직책2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 36;
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 328);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.deptCBox);
            this.Controls.Add(this.deptLabel);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsertSubmit);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxHpNum);
            this.Controls.Add(this.label_hp);
            this.Controls.Add(this.textBoxComNum);
            this.Controls.Add(this.label_com_num);
            this.Controls.Add(this.textBoxPositionRank);
            this.Controls.Add(this.label_rank);
            this.Controls.Add(this.textBoxDept);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_dept);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 0);
            this.Name = "InsertForm";
            this.Text = "직원 추가";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxHpNum;
        private System.Windows.Forms.Label label_hp;
        private System.Windows.Forms.TextBox textBoxComNum;
        private System.Windows.Forms.Label label_com_num;
        private System.Windows.Forms.TextBox textBoxPositionRank;
        private System.Windows.Forms.Label label_rank;
        private System.Windows.Forms.TextBox textBoxDept;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_dept;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button btnInsertSubmit;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.ComboBox deptCBox;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}