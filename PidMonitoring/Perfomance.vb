Public Class Perfomance
    Function GetCounterValue(pc As PerformanceCounter, categoryName As String, counterName As String, instanceName As String)
        pc.CategoryName = categoryName
        pc.CounterName = counterName
        pc.InstanceName = instanceName
        Return pc.NextValue()
    End Function

End Class
