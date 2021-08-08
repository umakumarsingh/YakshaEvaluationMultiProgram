using Odd;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace YakshaEvaluation.Test.TestCases
{
    public class BoundaryTest
    {
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static BoundaryTest()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test to find and check max odd for minimal value is return 0 or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testMaxOddForMinimal()
        {
            //Arrange
            bool res = false;
            CollectionEx ex = new CollectionEx();
            const int Array_SIZE = 5;
            int[] value = new int[Array_SIZE] { 0, 0, 0, 0, 0 };
            List<int> LstACValues = new List<int>();
            LstACValues.AddRange(value);
            //Act
            int result = ex.findOdd(LstACValues);
            //Assertion
            if (result == 0)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testMaxOddForMinimal=" + res + "\n");
            return res;
        }
    }
}
