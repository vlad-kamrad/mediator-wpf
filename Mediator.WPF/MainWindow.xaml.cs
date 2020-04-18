using Mediator.WPF.UserControls;
using System.Windows;
using System.Windows.Controls;

namespace Mediator.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadControls(new JobMediator());
        }

        private void LoadControls(IJobMediator mediator)
        {
            var jobs = new Jobs(mediator);
            jobs.SetValue(Grid.RowProperty, 1);
            LayoutRoot.Children.Add(jobs);

            var usersOnJob = new UsersOnJob(mediator);
            var jobDetails = new JobDatails(mediator);
            jobDetails.Margin = new Thickness(25, 0, 0, 0);
            jobDetails.SetValue(Grid.ColumnProperty, 1);

            ContainerGrid.Children.Add(usersOnJob);
            ContainerGrid.Children.Add(jobDetails);
        }
    }
}
