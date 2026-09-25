//using System;

//class Program
//{
//    static void Main()
//    {
//        Question01();
//    }

//    static void Question01()
//    {
//        Console.Write("Enter a number: ");
//        int number = int.Parse(Console.ReadLine());

//        if (number % 3 == 0 && number % 4 == 0)
//        {
//            Console.WriteLine("Yes");
//        }
//        else
//        {
//            Console.WriteLine("No");
//        }
//    }
//}

// quesyion 2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter an integer: ");
//        int number = int.Parse(Console.ReadLine());
//        Console.WriteLine(number < 0 ? "negative" : "positive");
//    }
//}

// question 3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter first number: ");
//        int a = int.Parse(Console.ReadLine());
//        Console.Write("Enter second number: ");
//        int b = int.Parse(Console.ReadLine());
//        Console.Write("Enter third number: ");
//        int c = int.Parse(Console.ReadLine());

//        Console.WriteLine("Max element = " + Math.Max(a, Math.Max(b, c)));
//        Console.WriteLine("Min element = " + Math.Min(a, Math.Min(b, c)));
//    }
//}
// question 4 

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter an integer: ");
//        int number = int.Parse(Console.ReadLine());
//        Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
//    }
//}

// question 5
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a character: ");
//        char ch = char.ToLower(char.Parse(Console.ReadLine()));
//        bool isVowel = ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
//        Console.WriteLine(isVowel ? "vowel" : "consonant");
//    }
//}
// question 6
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a number: ");
//        int number = int.Parse(Console.ReadLine());
//        for (int i = 1; i <= number; i++)
//            Console.Write(i + (i == number ? "" : ", "));
//        Console.WriteLine();
//    }
//}

// question 7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a number: ");
//        int number = int.Parse(Console.ReadLine());
//        for (int i = 1; i <= 12; i++)
//            Console.Write(number * i + (i == 12 ? "" : " "));
//        Console.WriteLine();
//    }
//}

// question 8
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a number: ");
//        int number = int.Parse(Console.ReadLine());
//        for (int i = 2; i <= number; i += 2)
//            Console.Write(i + " ");
//        Console.WriteLine();
//    }
//}
// question 9
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter base: ");
//        int number = int.Parse(Console.ReadLine());
//        Console.Write("Enter power: ");
//        int power = int.Parse(Console.ReadLine());
//        long result = 1;
//        for (int i = 1; i <= power; i++)
//            result *= number;
//        Console.WriteLine("Result = " + result);
//    }
//}
// question 10
//using System;

//class Program
//{
//    static void Main()
//    {
//        int total = 0;
//        Console.WriteLine("Enter marks of five subjects:");
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.Write("Mark " + i + ": ");
//            total += int.Parse(Console.ReadLine());
//        }
//        double average = total / 5.0;
//        double percentage = total / 500.0 * 100;
//        Console.WriteLine("Total marks = " + total);
//        Console.WriteLine("Average Marks = " + average);
//        Console.WriteLine("Percentage = " + percentage);
//    }
//}
// question 11
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter month number: ");
//        int month = int.Parse(Console.ReadLine());
//        int days;
//        switch (month)
//        {
//            case 1:
//            case 3:
//            case 5:
//            case 7:
//            case 8:
//            case 10:
//            case 12:
//                days = 31; break;
//            case 4:
//            case 6:
//            case 9:
//            case 11:
//                days = 30; break;
//            case 2:
//                days = 28; break;
//            default:
//                Console.WriteLine("Invalid month"); return;
//        }
//        Console.WriteLine("Days in Month: " + days);
//    }
//}
// question 12
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter first number: ");
//        double a = double.Parse(Console.ReadLine());
//        Console.Write("Enter operator (+, -, *, /): ");
//        char op = char.Parse(Console.ReadLine());
//        Console.Write("Enter second number: ");
//        double b = double.Parse(Console.ReadLine());
//        double result;
//        switch (op)
//        {
//            case '+': result = a + b; break;
//            case '-': result = a - b; break;
//            case '*': result = a * b; break;
//            case '/':
//                if (b == 0) { Console.WriteLine("Cannot divide by zero"); return; }
//                result = a / b; break;
//            default: Console.WriteLine("Invalid operator"); return;
//        }
//        Console.WriteLine("Result = " + result);
//    }
//}

// question 13
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a string: ");
//        string text = Console.ReadLine();
//        for (int i = text.Length - 1; i >= 0; i--)
//            Console.Write(text[i]);
//        Console.WriteLine();
//    }
//}
//question 14
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter an integer: ");
//        int number = int.Parse(Console.ReadLine());
//        int sign = number < 0 ? -1 : 1;
//        number = Math.Abs(number);
//        int reversed = 0;
//        do
//        {
//            reversed = reversed * 10 + number % 10;
//            number /= 10;
//        } while (number > 0);
//        Console.WriteLine("Reversed = " + reversed * sign);
//    }
//}
// question 15
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Input starting number of range: ");
//        int start = int.Parse(Console.ReadLine());
//        Console.Write("Input ending number of range: ");
//        int end = int.Parse(Console.ReadLine());
//        Console.WriteLine("The prime numbers are:");
//        for (int number = Math.Max(2, start); number <= end; number++)
//        {
//            bool prime = true;
//            for (int divisor = 2; divisor * divisor <= number; divisor++)
//                if (number % divisor == 0) { prime = false; break; }
//            if (prime) Console.Write(number + " ");
//        }
//        Console.WriteLine();
//    }
//}

