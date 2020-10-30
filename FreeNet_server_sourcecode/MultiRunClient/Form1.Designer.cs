namespace MultiRunClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProcessName = new System.Windows.Forms.TextBox();
            this.tbRunCount = new System.Windows.Forms.TextBox();
            this.btnRunProcesses = new System.Windows.Forms.Button();
            this.btnEndProcesses = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWaitTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPositionCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFindWindow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼편지체", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "실행 파일 명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼편지체", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(33, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "실행 회수";
            // 
            // tbProcessName
            // 
            this.tbProcessName.Font = new System.Drawing.Font("휴먼편지체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbProcessName.Location = new System.Drawing.Point(348, 32);
            this.tbProcessName.Name = "tbProcessName";
            this.tbProcessName.Size = new System.Drawing.Size(629, 45);
            this.tbProcessName.TabIndex = 2;
            this.tbProcessName.Text = "AndroidClientChat.exe";
            // 
            // tbRunCount
            // 
            this.tbRunCount.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbRunCount.Location = new System.Drawing.Point(350, 151);
            this.tbRunCount.Name = "tbRunCount";
            this.tbRunCount.Size = new System.Drawing.Size(627, 63);
            this.tbRunCount.TabIndex = 3;
            // 
            // btnRunProcesses
            // 
            this.btnRunProcesses.Font = new System.Drawing.Font("휴먼편지체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRunProcesses.Location = new System.Drawing.Point(153, 648);
            this.btnRunProcesses.Name = "btnRunProcesses";
            this.btnRunProcesses.Size = new System.Drawing.Size(200, 75);
            this.btnRunProcesses.TabIndex = 4;
            this.btnRunProcesses.Text = "실행";
            this.btnRunProcesses.UseVisualStyleBackColor = true;
            this.btnRunProcesses.Click += new System.EventHandler(this.btnRunProcesses_Click);
            // 
            // btnEndProcesses
            // 
            this.btnEndProcesses.Font = new System.Drawing.Font("휴먼편지체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEndProcesses.Location = new System.Drawing.Point(564, 648);
            this.btnEndProcesses.Name = "btnEndProcesses";
            this.btnEndProcesses.Size = new System.Drawing.Size(200, 75);
            this.btnEndProcesses.TabIndex = 4;
            this.btnEndProcesses.Text = "프로세스 종료";
            this.btnEndProcesses.UseVisualStyleBackColor = true;
            this.btnEndProcesses.Click += new System.EventHandler(this.btnEndProcesses_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼편지체", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(34, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼편지체", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(534, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 44);
            this.label4.TabIndex = 1;
            this.label4.Text = "height";
            // 
            // tbWidth
            // 
            this.tbWidth.Font = new System.Drawing.Font("휴먼편지체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWidth.Location = new System.Drawing.Point(190, 269);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(320, 63);
            this.tbWidth.TabIndex = 3;
            this.tbWidth.Text = "320";
            this.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHeight
            // 
            this.tbHeight.Font = new System.Drawing.Font("휴먼편지체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbHeight.Location = new System.Drawing.Point(688, 269);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(289, 63);
            this.tbHeight.TabIndex = 3;
            this.tbHeight.Text = "240";
            this.tbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼편지체", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(34, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 44);
            this.label5.TabIndex = 1;
            this.label5.Text = "대기 시간";
            // 
            // tbWaitTime
            // 
            this.tbWaitTime.Font = new System.Drawing.Font("휴먼편지체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWaitTime.Location = new System.Drawing.Point(243, 379);
            this.tbWaitTime.Name = "tbWaitTime";
            this.tbWaitTime.Size = new System.Drawing.Size(267, 63);
            this.tbWaitTime.TabIndex = 3;
            this.tbWaitTime.Text = "1000";
            this.tbWaitTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼편지체", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(515, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 44);
            this.label6.TabIndex = 1;
            this.label6.Text = "PositionCnt";
            // 
            // tbPositionCount
            // 
            this.tbPositionCount.Font = new System.Drawing.Font("휴먼편지체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPositionCount.Location = new System.Drawing.Point(784, 379);
            this.tbPositionCount.Name = "tbPositionCount";
            this.tbPositionCount.Size = new System.Drawing.Size(193, 63);
            this.tbPositionCount.TabIndex = 3;
            this.tbPositionCount.Text = "5";
            this.tbPositionCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼편지체", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(34, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 44);
            this.label7.TabIndex = 0;
            this.label7.Text = "종료 창 이름";
            // 
            // tbFindWindow
            // 
            this.tbFindWindow.Font = new System.Drawing.Font("휴먼편지체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbFindWindow.Location = new System.Drawing.Point(348, 500);
            this.tbFindWindow.Name = "tbFindWindow";
            this.tbFindWindow.Size = new System.Drawing.Size(629, 45);
            this.tbFindWindow.TabIndex = 2;
            this.tbFindWindow.Text = "AndroidClientChat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 735);
            this.Controls.Add(this.btnEndProcesses);
            this.Controls.Add(this.btnRunProcesses);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbPositionCount);
            this.Controls.Add(this.tbWaitTime);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbRunCount);
            this.Controls.Add(this.tbFindWindow);
            this.Controls.Add(this.tbProcessName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProcessName;
        private System.Windows.Forms.TextBox tbRunCount;
        private System.Windows.Forms.Button btnRunProcesses;
        private System.Windows.Forms.Button btnEndProcesses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWaitTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPositionCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFindWindow;
    }
}

