﻿using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Легенда:
            
            Вы приходите в магазин и хотите купить за своё золото кристаллы. 
            В вашем кошельке есть какое-то количество золота,
            продавец спрашивает у вас, сколько кристаллов вы хотите купить?
            После сделки у вас остаётся какое-то количество золота и появляется какое-то количество кристаллов.

            Формально:

            При старте программы пользователь вводит начальное количество золота.
            Потом ему предлагается купить какое-то количество кристаллов по цене N(задать в программе самому).
            Пользователь вводит число и его золото конвертируется в кристаллы.
            Остаток золота и кристаллов выводится на экран. */

            Console.WriteLine("Вы проснулись рано утром и сразу же отправились готовить свой любимый кофе, но вот незадача: " +
                "\nВ чайнике закончились кристаллы! Пока день еще не испорчен нужно скорее бежать в магазин кристаллов! " +
                "\nВы быстро добераетесь до магазина и проверяете свой кошелек.");

            Console.WriteLine("\nВведите количество вашего золота в кошельке: ");

            uint yourGold = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine($"\nУ вас в кошельке {yourGold} золотых монет");

            Console.WriteLine("\nВы заходите в магазин и подходите к прилавку, за которым сидит усталый кассир. " +
                "\n\n- Один кристал стоит 10 золотых монет. - Зевая произнес кассир." +
                "\n\nВ шоке от такой наглости вы используете все возможные навыки, чтобы сторговать цену получше.");

            Console.WriteLine("\nВведите новую цену:");
            byte newPrice = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"\n-Хорошо, хорошо, только перестань, для тебя 1 кристалл стоит {newPrice} золотых. - сдается под вашим напором кассир." +
                $"\n\nОткрыленные своим успехов вы покупаете на все ваши деньги криссталлы!" +
                $"\n\nТеперь у вас {yourGold / newPrice} криссталов и {yourGold%newPrice} золотых.");
            Console.WriteLine("\nВернувшись домой вы не раздеваясь идете на кухню и открываете кофеварку, чтобы заменить кристалл..." +
                "\n..." +
                "\n..." +
                "\nСтранно, но кристалл в кофеварке еще рабочий. Осмотрев кофеварку вы понимаете, что забыли нажать на кнопку питания.");


        }
    }
}
