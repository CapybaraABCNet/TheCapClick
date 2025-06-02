using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string i;
        int h = 0;
        string w;
        Console.WriteLine("TheCapClick");
        Console.WriteLine("-------------");
        Console.WriteLine("Привет! это TheCapClick! пиши +1 чтобы зарабатывать коины, чтобы пойти в магазин пиши magaz");
        Console.WriteLine("Хорошей игры!");
        while (true)
        {
            i = Console.ReadLine();
            if (i == "+1")
            {
                h = h + 1;
                Console.WriteLine("У вас " + h + " коинов");
            }
            else if (i == "magaz")
            {
                Console.WriteLine("выбери товар: чипсы [80 коинов], жвачка [40], мороженое [50], сухарики [35], кукурузные палочки [50]");
                w = Console.ReadLine();
                if (w == "чипсы")
                {
                    if (h>79)
                    {
                        h = h - 80;
                        Console.WriteLine("вы купили чипсы");
                    }
                    else
                    {
                        Console.WriteLine("вам не хватает коинов");
                    }
                }
                else if (w == "жвачка")
                {
                    if (h>39)
                    {
                        h = h - 40;
                        Console.WriteLine("вы купили жвачку");
                    }
                    else
                    {
                        Console.WriteLine("вам не хватает коинов");
                    }
                }
                else if (w == "мороженое")
                {
                    if (h>49)
                    {
                        h = h - 50;
                        Console.WriteLine("вы купили мороженое");
                    }
                    else
                    {
                        Console.WriteLine("вам не хватает коинов");
                    }
                }
                else if (w == "сухарики")
                {
                    if (h>34)
                    {
                        h = h - 35;
                        Console.WriteLine("вы купили сухарики");
                    }
                    else
                    {
                        Console.WriteLine("вам не хватает коинов");
                    }
                }
                else if (w == "кукурузные палочки")
                {
                    if (h<49)
                    {
                        h = h - 50;
                        Console.WriteLine("вы купили кукурузные шарики");
                    }
                    else
                    {
                        Console.WriteLine("вам не хватает коинов");
                    }
                }

            }
        }
    }
}