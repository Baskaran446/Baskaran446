using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoListApp
{
    /// <summary>
    /// Interaction logic for AddOrEditPage.xaml
    /// </summary>
    public partial class AddOrEditPage : Window
    {
        SubViewModel viewModel;
        public AddOrEditPage()
        {
            InitializeComponent();
            this.DataContextChanged += (o, e) =>
            {
                viewModel = (SubViewModel)(o as AddOrEditPage).DataContext;
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                viewModel.ButtonCommand.Execute("Back");
            }), System.Windows.Threading.DispatcherPriority.Background);           
            this.Close();
        }
    }
}
