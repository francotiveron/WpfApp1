namespace FsLibrary1

open System.Windows.Input

type CustomCommands =
    static member FsAssemblyCommand = RoutedCommand("OpenChartCommand", typeof<CustomCommands>)

