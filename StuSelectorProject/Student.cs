using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuSelectorProject
{
    /// <summary>
    /// 学生类
    /// </summary>
    internal class Student
    {
        public Student() { }
        public Student(string name,int stuId,string className,string grade) 
        { 
            this.StuName=name;
            this.StuId=stuId;
            this.ClassName=className;
            this.Grade=grade;
        }
        //定义学生的一些属性
        public string StuName {  get; set; }
        public int StuId {  get; set; }
        public string ClassName {  get; set; }  
        public string Grade {  get; set; }


    }
}
