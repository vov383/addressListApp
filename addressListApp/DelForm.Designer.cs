namespace addressListApp
{
    partial class DelForm
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
            this.btn_DelConfirm = new System.Windows.Forms.Button();
            this.btn_DelCancel = new System.Windows.Forms.Button();
            this.msg_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_DelConfirm
            // 
            this.btn_DelConfirm.Location = new System.Drawing.Point(75, 90);
            this.btn_DelConfirm.Name = "btn_DelConfirm";
            this.btn_DelConfirm.Size = new System.Drawing.Size(75, 23);
            this.btn_DelConfirm.TabIndex = 1;
            this.btn_DelConfirm.Text = "예(Y)";
            this.btn_DelConfirm.UseVisualStyleBackColor = true;
            this.btn_DelConfirm.Click += new System.EventHandler(this.btn_DelConfirm_Click);
            // 
            // btn_DelCancel
            // 
            this.btn_DelCancel.Location = new System.Drawing.Point(191, 90);
            this.btn_DelCancel.Name = "btn_DelCancel";
            this.btn_DelCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_DelCancel.TabIndex = 2;
            this.btn_DelCancel.Text = "아니오(N)";
            this.btn_DelCancel.UseVisualStyleBackColor = true;
            this.btn_DelCancel.Click += new System.EventHandler(this.btn_DelCancel_Click);
            // 
            // msg_label
            // 
            this.msg_label.AutoSize = true;
            this.msg_label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.msg_label.Location = new System.Drawing.Point(74, 42);
            this.msg_label.Name = "msg_label";
            this.msg_label.Size = new System.Drawing.Size(48, 16);
            this.msg_label.TabIndex = 0;
            this.msg_label.Text = "label1";
            // 
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 137);
            this.Controls.Add(this.msg_label);
            this.Controls.Add(this.btn_DelCancel);
            this.Controls.Add(this.btn_DelConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DelForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DelForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DelForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DelConfirm;
        private System.Windows.Forms.Button btn_DelCancel;
        private System.Windows.Forms.Label msg_label;
    }
}