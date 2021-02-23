using System;
using System.Collections.Generic;
using TimeTrackerTutorial.Models;
using TimeTrackerTutorial.PageModels.Base;

namespace TimeTrackerTutorial.PageModels
{
    public class SummaryPageModel : PageModelBase
    {
        private string _currentPayDateRange;
        public string CurrentPayDateRange
        {
            get => _currentPayDateRange;
            set => SetProperty(ref _currentPayDateRange, value);
        }

        private double _currentPeriodEarnings;
        public double CurrentPeriodEarnings
        {
            get => _currentPeriodEarnings;
            set => SetProperty(ref _currentPeriodEarnings, value);
        }

        private DateTime _currentPeriodPayDate;
        public DateTime CurrentPeriodPayDate
        {
            get => _currentPeriodPayDate;
            set => SetProperty(ref _currentPeriodPayDate, value);
        }

        private List<PayStatement> _statements;
        public List<PayStatement> Statements
        {
            get => _statements;
            set => SetProperty(ref _statements, value);
        }

        public SummaryPageModel()
        {

        }
    }
}
