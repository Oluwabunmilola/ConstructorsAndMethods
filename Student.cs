using System;
    class Student
    {
       string _stuName;
       string _stuRollNo;
       int _stuAge; 


       public Student (string stuName,string stuRollNo,int stuAge) //A constructor is something that can be called.
       {
           this._stuName = stuName;
           this._stuRollNo = stuRollNo;
           this._stuAge = stuAge;

       }

         public void printStuDetails()
         {
         Console.WriteLine("Your details are " + _stuName + "\n" + _stuRollNo + "\n" + _stuAge );
         }       
    }