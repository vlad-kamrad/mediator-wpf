using Mediator.WPF.Models;
using System;

namespace Mediator.WPF
{
    public interface IJobMediator
    {
        void OnJobChanged(object sender, Job job);
        event EventHandler<JobChangedEventArgs> JobChanged;
    }
}
