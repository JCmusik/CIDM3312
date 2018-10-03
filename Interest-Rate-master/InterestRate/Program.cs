using System;

namespace InterestRate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display instructions for user
            DisplayInstructions();

            // get user input: Age, Gender, and Credit Score
            PersonModel applicant = PersonModel.GetApplicantInfo();

            if(applicant.InterestRate != 0M)
            {
                // output to the console the user's determined interest rate
                Console.WriteLine(applicant);
                // get user input for amount to invest
                applicant.PresentValue = PersonModel.GetPresentValue();

                // get user input for number of years to invest
                applicant.NumberOfYears = PersonModel.GetNumberOfYears();

                // Calculate Compound Interest
                Interest.CalculateCompoundInterest(applicant);
            }
            else
            {
                System.Console.WriteLine("\nSorry, we are not able to offer you any rates at this time.");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Displays instructs to the user
        ///</summary>
        private static void DisplayInstructions()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome!\nIn this app you will be asked to input your age,\ngender, and credit score");
            Console.WriteLine();
            Console.WriteLine("After you have input the correct information,\nthe selected interest rate will be displayed");
            Console.WriteLine("You will be asked to input how much to invest,\nand how many years you want to invest");
            Console.WriteLine("Finally the program will calculate and display the results of the future value of your investment");
            Console.WriteLine();
        }
    }
}
