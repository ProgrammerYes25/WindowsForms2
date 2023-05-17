namespace WindowsForms2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFormTitle1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFormTitle1
            // 
            this.lblFormTitle1.BackColor = System.Drawing.Color.MistyRose;
            this.lblFormTitle1.Font = new System.Drawing.Font("휴먼편지체", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFormTitle1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblFormTitle1.Location = new System.Drawing.Point(12, 9);
            this.lblFormTitle1.Name = "lblFormTitle1";
            this.lblFormTitle1.Size = new System.Drawing.Size(550, 139);
            this.lblFormTitle1.TabIndex = 0;
            this.lblFormTitle1.Text = "취업 NO.1!";
            this.lblFormTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormTitle1.Click += new System.EventHandler(this.lblFormTitle1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 157);
            this.Controls.Add(this.lblFormTitle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "3-1 급훈";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle1;
    }
}

