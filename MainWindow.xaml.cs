using System.Windows;

namespace CMCS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenLecturer(object sender, RoutedEventArgs e)
        {
            var win = new Views.LecturerView();
            win.Owner = this;
            win.Show();
        }

        private void OpenCoordinator(object sender, RoutedEventArgs e)
        {
            var win = new Views.CoordinatorView();
            win.Owner = this;
            win.Show();
        }

        private void OpenManager(object sender, RoutedEventArgs e)
        {
            var win = new Views.ManagerView();
            win.Owner = this;
            win.Show();
        }
    }
}
