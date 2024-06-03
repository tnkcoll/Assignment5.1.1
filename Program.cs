namespace Assignment5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = GetNumber("Please enter a number to see if it is a palindrome.");
            if (IsPalindrome(num))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static int GetNumber(string s)
        {
            string? userInput = "";

            do
            {
                Console.WriteLine(s);
                userInput = Console.ReadLine();
            } while (userInput == "");
            return Convert.ToInt32(userInput);
        }

        static bool IsPalindrome(int n)
        {
            int reverse = 0;
            int temp = n;
            while (temp != 0)
            {
                //The next two lines remove the last digit in temp and puts it as the first digit in reverse.
                reverse = (reverse * 10) + (temp % 10); //Using Integer Math the (reverse * 10) + (temp % 10) takes the last digit from temp and makes it the first number of reverse. 
                temp = temp / 10; //Using integer math temp = temp / 10 removes the last digit in temp.
            }
            return (reverse == n); //Analyzes if reverse and n are the same. If so, true is returned. If not, false is returned.

        }
    }
}
