Module Module1

    Sub Main()
        Dim str1 As String
        Dim count As Integer
        Dim NC, letter As Char
        Console.Write("Enter String : ")
        str1 = Console.ReadLine()
        Console.Write("Enter letter : ")
        letter = Console.ReadLine()
        For n = 1 To Len(str1)
            NC = Mid(str1, n, 1)
            If NC = letter Then
                count = count + 1
            End If
        Next
        Console.WriteLine("the ans : " & count)
        Console.ReadKey()
    End Sub

End Module
