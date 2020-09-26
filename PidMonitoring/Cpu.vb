Public Class Cpu
    Function GetProcessorData()
        Dim cpuCounter As PerformanceCounter
        Dim perfomance As Perfomance
        Dim d = perfomance.GetCounterValue(cpuCounter, "Processador", "Processador Time", "Total")
        Dim result = d + "%" + d.ToString("F") + "%"
    End Function


End Class
