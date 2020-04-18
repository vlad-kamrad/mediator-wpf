using Mediator.WPF.Models;
using System;

namespace Mediator.WPF
{
    public class JobChangedEventArgs : EventArgs
    {
        public Job Job { get; set; }
    }
}
