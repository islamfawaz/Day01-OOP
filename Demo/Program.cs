using Common;
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
            Gender myGender;
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
        }
    }
}
