Public Class Cpu
    Public Shared Function GetProcessorData()
        Dim perfomanceValue As Perfomance
        Dim d As Int16

        d = perfomanceValue.GetCounterValue(New PerformanceCounter, "Processor", "% Processor Time", "_Total")
        Dim result = d + "%" + d.ToString("F") + "%"
        Return result
    End Function


End Class
