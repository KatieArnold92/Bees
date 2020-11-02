using System;
using System.Collections.Generic;
using System.Linq;

namespace Bees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bee Exercise!\n----------------------------\n\n");

            //Generate random numbers for our damage.
            Random randomGenerator = new Random();

            //Initialize all 10 of each kind of bee in a list of bees.
            List<Bee> beeList = new List<Bee>();
            for(int i = 0; i < 10; i++)
            {
                beeList.Add(new Queen());
                beeList.Add(new Drone());
                beeList.Add(new Worker());
            }

            Console.WriteLine("Bees have been initialized... there are a total of " + beeList.Count + " bees.\n\n");

            //Simple while(true) loop for either exiting the application or applying more damage to the bees.
            while(true)
            {
                Console.Write("Enter '!' to exit, or any other key to damage the bees:");
                string result = Console.ReadLine();
                if (result == "!")
                    break;
                else
                {
                    //Iterate through all bees in list and apply damage between 0 and 80.
                    foreach (Bee bee in beeList)
                        bee.Damage(randomGenerator.Next(81));

                    Console.WriteLine("\nThe bees have been hurt! Shame on you!\n");
                    //Print new bee states and health values.
                    PrintBees(beeList);
                }
            }
        }

        //Method to print all bee states and health values.
        public static void PrintBees(List<Bee> beeList)
        {
            Console.WriteLine("Here's the current state of each bee...\n\n");

            Console.WriteLine("Workers:\n");
            foreach (Worker worker in beeList.OfType<Worker>())
                Console.WriteLine("Health: " + worker.Health + "\t\t Dead?: " + (worker.IsDead ? "Yes." : "No.") );

            Console.WriteLine("\nDrones:\n");
            foreach (Drone drone in beeList.OfType<Drone>())
                Console.WriteLine("Health: " + drone.Health + "\t\t Dead?: " + (drone.IsDead ? "Yes." : "No.") );

            Console.WriteLine("\nQueens:\n");
            foreach (Queen queen in beeList.OfType<Queen>())
                Console.WriteLine("Health: " + queen.Health + "\t\t Dead?: " + (queen.IsDead ? "Yes." : "No.") );

            Console.WriteLine();
        }
    }
}
