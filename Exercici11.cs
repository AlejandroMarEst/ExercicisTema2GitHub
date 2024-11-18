using System;
using MyLibraryAleMar;

public class Exercici11
{
	public Class1()
	{
		public static void Main()
		{
            const string PreguntaIntents = "Quants nums vols introduir?";
            const string PreguntaNumero = "Inserta un numero:";
            const string NumOutsideInterval = "El numero no esta dins l'inteval, intenta un altre vegada:";
            const string OutOfTries = "No et queden intents, game over";
            const string Error = "Els valors han de ser numerics";
            int producte;
            int numeroInsertat;
            int numeroDeInputs;
            const int min = 15;
            const int max = 100;
            int tries = 5;
            Console.WriteLine(PreguntaIntents);
            try
            {
                producte = 0;
                numeroDeInputs = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numeroDeInputs; i++)
                {
                    Console.WriteLine(PreguntaNumero);
                    numeroInsertat = Convert.ToInt32(Console.ReadLine());
                    while (Utils.CheckInterval(numeroInsertat, min, max) == false || tries != 0)
                    {
                        tries--;
                        Console.WriteLine(NumOutsideInterval);
                        numeroInsertat = Convert.ToInt32(Console.ReadLine());
                    }
                    if (tries != 0)
                    {
                        Utils.ProducteDeNumerosInsertats(numeroInsertat, ref producte);
                    }
                    else
                    {
                        numeroDeInputs = 0;
                        Console.WriteLine(OutOfTries);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }

        }
    }
}
