using System;
using System.Windows.Input;

namespace WpfLibrary1
{
    public static class CustomCommands
    {
        public static readonly RoutedCommand DifferentAssemblyCommand = new RoutedCommand("DifferentAssemblyCommand", typeof(CustomCommands));
    }
}
