using System;

class JewelryOrderingSystem
{
    static void Main()
    {
        const decimal GoldChainPrice = 1000m;
        const decimal PearlNecklacePrice = 400m;
        const decimal SilverNecklacePrice = 600m;
        const decimal IronChainPrice = 100m;
        const decimal DiamondNecklacePrice = 5000m;
        const decimal YellowGoldNecklacePrice = 9000m;
        const decimal QuartzNecklacePrice = 50m;


        Console.WriteLine("Welcome to the MJ's Necklace Jewelry Ordering System!");
        
        Console.WriteLine("Please select the type of necklace you want to order:");
        Console.WriteLine("1. Gold Chain Necklace ($1000)");
        Console.WriteLine("2. Pearl Necklace ($400)");
        Console.WriteLine("3. Silver Necklace ($600)");
        Console.WriteLine("4. Iron Chain ($100)");
        Console.WriteLine("5. Diamond Necklace ($5000");
        Console.WriteLine("6. Yellow Gold Necklace ($9000)");
        Console.WriteLine("7. Quartz Necklace ($400)");

        Console.Write("Enter your jewelry of choice: ");
        string choice = Console.ReadLine();

        decimal totalPrice = 0m;
        string necklaceType = "";

        switch (choice)
        {
            
            case "1":
                totalPrice = GoldChainPrice;
                necklaceType = "Gold Chain Necklace";
                break;
            case "2":
                totalPrice = PearlNecklacePrice;
                necklaceType = "Pearl Necklace";
                break;
            case "3":
                totalPrice = SilverNecklacePrice;
                necklaceType = "Silver Necklace";
                break;
            case "4":
                totalPrice = IronChainPrice;
                necklaceType = "Iron Chain";
                break;
            case "5":
                totalPrice = DiamondNecklacePrice;
                necklaceType = "Diamond Necklace";
                break;
            case "6":
                totalPrice = YellowGoldNecklacePrice;
                necklaceType = "Yellow Gold Necklace";
                break;
            case "7":
                totalPrice = QuartzNecklacePrice;
                necklaceType = "Quartz Necklace";
                break;

            default:
                Console.WriteLine("Invalid choice!");
                return;
        }
        
        Console.WriteLine("You have selected: " + necklaceType);
        Console.WriteLine("Total Price: $" + totalPrice);

        Console.Write("Enter your name: ");
        string customerName = Console.ReadLine();

        Console.WriteLine("Thank you, " + customerName + "!");

        Console.Write("Enter your payment amount: $");
        decimal paymentAmount = decimal.Parse(Console.ReadLine());

        if (paymentAmount < totalPrice)
        {
            Console.WriteLine("Insufficient payment!");
            return;
        }

        decimal change = paymentAmount - totalPrice;
        Console.WriteLine("Payment successful. Your change: $" + change);

        Console.WriteLine();
        Console.WriteLine("Order Processing and Receipt");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Necklace Type: " + necklaceType);
        Console.WriteLine("Total Price: $" + totalPrice);
        Console.WriteLine("Payment Amount: $" + paymentAmount);
        Console.WriteLine("Change: $" + change);
        Console.WriteLine("Thank you for your order!");

    }
}
