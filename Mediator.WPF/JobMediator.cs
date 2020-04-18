using Mediator.WPF.Models;
using System;

namespace Mediator.WPF
{
    public class JobMediator : IJobMediator
    {
        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChanged(object sender, Job job)
        {
            (JobChanged as EventHandler<JobChangedEventArgs>)?
                .Invoke(sender, new JobChangedEventArgs { Job = job });
        }
    }
}
