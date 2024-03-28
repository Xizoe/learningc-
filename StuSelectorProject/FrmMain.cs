using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuSelectorProject
{
    public partial class FrmMain : Form
    {
        private Selector objSector = new Selector();//创建选择器对象
        int x = 175;//标题默认坐标
        int seconds = 0;//倒计时定时器秒速

        public FrmMain()
        {
            InitializeComponent();
            //设置定时器的参数
            this.Timer_selcet.Interval = 50;
            this.Timer1.Interval = 1000;
            this.Timer_title.Interval = 1;//标题
            this.Timer_title.Start();
        }
        //启动选择
        private void btnStart_Click(object sender, EventArgs e)
        {
            //初始化倒计时定时器参数
            this.seconds = 5;
            this.lblCount.Text = "5";
            this.lblSecond1.ForeColor = Color.Black;
            this.lblSecond2.ForeColor = Color.Black;
            this.lblSecond3.ForeColor = Color.Black;
            this.lblSecond4.ForeColor = Color.Black;
            this.lblSecond5.ForeColor = Color.Black;

            //启动随机选择学员定时器
            this.Timer_selcet.Start();
            //禁用按钮
            this.btnStart.Enabled = false;
            //启动倒计时计时器
            this.Timer1.Start();


        }
        //随机选择学员定时器
        private void Timer_selcet_Tick(object sender, EventArgs e)
        {
            Student objStudent = this.objSector.GetStudent();//随机抽取一个学员
            //显示学生信息
            this.lblName.Text = objStudent.StuName;
            this.lblStuId.Text = objStudent.StuId.ToString();
            this.lblClass.Text = objStudent.ClassName;
            this.lblGrade.Text = objStudent.Grade;
        }
        //倒计时计时器
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.seconds--;//递减1秒
            if (seconds == 0)
            {
                this.Timer1.Stop();
                this.btnStart.Enabled = true;
                this.Timer_selcet.Stop();
            }
            //显示当前秒数
            this.lblCount.Text = this.seconds.ToString();
            //显示进度
           switch(seconds) 
            {
                case 4:
                    this.lblSecond5.ForeColor = Color.Red; break;
                case 3:
                    this.lblSecond4.ForeColor = Color.Red; break;
                case 2:
                    this.lblSecond3.ForeColor = Color.Red; break;
                case 1:
                    this.lblSecond2.ForeColor = Color.Red; break;
                case 0:
                    this.lblSecond1.ForeColor = Color.Red; break;
            }
        }
        //标题移动定时器
        private void Timer_title_Tick(object sender, EventArgs e)
        {
            x++;
            if(x==800)
            {
                x = -290;
            }
            this.lblTime.Location = new System.Drawing.Point(x, 9);
        }

        private void lblTime_MouseHover(object sender, EventArgs e)
        {
            this.Timer_title.Stop();
        }

        private void lblTime_MouseLeave(object sender, EventArgs e)
        {
            this.Timer_title.Start();
        }

        private void lblStuId_Click(object sender, EventArgs e)
        {

        }
    }
}
