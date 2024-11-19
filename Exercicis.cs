using System;
using MyLibraryAleMar;
namespace ExercicisTema2
{
    public class Program
    {
        public static void Main()
        {
            const string InsertaNum = "Inserta un nombre enter";
            const string InsertaNum2 = "Inserta un altre nombre enter";
            const string TeuNum = "Els nombre més gran és {0} i el més petit és {1}";
            const string Igual = "Els nombres tenen el mateix valor";
            const string Error = "El valor ha de ser numeric";
            int NumUser;
            int NumUser2;
            Console.WriteLine(InsertaNum);
            try
            {
                NumUser = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(InsertaNum2);
                NumUser2 = Convert.ToInt32(Console.ReadLine());
                if (Utils.BiggerSmaller(NumUser, NumUser2) == 0)
                {
                    Console.WriteLine(Igual);
                }
                else if (Utils.BiggerSmaller(NumUser, NumUser2) == NumUser)
                {
                    Console.WriteLine(TeuNum, NumUser, NumUser2);
                }
                else {
                    Console.WriteLine(TeuNum, NumUser2, NumUser2);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}