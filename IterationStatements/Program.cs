namespace IterationStatements
{
    public class Program
    {
        // Method 1: Prints all numbers from 1000 down to -1000
        public void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Method 2: Prints every third number from 3 to 999
        public void PrintEveryThirdNumber()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // Method 3: Checks whether two integers are equal
        public bool AreNumbersEqual(int num1, int num2)
        {
            return num1 == num2;
        }

        // Method 4: Checks if a number is even
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Method 5: Checks if a number is positive
        public bool IsPositive(int number)
        {
            return number > 0;
        }

        // Method 6: Determines if a candidate is eligible to vote
        public bool CanVote(int age)
        {
            return age >= 18;
        }

        // Method 7: Checks if a number is within the range of -10 to 10
        public bool IsInRange(int number)
        {
            return number >= -10 && number <= 10;
        }

        // Method 8: Displays the multiplication table for a given number
        public void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }

        // Main method to test the implemented methods
        static void Main(string[] args)
        {
            Program program = new Program();

            // Test PrintNumbers
            program.PrintNumbers();

            // Test PrintEveryThirdNumber
            program.PrintEveryThirdNumber();

            // Test AreNumbersEqual
            Console.WriteLine(program.AreNumbersEqual(5, 5)); // True
            Console.WriteLine(program.AreNumbersEqual(5, 10)); // False

            // Test IsEven
            Console.WriteLine(program.IsEven(4)); // True
            Console.WriteLine(program.IsEven(7)); // False

            // Test IsPositive
            Console.WriteLine(program.IsPositive(10)); // True
            Console.WriteLine(program.IsPositive(-5)); // False

            // Test CanVote
            Console.WriteLine(program.CanVote(20)); // True
            Console.WriteLine(program.CanVote(16)); // False

            // Test IsInRange
            Console.WriteLine(program.IsInRange(5)); // True
            Console.WriteLine(program.IsInRange(15)); // False

            // Test DisplayMultiplicationTable
            program.DisplayMultiplicationTable(5);
        }
    }
}
