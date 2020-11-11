Sub Main()
        Dim mystring As String
        mystring = sf("hellow gOOGLE")
        Console.WriteLine(" after sf " & mystring)
        Console.ReadKey()
    End Sub

    Function sf(ByVal thisString As String) As String
        Dim x As Char
        Dim NewString As String
        Dim flag As Boolean
        Dim n, m As Integer

        flag = True
        NewString = ""
        m = Len(thisString)

        For n = 1 To m
            If flag = True Then
                x = UCase(Mid(thisString, n, 1))
                flag = False
            Else
                x = LCase(Mid(thisString, n, 1))
            End If
            NewString = NewString & x
            If x = " " Then
                flag = True
            End If

        Next
        Return NewString

    End Function
End Module
