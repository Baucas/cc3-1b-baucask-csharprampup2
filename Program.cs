﻿namespace CSharpRampUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            //Pounds to Kilograms
            Console.WriteLine("Pounds(lbs) to Kilograms(kgs):");
            Console.WriteLine("Enter the number: ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kilograms = pounds * 0.453592;
            Console.WriteLine("Weight in Pounds (lbs): " + pounds);
            Console.WriteLine("Weight converted to Kilograms (kg): " + kilograms);

            //Miles to Kilometers
            Console.WriteLine("Miles(mi) to Kilometers(Km):");
            Console.WriteLine("Enter the number: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilometers = miles * 1.60934;
            Console.WriteLine("Lenght in Miles (mi): " + miles);
            Console.WriteLine("Lenght converted to Kilometers (km): " + kilometers);

            //Fahrenheit to Celcius
            Console.WriteLine("Fahrenheit(°F) to Celcius(°C):");
            Console.WriteLine("Enter the number: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celcius = 5.0 / 9.0 * (fahrenheit - 32);
            Console.WriteLine("Temperature in Fahrenheit (°F): " + fahrenheit);
            Console.WriteLine("Temperature converted to Celcius (°C): " + celcius);

            //Average age of the students
            Console.WriteLine("Enter the Age of student 1: ");
            double student1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Age of student 2: ");
            double student2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Age of student 3: ");
            double student3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Age of student 4: ");
            double student4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Age of student 5: ");
            double student5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Age of student 6: ");
            double student6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Age of student 7: ");
            double student7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Age of student 8: ");
            double student8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Age of student 9: ");
            double student9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Age of student 10: ");
            double student10 = Convert.ToDouble(Console.ReadLine());

            double average = (student1 + student2 + student3 + student4 + student5 + student6 + student7 + student8 + student9 + student10)/(10);

            Console.WriteLine("Age of student 1:" + student1);
            Console.WriteLine("Age of student 2:" + student2);
            Console.WriteLine("Age of student 3:" + student3);
            Console.WriteLine("Age of student 4:" + student4);
            Console.WriteLine("Age of student 5:" + student5);
            Console.WriteLine("Age of student 6:" + student6);
            Console.WriteLine("Age of student 7:" + student7);
            Console.WriteLine("Age of student 8:" + student8);
            Console.WriteLine("Age of student 9:" + student9);
            Console.WriteLine("Age of student 10:" + student10);
            Console.WriteLine("The average age of the students is:" + average);

            //Fantasy story
            Console.WriteLine("Fantasy Story");
            Console.WriteLine("Enter the 5 names of your favorite characters: ");
            Console.WriteLine("Your Character 1:");
            string character1 = Console.ReadLine();
            Console.WriteLine("Equipment name of the character 1");
            string equipment1 = Console.ReadLine();
            Console.WriteLine("Item name or ability name of character 1");
            string item1 = Console.ReadLine();

            Console.WriteLine("Your Character 2:");
            string character2 = Console.ReadLine();
            Console.WriteLine("Equipment name of the character 2");
            string equipment2 = Console.ReadLine();
            Console.WriteLine("Item name or ability name of character 2");
            string item2 = Console.ReadLine();

            Console.WriteLine("Your Character 3:");
            string character3 = Console.ReadLine();
            Console.WriteLine("Equipment name of the character 3");
            string equipment3 = Console.ReadLine();
            Console.WriteLine("Item name or ability name of character 3");
            string item3 = Console.ReadLine();

            Console.WriteLine("Your Character 4:");
            string character4 = Console.ReadLine();
            Console.WriteLine("Equipment name of the character 4");
            string equipment4 = Console.ReadLine();
            Console.WriteLine("Item name or ability name of character 4");
            string item4 = Console.ReadLine();

            Console.WriteLine("Your Character 5:");
            string character5 = Console.ReadLine();
            Console.WriteLine("Equipment name of the character 5");
            string equipment5 = Console.ReadLine();
            Console.WriteLine("Item name or ability name of character 5");
            string item5 = Console.ReadLine();


            Console.WriteLine($"Once upon a time, there once were four heroes summoned in the Igorot Kingdom. They were named {character1}, {character2}, {character3}, {character4}, and {character5}.");
            Console.WriteLine($"Each hero wielded a unique set of equipment. {character1} carried a mighty {equipment1}, {character2} brandished a magical {equipment2}, {character3} donned an enchanted {equipment3}, {character4} wore a legendary {equipment4}, and {character5} wielded a powerful {equipment5}.");
            Console.WriteLine($"In addition to their equipment, each hero possessed a special item or ability. {character1} had the extraordinary power of {item1}, {character2} could manipulate the elements with {item2}, {character3} could teleport instantly using {item3}, {character4} could read minds with {item4}, and {character5} could control time itself with {item5}.");
            Console.WriteLine($"The Igorot Kingdom was under a dark threat from an ancient evil that lurked in the shadows. The heroes, united by destiny, set out on a perilous journey to uncover the source of the darkness and vanquish it.");
            Console.WriteLine($"Their path was fraught with challenges, from treacherous landscapes to mythical creatures. Along the way, they discovered the true power of their {equipment1}, {equipment2}, {equipment3}, {equipment4}, and {equipment5}, as well as the potential of their {item1}, {item2}, {item3}, {item4}, and {item5}.");
            Console.WriteLine($"As they reached the heart of the kingdom, a formidable foe, a dragon named Drakonex, awaited them. With a combination of their unique abilities and the strength of their {equipment1}, {equipment2}, {equipment3}, {equipment4}, and {equipment5}, the heroes engaged in an epic battle.");
            Console.WriteLine($"The clash between the heroes and Drakonex shook the very foundations of Igorot Kingdom. In the end, the heroes emerged victorious, banishing the darkness and restoring peace to the land.");
            Console.WriteLine($"The Igorot Kingdom celebrated the bravery of {character1}, {character2}, {character3}, {character4}, and {character5}, and their names were etched into the annals of history as legendary heroes who saved the realm from impending doom.");

            //Part 2
            //Write a program to that receives an input and prints the following number pattern using a loop. If output is zero or negative number an "Invalid input" should be displayed.
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32( Console.ReadLine() );

            if (number <= 0)
            { Console.WriteLine("Invalid, Please enter a positive number");
            }

            else
                for (int i = 1; i <= number; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }

            //Write a program that receives an input and prints the following number pattern using a loop. If output is zero or negative number an "Invalid input" should be displayed.
            Console.WriteLine("Enter a number:");
            int numb = Convert.ToInt32( Console.ReadLine() );

            if (numb <= 0)
            {
                Console.WriteLine("Invalid, Please enter a whole number.");
            }

            else
            {
                int total = 0;
                for (int i = 1; i <= numb; i++)
                {
                    total += i;
                }
                Console.WriteLine("The total is:" + total);
            }

            //Write a program to print the following number pattern using a loop. If output is zero or negative number an "Invalid input" should be displayed.
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32 ( Console.ReadLine() );

            if (num <= 0)
            {
                Console.WriteLine("Invalid. Please print a whole number");
            }

            else
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= num - i + 1; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
