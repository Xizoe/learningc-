using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StuSelectorProject
{
    /// <summary>
    /// 选号器类
    /// </summary>
    /// 
    internal class Selector
    {

        public Selector() 
        {
            this.stuList = new List<Student>();        
        }
        /// <summary>
        /// 选号器的存储模块
        /// </summary>
        private List<Student> stuList;//类的成员变量
        public List<Student> StuList
        {
            get
            {
                if (this.stuList.Count != 0) return stuList;
                //从学员信息文件中读取信息
                FileStream fs = new FileStream("stuList.txt", FileMode.Open);
                StreamReader sr=new StreamReader(fs,Encoding.Default);//读取器读取
                string stuinfo=string.Empty;

                while(true) 
                {
                    stuinfo=sr.ReadLine();
                    if(stuinfo==null) break;
                    else
                    {
                        string[] stuDetall=stuinfo.Split(',');
                        this.stuList.Add(new Student()//封装对象
                        {
                            StuName= stuDetall[0],
                            StuId =Convert.ToInt32(stuDetall[1]),
                            ClassName= stuDetall[2],
                            Grade = stuDetall[3]
                        } );
                    }
                }
                sr.Close();
                fs.Close();
                return stuList;
            }
        }
        /// <summary>
        /// 随机产生学员对象
        /// </summary>
        private Random objRandom=new Random();  //定义一个随机数对象
        public Student GetStudent()
        {
            int serialNo=objRandom.Next(stuList.Count);//随机产生序号
            return StuList[serialNo];//根据产生的随机索引值获取学员对象
        }
    }
} 
