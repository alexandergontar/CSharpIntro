using System;
using System.Collections;
using System.Collections.Generic;

namespace GBtest1
{
    class Program
    {
        static void promptMessage() 
        {
           Console.WriteLine(@"            Выберите действие:
            1 - добавить собаку 
            2 - добавить кошку
            3 - добавить хомяка
            4 - добавить лошадь
            5 - добавить осла
            6 - добавить верблюда
            10 - вывести список
            0 - выход"); 
        }

        static void displayAnimals(List<Animal> animals) 
        {
            if (animals.Count == 0 || animals == null)
            {
                Console.WriteLine("Список животных пуст.\n");
                return;
            }
            int n = 1;
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{n}. Кличка: {animal.Name} Возраст: {animal.Age}" +
                    $" Животное: {animal.GetType().Name} Тип: {animal.GetType().BaseType.Name}");
                n++;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Counter counter = new Counter();
            while (true)
            {
                promptMessage();
                try
                {
                    int action = int.Parse(Console.ReadLine());
                    if (action == 0) break;
                    if (action == 10)
                    {
                        displayAnimals(animals);
                        continue;
                    }
                    Console.WriteLine("Введите кличку животного:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите возраст животного:");
                    int age = int.Parse(Console.ReadLine());
                    switch (action)
                    {                        
                        case 1: Animal dog = new Dog(name, age);
                            animals.Add(dog);
                            break;
                        case 2:
                            Animal cat = new Cat(name, age);
                            animals.Add(cat);
                            break;
                        case 3:
                            Animal hamster = new Hamster(name, age);
                            animals.Add(hamster);
                            break;
                        case 4:
                            Animal horse = new Horse(name, age);
                            animals.Add(horse);
                            break;
                        case 5:
                            Animal donkey = new Donkey(name, age);
                            animals.Add(donkey);
                            break;
                        case 6:
                            Animal camel = new Camel(name, age);
                            animals.Add(camel);
                            break;
                        
                        default:
                            break;
                    }
                    Console.WriteLine("Число животных: " + counter.getCount()+"\n");
                                      
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    Console.WriteLine("Неверный ввод");
                    continue;
                }                
            }            
        }
    }
}
