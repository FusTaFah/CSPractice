using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSP
{
    public static class EigthKyu
    {
        public static int SquareSumOriginal(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i] * numbers[i];
            }
            return total;
        }

        public static int SquareSumWithLinq(int[] numbers)
        {
            return numbers.Sum(x => x * x);
        }

        public static int SquareSumWithLinqInline(int[] numbers) => numbers.Sum(x => x * x);

        public static double FindAverage(double[] array) => array.Length == 0 ? 0.0 : array.Average();

        static double BmiCalc(double weight, double height) => weight / (height * height);
        public static string Bmi(double weight, double height) => BmiCalc(weight, height) switch
        {
            _ when BmiCalc(weight, height) > 30 => "Obese",
            _ when BmiCalc(weight, height) > 25 => "Overweight",
            _ when BmiCalc(weight, height) > 18.5 => "Normal",
            _ => "Underweight"
        };

        public static int AreaOrPerimeter(int l, int w) => l == w ? l * w : 2 * (l + w);

        public static int StringToNumber(String str) => int.Parse(str);

        public static int Opposite(int number) => -number;

        public static string ToAlternatingCase(this string s)
        {
            StringBuilder sb = new StringBuilder(s.Length);
            foreach (Char c in s)
            {
                if (Char.IsLower(c))
                {
                    sb.Append(Char.ToUpper(c));
                }
                else if (Char.IsUpper(c))
                {
                    sb.Append(Char.ToLower(c));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string FakeBin(string x) =>
            string.Concat(x.Select(c => int.Parse(c.ToString()) < 5 ? "0" : "1"));

        public static int OtherAngle(int a, int b) => 180 - a - b;

        public static string NumberToString(int num) => num.ToString();
    }

    public static class SeventhKyu
    {
        public static int[] Process2Arrays(int[] arr1, int[] arr2) =>
            new int[] {
                arr1.Intersect(arr2).Count() ,
                arr1.Except(arr2).Concat(arr2.Except(arr1)).Count(),
                arr1.Except(arr2).Count(),
                arr2.Except(arr1).Count()
            };

        public static string MakeComplement(string dna) => string.Concat(dna.Select(x => 
            x switch {
                'A' => "T",
                'T' => "A",
                'C' => "G",
                'G' => "C",
                _ => string.Empty
            }));

        public static bool ValidatePin(string pin) => Regex.IsMatch(pin, @"(?<!.)(?:\d{4}|\d{6})(?!(?:.|\n))");

        public static bool IsSquare(int n)
        {
            if (n < 0) return false;

            float sq = MathF.Sqrt(n);
            float exp = MathF.Truncate(sq);

            return sq - exp <= float.Epsilon;
        }

        public static bool IsSquareBetterSolution(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }

        public static int[] minMax(int[] lst)
        {
            //you can also use Array.Sort for arrays. no need to make into a list
            List<int> sortedList = new List<int>(lst);
            sortedList.Sort();
            return new int[] { sortedList[0], sortedList[^1] };
        }
    }
}
