using Odd;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Upper;
using Xunit;

namespace YakshaEvaluation.Test.TestCases
{
    public class ExceptionalTest
    {
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static ExceptionalTest()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test to find and check max odd for null value is return 0 or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testMaxOddForNoValue()
        {
            //Arrange
            bool res = false;
            //int expexted = 2;
            CollectionEx ex = new CollectionEx();
            List<int> LstACValues = new List<int>();
            //Act
            int result = ex.findOdd(LstACValues);
            //Assertion
            if (result == 0)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "testMaxOddForNoValue=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to find Upper for Maximum value its return result or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFindUpperForNoValue()
        {
            //Arrange
            bool res = false;
            int expexted = 0;
            FindUpperCase ex = new FindUpperCase();
            string str = "";
            //Act
            int result = ex.FindUpper(str);
            //Assertion
            if (result == expexted)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "testFindUpperForNoValue=" + res + "\n");
            return res;
        }
    }
}
