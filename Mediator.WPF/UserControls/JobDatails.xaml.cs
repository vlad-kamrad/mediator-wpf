using System.Windows.Controls;

namespace Mediator.WPF.UserControls
{
    /// <summary>
    /// Interaction logic for JobDatails.xaml
    /// </summary>
    public partial class JobDatails : UserControl
    {
        public JobDatails(IJobMediator mediator)
        {
            InitializeComponent();
            Subscribe(mediator);
        }

        private void Subscribe(IJobMediator mediator)
        {
            mediator.JobChanged += (sender, eventArg) => { DataContext = eventArg.Job; };
        }
    }
}
