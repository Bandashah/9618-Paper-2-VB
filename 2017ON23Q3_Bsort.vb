Module Module1

    Sub main()
        Dim UserNameArray() = {"567843Kamran", "765345Ali", "234543shameer", "1123432InduaraMethamal", "345654Shahroshano", "665432MrSadiqHussain"}
        Dim swapped As Boolean
        Dim temp As Integer
        Dim maxsize As Integer
        Dim x1, x2 As String
        maxsize = 5

        swapped = True
        While swapped <> False
            swapped = False

            For count = 0 To maxsize - 1

                x1 = Left(UserNameArray(count), 6)
                x2 = Left(UserNameArray(count + 1), 6)

                If x2 < x1 Then
                    temp = UserNameArray(count)
                    UserNameArray(count) = UserNameArray(count + 1)
                    UserNameArray(count + 1) = temp
                    swapped = True
                End If

            Next
            maxsize = maxsize - 1
        End While

        For count = 0 To 5
            Console.WriteLine(count & ": " & UserNameArray(count))
        Next
        Console.ReadKey()
    End Sub

End Module
