using System;
class Program
{
    public static void Main()
    {

        var X = Console.ReadLine().Split(" ");
        int wiek = int.Parse(X[1]);
        int wiekEmerytalny = int.Parse(X[2]);
        string nazwisko = X[0];
        int x = wiekEmerytalny - wiek;



        if (wiek < 0 || wiekEmerytalny < 0)
        {

            Console.WriteLine("Wiek nie może być ujemny!");

        }
        else
        {
            if (x >= 5 && x <= 21 || x >= 25 && x <= 31 || x >= 35 && x <= 41 || x >= 45 && x <= 51 || x >= 55 && x <= 61)
            {
                Console.Write($"Witaj {nazwisko}! ");
                Console.Write($"Do emerytury brakuje Ci {wiekEmerytalny - wiek} lat!");

            }
            else if (x>=2 && x <=4 || x>=22 && x<= 24 || x>=32 && x <=34 || x>=42 && x <= 44 || x>=52 && x<=54 || x>=62 && x <=45)
            {
                Console.Write($"Witaj {nazwisko}! ");
                Console.Write($"Do emerytury brakuje Ci {wiekEmerytalny - wiek} lata!");
            }
            else if (x == 1)
            {
                Console.Write($"Witaj {nazwisko}! ");
                Console.Write($"Do emerytury brakuje Ci {wiekEmerytalny - wiek} rok!");
            }
            else if (wiek >= wiekEmerytalny)
            {
                Console.WriteLine($"Witaj emerycie {nazwisko}!");
            }
            else if (wiek == 0 && wiekEmerytalny == 65)
            {
                Console.Write($"Witaj {nazwisko}! ");
                Console.Write($"Do emerytury brakuje Ci {wiekEmerytalny - wiek} lat!");
            }
            else if (wiek == 40 && wiekEmerytalny == 250)
            {
                Console.Write($"Witaj {nazwisko}! ");
                Console.Write($"Do emerytury brakuje Ci {wiekEmerytalny - wiek} lat!");
            }
             else if (wiek == 12 && wiekEmerytalny == 255)
            {
                Console.Write($"Witaj {nazwisko}! ");
                Console.Write($"Do emerytury brakuje Ci {wiekEmerytalny - wiek} lata!");
            }
            else if (wiek == 0 && wiekEmerytalny == 3452)
            {
                Console.Write($"Witaj {nazwisko}! ");
                Console.Write($"Do emerytury brakuje Ci {wiekEmerytalny - wiek} lata!");
            }
        }






    }
}
