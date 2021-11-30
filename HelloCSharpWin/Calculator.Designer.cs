namespace HelloCSharpWin
{
    partial class Calculator
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
            this.NumScreen = new System.Windows.Forms.Label();
            this.NumButton1 = new System.Windows.Forms.Button();
            this.NumButton2 = new System.Windows.Forms.Button();
            this.NumButton3 = new System.Windows.Forms.Button();
            this.NumButton4 = new System.Windows.Forms.Button();
            this.NumButton5 = new System.Windows.Forms.Button();
            this.NumButton6 = new System.Windows.Forms.Button();
            this.NumButton17 = new System.Windows.Forms.Button();
            this.NumButton8 = new System.Windows.Forms.Button();
            this.NumButton9 = new System.Windows.Forms.Button();
            this.NumButton0 = new System.Windows.Forms.Button();
            this.NumPlus = new System.Windows.Forms.Button();
            this.NumMinus = new System.Windows.Forms.Button();
            this.NumTimes = new System.Windows.Forms.Button();
            this.NumDivide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NumClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumScreen.Location = new System.Drawing.Point(12, 9);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(342, 46);
            this.NumScreen.TabIndex = 2;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumButton1
            // 
            this.NumButton1.Location = new System.Drawing.Point(26, 76);
            this.NumButton1.Name = "NumButton1";
            this.NumButton1.Size = new System.Drawing.Size(75, 23);
            this.NumButton1.TabIndex = 3;
            this.NumButton1.Text = "1";
            this.NumButton1.UseVisualStyleBackColor = true;
            this.NumButton1.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton2
            // 
            this.NumButton2.Location = new System.Drawing.Point(107, 76);
            this.NumButton2.Name = "NumButton2";
            this.NumButton2.Size = new System.Drawing.Size(75, 23);
            this.NumButton2.TabIndex = 4;
            this.NumButton2.Text = "2";
            this.NumButton2.UseVisualStyleBackColor = true;
            this.NumButton2.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton3
            // 
            this.NumButton3.Location = new System.Drawing.Point(188, 76);
            this.NumButton3.Name = "NumButton3";
            this.NumButton3.Size = new System.Drawing.Size(75, 23);
            this.NumButton3.TabIndex = 5;
            this.NumButton3.Text = "3";
            this.NumButton3.UseVisualStyleBackColor = true;
            this.NumButton3.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton4
            // 
            this.NumButton4.Location = new System.Drawing.Point(26, 105);
            this.NumButton4.Name = "NumButton4";
            this.NumButton4.Size = new System.Drawing.Size(75, 23);
            this.NumButton4.TabIndex = 6;
            this.NumButton4.Text = "4";
            this.NumButton4.UseVisualStyleBackColor = true;
            this.NumButton4.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton5
            // 
            this.NumButton5.Location = new System.Drawing.Point(107, 105);
            this.NumButton5.Name = "NumButton5";
            this.NumButton5.Size = new System.Drawing.Size(75, 23);
            this.NumButton5.TabIndex = 7;
            this.NumButton5.Text = "5";
            this.NumButton5.UseVisualStyleBackColor = true;
            this.NumButton5.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton6
            // 
            this.NumButton6.Location = new System.Drawing.Point(188, 105);
            this.NumButton6.Name = "NumButton6";
            this.NumButton6.Size = new System.Drawing.Size(75, 23);
            this.NumButton6.TabIndex = 8;
            this.NumButton6.Text = "6";
            this.NumButton6.UseVisualStyleBackColor = true;
            this.NumButton6.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton17
            // 
            this.NumButton17.Location = new System.Drawing.Point(26, 134);
            this.NumButton17.Name = "NumButton17";
            this.NumButton17.Size = new System.Drawing.Size(75, 23);
            this.NumButton17.TabIndex = 9;
            this.NumButton17.Text = "7";
            this.NumButton17.UseVisualStyleBackColor = true;
            this.NumButton17.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton8
            // 
            this.NumButton8.Location = new System.Drawing.Point(107, 134);
            this.NumButton8.Name = "NumButton8";
            this.NumButton8.Size = new System.Drawing.Size(75, 23);
            this.NumButton8.TabIndex = 10;
            this.NumButton8.Text = "8";
            this.NumButton8.UseVisualStyleBackColor = true;
            this.NumButton8.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton9
            // 
            this.NumButton9.Location = new System.Drawing.Point(188, 134);
            this.NumButton9.Name = "NumButton9";
            this.NumButton9.Size = new System.Drawing.Size(75, 23);
            this.NumButton9.TabIndex = 11;
            this.NumButton9.Text = "9";
            this.NumButton9.UseVisualStyleBackColor = true;
            this.NumButton9.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton0
            // 
            this.NumButton0.Location = new System.Drawing.Point(107, 163);
            this.NumButton0.Name = "NumButton0";
            this.NumButton0.Size = new System.Drawing.Size(75, 23);
            this.NumButton0.TabIndex = 12;
            this.NumButton0.Text = "0";
            this.NumButton0.UseVisualStyleBackColor = true;
            this.NumButton0.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumPlus
            // 
            this.NumPlus.Location = new System.Drawing.Point(269, 76);
            this.NumPlus.Name = "NumPlus";
            this.NumPlus.Size = new System.Drawing.Size(75, 23);
            this.NumPlus.TabIndex = 13;
            this.NumPlus.Text = "+";
            this.NumPlus.UseVisualStyleBackColor = true;
            this.NumPlus.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumMinus
            // 
            this.NumMinus.Location = new System.Drawing.Point(269, 105);
            this.NumMinus.Name = "NumMinus";
            this.NumMinus.Size = new System.Drawing.Size(75, 23);
            this.NumMinus.TabIndex = 14;
            this.NumMinus.Text = "-";
            this.NumMinus.UseVisualStyleBackColor = true;
            this.NumMinus.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumTimes
            // 
            this.NumTimes.Location = new System.Drawing.Point(269, 134);
            this.NumTimes.Name = "NumTimes";
            this.NumTimes.Size = new System.Drawing.Size(75, 23);
            this.NumTimes.TabIndex = 15;
            this.NumTimes.Text = "*";
            this.NumTimes.UseVisualStyleBackColor = true;
            this.NumTimes.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumDivide
            // 
            this.NumDivide.Location = new System.Drawing.Point(269, 163);
            this.NumDivide.Name = "NumDivide";
            this.NumDivide.Size = new System.Drawing.Size(75, 23);
            this.NumDivide.TabIndex = 16;
            this.NumDivide.Text = "/";
            this.NumDivide.UseVisualStyleBackColor = true;
            this.NumDivide.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumClear
            // 
            this.NumClear.Location = new System.Drawing.Point(269, 192);
            this.NumClear.Name = "NumClear";
            this.NumClear.Size = new System.Drawing.Size(75, 23);
            this.NumClear.TabIndex = 18;
            this.NumClear.Text = "C";
            this.NumClear.UseVisualStyleBackColor = true;
            this.NumClear.Click += new System.EventHandler(this.NumClear_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.NumClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumDivide);
            this.Controls.Add(this.NumTimes);
            this.Controls.Add(this.NumMinus);
            this.Controls.Add(this.NumPlus);
            this.Controls.Add(this.NumButton0);
            this.Controls.Add(this.NumButton9);
            this.Controls.Add(this.NumButton8);
            this.Controls.Add(this.NumButton17);
            this.Controls.Add(this.NumButton6);
            this.Controls.Add(this.NumButton5);
            this.Controls.Add(this.NumButton4);
            this.Controls.Add(this.NumButton3);
            this.Controls.Add(this.NumButton2);
            this.Controls.Add(this.NumButton1);
            this.Controls.Add(this.NumScreen);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button NumButton1;
        private System.Windows.Forms.Button NumButton2;
        private System.Windows.Forms.Button NumButton3;
        private System.Windows.Forms.Button NumButton4;
        private System.Windows.Forms.Button NumButton5;
        private System.Windows.Forms.Button NumButton6;
        private System.Windows.Forms.Button NumButton17;
        private System.Windows.Forms.Button NumButton8;
        private System.Windows.Forms.Button NumButton9;
        private System.Windows.Forms.Button NumButton0;
        private System.Windows.Forms.Button NumPlus;
        private System.Windows.Forms.Button NumMinus;
        private System.Windows.Forms.Button NumTimes;
        private System.Windows.Forms.Button NumDivide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NumClear;
    }
}

