namespace topic_8_assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> randomNum = new List<int>();
            Random Generator = new Random();
            int numChoice, min, max;

            int count = 0;

            Console.WriteLine("Hello, Please enter the amount of numbers you need:");
            while (!int.TryParse(Console.ReadLine(), out numChoice) || numChoice <= 0)
            {
                Console.WriteLine("Error, you did not input a valid positive number, please try again:");
            }

            Console.WriteLine("Can I now get your minimum?");
            while (!int.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("Error, you did not input a number, please try again:");
            }

            Console.WriteLine("Can I now get your maximum?");
            while (!int.TryParse(Console.ReadLine(), out max) || max < min)
            {
                Console.WriteLine("Error, maximum must be a number greater than or equal to minimum. Try again:");
            }


            for (int i = 0; i < numChoice; i++)
            {
                int randomNumber = Generator.Next(min, max + 1);
                randomNum.Add(randomNumber);
            }
             

            Console.WriteLine("Your random numbers are: ");
            Console.WriteLine(string.Join(" ", randomNum));

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();


            int listChoice;
            Console.WriteLine("Pick a number you want me to count in the List:");
            while (!int.TryParse(Console.ReadLine(), out listChoice))
            {
                Console.WriteLine("Error, please enter a valid number to search for:");
            }

            for (int i = 0; i < randomNum.Count; i++)
            {
                if (randomNum[i] == listChoice)
                {
                    count += 1;
                }
            }

            Console.WriteLine("The number " + listChoice + " appears " + count + " times");
        }
    }
}
