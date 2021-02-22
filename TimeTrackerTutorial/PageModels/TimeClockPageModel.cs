using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TimeTrackerTutorial.Models;
using TimeTrackerTutorial.PageModels.Base;
using TimeTrackerTutorial.ViewModels.Buttons;

namespace TimeTrackerTutorial.PageModels
{
    public class TimeClockPageModel : PageModelBase
    {
        private bool _isClockedIn;

        TimeSpan _runningTotal;
        public TimeSpan RunningTotal
        {
            get => _runningTotal;
            set => SetProperty(ref _runningTotal, value);
        }

        DateTime _currentStartTime;
        public DateTime CurrentStartTime
        {
            get => _currentStartTime;
            set => SetProperty(ref _currentStartTime, value);
        }

        ObservableCollection<WorkItem> _workItems;
        public ObservableCollection<WorkItem> WorkItems
        {
            get => _workItems;
            set => SetProperty(ref _workItems, value);
        }

        double _todaysEarnings;
        public double TodaysEarnings
        {
            get => _todaysEarnings;
            set => SetProperty(ref _todaysEarnings, value);
        }

        ButtonModel _clockInOutButtonModel;
        public ButtonModel ClockInOutButtonModel
        {
            get => _clockInOutButtonModel;
            set => SetProperty(ref _clockInOutButtonModel, value);
        }

        public TimeClockPageModel()
        {
            WorkItems = new ObservableCollection<WorkItem>();
            ClockInOutButtonModel = new ButtonModel("Clock In", OnClockInOutAction);
        }

        public override Task InitializeAsync(object navigationData = null)
        {
            RunningTotal = new TimeSpan();
            return base.InitializeAsync(navigationData);
        }

        private void OnClockInOutAction()
        {
            if (_isClockedIn)
            {
                ClockInOutButtonModel.Text = "Clock In";
            }
            else
            {
                ClockInOutButtonModel.Text = "Clock Out";
            }
            _isClockedIn = !_isClockedIn;
        }
    }
}
