﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("SumChicken");



            Console.WriteLine("Ayo shrimpiez");
            int mslng = Convert.ToInt32(Console.ReadLine());
            int[,] ms = new int[50,50];
            for (int i = 0; i < mslng; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < mslng; j++)
                {
                    ms[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"| {j}");
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < mslng; i++) {
                for (int j = 0; j < mslng; j++)
                {
                    Console.Write($"{ms[i,j]} ");
                }
                Console.WriteLine();
            }
            {
                /*Game N001 = new Game("Gayshit", 10.6, "RPG", 26);
                var N002 = new Game("Honkai", 25.1, "RPG", 79);
                Console.WriteLine(SumTools.JumpByTwo(3));
                Console.WriteLine(Game.GetTotalSize());
                var sumdouble = Convert.ToDouble(Console.ReadLine());
                var MixedVar = SumTools.JumpByTwo(sumdouble);
                int[,] msinp;
                Console.WriteLine("\nUr variable type: {0}\n" +
                    "Ur variable itself: {1}", MixedVar.GetType().ToString(), MixedVar.ToString());
                Random rnd = new Random();
                while (sumdouble == sumdouble)
                {
                    int rndint = rnd.Next(10);
                    Console.Write($"\u001b[35m{rndint}\u001b[0m");
                }*/
            }
        }
    }
}

/*
3. Побег
 Связанные Хаос/Мог также могут друг друга выводит.
049, 096 также может сбежать и стать spectator.

4. Имена
Каждому присоеденившемуся игроку даётся РП имя. (как бейдж)

5. 049
При команде .random в BC (чумному и человек,
на которого он смотрит) пишется такие фразы:
1. человек заражён поветрием
2. человек здоров
 */