using System;

class Programa
{
    static void Main()
    {
        Console.Write("Valor Presente: ");
        decimal valorPresente = decimal.Parse(Console.ReadLine());

        Console.Write("Taxa de Juros (%): ");
        decimal taxaJuros = decimal.Parse(Console.ReadLine());

        Console.Write("Período (meses): ");
        int periodoMes = int.Parse(Console.ReadLine());

        decimal percentualJuros = taxaJuros / 100;

        double valorFuturo = (double)valorPresente * Math.Pow((double)(1 + percentualJuros), periodoMes);
        
        Console.WriteLine($"Valor Futuro: {valorFuturo:F2}");

        


    }
}