using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    internal class User
    {
        public static void PorkSinigang()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("How many people would eat your sinigang?: ");
            int num = Convert.ToInt16 (Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("The list of ingredients are: ");
            Console.WriteLine($"{num * 0.85} cup/s Water");
            Console.WriteLine($"{num * 0.5} kg/s Pork");
            Console.WriteLine($"{num * 0.15} pc/s Onion");
            Console.WriteLine($"{num * 0.35} pc/s Tomato");
            Console.WriteLine($"{num * 0.15} pc/s Finger Chili");
            Console.WriteLine($"{num * 0.10} cup/s Sitaw");
            Console.WriteLine($"{num * 0.10} cup/s Radish");
            Console.WriteLine($"{num * 0.10} cup/s Okra");
            Console.WriteLine($"{num * 0.15} sachet/s Sinigang Mix");
            Console.WriteLine($"{num * 0.15} cup/s Kang kong");

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Continue to the Steps and Procedures?");
            Console.WriteLine("2. Skip and go to the cost?");
            Console.Write("\r\nSelect option by typing 1 and 2: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            if (num1 == 1) 
            {
                Console.WriteLine("---------------------------------------------------------");
                Instructions.PorkSinigangInstructions();

            }
            else if (num1 == 2) 
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Skipping...");
            }
            else 
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Invalid Input... Will proceed to the recipe's cost");
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Know the recipe's estimated cost?");
            Console.WriteLine("2. Logout?");
            Console.Write("\r\nSelect option by typing 1 and 2: ");
            int numcost = Convert.ToInt16(Console.ReadLine());

            if (numcost == 1)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"Pork Sinigang that is good for {num} person/s, costs around: ");
                Console.WriteLine($"\r\n     {num * 68} Pesos! ");
            }
            else if (numcost == 2)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Logging out...");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Invalid Input... Will automatically Logout");
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\r\nThank you for using the RECIPE SYSTEM! <3\r\n"); 
        }
        public static void ChickenAdobo()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("How many people would eat your Chicken Adobo?: ");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("The list of ingredients are: ");
            Console.WriteLine($"{num * 0.25} cup/s Water");
            Console.WriteLine($"{num * 0.15} kg/s Chicken");
            Console.WriteLine($"{num * 0.15} cube/s Chicken Cube");
            Console.WriteLine($"{num * 0.05} cup/s Soy Sauce");
            Console.WriteLine($"{num * 0.35} pc/s Bay Leaf");
            Console.WriteLine($"{num * 0.10} tbsp/s Peppercorn");
            Console.WriteLine($"{num * 0.15} head/s Toasted Garlic");
            Console.WriteLine($"{num * 0.35} tbsp/s Vegetable Oil");

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Continue to the Steps and Procedures?");
            Console.WriteLine("2. Skip and go to the cost?");
            Console.Write("\r\nSelect option by typing 1 and 2: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            if (num2 == 1)
            {
                Console.WriteLine("---------------------------------------------------------");
                Instructions.ChickenAdoboInstructions();
            }
            else if (num2 == 2)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Skipping...");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Invalid Input... Will proceed to the recipe's cost");
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Know the recipe's estimated cost?");
            Console.WriteLine("2. Logout?");
            Console.Write("\r\nSelect option by typing 1 and 2: ");
            int numcost = Convert.ToInt16(Console.ReadLine());

            if (numcost == 1)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"Chicken Adobo that is good for {num} person/s, costs around: ");
                Console.WriteLine($"\r\n     {num * 64} Pesos! ");
            }
            else if (numcost == 2)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Logging out...");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Invalid Input... Will automatically Logout");
            }
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Thank you for using the RECIPE SYSTEM! <3\r\n");

        }
        public static void PorkAdobo()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("How many people would eat your Pork Adobo?: ");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("The list of ingredients are: ");
            Console.WriteLine($"{num * 0.25} cup/s Water");
            Console.WriteLine($"{num * 0.15} g/s Pork Shoulder");
            Console.WriteLine($"{num * 0.25} sachet/s Oyster Sauce");
            Console.WriteLine($"{num * 0.25} tbsp/s Vegetable Oil");
            Console.WriteLine($"{num * 0.5} pc/s Bay Leaf");
            Console.WriteLine($"{num * 0.25} tbsp/s Peppercorn");
            Console.WriteLine($"{num * 0.25} head/s Garlic");
            Console.WriteLine($"{num * 0.75} tbsp/s White Vinegar");

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Continue to the Steps and Procedures?");
            Console.WriteLine("2. Skip and go to the cost?");
            Console.Write("\r\nSelect option by typing 1 and 2: ");
            int num3 = Convert.ToInt16(Console.ReadLine());

            if (num3 == 1)
            {
                Console.WriteLine("---------------------------------------------------------");
                Instructions.PorkAdoboInstructions();
            }
            else if (num3 == 2)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Skipping...");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Invalid Input... Will proceed to the recipe's cost");
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Know the recipe's estimated cost?");
            Console.WriteLine("2. Logout?");
            Console.Write("\r\nSelect option by typing 1 and 2: ");
            int numcost = Convert.ToInt16(Console.ReadLine());

            if (numcost == 1)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"Pork Adobo that is good for {num} person/s, costs around: ");
                Console.WriteLine($"\r\n     {num * 69} Pesos! ");
            }
            else if (numcost == 2)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Logging out...");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Invalid Input... Will automatically Logout");
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Thank you for using the RECIPE SYSTEM! <3\r\n");
        }
        public static void Karekare()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("How many people would eat your Kare-kare?: ");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("The list of ingredients are: ");
            Console.WriteLine($"{num * 0.15} kg/s Beef Oxtail");
            Console.WriteLine($"{num * 0.35} sachet/s Seasonings");
            Console.WriteLine($"{num * 0.15} tbsp/s Vegetable Oil");
            Console.WriteLine($"{num * 0.15} pc/s Bay Leaf");
            Console.WriteLine($"{num * 0.10} tbsp/s Peppercorn");
            Console.WriteLine($"{num * 0.10} head/s Garlic");
            Console.WriteLine($"{num * 0.10} pc/s Onion");
            Console.WriteLine($"{num * 0.15} tbsp/s Anatto with iye");
            Console.WriteLine($"{num * 0.05} cup/s Ground Rice");
            Console.WriteLine($"{num * 0.05} cup/s Peanuts");
            Console.WriteLine($"{num * 0.85} pc/s Sitaw");
            Console.WriteLine($"{num * 0.15} bunch/es Pechay");
            Console.WriteLine($"{num * 0.40} pc/s Eggplant");
            Console.WriteLine($"{num * 0.10} cup/s Bagoong Alamang");

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Continue to the Steps and Procedures?");
            Console.WriteLine("2. Skip and go to the cost?");
            Console.Write("\r\nSelect option by typing 1 and 2: ");
            int num4 = Convert.ToInt16(Console.ReadLine());

            if (num4 == 1)
            {
                Instructions.KarekareInstructions();
            }
            else if (num4 == 2)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Skipping...");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Invalid Input... Will proceed to the recipe's cost");
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Know the recipe's estimated cost?");
            Console.WriteLine("2. Logout?");
            Console.Write("\r\nSelect option by typing 1 and 2: ");
            int numcost = Convert.ToInt16(Console.ReadLine());

            if (numcost == 1)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"Kare kare that is good for {num} person/s, costs around: ");
                Console.WriteLine($"\r\n     {num * 80} Pesos! ");
            }
            else if (numcost == 2)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Logging out...");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Invalid Input... Will automatically Logout");
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Thank you for using the RECIPE SYSTEM! <3\r\n");
        }
        public static void PorkMenudo() 
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("How many people would eat your Menudo?: ");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("The list of ingredients are: ");
            Console.WriteLine($"{num * 0.40} cup/s Water");
            Console.WriteLine($"{num * 0.10} kg/s Pork Shoulder");
            Console.WriteLine($"{num * 0.15} pc/s Carrot");
            Console.WriteLine($"{num * 0.15} pc/s Potato");
            Console.WriteLine($"{num * 0.55} sachet/s Seasoning");
            Console.WriteLine($"{num * 1} clove/s Garlic");
            Console.WriteLine($"{num * 0.15} pc/s Onion");
            Console.WriteLine($"{num * 0.15} pc/s Red Bell Pepper"); 
            Console.WriteLine($"{num * 0.15} pc/s Green Bell Pepper");
            Console.WriteLine($"{num * 0.15} pc/s Bay Leaf");
            Console.WriteLine($"{num * 0.15} cup/s Tomato Sauce");
            Console.WriteLine($"{num * 0.05} tbsp/s Ground Pepper");
            Console.WriteLine($"{num * 0.15} tbsp/s Brown Sugar");

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Continue to the Steps and Procedures?");
            Console.WriteLine("2. Skip and go to the cost?");
            Console.Write("\r\nSelect option by typing 1 and 2: ");
            int num5 = Convert.ToInt16(Console.ReadLine());

            if (num5 == 1)
            {
                Console.WriteLine("---------------------------------------------------------");
                Instructions.PorkMenudoInstructions();
            }
            else if (num5 == 2)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Skipping...");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Invalid Input... Will proceed to the recipe's cost");
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Know the recipe's estimated cost?");
            Console.WriteLine("2. Logout?");
            Console.Write("\r\nSelect option by typing 1 and 2: ");
            int numcost = Convert.ToInt16(Console.ReadLine());

            if (numcost == 1)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"Menudo that is good for {num} person/s, costs around: ");
                Console.WriteLine($"\r\n     {num * 75} Pesos! ");
            }
            else if (numcost == 2)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Logging out...");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Invalid Input... Will automatically Logout");
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Thank you for using the RECIPE SYSTEM! <3\r\n");
        }
        public static void Logout() 
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\r\nLogging Out...");
        }
    }
       
}
