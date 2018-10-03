using System;

namespace InterestRate
{
    /// <summary>
    /// Helper methods to store and process data based on user input
    ///</summary>
    public class Interest
    {
        /// <summary>
        /// Creates a new instance of type decimal[] array
        ///</summary>
        /// <returns>new instance of type decimal[] array</returns>
        public static decimal[] GetInterestRates()
        {
            // available rates
            decimal[] interestRates = new decimal[] { .0999M, .0799M, .0399M, 0299M, .0249M };

            return interestRates;
        }

        /// <summary>
        /// Makes determination for applicant's interest rate
        /// </summary>
        /// <returns>decimal type of applicant's interest rate</returns>
        public static decimal DetermineInterestRate(PersonModel applicant)
        {
            decimal[] intRates = Interest.GetInterestRates();  // gets array of available interest rates

            if (applicant.CreditScore < 400)
                return applicant.InterestRate = 0M;

            if (applicant.CreditScore < 500 && applicant.CreditScore > 399 || applicant.Age < 26)
                return applicant.InterestRate = intRates[4];
                
            if ((applicant.CreditScore < 500 && applicant.CreditScore > 399) || (applicant.Age < 36 && applicant.Age > 25))
                return applicant.InterestRate = intRates[3];

            if ((applicant.CreditScore < 600 && applicant.CreditScore > 499) || (applicant.Age < 46 && applicant.Age > 35))
                return applicant.InterestRate = intRates[2];
            else if (applicant.Gender == "m")
                return applicant.InterestRate = intRates[3];
            
            if ((applicant.CreditScore < 700 && applicant.CreditScore > 599) || (applicant.Age < 56 && applicant.Age > 45))
                return applicant.InterestRate = intRates[1];

            if ((applicant.CreditScore >= 700 && applicant.Gender == "m"))
                applicant.InterestRate = intRates[1];
            else if (applicant.Gender == "f")
                return applicant.InterestRate = intRates[0];

            return applicant.InterestRate;
        }

        /// <summary>
        /// Calculates future value based on user input
        ///</summary>
        ///<param name="applicant">applicant</param>
        public static void CalculateCompoundInterest(PersonModel applicant)
        {
            // A = P * (1 + r/n)^(nt)

            decimal A;  // Future Value
            decimal n = 12;  // number of times compounded per year

            decimal equation1 = 1 + (applicant.InterestRate / n);
            decimal equation2 = n * applicant.NumberOfYears;
            double equation3 = Math.Pow((double)equation1,(double)equation2);

            A = applicant.PresentValue * (decimal)equation3;

            Console.WriteLine($"An initial investment of {applicant.PresentValue:C} compounded {n} times per year for {applicant.NumberOfYears} years\nhas a future value of {A:C}");
        }
    }
}
