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
                reverse = (reverse * 10) + (temp % 10);
                temp = temp / 10;
            }
            return (reverse == n);

        }
    }
}
