using NUnit.Framework;

namespace Algorithms.Tests.NUnit
{
    [TestFixture]
    public class AlgorithmsTests
    {
        [TestCase(6, 10, 1, 3, ExpectedResult = 4)]
        [TestCase(29, 20, 2, 6, ExpectedResult = 81)]
        public int InsertNumber_executes_successfully(
            int firstNumber,
            int secondNumber,
            int i,
            int j)
        {
            return Algorithm.InsertNumber(
                firstNumber,
                secondNumber,
                i,
                j);
        }        
    }
}
