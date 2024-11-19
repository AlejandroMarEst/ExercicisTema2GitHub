using System;
using MyLibraryAleMar;
namespace ExercicisTema2
{
    public class Program
    {
        public static void Main()
        {
            const string InsertaNum = "Inserta un nombre enter de minuts";
            const string TeuNum = "Els teus minuts a segons son: {0}s";
            const string Error = "El valor ha de ser numeric";
            int NumUser;
            Console.WriteLine(InsertaNum);
            try
            {
                NumUser = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(TeuNum, Utils.MinutesToSeconds(NumUser));
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}