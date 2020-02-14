Module Module1

    Sub Main()
        Dim cdtitle As String
        Dim artist As String
        Dim loc As String
        Dim myline As String
        FileOpen(1, "mymusic.txt", OpenMode.Output)
        Do
            Console.Write(" input a CD title. A rogue value of '##' is to be used to end the input : ")
            cdtitle = Console.ReadLine()
            If cdtitle <> "##" Then
                Console.Write("Enter artist name : ")
                artist = Console.ReadLine()
                Console.WriteLine("Enter location : ")
                loc = Console.ReadLine()
                myline = cdtitle & " " & artist & " " & loc
                WriteLine(1, myline)
            End If
            
        Loop Until cdtitle = "##"
        FileClose(1)
        Console.WriteLine(" File is created ")
        Console.ReadKey()
    End Sub

End Module
