using System;   //Jackson Band 2/4/21

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank's For Choosing MPLS Dog Boarding!! Please enter your ID number:");
            string ownerId = Console.ReadLine();
            Console.WriteLine($"Welcome Back Customer #{ownerId}!! What is your dogs name?");
            string dogName = Console.ReadLine();
            Console.WriteLine($"And what breed is {dogName}?");
            string dogBreed = Console.ReadLine();
            Console.WriteLine($"And how many years old is {dogName}?");
            int dogAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"And how many weeks will {dogName} need to be in our care?");
            int careDuration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"How many lbs does {dogName} weigh?");
            int dogWeight = Convert.ToInt32(Console.ReadLine());
            if (dogWeight < 15){
                int totalCost = 55 * careDuration;
                Console.WriteLine($"The total cost for us to take care of {dogName} for {careDuration} weeks will be ${totalCost}");
                if (totalCost > 125){
                    Console.WriteLine("Congratulations! Because your total bill exceeds $125, you qualify for a 2% discount!");
                    }
            }
            else {
                if (dogWeight < 31){
                    int totalCost = 75 * careDuration;
                    Console.WriteLine($"The total cost for us to take care of {dogName} for {careDuration} weeks will be ${totalCost}");
                    if (totalCost > 125){
                    Console.WriteLine("Congratulations! Because your total bill exceeds $125, you qualify for a 2% discount!");
                    }
                }
                else {
                    if (dogWeight < 80){
                        int totalCost = 105 * careDuration;
                        Console.WriteLine($"The total cost for us to take care of {dogName} for {careDuration} weeks will be ${totalCost}");
                        if (totalCost > 125){
                    Console.WriteLine("Congratulations! Because your total bill exceeds $125, you qualify for a 2% discount!");
                    }
                    }
                    else {
                        int totalCost = 125 * careDuration;
                        Console.WriteLine($"The total cost for us to take care of {dogName} for {careDuration} weeks will be ${totalCost}");
                        if (totalCost > 125){
                    Console.WriteLine("Congratulations! Because your total bill exceeds $125, you qualify for a 2% discount!");
                    }
                    }
                }
            }
        }
    }
}
