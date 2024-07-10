﻿using LoanCalcuationUnitTest.Controller;

namespace LoanCalcuationUnitTest
{
    public class Program
    {
        public static void Main()
        {
            int choice;
            int principleAmount;
            double interest;
            int loanTermInYears;
            do
            {
                Console.WriteLine("----------MENU_____________");
                Console.WriteLine("1- Calculate interest");
                Console.WriteLine("2- Calculate amount to pay per month (simple interest)");
                Console.WriteLine("3- Exit");
                Console.WriteLine("Enter your choice");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: break;
                        case 2:
                            ReadInputs(out principleAmount, out interest, out loanTermInYears);
                            AmountPayPerMonth amountPayPerMonth = new();
                            Console.WriteLine($"Amount to Pay per month: {amountPayPerMonth.CalculateAmountPayPerMonth(principleAmount, interest, loanTermInYears)}");
                            break;
                        case 3: return;
                        default:
                            Console.WriteLine("Invlaid choice");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                }

            } while (true);
        }

        public static void ReadInputs(out int principleAmount, out double interest, out int loanTermInYears)
        {
            Console.Write("Enter principle amount: ");
            principleAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter interest(<20%): ");
            interest = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter the term in years(<30): ");
            loanTermInYears = Convert.ToInt32(Console.ReadLine());
        }
    }
}
