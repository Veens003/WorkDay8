Module Module1

    Sub Main()
        Dim i As Integer
        Dim j As Integer

        For i = 65 To 70
            Console.WriteLine("Appendix " & Chr(i))
            For j = 1 To 5
                Console.WriteLine("Section " & CStr(j))
            Next
        Next

    End Sub

End Module
