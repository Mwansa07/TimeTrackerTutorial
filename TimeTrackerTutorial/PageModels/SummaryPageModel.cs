using System;
using System.Collections.Generic;
using TimeTrackerTutorial.PageModels.Base;

namespace TimeTrackerTutorial.PageModels
{
    public class SummaryPageModel : PageModelBase
    {
        public string CurrentPayDateRange { get; set; }
        public double CurrentPeriodEarnings { get; set; }
        public DateTime CurrentPeriodPayDate { get; set; }
        public List<object> Statements { get; set; }
    }
}
