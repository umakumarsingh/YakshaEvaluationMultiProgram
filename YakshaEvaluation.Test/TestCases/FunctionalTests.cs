using Odd;
using Upper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace YakshaEvaluation.Test.TestCases
{
    public class FunctionalTests
    {
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static FunctionalTests()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test to find expected odd number of result is returned or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFindOddExpectedValue()
        {
            //Arrange
            bool res = false;
            int expexted = 2;
            CollectionEx ex = new CollectionEx();
            const int Array_SIZE = 5;
            int[] value = new int[Array_SIZE] { 10, 11, 12, 13, 14 };
            List<int> LstACValues = new List<int>();
            LstACValues.AddRange(value);
            //Act
            int result = ex.findOdd(LstACValues);
            //Assertion
            if (result == expexted)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "testFindOdd_ExpectedValueAndResultMatch=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to find expected Upper case number of result is returned equal or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFindUpper_ExpectedValueAndResultMatch()
        {
            //Arrange
            bool res = false;
            int expexted = 5;
            FindUpperCase ex = new FindUpperCase();
            string str = "HeLlO AlL";
            //Act
            int result = ex.FindUpper(str);
            //Assertion
            if (result == expexted)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "testFindUpper_ExpectedValueAndResultMatch=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to find Upper for Minimal value its return result or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFindUpperForMinimalValue()
        {
            //Arrange
            bool res = false;
            int expexted = 0;
            FindUpperCase ex = new FindUpperCase();
            string str = "hello all";
            //Act
            int result = ex.FindUpper(str);
            //Assertion
            if (result == expexted)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "testFindUpperForMinimalValue=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to find Upper for Maximum value its return result or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFindUpperForMaximumValue()
        {
            //Arrange
            bool res = false;
            int expexted = 8;
            FindUpperCase ex = new FindUpperCase();
            string str = "HELLO ALL";
            //Act
            int result = ex.FindUpper(str);
            //Assertion
            if (result == expexted)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "testFindUpperForMaximumValue=" + res + "\n");
            return res;
        }
    }
}
