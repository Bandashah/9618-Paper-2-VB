Module Module1

    Sub Main()
        ExCamel("MyUserInput")
    End Sub
    Function ExCamel(ByVal instring As String) As String
        Dim NextChar As Char
        Dim outstring As String
        Dim n As Integer
        outstring = ""  ' initialise the return string
        ' loop through InString to produce OutString

        For n = 1 To Len(instring) ' from first to last
            NextChar = Mid(instring, n, 1) ' get next character
            If NextChar <> UCase(NextChar) Then ' check if upper case

                If n > 1 Then ' if not first character

                    outstring = outstring & " " ' add space to OutString
                End If
                NextChar = LCase(NextChar) ' make NextChar lower case
            End If
            outstring = outstring & NextChar 'add NextChar to OutString
        Next
        Return outstring ' return value
    End Function
End Module
