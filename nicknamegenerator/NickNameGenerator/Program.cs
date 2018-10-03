using System;

namespace NickNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask for user name and store in a variable
            string name = AppHelper.GetUserName();

            Console.WriteLine(); // create a line break

            // retrieve jagged array of adjectives
            string[][] nickNames = AppHelper.GetNickNames();
            // display adjective options
            AppHelper.DisplayAdjectiveChoices(nickNames);

            Console.WriteLine(); // create a line break

            // validate user input and return selection to store in variable
            string adjective = AppHelper.GetAdjectiveSelection();

            Console.WriteLine(); // create a line break

            // loop through jagged array and display the corresponding elments
            AppHelper.DisplayNickName(nickNames, adjective, name);

            Console.ReadKey();
        }
    }
}
