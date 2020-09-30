Public Class Perfomance
    Public Shared Function GetCounterValue(pc As PerformanceCounter, categoryName As String, counterName As String, instanceName As String)
        'Implements thread http://www.macoratti.net/vbn_thd1.htm
        Dim percentProcess As Int16
        pc.CategoryName = categoryName
        pc.CounterName = counterName
        pc.InstanceName = instanceName
        percentProcess = pc.NextValue()
        Return percentProcess
    End Function

End Class
