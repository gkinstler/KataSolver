using System;
using Xunit;
using KataSolver;

namespace KataSolverTests.tests
{
    public class KataTests
    {
        //  8KYU #1 https://www.codewars.com/kata/basic-mathematical-operations //

        [Theory]
        [InlineData('+', 4, 7, 11)]
        [InlineData('-', 2, 1, 1)]
        [InlineData('*', 4, 7, 28)]
        [InlineData('/', 4, 2, 2)]
        public void BasicMathOps(char operation, double value1, double value2, double expected)
        {
            // Arrange
            BasicMathOps BasicMathOps = new BasicMathOps();

            // Act
            double actual = BasicMathOps.BasicMathOpsTests(operation, value1, value2);

            // Assert
            Assert.Equal(expected, actual);
        }

        //  8KYU #2 https://www.codewars.com/kata/century-from-year //

        [Theory]
        [InlineData(1750, 17)]
        [InlineData(1865, 18)]
        [InlineData(1900, 19)]
        public void CenturyFromYear(int year, int expected)
        {
            // Arrange
            CenturyFromYear CenturyFromYear = new CenturyFromYear();

            // Act
            int actual = CenturyFromYear.СenturyFromYearTests(year);

            // Assert
            Assert.Equal(expected, actual);
        }

        //  8KYU #3 https://www.codewars.com/kata/even-or-odd //

        [Theory]
        [InlineData(2, "Even")]
        [InlineData(1, "Odd")]
        [InlineData(7, "Odd")]
        [InlineData(0, "Even")]
        public void EvenOrOdd(int number, string expected)
        {
            // Arrange
            EvenOrOdd EvenOrOdd = new EvenOrOdd();

            // Act
            string actual = EvenOrOdd.EvenOrOddTests(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        //  8KYU #4 https://www.codewars.com/kata/return-negative  //

        [Theory]
        [InlineData(1, -1)]
        [InlineData(-5, -5)]
        [InlineData(5, -5)]
        public void MakeNegative_Method(int number, int expected)
        {
            //  Arrange
            MakeNegative makeNegative = new MakeNegative();

            //  Act
            int actual = MakeNegative.MakeNegativeTests(number);

            //  Assert
            Assert.Equal(expected, actual);

        }

        //  8KYU #5 https://www.codewars.com/kata/dna-to-rna-conversion/train/csharp  //

        [Theory]
        [InlineData("TTTT", "UUUU")]
        [InlineData("GCAT", "GCAU")]
        public void DNAtoRNA_Method(string dna, string expected)
        {
            // Arrange
            DNAtoRNA dNAtoRNA = new DNAtoRNA();

            //  Act
            string actual = DNAtoRNA.DNAtoRNATests(dna);

            //  Assert
            Assert.Equal(expected, actual);

        }

        //  8KYU #6 https://www.codewars.com/kata/do-i-get-a-bonus/train/csharp //

        [Theory]
        [InlineData(10000, true, "$100000")]
        [InlineData(25000, true, "$250000")]
        [InlineData(10000, false, "$10000")]
        public void Bonus_Time_Method(int salary, bool bonus, string expected)
        {
            //  Arrange
            BonusTime bonusTime = new BonusTime();

            //  Act
            string actual = BonusTime.Bonus_Time_Tests(salary, bonus);

            //  Assert
            Assert.Equal(expected, actual);
        }

        //  8KYU #7 https://www.codewars.com/kata/string-repeat/train/csharp //

        [Theory]
        [InlineData(6, "I", "IIIIII")]
        [InlineData(5, "Hello", "HelloHelloHelloHelloHello")]
        [InlineData(2, "Bye", "ByeBye")]
        public void RepeatStr_Method(int n, string s, string expected)
        {
            //  Arrange
            RepeatString repeatString = new RepeatString();

            //  Act
            string actual = RepeatString.repeatStrTests(n, s);

            //  Assert
            Assert.Equal(expected, actual);
        }

        //  8KYU #8 https://www.codewars.com/kata/grasshopper-summation/train/csharp //

        [Theory]
        [InlineData(2, 3)]
        [InlineData(8, 36)]
        [InlineData(22, 253)]
        public void GrasshopperSummation_Method(int num, int expected)
        {
            //  Arrange
            GrasshopperSummation grasshopperSummation = new GrasshopperSummation();

            //  Act
            int actual = GrasshopperSummation.SummationTests(num);

            //  Assert
            Assert.Equal(actual, expected);
        }

        //  6KYU #1 https://www.codewars.com/kata/multiples-of-3-or-5 //
        //  I don't know how to actually solve this one.  Just providing the test //
        [Theory]
        [InlineData(10, 23)]
        public void Multiplesof3and5_Method(int value, int expected)
        {
            //  Arrange
            Multiplesof3and5 multiplesof3And5 = new Multiplesof3and5();

            //  Act
            int actual = Multiplesof3and5.MultiplesOf3and5_Tests(value);

            //  Assert
            Assert.Equal(actual, expected);
        }

        //  6KYU #2  https://www.codewars.com/kata/format-words-into-a-sentence/train/csharp //
        //  I don't know how to actually solve this one.  Just providing the test //
        [Theory]
        [InlineData("ninja, samurai and ronin", "ninja, sumarai and ronin")]
        [InlineData("one, two, three and four", "one, two, three and four")]
        public void FormatWordsIntoASentence_Method(string words, string expected)
        {
            //  Arrange
            FormatWordsIntoASentence formatWordsIntoASentence = new FormatWordsIntoASentence();

            //  Act
            string actual = FormatWordsIntoASentence.FormatWordsIntoASentence_Tests(words);

            // Assert
            Assert.Equal(actual, expected);
        }

        //  6KYU #3  https://www.codewars.com/kata/split-strings/train/csharp //
        //  I don't know how to actually solve this one.  Just providing the test //
        [Theory]
        [InlineData("abc", "abc")]
        [InlineData("abcdef", "abcdef")]
        public void SplitString_Method (string str, string expected)
        {
            //  Arrange
            SplitStrings splitStrings = new SplitStrings();

            //  Act
            string actual = SplitStrings.SplitStrings_Tests(str);

            //  Asser
            Assert.Equal(actual, expected);
        }

        //  6KYU #4  https://www.codewars.com/kata/throwing-darts/train/csharp //
        //  I don't know how to actually solve this one.  Just providing the test //
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(2, 4, 6, 12)]
        public void ThrowingDarts_Method (int throw1, int throw2, int throw3, int expected)
        {
            //  Arrange
            ThrowingDarts throwingDarts = new ThrowingDarts();

            //  Act
            int actual = ThrowingDarts.ThrowingDarts_Tests(throw1, throw2, throw3);

            //  Assert
            Assert.Equal(actual, expected);

        }

    }


}
 
