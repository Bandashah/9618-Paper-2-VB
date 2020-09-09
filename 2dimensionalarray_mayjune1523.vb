Module Module1

    Sub Main()
        Dim dailyhoursworked() = {5, 10, 10}

        Dim productiondata(,) = {{10, 20, 9},
                                {11, 16, 11},
                                {10, 24, 13},
                                {14, 20, 17}}
        Dim workertotal(2) As Integer
        Dim workeravg As Single

        For workernum = 0 To 2
            workertotal(workernum) = 0
        Next

        For workernum = 0 To 2
            For daynum = 0 To 3
                workertotal(workernum) = workertotal(workernum) + productiondata(daynum, workernum)
            Next


        Next

        For workernum = 0 To 2
            workeravg = workertotal(workernum) / (4 * dailyhoursworked(workernum))
            If workeravg < 2 Then
                Console.WriteLine("Investigate " & workernum)
            End If
        Next

        Console.ReadKey()
    End Sub

End Module
