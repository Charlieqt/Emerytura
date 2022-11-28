using System;
class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int[] X = Array.ConvertAll<string, int>(input.Split(" "), int.Parse);
        int wiek = X[0];
        int wiekEmerytalny = X[1];
        string nazwisko;
        

        Console.WriteLine($"Witaj !");
        if (wiek < 0 || wiekEmerytalny < 0)
        {
            Console.WriteLine("Wiek nie może być ujemny");
        }
        else
        {
            if (wiek < wiekEmerytalny)
            {
                Console.WriteLine($"Do emerytury brakuje Ci {wiekEmerytalny - wiek} lat .");

            }
            else
            {
                Console.WriteLine("Jesteś emerytem");
            }
        }






    }
}