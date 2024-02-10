using System;

//Napisz program, który w 100-elementowej tablicy jednowymiarowej umieszcza liczby z przedziału od 1 do 100,
//a następnie sumuje liczby parzyste i nieparzyste należące do tego przedziału.

class Przelaczanie
{
    static void Main(string[] args)
    {
        int[,] numbers = new int[10, 10];
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                numbers[i, j] = random.Next(1, 101);
            }
        }

        Console.WriteLine("Zawartość tablicy: ");
        for (int i = 0;i < 10; i++)
        {
            for (int j = 0;j < 10; j++)
            {
                Console.WriteLine(numbers[i, j] + "\t");
            }
        }

        int sumOfEven = 0;
        int sumOfOdd = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (numbers[i, j] % 2 == 0)
                {
                    sumOfEven += numbers[i, j];
                }
                else
                {
                    sumOfOdd += numbers[i, j];
                }
            }
        }

        Console.WriteLine($"Suma liczb parzystych wynosi: {sumOfEven}.");
        Console.WriteLine($"Suma liczb nieparzystych wynosi: {sumOfOdd}.");
    }
}