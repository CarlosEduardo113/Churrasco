using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantidade de adultos que consomem bebida alcoólica: ");
        int adultosBebem = int.Parse(Console.ReadLine());
        
        Console.Write("Quantidade de adultos que NÃO consomem bebida alcoólica: ");
        int adultosNaoBebem = int.Parse(Console.ReadLine());
        
        Console.Write("Quantidade de crianças: ");
        int criancas = int.Parse(Console.ReadLine());
        
        double carne = (adultosBebem + adultosNaoBebem) * 400 + criancas * 200;
        double acompanhamentos = (adultosBebem + adultosNaoBebem + criancas) * 200;
        double cerveja = adultosBebem * 2.0;
        double refrigerante = (adultosNaoBebem * 0.5) + (criancas * 0.5);
        double agua = (adultosBebem + adultosNaoBebem + criancas) * 0.4;
        
        Console.WriteLine("\n--- Quantidade de itens para o churrasco ---");
        Console.WriteLine("Carne: " + (carne / 1000).ToString("F2") + " kg");
        Console.WriteLine("Acompanhamentos: " + (acompanhamentos / 1000).ToString("F2") + " kg");
        Console.WriteLine("Cerveja: " + cerveja.ToString("F2") + " L");
        Console.WriteLine("Refrigerante: " + refrigerante.ToString("F2") + " L");
        Console.WriteLine("Água: " + agua.ToString("F2") + " L");
    }
}