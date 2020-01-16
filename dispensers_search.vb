Module Module1

    Sub Main()
        Dim dispensercode, bankcode, linestring As String
        Dim temp, y, x As String
        Dim count As Integer
        Console.Write("enter the bank code to see the list of its despensers : ")
        bankcode = Console.ReadLine()
        FileOpen(1, My.Application.Info.DirectoryPath & "\DISPENSERS.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, temp)
            x = Right(temp, 3)
            y = Left(temp, 5)
           
            If bankcode = x Then
                count = count + 1
                Console.WriteLine(y)
            End If
        End While
        Console.WriteLine("the number of dispensers " & count)
        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
