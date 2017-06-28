using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2k17
{
    class Program
    {
        static void Main(string[] args)

            
        {
            ////ask user of much they paid
            //Console.WriteLine("How much was your bill?");
            //double bill = double.Parse(Console.ReadLine());
            //if (bill >= 50)
            //{
            //    Console.WriteLine("You get 10% off of your bill!");

            //}
            //else
            //{
            //    Console.WriteLine("You get 5% off!");
            //}

            //Console.WriteLine("How many people are in your party?");
            //int numberOfPeople = int.Parse(Console.ReadLine());
            //double costPerPerson = bill / numberOfPeople;
            //double totalBill = (costPerPerson * numberOfPeople);
            //Console.WriteLine("Each person paid $" + costPerPerson);

            //Console.WriteLine("What is the the name on the reservation?");
            //string reserveName = Console.ReadLine();

            Console.WriteLine("Thank you for eating at Frankie's Place!");
            Console.WriteLine("What is your total bill?");

            double billTotal = double.Parse(Console.ReadLine());
            double discount10 = billTotal - (billTotal * .10d);
            double discount5 = billTotal - (billTotal * .05d);
            double billSplit;

            Console.WriteLine("How many people in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());

            if (billTotal >= 50)
            {
                Console.WriteLine("You get 10% off of your bill!");
                Console.WriteLine("Your total with your discount: $" + discount10);
                billSplit = discount10 / numberOfPeople;
                Console.WriteLine("Each person in your party will pay");
                Console.WriteLine("Each person in your party will pay: $" + billSplit);
            }
            else
            {
                Console.WriteLine("You get 5% off of you bill!");
                Console.WriteLine("Your total with your discount: $" + discount5);
                billSplit = discount5 / numberOfPeople;
                Console.WriteLine("Each person in your party will pay: $" + billSplit);
            }
            //how mucheach person is paying?
           

            
            

            

        
        }
    }
}
