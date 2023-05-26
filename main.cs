using System;
using System.Collections.Generic;

namespace JewelryOrderingSystem
{
    class Program
    {
        static List<string> necklaces = new List<string>()
        {
            "Gold Chain Necklace",
            "Pearl Necklace",
            "Silver Necklace",
            "Iron Chain",
            "Diamond Necklace",
            "Yellow Gold Necklace",
            "Quartz Necklace"
        };

        static Dictionary<string, decimal> necklacePrices = new Dictionary<string, decimal>()
        {
            { "Gold Chain Necklace", 1000m },
            { "Pearl Necklace", 400m },
            { "Silver Necklace", 600m },
            { "Iron Chain", 100m },
            { "Diamond Necklace", 5000m },
            { "Yellow Gold Necklace", 9000m },
            { "Quartz Necklace", 50m }
        };

        static Dictionary<string, List<string>> customizations = new Dictionary<string, List<string>>()
        {
            { "Gold Chain Necklace", new List<string>() { "Locket", "Princess Necklace", "Choker", "Multi Chain", "Negligee" } },
            { "Pearl Necklace", new List<string>() { "Locket", "Princess Necklace", "Choker", "Multi Chain", "Negligee" } },
            { "Silver Necklace", new List<string>() { "Locket", "Princess Necklace", "Choker", "Multi Chain", "Negligee" } },
            { "Iron Chain", new List<string>() { "Locket", "Princess Necklace", "Choker", "Multi Chain", "Negligee" } },
            { "Diamond Necklace", new List<string>() { "Locket", "Princess Necklace", "Choker", "Multi Chain", "Negligee" } },
            { "Yellow Gold Necklace", new List<string>() { "Locket", "Princess Necklace", "Choker", "Multi Chain", "Negligee" } },
            { "Quartz Necklace", new List<string>() { "Locket", "Princess Necklace", "Choker", "Multi Chain", "Negligee" } }
        };

        static void Main()
        {
            Console.WriteLine("Welcome to the MJ's Necklace Jewelry Ordering System!");

            DisplayNecklaces();

            Console.Write("Enter your jewelry of choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice < 1 || choice > necklaces.Count)
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            string selectedNecklace = necklaces[choice - 1];
            List<string> customizationOptions = customizations[selectedNecklace];

            Console.WriteLine("You have selected: " + selectedNecklace);
            Console.WriteLine("Please select the customization option:");

            for (int i = 0; i < customizationOptions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {customizationOptions[i]}");
            }

            Console.Write("Enter your customization choice: ");
            int customizationChoice = int.Parse(Console.ReadLine());

            if (customizationChoice < 1 || customizationChoice > customizationOptions.Count)
            {
                Console.WriteLine("Invalid customization choice!");
                return;
            }

            string selectedCustomization = customizationOptions[customizationChoice - 1];
            string necklaceType = $"{selectedNecklace} ({selectedCustomization})";

            decimal necklacePrice = necklacePrices[selectedNecklace];
            Console.WriteLine("Total Price: $" + necklacePrice);

            Console.Write("Enter your name: ");
            string customerName = Console.ReadLine();
            Console.WriteLine("Thank you, " + customerName + "!");

            Console.Write("Enter your payment amount: $");
            decimal paymentAmount = decimal.Parse(Console.ReadLine());

            if (paymentAmount < necklacePrice)
            {
                Console.WriteLine("Insufficient payment!");
                return;
            }

            decimal change = paymentAmount - necklacePrice;
            Console.WriteLine("Payment successful. Your change: $" + change);

            Console.WriteLine();
            Console.WriteLine("Order Processing and Receipt");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Necklace Type: " + necklaceType);
            Console.WriteLine("Total Price: $" + necklacePrice);
            Console.WriteLine("Payment Amount: $" + paymentAmount);
            Console.WriteLine("Change: $" + change);
            Console.WriteLine("Thank you for your order!");
        }

        static void DisplayNecklaces()
        {
            Console.WriteLine("Please select the type of necklace you want to order:");

            for (int i = 0; i < necklaces.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {necklaces[i]}");
            }
        }
    }
}
