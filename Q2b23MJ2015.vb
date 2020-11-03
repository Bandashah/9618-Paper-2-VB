Module Module1

    Sub Main()
        Dim amount As Integer
        Dim Fiftydollar, twentydollar, tendollar, temp As Single

        Console.Write("Enter amount : ")
        amount = Console.ReadLine()
        If amount > 500 Then
            Console.WriteLine(" Refused - amount too large ")
        ElseIf amount Mod 10 <> 0 Then
            Console.WriteLine(" Refused - not a multiple of 10 $ ")
        Else
            Fiftydollar = Int(amount / 50)
            temp = amount Mod 50
            twentydollar = Int(temp / 20)
            temp = temp Mod 20
            tendollar = Int(temp / 10)
        End If
        Console.WriteLine(" 50 Dollar notes :" & Fiftydollar & ", 20 Dollar notes : " & twentydollar & ", 10 Dollar notes :  " & tendollar)

        Console.ReadKey()

    End Sub

End Module
