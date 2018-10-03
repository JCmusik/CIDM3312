using System;
namespace InterestRate
{
    /// <summary>
    /// Properties and methods for a person model
    /// </summary>
    public class PersonModel
    {
        # region Constructor
        public PersonModel(byte age, string gender, short creditScore)
        {
            Age = age;
            Gender = gender;
            CreditScore = creditScore;
        }
        
        #endregion

        #region Properties

        public byte Age { get; set; } 
        public string Gender { get; set; }
        public short CreditScore { get; set; }  
        public decimal InterestRate { get; set; }
        public int PresentValue { get; set; }
        public byte NumberOfYears { get; set; }

        #endregion
        

        #region Methods
        /// <summary>
        /// Gets a new instance of a person model.
        /// </summary>
        /// <returns>PersonModel</returns>
        public static PersonModel GetApplicantInfo()
        {            
            byte age = GetApplicantAge();
            
            string gender = GetApplicantGender();

            short creditScore = GetApplicantCreditScore();  
           
            PersonModel applicant = new PersonModel(age, gender, creditScore); // create new instance of Person model based on user input

            // use applicant info to determine interest rate
            applicant.InterestRate =  Interest.DetermineInterestRate(applicant);

            return applicant; // return PersonModel
        }

        public static byte GetNumberOfYears()
        {
            byte numYears = 0;
            bool isValid = false;

            while(!isValid)
            {         
                Console.Write("How many years do you want to invest? (4 to 20) "); // prompt user for age       
                try
                {
                    numYears = byte.Parse(Console.ReadLine()); // store user's age
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                if(numYears < 4 || numYears > 20)
                    Console.WriteLine($"Investment range is from 4 to 20 years");
                else
                    isValid = true;
            }
            return numYears;
        }

        /// <summary>
        /// Gets inital investment from applicant
        ///</summary>
        ///<returns>Validated int value</returns>
        public static int GetPresentValue()
        {
            int presentValue = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("\nHow much do you want to invest? "); // prompt user for credit score
                try
                {
                    presentValue = int.Parse(Console.ReadLine()); // store user's credit score
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                if (presentValue < 500 || presentValue > 1000000 )
                    Console.WriteLine("Investment are between 500 and 1000000");
                else
                    isValid = true;               
            }             
            return presentValue;
        }


        /// <summary>
        /// Validates user input for credit score
        ///</summary>
        /// <returns>Validated int data</returns>
        private static short GetApplicantCreditScore()
        {
            short creditScore = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("\nWhat is your credit score?: (0 - 850) "); // prompt user for credit score
                try
                {
                    creditScore = short.Parse(Console.ReadLine()); // store user's credit score
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                if (creditScore < 0 || creditScore > 850 )
                    Console.WriteLine("Values range from 0 to 850");
                else
                    isValid = true;               
            }             
            return creditScore;

        }

        /// <summary>
        /// Validates user input for gender
        ///</summary>
        ///<returns>Validated string data</returns>
        private static string GetApplicantGender()
        {
            string gender = "";
            bool isValid = false;

            do
            {
                Console.Write("\nAre you M or F? "); // prompt user for gender
                
                // TODO: add validation
                gender = Console.ReadLine().ToLower(); // store user's gender
                                    
                if (gender == "f" || gender == "m")
                    isValid = true;

            } while (!isValid);
            
            return gender;
        }

        /// <summary>
        /// Validates user input for age
        ///</summary>
        /// <returns>Validated int data</returns>
        private static byte GetApplicantAge()
        {
            byte age = 0;
            bool isValid = false;
            string enterValidAge = "Please enter a valid age (16 - 120)";

            while(!isValid)
            {         
                Console.Write("What is your age?: "); // prompt user for age       
                try
                {
                    age = byte.Parse(Console.ReadLine()); // store user's age
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                if(age < 16 || age > 120) // contrain user input
                    Console.WriteLine($"{enterValidAge}");
                else
                    isValid = true;
            }
            return age;
        }
        
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:InterestRate.PersonModel"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:InterestRate.PersonModel"/>.</returns>
        public override string ToString() => $"Age: {Age,11}\nGender: {Gender,8}\nCreditScore: {CreditScore,3}\nYour interest rate is: {InterestRate:P2}";

        #endregion
    }
}
