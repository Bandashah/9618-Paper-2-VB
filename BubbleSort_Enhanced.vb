'Bubble Sort Visual Basic Code

Module Module1

    Sub main()
        Dim height(5) As Integer
        Dim swapped As Boolean
        Dim temp As Integer
        Dim maxsize As Integer
        maxsize = 5

        For count = 1 To 5
            Console.Write(" Enter Height of a student in cenitmeters : ")
            height(count) = Console.ReadLine()
        Next
        'sort the elements
        Do
            swapped = False
            For count = 1 To maxsize - 1

                If height(count + 1) < height(count) Then
                    temp = height(count)
                    height(count) = height(count + 1)
                    height(count + 1) = temp
                    swapped = True
                End If
            Next
            maxsize = maxsize - 1
        Loop Until swapped = False

        'Print out the elements
        For count = 1 To 5
            Console.WriteLine(count & ": " & height(count))
        Next
        Console.ReadKey()
    End Sub

End Module
