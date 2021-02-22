using System;
using System.Threading.Tasks;
using TimeTrackerTutorial.Models;

namespace TimeTrackerTutorial.Services.Work
{
    public class MockWorkService : IWorkService
    {
        public MockWorkService()
        {
        }

        public Task<bool> LogWorkAsync(WorkItem item)
        {
            throw new NotImplementedException();
        }
    }
}
