﻿using System;

namespace Farm
{
    class Controller
    {
        public static void Game()
        {
            Console.WriteLine("Привет! какое животное ты хочешь выбрать? \n1)Котик \n2)Собака \n3)Лошадь");
            int choice = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (choice)
                {
                    case 1:
                        Eat eat = new Eat("viskas", 20);
                        Cat cat = new Cat("", 30);

                        Console.WriteLine("Введите имя котика: ");
                        cat.name = Console.ReadLine();
                        Console.WriteLine($"Котика зовут {cat.name} и его сытость {cat.hunger}\n");
                        while (true)
                        {
                            Console.WriteLine("Что хотите сделать \n1)Голос \n2)Кушать \n3)Играть \n4)Бегить \n5)Спать \n6)Информация \n7)Выход");
                            int a = int.Parse(Console.ReadLine());
                            if (a == 1)
                            {
                                cat.Meow();
                            }
                            if (a == 2)
                            {
                                cat.Niam(eat, cat);
                            }
                            if (a == 3)
                            {
                                cat.Play();
                                if (cat.hunger < 5)
                                {
                                    Console.WriteLine("Cat died =((((((");
                                    break;

                                }
                            }
                            if (a == 4)
                            {
                                cat.Run();
                                if (cat.hunger < 5)
                                {
                                    Console.WriteLine("Cat died =((((((");
                                    break;

                                }
                            }
                            if (a == 5)
                            {
                                cat.Sleep();
                                if (cat.hunger < 5)
                                {
                                    Console.WriteLine("Cat died =((((((");
                                    break;

                                }
                            }
                            if (a == 6)
                            {
                                cat.Print();
                            }
                            if (a == 7)
                            {
                                break;
                            }
                            continue;
                        }
                        break;
                    case 2:
                        Eat eat1 = new Eat("meal", 15);
                        Dog dog = new Dog("", 50);

                        Console.WriteLine("Введите имя собаки: ");
                        dog.name = Console.ReadLine();
                        Console.WriteLine($"Собаку зовут {dog.name} и его сытость {dog.hunger}\n");
                        while (true)
                        {
                            Console.WriteLine("Что хотите сделать \n1)Голос \n2)Кушать \n3)Играть \n4)Бегить \n5)Спать \n6)Информация \n7)Выход");
                            int a = int.Parse(Console.ReadLine());
                            if (a == 1)
                            {
                                dog.Bark();
                            }
                            if (a == 2)
                            {
                                dog.Niam(eat1, dog);
                            }
                            if (a == 3)
                            {
                                dog.Play();
                                if (dog.hunger < 5)
                                {
                                    Console.WriteLine("Dog died =((((((");
                                    break;

                                }
                            }
                            if (a == 4)
                            {
                                dog.Run();
                                if (dog.hunger < 5)
                                {
                                    Console.WriteLine("Dog died =((((((");
                                    break;

                                }
                            }
                            if (a == 5)
                            {
                                dog.Sleep();
                                if (dog.hunger < 5)
                                {
                                    Console.WriteLine("Dog died =((((((");
                                    break;

                                }
                            }
                            if (a == 6)
                            {
                                dog.Print();
                            }
                            if (a == 7)
                            {
                                break;
                            }
                            continue;
                        }
                        break;
                    case 3:
                        Eat eat2 = new Eat("apple", 10);
                        Horse horse = new Horse("", 40);

                        Console.WriteLine("Введите имя лошади: ");
                        horse.name = Console.ReadLine();
                        Console.WriteLine($"Лошадь зовут {horse.name} и его сытость {horse.hunger}\n");
                        while (true)
                        {
                            Console.WriteLine("Что хотите сделать \n1)Голос \n2)Кушать \n3)Играть \n4)Бегить \n5)Спать \n6)Информация \n7)Выход");
                            int a = int.Parse(Console.ReadLine());
                            if (a == 1)
                            {
                                horse.Sound();
                            }
                            if (a == 2)
                            {
                                horse.Niam(eat2, horse);
                            }
                            if (a == 3)
                            {
                                horse.Play();
                                if (horse.hunger < 5)
                                {
                                    Console.WriteLine("Horse died =((((((");
                                    break;

                                }
                            }
                            if (a == 4)
                            {
                                horse.Run();
                                if (horse.hunger < 5)
                                {
                                    Console.WriteLine("Horse died =((((((");
                                    break;

                                }
                            }
                            if (a == 5)
                            {
                                horse.Sleep();
                                if (horse.hunger < 5)
                                {
                                    Console.WriteLine("Horse died =((((((");
                                    break;

                                }
                            }
                            if (a == 6)
                            {
                                horse.Print();
                            }
                            if (a == 7)
                            {
                                break;
                            }
                            continue;
                        }
                        break;



                    default:
                        break;
                }
                break;
            }
        }
    }
}
