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

            //Console.WriteLine("Thank you for eating at Frankie's Place!");
            //Console.WriteLine("What is your total bill?");

            //double billTotal = double.Parse(Console.ReadLine());
            //double discount10 = billTotal - (billTotal * .10d);
            //double discount5 = billTotal - (billTotal * .05d);
            //double billSplit;

            //Console.WriteLine("How many people in your party?");
            //int numberOfPeople = int.Parse(Console.ReadLine());

            //if (billTotal >= 50)
            //{
            //    Console.WriteLine("You get 10% off of your bill!");
            //    Console.WriteLine("Your total with your discount: $" + discount10);
            //    billSplit = discount10 / numberOfPeople;
            //    Console.WriteLine("Each person in your party will pay");
            //    Console.WriteLine("Each person in your party will pay: $" + billSplit);
            //}
            //else
            //{
            //    Console.WriteLine("You get 5% off of you bill!");
            //    Console.WriteLine("Your total with your discount: $" + discount5);
            //    billSplit = discount5 / numberOfPeople;
            //    Console.WriteLine("Each person in your party will pay: $" + billSplit);
            //}
            ////how mucheach person is paying?

            //Age Distribution Example

            //Console.WriteLine("How old is your child?");
            //int childAge = int.Parse(Console.ReadLine());

            //if (childAge >= 0 && childAge <= 2)
            //{
            //    Console.WriteLine("Still in Mama's Arms");
            //}
            //else if (childAge >= 3 && childAge <= 4)
            //{
            //    Console.WriteLine("Preschool Maniac");
            //}
            //else if (childAge >=5 && childAge <=11)
            //{
            //    Console.WriteLine("Elementary School");
            //}
            //else if (childAge >= 12 && childAge <=14)
            //{
            //    Console.WriteLine("Middle School");
            //}
            //else if (childAge >=15 && childAge <= 18)
            //{
            //    Console.WriteLine("High-School");
            //}
            //else if (childAge >=19 && childAge <= 22)
            //{
            //    Console.WriteLine("College");
            //}
            //else if (childAge >=23 && childAge <= 65)
            //{
            //    Console.WriteLine("Working for the Man");
            //}
            //else if (childAge >=66 && childAge <= 100)
            //{
            //    Console.WriteLine("The Golden Years");
            //}
            //else
            //{
            //    Console.WriteLine("This Program is For Humans");
            //}


            //Words to Digits

            Console.WriteLine("Please enter the string vale of the number ie: one,two,three (0-10)");

            string number = Console.ReadLine();
            switch (number)
            {
                case "zero":
                    Console.WriteLine("0");
                    break;
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine("10");
                    break;
            }









            }
    }
}
