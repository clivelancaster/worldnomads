using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumSeqCalc.Models;
using NumSeqCalc.Business;
using NumSeqCalc.Entities;
using AutoMapper;

namespace NumSeqCalc.Service
{
    public class CalculateService : NumSeqCalc.Service.ICalculateService
    {
        ICalculator _calculator;

        public CalculateService()
            : this(new Business.Calculator())
        {
        }

        public CalculateService(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public List<CalculateModel> GetCalculatedResult(string number)
        {
            Mapper.CreateMap<Calculate, CalculateModel>();
            var calculations = Mapper.Map<List<Calculate>, List<CalculateModel>>(_calculator.GetFullList(number));

            return calculations;
        }
    }
}
