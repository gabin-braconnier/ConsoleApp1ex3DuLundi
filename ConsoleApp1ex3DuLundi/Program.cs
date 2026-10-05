using System;

class Program
{
    static void Main()
    {
        double capital = 1200;
        double taux = 1.3;

        Console.Write("Combien d'années ? ");
        int nbAnnees = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nbAnnees; i++)
        {
            capital = capital + capital * taux / 100;
        }

        Console.WriteLine("Après " + nbAnnees + " an(s), le capital est de " + Math.Round(capital, 2) + " €.");
    }
}