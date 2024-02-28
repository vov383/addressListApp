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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tboxEmail2 = new System.Windows.Forms.TextBox();
            this.cboxEmail = new System.Windows.Forms.ComboBox();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.cboxRank = new System.Windows.Forms.ComboBox();
            this.cboxDept = new System.Windows.Forms.ComboBox();
            this.tboxEmail1 = new System.Windows.Forms.TextBox();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInsertSubmit = new System.Windows.Forms.Button();
            this.cboxGender = new System.Windows.Forms.ComboBox();
            this.tboxHpNum = new System.Windows.Forms.TextBox();
            this.label_hp = new System.Windows.Forms.Label();
            this.tboxComNum = new System.Windows.Forms.TextBox();
            this.label_com_num = new System.Windows.Forms.Label();
            this.label_rank = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_dept = new System.Windows.Forms.Label();
            this.tboxAge = new System.Windows.Forms.TextBox();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
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
            // tboxEmail2
            // 
            this.tboxEmail2.Location = new System.Drawing.Point(200, 250);
            this.tboxEmail2.Name = "tboxEmail2";
            this.tboxEmail2.Size = new System.Drawing.Size(132, 21);
            this.tboxEmail2.TabIndex = 57;
            // 
            // cboxEmail
            // 
            this.cboxEmail.FormattingEnabled = true;
            this.cboxEmail.Items.AddRange(new object[] {
            "dawooleng.co.kr",
            "naver.com",
            "gmail.com",
            "nate.com",
            "hanmail.net",
            "직접입력"});
            this.cboxEmail.Location = new System.Drawing.Point(345, 251);
            this.cboxEmail.Name = "cboxEmail";
            this.cboxEmail.Size = new System.Drawing.Size(121, 20);
            this.cboxEmail.TabIndex = 56;
            this.cboxEmail.SelectedIndexChanged += new System.EventHandler(this.cboxEmail_SelectedIndexChanged);
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(182, 254);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(17, 12);
            this.lblEmail2.TabIndex = 55;
            this.lblEmail2.Text = "@";
            // 
            // cboxRank
            // 
            this.cboxRank.FormattingEnabled = true;
            this.cboxRank.Location = new System.Drawing.Point(80, 166);
            this.cboxRank.Name = "cboxRank";
            this.cboxRank.Size = new System.Drawing.Size(144, 20);
            this.cboxRank.TabIndex = 40;
            // 
            // cboxDept
            // 
            this.cboxDept.FormattingEnabled = true;
            this.cboxDept.Location = new System.Drawing.Point(80, 140);
            this.cboxDept.Name = "cboxDept";
            this.cboxDept.Size = new System.Drawing.Size(144, 20);
            this.cboxDept.TabIndex = 39;
            // 
            // tboxEmail1
            // 
            this.tboxEmail1.Location = new System.Drawing.Point(80, 249);
            this.tboxEmail1.Name = "tboxEmail1";
            this.tboxEmail1.Size = new System.Drawing.Size(100, 21);
            this.tboxEmail1.TabIndex = 43;
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Location = new System.Drawing.Point(34, 254);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(41, 12);
            this.lblEmail1.TabIndex = 54;
            this.lblEmail1.Text = "이메일";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(232, 286);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 26);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnInsertSubmit
            // 
            this.btnInsertSubmit.Location = new System.Drawing.Point(345, 286);
            this.btnInsertSubmit.Name = "btnInsertSubmit";
            this.btnInsertSubmit.Size = new System.Drawing.Size(100, 26);
            this.btnInsertSubmit.TabIndex = 44;
            this.btnInsertSubmit.Text = "추가";
            this.btnInsertSubmit.UseVisualStyleBackColor = true;
            // 
            // cboxGender
            // 
            this.cboxGender.FormattingEnabled = true;
            this.cboxGender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.cboxGender.Location = new System.Drawing.Point(80, 59);
            this.cboxGender.Name = "cboxGender";
            this.cboxGender.Size = new System.Drawing.Size(144, 20);
            this.cboxGender.TabIndex = 36;
            // 
            // tboxHpNum
            // 
            this.tboxHpNum.Location = new System.Drawing.Point(80, 219);
            this.tboxHpNum.Name = "tboxHpNum";
            this.tboxHpNum.Size = new System.Drawing.Size(144, 21);
            this.tboxHpNum.TabIndex = 42;
            // 
            // label_hp
            // 
            this.label_hp.AutoSize = true;
            this.label_hp.Location = new System.Drawing.Point(21, 222);
            this.label_hp.Name = "label_hp";
            this.label_hp.Size = new System.Drawing.Size(53, 12);
            this.label_hp.TabIndex = 46;
            this.label_hp.Text = "개인번호";
            // 
            // tboxComNum
            // 
            this.tboxComNum.Location = new System.Drawing.Point(80, 192);
            this.tboxComNum.Name = "tboxComNum";
            this.tboxComNum.Size = new System.Drawing.Size(144, 21);
            this.tboxComNum.TabIndex = 41;
            // 
            // label_com_num
            // 
            this.label_com_num.AutoSize = true;
            this.label_com_num.Location = new System.Drawing.Point(21, 195);
            this.label_com_num.Name = "label_com_num";
            this.label_com_num.Size = new System.Drawing.Size(53, 12);
            this.label_com_num.TabIndex = 47;
            this.label_com_num.Text = "회사번호";
            // 
            // label_rank
            // 
            this.label_rank.AutoSize = true;
            this.label_rank.Location = new System.Drawing.Point(45, 169);
            this.label_rank.Name = "label_rank";
            this.label_rank.Size = new System.Drawing.Size(29, 12);
            this.label_rank.TabIndex = 48;
            this.label_rank.Text = "직책";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(45, 90);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(29, 12);
            this.label_age.TabIndex = 49;
            this.label_age.Text = "나이";
            // 
            // label_dept
            // 
            this.label_dept.AutoSize = true;
            this.label_dept.Location = new System.Drawing.Point(45, 143);
            this.label_dept.Name = "label_dept";
            this.label_dept.Size = new System.Drawing.Size(29, 12);
            this.label_dept.TabIndex = 50;
            this.label_dept.Text = "부서";
            // 
            // tboxAge
            // 
            this.tboxAge.Location = new System.Drawing.Point(80, 85);
            this.tboxAge.Name = "tboxAge";
            this.tboxAge.Size = new System.Drawing.Size(144, 21);
            this.tboxAge.TabIndex = 37;
            // 
            // tboxAddress
            // 
            this.tboxAddress.Location = new System.Drawing.Point(80, 112);
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(144, 21);
            this.tboxAddress.TabIndex = 38;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(45, 115);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(29, 12);
            this.label_address.TabIndex = 51;
            this.label_address.Text = "주소";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(45, 59);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(29, 12);
            this.label_gender.TabIndex = 52;
            this.label_gender.Text = "성별";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(80, 31);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(144, 21);
            this.tboxName.TabIndex = 35;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(45, 36);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 53;
            this.label_name.Text = "이름";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 433);
            this.Controls.Add(this.tboxEmail2);
            this.Controls.Add(this.cboxEmail);
            this.Controls.Add(this.lblEmail2);
            this.Controls.Add(this.cboxRank);
            this.Controls.Add(this.cboxDept);
            this.Controls.Add(this.tboxEmail1);
            this.Controls.Add(this.lblEmail1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsertSubmit);
            this.Controls.Add(this.cboxGender);
            this.Controls.Add(this.tboxHpNum);
            this.Controls.Add(this.label_hp);
            this.Controls.Add(this.tboxComNum);
            this.Controls.Add(this.label_com_num);
            this.Controls.Add(this.label_rank);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_dept);
            this.Controls.Add(this.tboxAge);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateForm";
            this.Text = "직원 정보 수정";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox tboxEmail2;
        private System.Windows.Forms.ComboBox cboxEmail;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.ComboBox cboxRank;
        private System.Windows.Forms.ComboBox cboxDept;
        private System.Windows.Forms.TextBox tboxEmail1;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsertSubmit;
        private System.Windows.Forms.ComboBox cboxGender;
        private System.Windows.Forms.TextBox tboxHpNum;
        private System.Windows.Forms.Label label_hp;
        private System.Windows.Forms.TextBox tboxComNum;
        private System.Windows.Forms.Label label_com_num;
        private System.Windows.Forms.Label label_rank;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_dept;
        private System.Windows.Forms.TextBox tboxAge;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Label label_name;
    }
}