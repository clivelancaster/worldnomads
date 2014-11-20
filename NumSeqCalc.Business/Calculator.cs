using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumSeqCalc.Entities;

namespace NumSeqCalc.Business
{
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Validate positive number.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool ValidatePositive(string n)
        {
            int i;
            return int.TryParse(n, out i);
        }

        #region Story ID:3

        /// <summary>
        /// All numbers up to and including the number entered.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<string> GetAllNumbersIncTo(string n)
        {
            // Cast input
            int len = Convert.ToInt32(n);
            // Set start
            int sum = 0;
            // Loop through all
            var resultList = new List<string>();
            while (sum <= len)
            {
                resultList.Add(sum.ToString());
                sum++;
            }
            return resultList;
        }

        /// <summary>
        /// All odd numbers up to and including the number entered.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<string> GetOddNumbersIncTo(string n)
        {
            // Cast input
            int len = Convert.ToInt32(n);
            // Set start
            int sum = 0;
            // Loop through all
            var resultList = new List<string>();
            while (sum <= len)
            {
                // Not divisable by 2
                if (sum % 2 != 0)
                {
                    resultList.Add(sum.ToString());
                }
                sum++;
            }
            return resultList;
        }

        /// <summary>
        /// All even numbers up to and including the number entered.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<string> GetEvenNumbersIncTo(string n)
        {
            // Cast input
            int len = Convert.ToInt32(n);
            // Set start
            int sum = 0;
            // Loop through all
            var resultList = new List<string>();
            while (sum <= len)
            {
                // Is divisable by 2
                if (sum % 2 == 0)
                {
                    resultList.Add(sum.ToString());
                }
                sum++;
            }
            return resultList;
        }

        /// All numbers up to and including the number entered. 
        /// Except: [ multiple of 3 output C]
        /// Except: [ multiple of 5 output E]
        /// Except: [ multiple of 3 & 5 output Z]
        public List<string> GetAllNumbersIncToCase(string n)
        {
            // Cast input
            int len = Convert.ToInt32(n);
            // Set start
            int sum = 0;
            // Loop through all
            var resultList = new List<string>();
            while (sum <= len)
            {
                // multiple of 3 & 5 output Z
                if (((sum % 3) == 0) && (sum % 5) == 0)
                {
                    resultList.Add("Z");
                }
                // multiple of 3 output C
                else if ((sum % 3) == 0)
                {
                    resultList.Add("C");
                }
                // multiple of 5 output E
                else if ((sum % 5) == 0)
                {
                    resultList.Add("E");
                }
                else
                {
                    resultList.Add(sum.ToString());
                }
                sum++;
            }
            return resultList;
        }

        /// <summary>
        /// fibonacci numbers up to and including the number entered. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<string> GetAllFibonacciNumbersIncTo(string n)
        {
            
            // Cast input
            int len = Convert.ToInt32(n);
            // Set start
            int num1 = 0;
            int num2 = 1;
            int sum = 1;
            // Loop through all
            var resultList = new List<string>();
            // Manual 0,1
            resultList.Add("0");
            if (len > 0)
            {
                resultList.Add("1");
            }
            while (sum < len)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                // Fix for fibonacci greater than lenth set
                if(num2 <= len)
                resultList.Add(num2.ToString());
            }
            return resultList;
        }

        #endregion

        /// <summary>
        /// Method to collect all results into a list
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<Calculate> GetFullList(string number)
        {
            var calculateList = new List<Calculate>();

            // Get All
            var _calculate1 = new Calculate()
            {
                id = 1,
                description = "S3.1.1 All numbers up to and including the number entered.",
                numberList = string.Join(", ", GetAllNumbersIncTo(number).ToArray())
            };
            calculateList.Add(_calculate1);

            // Get Odd
            var _calculate2 = new Calculate()
            {
                id = 2,
                description = "S3.1.2 All odd numbers up to and including the number entered.",
                numberList = string.Join(", ", GetOddNumbersIncTo(number).ToArray())
            };
            calculateList.Add(_calculate2);

            // Get Even
            var _calculate3 = new Calculate()
            {
                id = 3,
                description = "S3.1.3 All even numbers up to and including the number entered.",
                numberList = string.Join(", ", GetEvenNumbersIncTo(number).ToArray())
            };
            calculateList.Add(_calculate3);

            // Get All Case
            var _calculate4 = new Calculate()
            {
                id = 4,
                description = "S3.1.4  All numbers up to and including the number entered except when multiple of 3, 5 or both.",
                numberList = string.Join(", ", GetEvenNumbersIncTo(number).ToArray())
            };
            calculateList.Add(_calculate4);

            // Get All Fibonacci
            var _calculate5 = new Calculate()
            {
                id = 5,
                description = "S3.1.5 All fibonacci numbers up to and including the number entered.",
                numberList = string.Join(", ", GetAllFibonacciNumbersIncTo(number).ToArray())
            };
            calculateList.Add(_calculate5);


            return calculateList;
        }
    }
}
