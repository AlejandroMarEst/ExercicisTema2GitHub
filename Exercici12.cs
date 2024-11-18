using System;
using MyLibraryAleMar;
namespace ExercicisTema2
{
    public class Program
    {
        public static void Main()
        {
            const string InsertaTemperatura = "Inserta un numero de graus Cº i retornare els grauns en Fº";
            const string TemperaturaFahr = "La teva temperatura en Fahrenheit es: {0}Fº";
            const string Error = "El valor introduit ha de ser numeric";
            int gradosUser;
            Console.WriteLine(InsertaTemperatura);
            try
            {
                gradosUser = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(TemperaturaFahr, Utils.CelsiusToFahr(gradosUser));
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}