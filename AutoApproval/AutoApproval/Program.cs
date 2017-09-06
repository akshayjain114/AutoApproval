using AutoApproval.AdminHistory;
using NRakeCore.StopWordFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminApprovalHistory h = new AdminApprovalHistory(new EnglishSmartStopWordFilter(), new DataExtractor());
            h.SaveHistory();
            h.GetOutcomes();
        }
    }
}
