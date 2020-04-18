using Mediator.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Mediator.WPF.UserControls
{
    public class BaseUserControl : UserControl
    {
        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChanged(object sender, Job job)
        {
            (JobChanged as EventHandler<JobChangedEventArgs>)?
                .Invoke(sender, new JobChangedEventArgs { Job = job });
        }
    }
}
