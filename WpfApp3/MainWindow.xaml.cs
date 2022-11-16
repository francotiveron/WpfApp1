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

namespace WpfApp3
{
    public static class CustomCommands
    {
        public static readonly RoutedCommand SameAssemblyCommand = new RoutedCommand("SameAssemblyCommand", typeof(CustomCommands));
    }
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            var cmdBindings = new CommandBinding(CustomCommands.SameAssemblyCommand);
            cmdBindings.Executed += SameAssemblyCommandExecuted;
            //cmdBindings.CanExecute += OpenChartCanExecute1;
            CommandBindings.Add(cmdBindings);
            
            cmdBindings = new CommandBinding(WpfLibrary1.CustomCommands.DifferentAssemblyCommand);
            cmdBindings.Executed += DifferentAssemblyCommandExecuted;
            //cmdBindings.CanExecute += OpenChartCanExecute1;
            CommandBindings.Add(cmdBindings);

            cmdBindings = new CommandBinding(FsLibrary1.CustomCommands.FsAssemblyCommand);
            cmdBindings.Executed += FsAssemblyCommandExecuted;
            //cmdBindings.CanExecute += OpenChartCanExecute1;
            CommandBindings.Add(cmdBindings);
        }

        private void FsAssemblyCommandExecuted(object sender, ExecutedRoutedEventArgs e) { }
        private void SameAssemblyCommandExecuted(object sender, ExecutedRoutedEventArgs e) { }
        private void DifferentAssemblyCommandExecuted(object sender, ExecutedRoutedEventArgs e) { }
    }
}
