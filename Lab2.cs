using System;
public class Prog
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        int nechet=0;
        for (int i = 0; i < num; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 != 0)
            {
                nechet++;
            }
            
        }
        if (nechet == num)
        {
            Console.WriteLine("Все элементы нечетные");
        }
        else
        {
            Console.WriteLine("Не все элементы нечетные");
        }









    }
}


