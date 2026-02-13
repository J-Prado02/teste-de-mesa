class Programa3
{
    static void Main()
    {
        int a = 7;

        int b = a - 6;

        int[] vetor = new int [a];

        while (b < a)
        {
            vetor[b] = b + a;

            Console.WriteLine(vetor [b]);

            b += 2;
        }

    }
}