namespace addressListApp
{
    partial class Form_add_emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add_emp));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(141, 24);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
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
            // 
            // textBoxHpNum
            // 
            this.textBoxHpNum.Location = new System.Drawing.Point(237, 144);
            this.textBoxHpNum.Name = "textBoxHpNum";
            this.textBoxHpNum.Size = new System.Drawing.Size(100, 21);
            this.textBoxHpNum.TabIndex = 28;
            this.textBoxHpNum.TextChanged += new System.EventHandler(this.textBoxHpNum_TextChanged);
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
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(60, 244);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(106, 33);
            this.btnInsert.TabIndex = 30;
            this.btnInsert.Text = "추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(212, 244);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 33);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form_add_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 328);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.btnInsert);
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
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "Form_add_emp";
            this.Text = "직원 추가하기";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
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
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Button btnUpdate;
    }
}