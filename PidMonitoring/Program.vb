Imports System

Module Program
    Sub Main(args As String())
        Dim cpuCounter As New PerformanceCounter
        cpuCounter.CategoryName = "Processor"
        cpuCounter.CounterName = "% Processor Time"
        cpuCounter.InstanceName = "_Total"
        Console.WriteLine(cpuCounter.NextValue.ToString + "%")
    End Sub
End Module
