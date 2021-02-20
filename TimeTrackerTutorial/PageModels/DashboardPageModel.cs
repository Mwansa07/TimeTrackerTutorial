using System;
using TimeTrackerTutorial.PageModels.Base;

namespace TimeTrackerTutorial.PageModels
{
    public class DashboardPageModel : PageModelBase
    {
        private LoginPageModel _loginPM;
        public LoginPageModel LoginPageModel
        {
            get => _loginPM;
            set => SetProperty(ref _loginPM, value);
        }

        private ProfilePageModel _profilePM;
        public ProfilePageModel ProfilePageModel
        {
            get => _profilePM;
            set => SetProperty(ref _profilePM, value);
        }

        private SettingsPageModel _settingsPM;
        public SettingsPageModel SettingsPageModel
        {
            get => _settingsPM;
            set => SetProperty(ref _settingsPM, value);
        }

        private SummaryPageModel _summaryPM;
        public SummaryPageModel SummaryPageModel
        {
            get => _summaryPM;
            set => SetProperty(ref _summaryPM, value);
        }

        private TimeClockPageModel _timePM;
        public TimeClockPageModel TimeClockPageModel
        {
            get => _timePM;
            set => SetProperty(ref _timePM, value);
        }
    }
}
