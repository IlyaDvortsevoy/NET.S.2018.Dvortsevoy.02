using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Algorithms
{ 
    /// <summary>
    /// Implements different types of algorithms
    /// </summary>
    public static class Algorithm
    {
        /// <summary>
        /// Realises bitwise insertion of one number into another within the certain range
        /// </summary>
        /// <param name="firstNumber"> A source number to insert in </param>
        /// <param name="secondNumber"> Insertion number </param>
        /// <param name="i"> Starting point of the bit range </param>
        /// <param name="j"> Ending point of the bit range </param>
        /// <returns> Resulting number </returns>
        public static int InsertNumber(int firstNumber, int secondNumber, int i, int j)
        {
            ValidatePoints(i, j);

            int indicator = 1;
            int count;
            int temp;

            for (int k = i; k <= j; k++)
            {
                temp = secondNumber & indicator;
                count = 1 << k;
                if (temp == 0)
                {
                    count = ~count;
                    firstNumber &= count;
                }
                else
                {
                    firstNumber |= count;
                }

                indicator <<= 1;
            }

            return firstNumber;
        }

        /// <summary>
        /// Filters input array and returns array containing only numbers with given digit
        /// </summary>
        /// <param name="array"> Input array of integer numbers </param>
        /// <param name="digit"> The given integer digit for filtering </param>
        /// <returns> Filtered array of integer numbers </returns>
        /// <exception cref="ArgumentOutOfRangeException"> Occurs if the given digit is out of the range from 0 to 9 </exception>
        public static int[] FilterDigitByDivision(int digit, params int[] array)
        {
            ValidateDigit(digit);
            ValidateArray(array);

            var list = new List<int>();

            foreach (var number in array)
            {
                int temp = number;

                if (temp < 0)
                {
                    temp *= -1;
                }

                while (temp > 0)
                {
                    if (temp % 10 == digit)
                    {
                        list.Add(number);
                        break;
                    }

                    temp /= 10;
                }
            }

            return list.ToArray();
        }
        
        #region Private Methods
        /// <summary>
        /// Validates starting and ending points of the bit range of System.Int32 number
        /// </summary>
        /// <param name="i"> Starting point of the bit range </param>
        /// <param name="j"> Ending point of the bit range </param>
        /// <exception cref="ArgumentException"> Occurs if starting or ending point of the bit range doesn't match requirements </exception>
        private static void ValidatePoints(int i, int j)
        {
            if (i < 0 || i > j)
            {
                throw new ArgumentException(nameof(i));
            }
            else if (j < 0 || j > 32)
            {
                throw new ArgumentException(nameof(j));
            }
        }

        /// <summary>
        /// Validates the array built from input integer parameters
        /// </summary>
        /// <param name="array"> The built array of the integer numbers </param>
        /// <exception cref="ArgumentNullException"> Occurs if null argument was passed </exception>
        private static void ValidateArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
        }

        /// <summary>
        /// Validates that a value of the integer digit is in the range from 0 to 9
        /// </summary>
        /// <param name="digit"> The integer digit to validate </param>
        /// <exception cref="ArgumentOutOfRangeException"> Occurs if the integer digit is out of the range </exception>
        private static void ValidateDigit(int digit)
        {
            string pattern = @"^[0-9]$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(digit.ToString()))
            {
                throw new ArgumentOutOfRangeException(nameof(digit));
            }
        }
        #endregion
    }
}