Imports System

Module Program
    Sub Main(args As String())
        Dim cpu As Cpu
        Dim dataCpu = cpu.GetProcessorData()
        Console.WriteLine(cpu.GetProcessorData())
    End Sub
End Module
