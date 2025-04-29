using CSP;

namespace CSPTest
{
    public class ExerciseTests
    {
        [Fact]
        public void SquareSum()
        {
            //assemble
            int[] arr = { 1, 2, 2 };
            //act
            int ans = EigthKyu.SquareSumOriginal(arr);
            //assert
            Assert.Equal(9, ans);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 2 }, 9)]
        [InlineData(new int[] { 1, 1, 1 }, 3)]
        public void SquareSumParam(int[] arr, int answer)
        {
            int ans = EigthKyu.SquareSumWithLinq(arr);
            int ans2 = EigthKyu.SquareSumWithLinqInline(arr);
            Assert.Equal(answer, ans);
            Assert.Equal(answer, ans2);
        }

        [Theory]
        [InlineData(new double[] { }, 0.0)]
        [InlineData(new double[] { 1.0, 1.1, 1.2, 1.3, 1.4 }, 1.2)]
        [InlineData(new double[] { 1, 2, 3 }, 2.0)]
        [InlineData(new double[] { 5, 5, 5, 5 }, 5.0)]
        [InlineData(new double[] { 2, 3, 6, 7, 1 }, 3.8)]
        public void FindAverage(double[] numbers, double answer)
        {
            double avg = EigthKyu.FindAverage(numbers);
            Assert.Equal(answer, avg);
        }

        [Theory]
        [InlineData(50, 1.80, "Underweight")]
        [InlineData(80, 1.80, "Normal")]
        [InlineData(90, 1.80, "Overweight")]
        [InlineData(100, 1.80, "Obese")]
        public void Bmi(double weight, double height, string message)
        {
            string msg = EigthKyu.Bmi(weight, height);
            Assert.Equal(message, msg);
        }

        [Theory]
        [InlineData(10, 10, 100)]
        [InlineData(4, 4, 16)]
        [InlineData(6, 10, 32)]
        public void AreaOrPerimeter(int length, int width, int answer)
        {
            int result = EigthKyu.AreaOrPerimeter(length, width);
            Assert.Equal(answer, result);
        }

        [Theory]
        [InlineData("1234", 1234)]
        [InlineData("605", 605)]
        [InlineData("1405", 1405)]
        [InlineData("-7", -7)]
        public void StringToNumber(string value, int answer)
        {
            int ans = EigthKyu.StringToNumber(value);
            Assert.Equal(answer, ans);
        }

        [Theory]
        [InlineData(1, -1)]
        [InlineData(-1, 1)]
        public void Opposite(int number, int answer)
        {
            int retVal = EigthKyu.Opposite(number);
            Assert.Equal(answer, retVal);
        }

        [Theory]
        [InlineData("hello world", "HELLO WORLD")]
        [InlineData("HELLO WORLD", "hello world")]
        [InlineData("hello WORLD", "HELLO world")]
        [InlineData("HeLLo WoRLD", "hEllO wOrld")]
        [InlineData("12345", "12345")]
        [InlineData("1a2b3c4d5e", "1A2B3C4D5E")]
        [InlineData("String.ToAlternatingCase", "sTRING.tOaLTERNATINGcASE")]
        public void ToAlternatingCase(string input, string answer)
        {
            string ans = input.ToAlternatingCase();
            Assert.Equal(answer, ans);
        }

        [Theory]
        [InlineData(
            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            new int[] {2, 4, 6, 8, 10, 12, 14}, 
            new int[] { 4, 8, 5, 3 })]
        [InlineData(
            new int[] { 33, 2, 3, 37, 38, 40, 12, 10, 43, 44, 47, 49, 8, 19, 22, 24, 26, 28, 29, 30 },
            new int[] { 1, 34, 17, 7, 9, 10, 43, 49, 22, 27, 28 },
            new int[] { 5, 21, 15, 6 })]
        [InlineData(
            new int[] { 32, 34, 3, 4, 39, 10, 43, 13, 11, 18, 21, 22, 7, 25, 26, 36 },
            new int[] { 32, 5, 38, 8, 41, 42, 12, 48, 40, 21, 22, 26, 10, 30 },
            new int[] { 5, 20, 11, 9 })]
        [InlineData(
            new int[] { 0, 33, 37, 6, 10, 44, 13, 47, 16, 18, 22, 25 },
            new int[] { 1, 38, 48, 8, 41, 7, 12, 47, 16, 40, 20, 23, 25 },
            new int[] { 3, 19, 9, 10 })]
        [InlineData(
            new int[] { 0, 19, 34, 35, 5, 7, 45, 13, 3, 20, 26, 29, 30 },
            new int[] { 33, 4, 38, 1, 8, 13, 47, 23, 28, 30, 31 },
            new int[] { 2, 20, 11, 9 })]
        [InlineData(
            new int[] { 0, 35, 17, 6, 7, 10, 11, 46, 47, 16, 49, 20, 14, 23, 25, 26, 29 },
            new int[] { 0, 6, 17, 42, 43, 47, 16, 49, 50, 21, 28, 30 },
            new int[] { 6, 17, 11, 6 })]
        public void Process2Arrays(int[] arr1, int[] arr2, int[] answer)
        {
            int[] ans = SeventhKyu.Process2Arrays(arr1, arr2);
            Assert.Equal(answer, ans);
        }

        [Theory]
        [InlineData("45385593107843568", "01011110001100111")]
        [InlineData("509321967506747", "101000111101101")]
        [InlineData("366058562030849490134388085", "011011110000101010000011011")]
        public void FakeBin(string input, string answer)
        {
            string ans = EigthKyu.FakeBin(input);
            Assert.Equal(ans, answer);
        }

        [Theory]
        [InlineData(30, 60, 90)]
        [InlineData(60, 60, 60)]
        [InlineData(43, 78, 59)]
        [InlineData(10, 20, 150)]
        public void OtherAngle(int a, int b, int answer)
        {
            Assert.Equal(answer, EigthKyu.OtherAngle(a, b));
        }

        [Theory]
        [InlineData(67, "67")]
        [InlineData(79585, "79585")]
        [InlineData(1 + 2, "3")]
        [InlineData(1 - 2, "-1")]
        [InlineData(0, "0")]
        public void NumberToString(int number, string answer)
        {
            string ans = EigthKyu.NumberToString(number);
            Assert.Equal(answer, ans);
        }

        [Theory]
        [InlineData("AAAA", "TTTT")]
        [InlineData("GTAT", "CATA")]
        [InlineData("AAGG", "TTCC")]
        [InlineData("CGCG", "GCGC")]
        [InlineData("ATTGC", "TAACG")]
        [InlineData("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA", "CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT")]
        public void MakeComplement(string input, string answer)
        {
            string ans = SeventhKyu.MakeComplement(input);
            Assert.Equal(ans, answer);
        }

        [Theory]
        [InlineData("1", false)]
        [InlineData("12", false)]
        [InlineData("123", false)]
        [InlineData("12345", false)]
        [InlineData("1234567", false)]
        [InlineData("-1234", false)]
        [InlineData("1.234", false)]
        [InlineData("-1.234", false)]
        [InlineData("00000000", false)]
        [InlineData("1234\n", false)]
        [InlineData("1234", true)]
        [InlineData("0000", true)]
        [InlineData("1111", true)]
        [InlineData("123456", true)]
        [InlineData("098765", true)]
        [InlineData("000000", true)]
        [InlineData("090909", true)]
        public void ValidatePin(string pin, bool answer)
        {
            Assert.Equal(answer, SeventhKyu.ValidatePin(pin));
        }

        [Theory]
        [InlineData(-1, false)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(25, true)]
        [InlineData(26, false)]
        [InlineData(81, true)]
        [InlineData(2147395600, true)]
        [InlineData(int.MaxValue, false)]
        public void IsSquare(int n, bool answer)
        {
            Assert.Equal(answer, SeventhKyu.IsSquare(n));
        }

        [Theory]
        [InlineData(-1, false)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(25, true)]
        [InlineData(26, false)]
        [InlineData(81, true)]
        [InlineData(2147395600, true)]
        [InlineData(int.MaxValue, false)]
        public void IsSquareBetterSolution(int n, bool answer)
        {
            Assert.Equal(answer, SeventhKyu.IsSquareBetterSolution(n));
        }
    }
}