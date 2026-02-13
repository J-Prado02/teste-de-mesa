using System;

class Programa
{
    static void Main()
    {

        Console.Write("Valor Presente: ");
        double valorPresente = double.Parse(Console.ReadLine());

        decimal percentualJuros = 1.25m;


        for(int mes = 1; mes <= 6; mes++)
        {
            double valorFuturo = (double)valorPresente * Math.Pow((double)(1 + percentualJuros), 6);

            double[] rendimentos = new double[6];

            rendimentos[mes -1] = valorFuturo;

            Console.WriteLine(rendimentos[mes]);
        }

    }
}