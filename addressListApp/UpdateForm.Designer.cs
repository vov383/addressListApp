namespace addressListApp
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxHpNum = new System.Windows.Forms.TextBox();
            this.hp_label = new System.Windows.Forms.Label();
            this.textBoxComNum = new System.Windows.Forms.TextBox();
            this.com_num_label = new System.Windows.Forms.Label();
            this.textBoxPositionRank = new System.Windows.Forms.TextBox();
            this.position_label = new System.Windows.Forms.Label();
            this.textBoxDept = new System.Windows.Forms.TextBox();
            this.age_label = new System.Windows.Forms.Label();
            this.department_label = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.gender_label = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btn_update_submit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            // hp_label
            // 
            this.hp_label.AutoSize = true;
            this.hp_label.Location = new System.Drawing.Point(210, 150);
            this.hp_label.Name = "hp_label";
            this.hp_label.Size = new System.Drawing.Size(21, 12);
            this.hp_label.TabIndex = 19;
            this.hp_label.Text = "HP";
            // 
            // textBoxComNum
            // 
            this.textBoxComNum.Location = new System.Drawing.Point(237, 112);
            this.textBoxComNum.Name = "textBoxComNum";
            this.textBoxComNum.Size = new System.Drawing.Size(100, 21);
            this.textBoxComNum.TabIndex = 27;
            // 
            // com_num_label
            // 
            this.com_num_label.AutoSize = true;
            this.com_num_label.Location = new System.Drawing.Point(178, 115);
            this.com_num_label.Name = "com_num_label";
            this.com_num_label.Size = new System.Drawing.Size(53, 12);
            this.com_num_label.TabIndex = 20;
            this.com_num_label.Text = "회사번호";
            // 
            // textBoxPositionRank
            // 
            this.textBoxPositionRank.Location = new System.Drawing.Point(60, 144);
            this.textBoxPositionRank.Name = "textBoxPositionRank";
            this.textBoxPositionRank.Size = new System.Drawing.Size(100, 21);
            this.textBoxPositionRank.TabIndex = 21;
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Location = new System.Drawing.Point(21, 150);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(29, 12);
            this.position_label.TabIndex = 22;
            this.position_label.Text = "직책";
            // 
            // textBoxDept
            // 
            this.textBoxDept.Location = new System.Drawing.Point(60, 113);
            this.textBoxDept.Name = "textBoxDept";
            this.textBoxDept.Size = new System.Drawing.Size(100, 21);
            this.textBoxDept.TabIndex = 18;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(202, 52);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(29, 12);
            this.age_label.TabIndex = 23;
            this.age_label.Text = "나이";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Location = new System.Drawing.Point(21, 118);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(29, 12);
            this.department_label.TabIndex = 24;
            this.department_label.Text = "부서";
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
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(202, 81);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(29, 12);
            this.address_label.TabIndex = 25;
            this.address_label.Text = "주소";
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Location = new System.Drawing.Point(19, 80);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(29, 12);
            this.gender_label.TabIndex = 26;
            this.gender_label.Text = "성별";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(60, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 14;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(21, 52);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(29, 12);
            this.name_label.TabIndex = 29;
            this.name_label.Text = "이름";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(60, 177);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 21);
            this.textBoxEmail.TabIndex = 32;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(13, 182);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 12);
            this.email_label.TabIndex = 31;
            this.email_label.Text = "이메일";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(141, 24);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 33;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btn_update_submit
            // 
            this.btn_update_submit.Location = new System.Drawing.Point(60, 226);
            this.btn_update_submit.Name = "btn_update_submit";
            this.btn_update_submit.Size = new System.Drawing.Size(100, 46);
            this.btn_update_submit.TabIndex = 34;
            this.btn_update_submit.Text = "제출하기";
            this.btn_update_submit.UseVisualStyleBackColor = true;
            this.btn_update_submit.Click += new System.EventHandler(this.btn_update_submit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(237, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 46);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 328);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_update_submit);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxHpNum);
            this.Controls.Add(this.hp_label);
            this.Controls.Add(this.textBoxComNum);
            this.Controls.Add(this.com_num_label);
            this.Controls.Add(this.textBoxPositionRank);
            this.Controls.Add(this.position_label);
            this.Controls.Add(this.textBoxDept);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateForm";
            this.Text = "직원 정보 수정";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxHpNum;
        private System.Windows.Forms.Label hp_label;
        private System.Windows.Forms.TextBox textBoxComNum;
        private System.Windows.Forms.Label com_num_label;
        private System.Windows.Forms.TextBox textBoxPositionRank;
        private System.Windows.Forms.Label position_label;
        private System.Windows.Forms.TextBox textBoxDept;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btn_update_submit;
        private System.Windows.Forms.Button btnClose;
    }
}