Imports ThisEqualsNull

Module Module1

    Sub Main()
        Dim checker As SelfNullChecker = New SelfNullChecker()
        'checker = Nothing
        Console.WriteLine(checker.ThisIsNull())
    End Sub

End Module
