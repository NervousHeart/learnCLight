﻿using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вспышка фотокамеры на секунду ослепила вас. Проморгавшись вы устало смотрите на человека напротив." +
                "\n- Мы все хдесь устали, поэтому работаем быстро. - Мужчина потер переносицу ручкой и тяжело поднял на вас взгляд. " +
                "\n- Подтвердим показания и вы сможете уйти. Начнем: как вас зовут?" +
                "\n\n(Введите ваше имя:)");

            string name = Console.ReadLine();


            Console.WriteLine($"\n-{name}? Хорошо, сколько вам полных лет?" +
                $"\n\n(Введите количество полных лет:)");

            byte age = Convert.ToByte(Console.ReadLine());


            Console.WriteLine("\n-Отлично, последний вопрос: номер учебной группы?");
            string numberGroup = Console.ReadLine();


            Console.WriteLine($"\n\nВыдержка из протокола №2104" +
                $"\n\nВо время проведения концерта на территории учебного комплекса \"Заря\" " +
                $"\nнеизвестные подожгли чучело директора данного заведения." +
                $"\nНа месте поджога задержали несколько подозреваемых." +
                $"\nОдин из них ученик группы номер {numberGroup} по имени {name}, {age} лет.");


        }
    }
}
