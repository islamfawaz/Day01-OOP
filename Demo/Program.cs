﻿using Common;
namespace Demo
{
    enum Grade
    {
        A,B,C,D,E,F
    }
    enum Gender
    {
        male,
        female
    }
    enum Branch :byte
    {
      Dokki=202 ,NasrCity,SmartVillage       
    }
    internal class Program
    {
        [Flags]
        enum Permission :byte
        {
            write=1,read=2,execute=4,delete=8
        }
        class Employee
        {
            public int id {  get; set; }    
            public string name { get; set; }

            public decimal salary { get; set; } 
            public Permission permission { get; set; }  


            
        }



        static void Main(string[] args)
        {
            #region AccessModifiers Video3

            //TypeA obj =new TypeA();
            ////   obj.x=10
            ////   obj.y = 20;
            //obj.z = 10;

            #endregion

            #region Enum Example 1
            //    Grade G01 = Grade.A;
            //if (G01 == Grade.A)
            //{
            //    Console.WriteLine(")");

            //}
            //else
            //{
            //    Console.WriteLine("(");
            //}
            //G01 = (Grade)4;
            //Console.WriteLine(G01);

            #endregion
            // Gender myGender;
            #region Video5 Example2

            #region Parse Method
            //    myGender = Enum.Parse<Gender>(Console.ReadLine() ?? "", true);
            //    myGender= (Gender)Enum.Parse(typeof(Gender),"Male");

            #endregion
            #region TryParse
            //Enum.TryParse(typeof(Gender),Console.ReadLine(),true ,out object ? obj);
            //myGender = (Gender?) obj;

            // Enum.TryParse<Gender>(Console.ReadLine(), out myGender);
            // Console.WriteLine(myGender); 
            #endregion

            #endregion



            #region Video6 Example 3 


            //Employee employee = new Employee();
            //employee.id = 101;
            //employee.name = "Test";
            //employee.salary = 100;
            //employee.permission = (Permission)3;
            //Permission MyP = (Permission)3;
            //MyP = MyP |Permission.execute;
            //Console.WriteLine(MyP); 
            #endregion


        }



    }
}
