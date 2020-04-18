using Mediator.WPF.Models;
using System.Linq;
using System.Windows.Controls;

namespace Mediator.WPF.UserControls
{
    /// <summary>
    /// Interaction logic for UsersOnJob.xaml
    /// </summary>
    public partial class UsersOnJob : UserControl
    {
        public UsersOnJob(IJobMediator mediator)
        {
            InitializeComponent();
            Subscribe(mediator);
        }

        private void Subscribe(IJobMediator mediator)
        {
            mediator.JobChanged += (sender, eventArg) => { BindData(eventArg.Job); };
        }

        private void BindData(Job job)
        {
            DataContext = job;
            UsersListView.ItemsSource = SeedData.Users.Where(x => x.Jobs.Any(j => j.Id == job.Id));
        }
    }
}
