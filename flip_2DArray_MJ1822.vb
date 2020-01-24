Module Module1
    Dim picture(,) As Integer = {{80, 80, 255, 80, 80, 255, 80, 80},
                                 {80, 80, 255, 80, 80, 255, 80, 80},
                                 {255, 80, 120, 120, 120, 120, 255, 80},
                                 {255, 80, 255, 255, 255, 255, 80, 80},
                                 {255, 80, 120, 120, 120, 120, 80, 80}}
    Sub Main()

        For row = 0 To 4
            Console.WriteLine()
            For col = 0 To 7
                Console.Write("   " & picture(row, col))
            Next
        Next
        Flip()
        Console.WriteLine()
        For row = 0 To 4
            Console.WriteLine()
            For col = 0 To 7
                Console.Write("   " & picture(row, col))
            Next
        Next
        Console.ReadKey()
    End Sub

    Sub Flip()
        'Use of Single temp value
        Dim temp As Integer
        Dim i As Integer 'i is the row
        Dim j As Integer 'j is the column
        For i = 2 To 4
            For j = 0 To 3 'swap element 1&8, 2&7, 3&6, 4&5
                temp = picture(i, j)
                picture(i, j) = picture(i, 7 - j)
                picture(i, 7 - j) = temp
            Next
        Next
    End Sub
End Module
