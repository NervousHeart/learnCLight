﻿using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вы проснулись рано утром и сразу же отправились готовить свой любимый кофе, но вот незадача: " +
                "\nВ чайнике закончились кристаллы! Пока день еще не испорчен нужно скорее бежать в магазин кристаллов! " +
                "\nВы быстро добераетесь до магазина и проверяете свой кошелек.");

            Console.WriteLine("\nВведите количество вашего золота в кошельке: ");

            int gold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nУ вас в кошельке {gold} золотых монет");

            Console.WriteLine("\nВы заходите в магазин и подходите к прилавку, за которым сидит усталый кассир. " +
                "\n\n- Один кристал стоит 10 золотых монет. - Зевая произнес кассир." +
                "\n\nВ шоке от такой наглости вы используете все возможные навыки, чтобы сторговать цену получше.");

            Console.WriteLine("\nВведите новую цену:");
            int discountPrice = Convert.ToInt32(Console.ReadLine());
            int crystal = gold / discountPrice;
            gold %=discountPrice;

            Console.WriteLine($"\n-Хорошо, хорошо, только перестань, для тебя 1 кристалл стоит {discountPrice} золотых. - сдается под вашим напором кассир." +
                $"\n\nОткрыленные своим успехов вы покупаете на все ваши деньги криссталлы!" +
                $"\n\nТеперь у вас {crystal} криссталов и {gold} золотых.");
            Console.WriteLine("\nВернувшись домой вы не раздеваясь идете на кухню и открываете кофеварку, чтобы заменить кристалл..." +
                "\n..." +
                "\n..." +
                "\nСтранно, но кристалл в кофеварке еще рабочий. Осмотрев кофеварку вы понимаете, что забыли нажать на кнопку питания.");


        }
    }
}