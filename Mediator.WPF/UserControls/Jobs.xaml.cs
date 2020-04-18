using Mediator.WPF.Models;
using System.Windows.Controls;

namespace Mediator.WPF.UserControls
{
    /// <summary>
    /// Interaction logic for Jobs.xaml
    /// </summary>
    public partial class Jobs : UserControl
    {
        private readonly IJobMediator mediator;
        public Jobs(IJobMediator mediator)
        {
            this.mediator = mediator;
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            JobsComboBox.ItemsSource = SeedData.Jobs;
        }

        private void JobsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mediator.OnJobChanged(this, (Job)JobsComboBox.SelectedItem);
        }
    }
}
