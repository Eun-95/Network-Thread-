namespace WindowsFormsApplication3
{
    partial class Form1_FormClosing
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
            this.IbIReceive01 = new System.Windows.Forms.Label();
            this.lblReceive02 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IbIReceive01
            // 
            this.IbIReceive01.AutoSize = true;
            this.IbIReceive01.Location = new System.Drawing.Point(43, 110);
            this.IbIReceive01.Name = "IbIReceive01";
            this.IbIReceive01.Size = new System.Drawing.Size(157, 15);
            this.IbIReceive01.TabIndex = 0;
            this.IbIReceive01.Text = "외부에서 받은 데이터:";
            // 
            // lblReceive02
            // 
            this.lblReceive02.AutoSize = true;
            this.lblReceive02.Location = new System.Drawing.Point(43, 170);
            this.lblReceive02.Name = "lblReceive02";
            this.lblReceive02.Size = new System.Drawing.Size(37, 15);
            this.lblReceive02.TabIndex = 1;
            this.lblReceive02.Text = "결과";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(202, 226);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 2;
            this.btnReceive.Text = "전달받기";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // Form1_FormClosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 326);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lblReceive02);
            this.Controls.Add(this.IbIReceive01);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1_FormClosing";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbIReceive01;
        private System.Windows.Forms.Label lblReceive02;
        private System.Windows.Forms.Button btnReceive;
    }
}

