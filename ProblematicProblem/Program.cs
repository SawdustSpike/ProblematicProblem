using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;

namespace ProblematicProblem
{
    class Program 
    {
       
static bool cont = false;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
{
            Random rng = new Random();
            while (cont == false)
            {
                Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
                string ans1 = Console.ReadLine();
                switch (ans1.ToLower())
                {
                    case "yes":
                    case "sure":
                    case "yeah":
                    case "true":
                        Console.WriteLine("Excellent!");
                        cont = true;
                        break;
                    case "no":
                    case "nope":
                    case "false":
                    case "nah":
                        Console.WriteLine("Then why are you here? come on..");
                        break;
                    default:
                        Console.WriteLine("It's a yes or no question. Unless endless loops are your idea of a fun activity?");
                        break;
                }
            }
    Console.WriteLine();
    Console.Write("We are going to need your information first! What is your name? ");
    string userName = Console.ReadLine();
    Console.WriteLine();
    Console.Write("What is your age? ");
    int userAge = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Would you like to see the current list of activities? Yes or no?");
    bool seeList = (Console.ReadLine().ToLower() == "yes")? true : false;
    //= bool.Parse(Console.ReadLine());
    if (seeList == true)
    {
        foreach (string activity in activities)
        {
            Console.Write($"{activity} ");
            Thread.Sleep(250);
        }
        Console.WriteLine();
        Console.Write("Would you like to add any activities before we generate one? yes/no:");
        bool addToList = (Console.ReadLine() == "yes") ? true : false;
                Console.WriteLine();
        while (addToList == true)
        {
            Console.Write("What would you like to add? ");
            string userAddition = Console.ReadLine();
            activities.Add(userAddition);
            foreach (string activity in activities)
            {
                Console.Write($"{activity} ");
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to add more? yes/no: ");
            addToList = (Console.ReadLine().ToLower() == "yes") ? true : false;
                }
    }

    while (cont == true)
    {
        Console.Write("Connecting to the database");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
                Console.WriteLine();
                Console.Write("Choosing your random activity");
        for (int i = 0; i < 9; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
                Console.WriteLine();
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];
                if (userAge > 21 && randomActivity == "Wine Tasting")
        {
            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
            Console.WriteLine("Pick something else!");
            activities.Remove(randomActivity);
            randomNumber = rng.Next(activities.Count);
            randomActivity = activities[randomNumber];
        }
                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Do you hate it? Type yes if you want us to grab another activity.");
                Console.WriteLine();
        cont = (Console.ReadLine().ToLower() == "yes") ? true : false;
            }
}
    }
}