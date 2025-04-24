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

        public static bool ValidatePin(string pin)
        {
            return Regex.IsMatch(pin, @"\d{4}") || Regex.IsMatch(pin, @"\d{6}");
        }
    }
}
