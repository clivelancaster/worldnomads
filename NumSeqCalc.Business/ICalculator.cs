using System;
using System.Collections.Generic;
using NumSeqCalc.Entities;
namespace NumSeqCalc.Business
{
    public interface ICalculator
    {
        List<string> GetAllFibonacciNumbersIncTo(string n);
        List<string> GetAllNumbersIncTo(string n);
        List<string> GetAllNumbersIncToCase(string n);
        List<string> GetEvenNumbersIncTo(string n);
        List<string> GetOddNumbersIncTo(string n);
        List<Calculate> GetFullList(string number);
        bool ValidatePositive(string n);
    }
}
