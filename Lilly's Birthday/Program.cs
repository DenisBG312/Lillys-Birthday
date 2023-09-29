namespace Lilly_s_Birthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double carPrice = 2000;
            double phonePrice = 1000;
            double apartmentPrice = 50000;
            double backpackPrice = 70;
            double laptopPrice = 900;

            int carCount = 0;
            int phoneCount = 0;
            int apartmentCount = 0;
            int backpackCount = 0;
            int laptopCount = 0;
            Console.Write("Write your total budget: ");
            double totalBudget = double.Parse(Console.ReadLine());

            Console.Write("Choose your currency: ");
            string currency = Console.ReadLine();

            Console.WriteLine($"You have {totalBudget}{currency}.");

            Console.WriteLine("Choose what to buy for Lilly's birthday: [c]ar, [p]hone, [a]partment, [b]ackpack, [l]aptop");
            string presentType = Console.ReadLine();
            ////////////////////////////
            /// 
            while (presentType != "Stop")
            {
                if (presentType == "c" || presentType == "car")
                {
                    totalBudget -= carPrice;
                    if (totalBudget < 0)
                    {
                        Console.WriteLine("You don't have the money.");
                        break;
                    }
                    else if (totalBudget == 0)
                    {
                        Console.WriteLine($"You bought it and now you have 0{currency}.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You chose to buy a car!");
                        carCount++;
                    }
                }
                else if (presentType == "p" || presentType == "phone")
                {
                    totalBudget -= phonePrice;
                    if (totalBudget < 0)
                    {
                        Console.WriteLine("You don't have the money.");
                        break;
                    }
                    else if (totalBudget == 0)
                    {
                        Console.WriteLine($"You bought it and now you have 0{currency}.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You chose to buy a phone.");
                        phoneCount++;
                    }
                }
                else if (presentType == "a" || presentType == "apartment")
                {
                    totalBudget -= apartmentPrice;
                    if (totalBudget < 0)
                    {
                        Console.WriteLine("You don't have the money.");
                        break;
                    }
                    else if (totalBudget == 0)
                    {
                        Console.WriteLine($"You bought it and now you have 0{currency}.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You chose to buy an apartment!");
                        apartmentCount++;
                    }
                }
                else if (presentType == "b" || presentType == "backpack")
                {
                    totalBudget -= backpackPrice;
                    if (totalBudget < 0)
                    {
                        Console.WriteLine("You don't have the money.");
                        break;
                    }
                    else if (totalBudget == 0)
                    {
                        Console.WriteLine($"You bought it and now you have 0{currency}.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You chose to buy a backpack!");
                        backpackCount++;
                    }
                }
                else if (presentType == "l" || presentType == "laptop")
                {
                    totalBudget -= laptopPrice;
                    if (totalBudget < 0)
                    {
                        Console.WriteLine("You don't have the money.");
                        break;
                    }
                    else if (totalBudget == 0)
                    {
                        Console.WriteLine($"You bought it and now you have 0{currency}.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You chose to buy a laptop!");
                        laptopCount++;
                    }
                }

                Console.WriteLine($"You have {totalBudget}{currency} left.");
                Console.WriteLine("Do you want to buy something else: yes/no");
                string yN = Console.ReadLine();
                if (yN == "no")
                {
                    Console.WriteLine("You chose to stop the program!");
                    break;
                }
                else if (yN == "yes")
                {
                    Console.Write("Choose what to buy next: ");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }

                presentType = Console.ReadLine();
            }

            Console.WriteLine($"Congrats! You bought: {carCount} cars, {phoneCount} phones, {apartmentCount} apartments, {backpackCount} backpacks and {laptopCount} laptops.");
            if (totalBudget > 0)
            {
                Console.WriteLine($"Your left budget is: {totalBudget}");
            }
        }
    }
}