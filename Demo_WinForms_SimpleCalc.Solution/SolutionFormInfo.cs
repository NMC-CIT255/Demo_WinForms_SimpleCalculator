using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WinForms_SimpleCalculator
{
    public struct SolutionFormInfo
    {
        public int NumberOfPeople { get; set; }
        public string BodyType { get; set; }

        public SolutionFormInfo(int numberOfPeople, string bodyType)
        {
            this.NumberOfPeople = numberOfPeople;
            this.BodyType = bodyType;
        }
    }
}
