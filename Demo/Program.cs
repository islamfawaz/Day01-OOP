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

        }
    }
}
