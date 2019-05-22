namespace cbchoice
{
    partial class Form1
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
            this.cblist = new System.Windows.Forms.ComboBox();
            this.txtlist = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cblist
            // 
            this.cblist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblist.FormattingEnabled = true;
            this.cblist.Location = new System.Drawing.Point(56, 30);
            this.cblist.Name = "cblist";
            this.cblist.Size = new System.Drawing.Size(121, 20);
            this.cblist.TabIndex = 0;
            // 
            // txtlist
            // 
            this.txtlist.Location = new System.Drawing.Point(58, 63);
            this.txtlist.Name = "txtlist";
            this.txtlist.Size = new System.Drawing.Size(118, 21);
            this.txtlist.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(58, 99);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(117, 41);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "추가";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(196, 33);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(65, 12);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "선택 결과 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtlist);
            this.Controls.Add(this.cblist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cblist;
        private System.Windows.Forms.TextBox txtlist;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblResult;
    }
}

