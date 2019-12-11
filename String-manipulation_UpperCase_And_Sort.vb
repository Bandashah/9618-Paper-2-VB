Module Module1

    ' upper case with sorting alphabetically

    Sub Main()
        Dim StudentName(10) As String
        StudentName = {"salman", "kamran", "bashir", "zohaib", "mohsin", "ali", "####", "####", "####", "####"}
        Dim C As Integer
        Dim Temp, lelement, relement As Char
        Dim NameLenght, i, lchar, rchar As Integer
        Dim UnusedCount As Integer
        Dim stemp As String
        Const dumval = "####"
        Dim swapped As Boolean
        i = 9
        UnusedCount = 0
        For C = 0 To 9
            If StudentName(C) = dumval Then
                UnusedCount = UnusedCount + 1
            Else
                NameLenght = Len(StudentName(C))
                Temp = Left(StudentName(C), 1)
                Temp = UCase(Temp)
                StudentName(C) = Temp & Right(StudentName(C), NameLenght - 1)
            End If
        Next
        Do
            swapped = False
            For C = 0 To i - 1
                lelement = Left(StudentName(C), 1)
                relement = Left(StudentName(C + 1), 1)
                lchar = Asc(lelement)
                rchar = Asc(relement)

                If lchar > rchar Then
                    stemp = StudentName(C)
                    StudentName(C) = StudentName(C + 1)
                    StudentName(C + 1) = stemp
                    swapped = True
                End If
            Next
        Loop Until swapped = False

        For C = 0 To 9
            Console.WriteLine(" The studentname " & StudentName(C))
        Next
        Console.WriteLine("There are = " & UnusedCount)

        Console.ReadKey()

    End Sub

End Module
