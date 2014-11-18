using System;
using NumSeqCalc.Models;
using System.Collections.Generic;
namespace NumSeqCalc.Service
{
    interface ICalculateService
    {
        List<CalculateModel> GetCalculatedResult(string number);
    }
}
