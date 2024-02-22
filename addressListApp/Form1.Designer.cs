namespace addressListApp
{
    partial class winFormApp
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winFormApp));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.listViewAddr = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name_label = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.gender_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.department_label = new System.Windows.Forms.Label();
            this.textBoxDept = new System.Windows.Forms.TextBox();
            this.position_label = new System.Windows.Forms.Label();
            this.textBoxPositionRank = new System.Windows.Forms.TextBox();
            this.com_num_label = new System.Windows.Forms.Label();
            this.textBoxComNum = new System.Windows.Forms.TextBox();
            this.hp_label = new System.Windows.Forms.Label();
            this.textBoxHpNum = new System.Windows.Forms.TextBox();
            this.age_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.group_data = new System.Windows.Forms.GroupBox();
            this.group_table = new System.Windows.Forms.GroupBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.group_data.SuspendLayout();
            this.group_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(432, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 33);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(167, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 33);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(309, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 33);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(36, 137);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(106, 33);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // listViewAddr
            // 
            this.listViewAddr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewAddr.FullRowSelect = true;
            this.listViewAddr.HideSelection = false;
            this.listViewAddr.Location = new System.Drawing.Point(8, 54);
            this.listViewAddr.Name = "listViewAddr";
            this.listViewAddr.Size = new System.Drawing.Size(939, 316);
            this.listViewAddr.TabIndex = 13;
            this.listViewAddr.UseCompatibleStateImageBehavior = false;
            this.listViewAddr.View = System.Windows.Forms.View.Details;
            this.listViewAddr.SelectedIndexChanged += new System.EventHandler(this.listViewAddr_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "성별";
            this.columnHeader3.Width = 54;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "나이";
            this.columnHeader4.Width = 53;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "주소";
            this.columnHeader5.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "부서";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "직책";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "회사번호";
            this.columnHeader8.Width = 115;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "전화번호";
            this.columnHeader9.Width = 115;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "메일";
            this.columnHeader10.Width = 110;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "입사일";
            this.columnHeader11.Width = 91;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(6, 19);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(29, 12);
            this.name_label.TabIndex = 6;
            this.name_label.Text = "이름";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(41, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 0;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Location = new System.Drawing.Point(4, 47);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(29, 12);
            this.gender_label.TabIndex = 6;
            this.gender_label.Text = "성별";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(187, 50);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(29, 12);
            this.address_label.TabIndex = 6;
            this.address_label.Text = "주소";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(222, 47);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 21);
            this.textBoxAddress.TabIndex = 3;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(222, 16);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 21);
            this.textBoxAge.TabIndex = 2;
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Location = new System.Drawing.Point(348, 19);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(29, 12);
            this.department_label.TabIndex = 6;
            this.department_label.Text = "부서";
            // 
            // textBoxDept
            // 
            this.textBoxDept.Location = new System.Drawing.Point(385, 16);
            this.textBoxDept.Name = "textBoxDept";
            this.textBoxDept.Size = new System.Drawing.Size(100, 21);
            this.textBoxDept.TabIndex = 4;
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Location = new System.Drawing.Point(348, 50);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(29, 12);
            this.position_label.TabIndex = 6;
            this.position_label.Text = "직책";
            // 
            // textBoxPositionRank
            // 
            this.textBoxPositionRank.Location = new System.Drawing.Point(385, 47);
            this.textBoxPositionRank.Name = "textBoxPositionRank";
            this.textBoxPositionRank.Size = new System.Drawing.Size(100, 21);
            this.textBoxPositionRank.TabIndex = 5;
            // 
            // com_num_label
            // 
            this.com_num_label.AutoSize = true;
            this.com_num_label.Location = new System.Drawing.Point(511, 19);
            this.com_num_label.Name = "com_num_label";
            this.com_num_label.Size = new System.Drawing.Size(53, 12);
            this.com_num_label.TabIndex = 6;
            this.com_num_label.Text = "회사번호";
            // 
            // textBoxComNum
            // 
            this.textBoxComNum.Location = new System.Drawing.Point(570, 16);
            this.textBoxComNum.Name = "textBoxComNum";
            this.textBoxComNum.Size = new System.Drawing.Size(100, 21);
            this.textBoxComNum.TabIndex = 6;
            // 
            // hp_label
            // 
            this.hp_label.AutoSize = true;
            this.hp_label.Location = new System.Drawing.Point(543, 50);
            this.hp_label.Name = "hp_label";
            this.hp_label.Size = new System.Drawing.Size(21, 12);
            this.hp_label.TabIndex = 6;
            this.hp_label.Text = "HP";
            // 
            // textBoxHpNum
            // 
            this.textBoxHpNum.Location = new System.Drawing.Point(570, 47);
            this.textBoxHpNum.Name = "textBoxHpNum";
            this.textBoxHpNum.Size = new System.Drawing.Size(100, 21);
            this.textBoxHpNum.TabIndex = 7;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(187, 21);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(29, 12);
            this.age_label.TabIndex = 6;
            this.age_label.Text = "나이";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(699, 19);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 12);
            this.email_label.TabIndex = 6;
            this.email_label.Text = "이메일";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(746, 16);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 21);
            this.textBoxEmail.TabIndex = 8;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBoxGender.Location = new System.Drawing.Point(41, 47);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(100, 20);
            this.comboBoxGender.TabIndex = 1;
            this.comboBoxGender.Enter += new System.EventHandler(this.comboBoxGender_Enter);
            // 
            // group_data
            // 
            this.group_data.Controls.Add(this.comboBoxGender);
            this.group_data.Controls.Add(this.textBoxEmail);
            this.group_data.Controls.Add(this.email_label);
            this.group_data.Controls.Add(this.textBoxHpNum);
            this.group_data.Controls.Add(this.hp_label);
            this.group_data.Controls.Add(this.textBoxComNum);
            this.group_data.Controls.Add(this.com_num_label);
            this.group_data.Controls.Add(this.textBoxPositionRank);
            this.group_data.Controls.Add(this.position_label);
            this.group_data.Controls.Add(this.textBoxDept);
            this.group_data.Controls.Add(this.age_label);
            this.group_data.Controls.Add(this.department_label);
            this.group_data.Controls.Add(this.textBoxAge);
            this.group_data.Controls.Add(this.textBoxAddress);
            this.group_data.Controls.Add(this.address_label);
            this.group_data.Controls.Add(this.gender_label);
            this.group_data.Controls.Add(this.textBoxName);
            this.group_data.Controls.Add(this.name_label);
            this.group_data.Location = new System.Drawing.Point(12, 42);
            this.group_data.Name = "group_data";
            this.group_data.Size = new System.Drawing.Size(953, 89);
            this.group_data.TabIndex = 9;
            this.group_data.TabStop = false;
            // 
            // group_table
            // 
            this.group_table.Controls.Add(this.listViewAddr);
            this.group_table.Location = new System.Drawing.Point(12, 173);
            this.group_table.Name = "group_table";
            this.group_table.Size = new System.Drawing.Size(953, 376);
            this.group_table.TabIndex = 10;
            this.group_table.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(141, 24);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // winFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 561);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.group_table);
            this.Controls.Add(this.group_data);
            this.Controls.Add(this.btnDelete);
            this.Name = "winFormApp";
            this.Text = "다울 주소록 관리도구";
            this.Load += new System.EventHandler(this.winFormApp_Load);
            this.group_data.ResumeLayout(false);
            this.group_data.PerformLayout();
            this.group_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListView listViewAddr;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.TextBox textBoxDept;
        private System.Windows.Forms.Label position_label;
        private System.Windows.Forms.TextBox textBoxPositionRank;
        private System.Windows.Forms.Label com_num_label;
        private System.Windows.Forms.TextBox textBoxComNum;
        private System.Windows.Forms.Label hp_label;
        private System.Windows.Forms.TextBox textBoxHpNum;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox group_data;
        private System.Windows.Forms.GroupBox group_table;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

