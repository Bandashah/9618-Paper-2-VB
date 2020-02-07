Module Module1

Sub main()
        Dim height() = {45, 67, 23, 45, 21, 78, 90, 11, 21}
        Dim swapped As Boolean
        Dim temp As Integer
        Dim maxsize As Integer
        maxsize = 8
        Dim counter As Integer
        swapped = True
        While swapped <> False ' Do
            swapped = False
            'For x = 0 To 8
            For count = 0 To 7 'maxsize - 1

                If height(count + 1) < height(count) Then
                    temp = height(count)
                    height(count) = height(count + 1)
                    height(count + 1) = temp
                    swapped = True
                End If
                counter = counter + 1
            Next
            ' maxsize = maxsize - 1
        End While 'Loop Until swapped = False
        ' Next
        'Print out the elements
        For count = 0 To 8
            Console.WriteLine(count & ": " & height(count))
        Next
        Console.WriteLine("the algo analysis : " & counter)
        Console.ReadKey()
    End Sub

End Module