// question 16
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a number to convert: ");
//        int number = int.Parse(Console.ReadLine());
//        if (number == 0) { Console.WriteLine("The Binary of 0 is 0."); return; }
//        string binary = "";
//        while (number > 0)
//        {
//            binary = (number % 2) + binary;
//            number /= 2;
//        }
//        Console.WriteLine("Binary = " + binary);
//    }
//}

// question 17
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("x1: "); double x1 = double.Parse(Console.ReadLine());
//        Console.Write("y1: "); double y1 = double.Parse(Console.ReadLine());
//        Console.Write("x2: "); double x2 = double.Parse(Console.ReadLine());
//        Console.Write("y2: "); double y2 = double.Parse(Console.ReadLine());
//        Console.Write("x3: "); double x3 = double.Parse(Console.ReadLine());
//        Console.Write("y3: "); double y3 = double.Parse(Console.ReadLine());
//        double determinant = (y2 - y1) * (x3 - x2) - (y3 - y2) * (x2 - x1);
//        Console.WriteLine(Math.Abs(determinant) < 0.000001 ? "The points lie on a single straight line." : "The points do not lie on a single straight line.");
//    }
//}
// question 18

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter time taken in hours: ");
//        double hours = double.Parse(Console.ReadLine());
//        if (hours >= 2 && hours <= 3) Console.WriteLine("Highly efficient");
//        else if (hours > 3 && hours <= 4) Console.WriteLine("Increase your speed");
//        else if (hours > 4 && hours <= 5) Console.WriteLine("Training");
//        else if (hours > 5) Console.WriteLine("Leave the company");
//        else Console.WriteLine("Invalid time");
//    }
//}
// question 19
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter matrix size n: ");
//        int n = int.Parse(Console.ReadLine());
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//                Console.Write((i == j ? 1 : 0) + " ");
//            Console.WriteLine();
//        }
//    }
//}
// question 20
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter array size: ");
//        int n = int.Parse(Console.ReadLine());
//        int sum = 0;
//        Console.WriteLine("Enter array elements:");
//        for (int i = 0; i < n; i++) sum += int.Parse(Console.ReadLine());
//        Console.WriteLine("Sum = " + sum);
//    }
//}
// question 21
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter size of each array: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] a = new int[n];
//        int[] b = new int[n];
//        Console.WriteLine("Enter first array elements:");
//        for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());
//        Console.WriteLine("Enter second array elements:");
//        for (int i = 0; i < n; i++) b[i] = int.Parse(Console.ReadLine());
//        int[] merged = new int[2 * n];
//        Array.Copy(a, 0, merged, 0, n);
//        Array.Copy(b, 0, merged, n, n);
//        Array.Sort(merged);
//        Console.WriteLine("Merged array:");
//        Console.WriteLine(string.Join(" ", merged));
//    }
//}
// question 22
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter array size: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] numbers = new int[n];
//        bool[] visited = new bool[n];
//        Console.WriteLine("Enter array elements:");
//        for (int i = 0; i < n; i++) numbers[i] = int.Parse(Console.ReadLine());
//        for (int i = 0; i < n; i++)
//        {
//            if (visited[i]) continue;
//            int count = 1;
//            for (int j = i + 1; j < n; j++)
//                if (numbers[i] == numbers[j]) { count++; visited[j] = true; }
//            Console.WriteLine(numbers[i] + " -> " + count);
//        }
//    }
//}
// question 23
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter array size: ");
//        int n = int.Parse(Console.ReadLine());
//        if (n <= 0) { Console.WriteLine("Array size must be positive."); return; }
//        int[] numbers = new int[n];
//        Console.WriteLine("Enter array elements:");
//        for (int i = 0; i < n; i++) numbers[i] = int.Parse(Console.ReadLine());
//        int min = numbers[0], max = numbers[0];
//        for (int i = 1; i < n; i++) { if (numbers[i] < min) min = numbers[i]; if (numbers[i] > max) max = numbers[i]; }
//        Console.WriteLine("Maximum = " + max);
//        Console.WriteLine("Minimum = " + min);
//    }
//}
// question 24
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter array size: ");
//        int n = int.Parse(Console.ReadLine());
//        if (n < 2) { Console.WriteLine("At least two elements are required."); return; }
//        int[] numbers = new int[n];
//        Console.WriteLine("Enter array elements:");
//        for (int i = 0; i < n; i++) numbers[i] = int.Parse(Console.ReadLine());
//        Array.Sort(numbers);
//        int largest = numbers[n - 1];
//        bool found = false;
//        for (int i = n - 2; i >= 0; i--)
//            if (numbers[i] != largest) { Console.WriteLine("Second largest = " + numbers[i]); found = true; break; }
//        if (!found) Console.WriteLine("There is no distinct second largest element.");
//    }
//}
// question 25
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter array size: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] numbers = new int[n];
//        Console.WriteLine("Enter array elements:");
//        for (int i = 0; i < n; i++) numbers[i] = int.Parse(Console.ReadLine());
//        int longest = 0;
//        for (int i = 0; i < n; i++)
//            for (int j = i + 1; j < n; j++)
//                if (numbers[i] == numbers[j] && j - i - 1 > longest) longest = j - i - 1;
//        Console.WriteLine("Longest distance = " + longest);
//    }
//}
