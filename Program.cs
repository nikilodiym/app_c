namespace app_c_
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("It's easy to win forgiveness for being wrong;\r\nbeing right is what gets you into real trouble! \r\n");
    //        Console.WriteLine("Bjarne Stroustrup");
    //    }
    //}

    //internal class task2
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] numbers = new int[5];
    //        int sum = 0;
    //        int product = 1;
    //        int min = numbers[0];
    //        int max = numbers[1];

    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.Write("Enter number: ");
    //            numbers[i] = Convert.ToInt32(Console.ReadLine());
    //            sum += numbers[i];
    //        }

    //        foreach (int number in numbers)
    //        {
    //            product *= number;
    //            if (number < min)
    //            {
    //                min = number;
    //            }
    //            if (number > max)
    //            {
    //                max = number;
    //            }
    //        }

    //        Console.WriteLine("Sum: " + sum);
    //        Console.WriteLine("Product: " + product);
    //        Console.WriteLine("Min: " + min);
    //        Console.WriteLine("Max: " + max);

    //    }
    //}

    //internal class task3
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a 6 numbers: ");
    //        string input = Console.ReadLine();

    //        if (input.Length == 6 && int.TryParse(input, out int number))
    //        {
    //            char[] reversedArray = input.ToCharArray();
    //            Array.Reverse(reversedArray);
    //            string reversedNumber = new string(reversedArray);

    //            Console.WriteLine($"Reversed number: {reversedNumber}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid input");
    //        }

    //    }
    //}

    //internal class task4
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter A: ");
    //        int A = int.Parse(Console.ReadLine());
    //        Console.Write("Enter B: ");
    //        int B = int.Parse(Console.ReadLine());

    //        if (A > 0 && B > 0)
    //        {
    //            for (int i = A; i <= B; i++)
    //            {
    //                for (int j = 0; j < i; j++)
    //                {
    //                    Console.Write(i + " ");
    //                }
    //                Console.WriteLine();
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid input");
    //        }

    //    }
    //}

    internal class task5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the line: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter the fill character: ");
            char fillChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter the direction (horizontal/vertical): ");
            string direction = Console.ReadLine().ToLower();

            Console.WriteLine("\nResult:");

            if (length > 0 && (direction == "horizontal" || direction == "vertical"))
            {
                if (direction == "horizontal")
                {
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write(fillChar);
                    }
                    Console.WriteLine();
                }
                else if (direction == "vertical")
                {
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine(fillChar);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}   