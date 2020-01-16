Module Module1

    Sub Main()
        Dim dispensercode, bankcode, linestring As String

        FileOpen(1, My.Application.Info.DirectoryPath & "\DISPENSERS.txt", OpenMode.Output)

        Do
            Console.WriteLine("Enter dispenser code (XXXXX to end)")
            dispensercode = Console.ReadLine
            If DispenserCode <> "XXXXX" Then

                Console.WriteLine("Enter bank code …")
                bankcode = Console.ReadLine
                linestring = dispensercode & " " & bankcode
                'now write the new line to the file
                WriteLine(1, linestring)
            End If
        Loop Until dispensercode = "XXXXX"
        FileClose(1)
        Console.WriteLine("DISPENSERS file now created")
        FileClose(1)
    End Sub

End Module
