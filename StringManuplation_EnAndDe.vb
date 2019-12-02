Module Module1

    Sub Main()
        Dim key() = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "@", "7", "$", "%", "2", "!", "#", "&", "*", "(", ")", "+", "-", ":", ">", "<", "{", "}", "1", "3", "4", "5", "9", "8", "6", "/"}
        Dim pt As String
        Dim estring, dstring, dchar As String
        Dim choice As Integer
        Dim character As Char
        estring = ""
        dstring = ""
        pt = ""
        While choice <> 3
            Console.Write("press 1 to encrypt, 2 decrypt and 3 to exit :")
            choice = Console.ReadLine()
            Select Case choice
                Case 1 : Console.Write("Enter the plain text to encrypt :")
                    pt = Console.ReadLine()
                    estring = EncryptString(key, pt)
                    Console.Write("the encrypted text :" & estring)
                Case 2 : For n = 1 To Len(estring)
                        character = Mid(estring, n, 1)
                        dchar = decrypt(key, character)
                        dstring = dstring & dchar
                    Next
                    Console.WriteLine("the decrypted string : " & dstring)

                Case 3
            End Select
            Console.WriteLine()
        End While


        Console.ReadKey()
    End Sub
    Function EncryptString(ByVal LookUp As Array, ByVal PlainText As String) As String

        Dim OldChar, NewChar As Char
        Dim OldCharValue As Integer
        Dim OutString As String

        'first initialise the return string

        OutString = "" 'initialise the return string
        'loop through PlainText to produce OutString
        For n = 1 To Len(PlainText) 'from first to last character
            OldChar = Mid(PlainText, n, 1) 'get next character
            OldCharValue = Asc(OldChar) 'find the ASCII value
            NewChar = LookUp(OldCharValue) 'look up substitute character
            OutString = OutString & NewChar ' concatenate to OutString
        Next
        Return OutString 'EncryptString © OutString
    End Function

    Function decrypt(ByVal lookup As Array, ByVal chipherchar As Char) As Char
        Dim found As Boolean
        Dim index As Integer
        Dim originalchar As Char
        index = 1
        found = False
        While found = False
            If lookup(index) = chipherchar Then
                found = True
            Else
                index = index + 1
            End If
        End While
        originalchar = Chr(index)
        Return originalchar
    End Function
End Module
