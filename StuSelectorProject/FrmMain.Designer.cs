namespace StuSelectorProject
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStuId1 = new System.Windows.Forms.Label();
            this.lblStuId = new System.Windows.Forms.Label();
            this.lblClass1 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblGrade1 = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSecond5 = new System.Windows.Forms.Label();
            this.lblSecond4 = new System.Windows.Forms.Label();
            this.lblSecond3 = new System.Windows.Forms.Label();
            this.lblSecond2 = new System.Windows.Forms.Label();
            this.lblSecond1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer_selcet = new System.Windows.Forms.Timer(this.components);
            this.Timer_title = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(272, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(302, 52);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "幸运学员选择器";
            this.lblTime.MouseLeave += new System.EventHandler(this.lblTime_MouseLeave);
            this.lblTime.MouseHover += new System.EventHandler(this.lblTime_MouseHover);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName1.Location = new System.Drawing.Point(175, 112);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(79, 23);
            this.lblName1.TabIndex = 1;
            this.lblName1.Text = "姓名：";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(242, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(147, 34);
            this.lblName.TabIndex = 1;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStuId1
            // 
            this.lblStuId1.AutoSize = true;
            this.lblStuId1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuId1.Location = new System.Drawing.Point(409, 112);
            this.lblStuId1.Name = "lblStuId1";
            this.lblStuId1.Size = new System.Drawing.Size(79, 23);
            this.lblStuId1.TabIndex = 1;
            this.lblStuId1.Text = "学号：";
            // 
            // lblStuId
            // 
            this.lblStuId.BackColor = System.Drawing.Color.White;
            this.lblStuId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuId.Location = new System.Drawing.Point(476, 109);
            this.lblStuId.Name = "lblStuId";
            this.lblStuId.Size = new System.Drawing.Size(164, 34);
            this.lblStuId.TabIndex = 1;
            this.lblStuId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStuId.Click += new System.EventHandler(this.lblStuId_Click);
            // 
            // lblClass1
            // 
            this.lblClass1.AutoSize = true;
            this.lblClass1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClass1.Location = new System.Drawing.Point(175, 183);
            this.lblClass1.Name = "lblClass1";
            this.lblClass1.Size = new System.Drawing.Size(79, 23);
            this.lblClass1.TabIndex = 1;
            this.lblClass1.Text = "班级：";
            // 
            // lblClass
            // 
            this.lblClass.BackColor = System.Drawing.Color.White;
            this.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClass.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClass.Location = new System.Drawing.Point(242, 180);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(147, 34);
            this.lblClass.TabIndex = 1;
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrade1
            // 
            this.lblGrade1.AutoSize = true;
            this.lblGrade1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGrade1.Location = new System.Drawing.Point(409, 183);
            this.lblGrade1.Name = "lblGrade1";
            this.lblGrade1.Size = new System.Drawing.Size(79, 23);
            this.lblGrade1.TabIndex = 1;
            this.lblGrade1.Text = "年级：";
            // 
            // lblGrade
            // 
            this.lblGrade.BackColor = System.Drawing.Color.White;
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrade.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGrade.Location = new System.Drawing.Point(476, 180);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(164, 34);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount2.Location = new System.Drawing.Point(172, 290);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(79, 23);
            this.lblCount2.TabIndex = 1;
            this.lblCount2.Text = "计时：";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(250, 287);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(27, 28);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(296, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "秒";
            // 
            // lblSecond5
            // 
            this.lblSecond5.AutoSize = true;
            this.lblSecond5.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSecond5.Location = new System.Drawing.Point(368, 288);
            this.lblSecond5.Name = "lblSecond5";
            this.lblSecond5.Size = new System.Drawing.Size(33, 23);
            this.lblSecond5.TabIndex = 1;
            this.lblSecond5.Text = "●";
            // 
            // lblSecond4
            // 
            this.lblSecond4.AutoSize = true;
            this.lblSecond4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSecond4.Location = new System.Drawing.Point(419, 288);
            this.lblSecond4.Name = "lblSecond4";
            this.lblSecond4.Size = new System.Drawing.Size(33, 23);
            this.lblSecond4.TabIndex = 1;
            this.lblSecond4.Text = "●";
            // 
            // lblSecond3
            // 
            this.lblSecond3.AutoSize = true;
            this.lblSecond3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSecond3.Location = new System.Drawing.Point(470, 288);
            this.lblSecond3.Name = "lblSecond3";
            this.lblSecond3.Size = new System.Drawing.Size(33, 23);
            this.lblSecond3.TabIndex = 1;
            this.lblSecond3.Text = "●";
            // 
            // lblSecond2
            // 
            this.lblSecond2.AutoSize = true;
            this.lblSecond2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSecond2.Location = new System.Drawing.Point(521, 288);
            this.lblSecond2.Name = "lblSecond2";
            this.lblSecond2.Size = new System.Drawing.Size(33, 23);
            this.lblSecond2.TabIndex = 1;
            this.lblSecond2.Text = "●";
            // 
            // lblSecond1
            // 
            this.lblSecond1.AutoSize = true;
            this.lblSecond1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSecond1.Location = new System.Drawing.Point(572, 288);
            this.lblSecond1.Name = "lblSecond1";
            this.lblSecond1.Size = new System.Drawing.Size(33, 23);
            this.lblSecond1.TabIndex = 1;
            this.lblSecond1.Text = "●";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(623, 288);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 25);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始选择";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer_selcet
            // 
            this.Timer_selcet.Tick += new System.EventHandler(this.Timer_selcet_Tick);
            // 
            // Timer_title
            // 
            this.Timer_title.Tick += new System.EventHandler(this.Timer_title_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 441);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblGrade1);
            this.Controls.Add(this.lblStuId);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblStuId1);
            this.Controls.Add(this.lblClass1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblSecond1);
            this.Controls.Add(this.lblSecond2);
            this.Controls.Add(this.lblSecond3);
            this.Controls.Add(this.lblSecond4);
            this.Controls.Add(this.lblSecond5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCount2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[幸运学员选择器]-实践项目";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStuId1;
        private System.Windows.Forms.Label lblStuId;
        private System.Windows.Forms.Label lblClass1;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblGrade1;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSecond5;
        private System.Windows.Forms.Label lblSecond4;
        private System.Windows.Forms.Label lblSecond3;
        private System.Windows.Forms.Label lblSecond2;
        private System.Windows.Forms.Label lblSecond1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer Timer_selcet;
        private System.Windows.Forms.Timer Timer_title;
    }
}

