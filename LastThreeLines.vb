Module Module1

    Sub Main()
        LastLines()
        Console.ReadKey()
    End Sub
    Sub LastLines()
        Dim ThisLine, LineX, LineY, LineZ As String
        ThisLine = ""
        LineX = ""
        LineY = ""
        LineZ = ""
        Dim Count, Count2 As Integer
        Count = 0
        FileOpen(1, My.Application.Info.DirectoryPath & "\ThisFile.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, ThisLine) ' read a line
            Count = Count + 1
        End While
        FileClose(1)
        FileOpen(1, My.Application.Info.DirectoryPath & "\ThisFile.txt", OpenMode.Input)
        For Count2 = 1 To Count - 3
            Input(1, ThisLine) ' read a line
        Next
        Input(1, LineX)
        Input(1, LineY)
        Input(1, LineZ)
        Console.WriteLine(LineX)
        Console.WriteLine(LineY)
        Console.WriteLine(LineZ)
        FileClose(1)
    End Sub
End Module
