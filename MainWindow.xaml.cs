using System;
using System.Collections.Generic;
using System.Windows;

namespace TaskSolver
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i <= 30; i++)
            {
                TaskComboBox.Items.Add($"Task {i}");
            }
        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputTextBox.Text, out int input))
            {
                int taskNumber = TaskComboBox.SelectedIndex + 1;
                string result = SolveTask(taskNumber, input);
                OutputTextBox.Text = result;
            }
            else
            {
                OutputTextBox.Text = "Invalid input";
            }
        }

        private string SolveTask(int taskNumber, int input)
        {
            switch (taskNumber)
            {
                case 1:
                    return $"Result: {Math.Pow(input, 2)}";
                case 2:
                    return $"Factorial: {Factorial(input)}";
                case 3:
                    return $"Sum of squares: {SumOfSquares(input)}";
                case 4:
                    return $"Sum of squares and cubes: {SumOfSquaresAndCubes(input)}";
                case 5:
                    return $"Numbers: {FindNumbers(input)}";
                case 6:
                    return $"Multiples of five: {FindMultiplesOfFive(input)}";
                case 7:
                    return $"Is power of two: {IsPowerOfTwo(input)}";
                case 8:
                    return $"Prime factors: {PrimeFactors(input)}";
                case 9:
                    return $"Perfect numbers: {FindPerfectNumbers(input)}";
                case 10:
                    return $"Sum of squares from m to n: {SumOfSquaresRange(input, input + 10)}";
                case 11:
                    return $"Sum of squares of odd numbers: {SumOfSquaresOfOddNumbers(input, input + 10)}";
                case 12:
                    return $"Product of odd multiples of seven: {ProductOfOddMultiplesOfSeven()}";
                case 13:
                    return $"Sum of positive multiples of nine: {SumOfPositiveMultiplesOfNine()}";
                case 14:
                    return $"Count of three-digit numbers greater than n: {CountThreeDigitNumbersGreaterThan(input)}";
                case 15:
                    return $"Numbers coprime with n: {FindCoprimeNumbers(input)}";
                case 16:
                    return $"Divisors of q coprime with p: {FindDivisorsCoprimeWithP(input, input + 10)}";
                case 17:
                    return $"Prime divisors of n: {FindPrimeDivisors(input)}";
                case 18:
                    return $"First 100 prime numbers: {FindFirst100Primes()}";
                case 19:
                    return $"Product of squares of even numbers: {ProductOfSquaresOfEvenNumbers(input, input + 10)}";
                case 20:
                    return $"Sum of series: {SumOfSeries(input)}";
                case 21:
                    return $"Difference of cubes: {DifferenceOfCubes(input)}";
                case 22:
                    return $"Square of difference: {SquareOfDifference(input, input + 10)}";
                case 23:
                    return $"Sum of negative multiples of five: {SumOfNegativeMultiplesOfFive()}";
                case 24:
                    return $"Sum of positive multiples of four: {SumOfPositiveMultiplesOfFour()}";
                case 25:
                    return $"Difference of squares: {DifferenceOfSquares(input)}";
                case 26:
                    return $"Odd numbers from 100 to 200: {OddNumbersFrom100To200()}";
                case 27:
                    return $"Product of cubes from m to n: {ProductOfCubes(input, input + 10)}";
                case 28:
                    return $"Numbers with square of sum of digits equal to m: {NumbersWithSquareOfSumOfDigits(input, input + 10)}";
                case 29:
                    return $"Product of squares of odd numbers: {ProductOfSquaresOfOddNumbers(input, input + 10)}";
                case 30:
                    return $"Sum of squares of even numbers: {SumOfSquaresOfEvenNumbers(input, input + 10)}";
                default:
                    return "Task not implemented";
            }
        }

        private int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        private int SumOfSquares(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        private int SumOfSquaresAndCubes(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i * i;
                }
                else
                {
                    sum += i * i * i;
                }
            }
            return sum;
        }

        private string FindNumbers(int n)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 != 0 && i % 3 == 0 && (i % 10 + i / 10) % 5 != 0 && (i % 10 + i / 10) % 3 == 0)
                {
                    numbers.Add(i);
                }
            }
            return string.Join(", ", numbers);
        }

        private string FindMultiplesOfFive(int n)
        {
            List<int> multiples = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }
            return string.Join(", ", multiples);
        }

        private bool IsPowerOfTwo(int n)
        {
            return (n != 0) && ((n & (n - 1)) == 0);
        }

        private string PrimeFactors(int n)
        {
            List<int> factors = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            }
            return string.Join(", ", factors);
        }

        private string FindPerfectNumbers(int x)
        {
            List<int> perfectNumbers = new List<int>();
            for (int i = 2; i <= x; i++)
            {
                if (IsPerfect(i))
                {
                    perfectNumbers.Add(i);
                }
            }
            return string.Join(", ", perfectNumbers);
        }

        private bool IsPerfect(int n)
        {
            int sum = 1;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i * i != n)
                    {
                        sum += i + n / i;
                    }
                    else
                    {
                        sum += i;
                    }
                }
            }
            return sum == n;
        }

        private int SumOfSquaresRange(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        private int SumOfSquaresOfOddNumbers(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i * i;
                }
            }
            return sum;
        }

        private int ProductOfOddMultiplesOfSeven()
        {
            int product = 1;
            for (int i = -80; i <= 80; i++)
            {
                if (i % 2 != 0 && i % 7 == 0)
                {
                    product *= i;
                }
            }
            return product;
        }

        private int SumOfPositiveMultiplesOfNine()
        {
            int sum = 0;
            for (int i = -10; i <= 10; i++)
            {
                if (i > 0 && i % 9 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private int CountThreeDigitNumbersGreaterThan(int n)
        {
            int count = 0;
            for (int i = 100; i <= 999; i++)
            {
                if (i > n)
                {
                    count++;
                }
            }
            return count;
        }

        private string FindCoprimeNumbers(int n)
        {
            List<int> coprimeNumbers = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if (GCD(i, n) == 1)
                {
                    coprimeNumbers.Add(i);
                }
            }
            return string.Join(", ", coprimeNumbers);
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private string FindDivisorsCoprimeWithP(int p, int q)
        {
            List<int> divisors = new List<int>();
            for (int i = 1; i <= q; i++)
            {
                if (q % i == 0 && GCD(i, p) == 1)
                {
                    divisors.Add(i);
                }
            }
            return string.Join(", ", divisors);
        }

        private string FindPrimeDivisors(int n)
        {
            List<int> primeDivisors = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0 && IsPrime(i))
                {
                    primeDivisors.Add(i);
                }
            }
            return string.Join(", ", primeDivisors);
        }

        private bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private string FindFirst100Primes()
        {
            List<int> primes = new List<int>();
            int count = 0;
            int num = 2;
            while (count < 100)
            {
                if (IsPrime(num))
                {
                    primes.Add(num);
                    count++;
                }
                num++;
            }
            return string.Join(", ", primes);
        }

        private int ProductOfSquaresOfEvenNumbers(int m, int n)
        {
            int product = 1;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    product *= i * i;
                }
            }
            return product;
        }

        private int SumOfSeries(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int term = 1;
                for (int j = i; j <= 2 * i; j++)
                {
                    term *= j;
                }
                sum += term;
            }
            return sum;
        }

        private int DifferenceOfCubes(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i * i * i;
                }
            }
            return sum;
        }

        private int SquareOfDifference(int m, int n)
        {
            int difference = m - n;
            return difference * difference;
        }

        private int SumOfNegativeMultiplesOfFive()
        {
            int sum = 0;
            for (int i = -20; i <= 20; i++)
            {
                if (i < 0 && i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private int SumOfPositiveMultiplesOfFour()
        {
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private int DifferenceOfSquares(int n)
        {
            int sumOfSquares = 0;
            int squareOfSum = 0;
            for (int i = 1; i <= n; i++)
            {
                sumOfSquares += i * i;
                squareOfSum += i;
            }
            squareOfSum *= squareOfSum;
            return squareOfSum - sumOfSquares;
        }

        private string OddNumbersFrom100To200()
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(i);
                }
            }
            return string.Join(", ", oddNumbers);
        }

        private int ProductOfCubes(int m, int n)
        {
            int product = 1;
            for (int i = m; i <= n; i++)
            {
                product *= i * i * i;
            }
            return product;
        }

        private string NumbersWithSquareOfSumOfDigits(int n, int m)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i < n; i++)
            {
                int sumOfDigits = SumOfDigits(i);
                if (sumOfDigits * sumOfDigits == m)
                {
                    numbers.Add(i);
                }
            }
            return string.Join(", ", numbers);
        }

        private int SumOfDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        private int ProductOfSquaresOfOddNumbers(int m, int n)
        {
            int product = 1;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    product *= i * i;
                }
            }
            return product;
        }

        private int SumOfSquaresOfEvenNumbers(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i * i;
                }
            }
            return sum;
        }
    }
}
