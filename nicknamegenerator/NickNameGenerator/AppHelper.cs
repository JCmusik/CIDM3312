using System;

namespace NickNameGenerator
{
    /// <summary>
    /// Stores methods for functionality of the app
    /// </summary>
    public static class AppHelper
    {
        /// <summary>
        /// Validate if user is selecting a valid choice
        /// </summary>
        /// <returns>New String</returns>
        public static string GetAdjectiveSelection()
        {
            var isValid = false; // use for while loop to check for valid user input
            var adjective = ""; // start with empty string
            while (!isValid)
            {
                // store user input
                Console.Write("Please select one of the adjectives listed: ");
                adjective = Console.ReadLine();
                switch (adjective)
                {
                    case "1":
                        adjective = "quirky";
                        isValid = true;
                        return adjective;
                    case "2":
                        adjective = "mellow";
                        isValid = true;
                        return adjective;
                    case "3":
                        adjective = "lively";
                        isValid = true;
                        return adjective;
                    case "4":
                        adjective = "determined";
                        isValid = true;
                        return adjective;
                    default:
                        Console.WriteLine("Please enter 1, 2, 3, or 4");
                        break;
                }
            }
            return adjective;
        }
        /// <summary>
        /// Displays the final nickname back to the user
        /// </summary>
        /// <param name="nickNames">Array of possible nicknames</param>
        /// <param name="adjective">User chosen adjective used to locate synonyms</param>
        /// <param name="name">User's initial name</param>
        public static void DisplayNickName(string[][] nickNames, string adjective, string name)
        {
            Random randNumber = new Random();
            for (int i = 0; i < nickNames.Length; i++)
            {
                for (int j = 0; j < nickNames[i].Length; j++)
                {
                    
                    if (nickNames[i][j] == adjective)
                    {
                        if(name.Length < 5)
                        {
                            Console.WriteLine($"{nickNames[i][randNumber.Next(1, 4)].ToUpper()} {name.ToUpper()}");
                        }
                        else
                        {
                            Console.WriteLine($"{name.ToUpper()} THE {nickNames[i][randNumber.Next(1, 4)].ToUpper()}"); // Display nickname
                        }
                    }
                        
                }
            }
        }
        /// <summary>
        /// Displays a list of adjectives for user to choose from
        /// </summary>
        /// <param name="nickNames">Array of possible choices</param>
        public static void DisplayAdjectiveChoices(string[][] nickNames)
        {
            for (var i = 0; i < nickNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {nickNames[i][0]}"); // display the first element of each array
            }
        }
        /// <summary>
        /// Prompt user for input and store in a variable
        /// </summary>
        /// <returns>Input from user</returns>
        public static string GetUserName()
        {
            const string nameMessage = "Please enter your name: ";
            Console.Write(nameMessage);
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name) || name.Length > 20)
            {
                Console.WriteLine("You must enter a name and has less than 20 characters.");
                Console.Write(nameMessage);
                name = Console.ReadLine();
            }

            return name;
        }
        /// <summary>
        /// Creates array of possible nick names to use in the app
        /// </summary>
        /// <returns>array of possible nick names</returns>
        public static string[][] GetNickNames()
        {

            string[][] nickNames = new string[][]
            {
                new string[] { "quirky", "peculiar", "unconventional", "wacky" },
                new string[] { "mellow", "delicate", "cultured", "chill" },
                new string[] { "lively", "bright", "enjoyable", "spirited" },
                new string[] { "determined", "stubborn", "purposeful", "tenacious"}
            };

            return nickNames;
        }
    }
}
