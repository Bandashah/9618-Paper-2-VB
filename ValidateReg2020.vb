Module Module1

    Sub Main()
        Console.WriteLine(ValidateRegistration("ACV45VDTF"))

        Console.ReadKey()

    End Sub

    Function ValidateRegistration(ByVal Registration As String) As Boolean
        Dim validate As Boolean
        Dim nextchar As Char
        validate = True
        If Len(Registration) <> 6 And Len(Registration) <> 9 Then
            validate = False
        End If
        For count = 1 To 3
            nextchar = Mid(Registration, count, 1)
            If nextchar <> UCase(nextchar) Then validate = False
        Next
        For count = 4 To 5
            nextchar = Mid(Registration, count, 1)
            If nextchar < "0" Or nextchar > "9" Then validate = False
        Next
        For count = 6 To 9
            nextchar = Mid(Registration, count, 1)
            If nextchar <> UCase(nextchar) Then validate = False
        Next

        Return validate
    End Function
End Module
