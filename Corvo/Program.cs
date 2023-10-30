using System;

class Program
{
    public static void Main(string[] args)
    {
        int valor = 0;
        int vezes = 0;
        string piscada;
        int[] total = new int[3];

        while (vezes != 3)
        {

            do
            {
                piscada = Console.ReadLine();
                if (piscada[2] == '*')
                {
                    valor++;
                }
                if (piscada[1] == '*')
                {
                    valor += 2;
                }
                if (piscada[0] == '*')
                {
                    valor += 4;
                }
            } while (piscada.Equals("caw caw") == false);
            total[vezes] = valor;
            valor = 0;
            vezes++;
        }

        foreach (int i in total)
        {
            Console.WriteLine(i);
        }
    }
}
