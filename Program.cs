using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1

            Console.WriteLine("Определение четного и нечетного числа");
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 != 0)
            {
                Console.WriteLine($"Введенное число {number} является нечетным\n");
            }
            else
            {
                Console.WriteLine($"Введенное число {number} является четным\n");
            }

            //Задание 2

            Console.WriteLine("Карточная игра Black Jack");
            Console.WriteLine("Сколько у Вас на руках карт? Введите число от 1 до 3");

            int numberOfCards = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int j = 0; j < numberOfCards; j++)
            {
                Console.WriteLine($"Введите номинал {j+1} карты : от 2 до 10 или J,Q,K,T");
                
                var card = Console.ReadLine();
                switch (card)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        sum += int.Parse(card);
                        break ;
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        Console.WriteLine("Нет такой карты");
                        break;
                }
            }
            Console.WriteLine($"Сумма карт : {sum}\n");

            //Задание 3

            Console.WriteLine("Определение простго числа — числа, которое делится только само на себя и на единицу");
            Console.WriteLine("Введите число больше 1");
            int simpleNumber = int.Parse(Console.ReadLine());
            bool flag = false;
            while (simpleNumber>1) 
            {
                for (int i = 2; i < simpleNumber; i++)
                {
                    if (simpleNumber % i == 0)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                        continue;
                    }
                }
                break;
                
            }
            if (flag)
            {
                Console.WriteLine($"Число {simpleNumber} не является простым");
            }
            else
            {
                Console.WriteLine($"Число {simpleNumber} является простым");
            }

            Console.ReadLine();
        }
    }
}
