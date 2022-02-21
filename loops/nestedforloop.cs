using System;
class Forloop
{
    static void Main(String[] args)
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 2; j <= 10; j++)
            {
                j++;
                Console.WriteLine("j");

            }
            for (int l = 2; l <= 10; l++)
            {
                l = l * l;
                Console.WriteLine("l");

            }
            for (int m = 2; m <= 10; m++)
            {
                m = m * m * m;
                Console.WriteLine("m");
            }
        }
    }
}