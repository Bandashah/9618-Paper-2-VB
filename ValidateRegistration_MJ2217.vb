Module Module1

    Sub Main()
        Dim reg As String
        Console.Write("Enter vehicle registration number for check : ")
        reg = Console.ReadLine()
        Console.WriteLine(" the vehicle Plate is : " & validateregistration(reg))
        Console.ReadKey()
    End Sub
    Function validateregistration(ByVal registration As String) As Boolean
        Dim Check As Char
        Dim Flag = True
        Dim X As Integer

        If Len(registration) < 6 Or Len(registration) > 9 Then
            Console.WriteLine("invalid id")
            Flag = False
        End If
        For X = 1 To 3
            Check = Mid(registration, X, 1)
            If Check <> UCase(Check) Then
                Console.WriteLine("invalid id")
                Flag = False
            End If
        Next
        For X = 4 To 5
            Check = Mid(registration, X, 1)
            If Check < "0" Or Check > "9" Then
                Console.WriteLine("invalid id")
                Flag = False
            End If
        Next
        For X = 6 To Len(registration)
            Check = Mid(registration, X, 1)
            If Check <> UCase(Check) Then
                Console.WriteLine("invalid id")
                Flag = False
            End If
        Next

        Return Flag
    End Function
End Module
