Module SolutionModule

    Public Function ReadSln(loc As String)

        Dim file = loc

        Dim rawOptions() As String = loc.Split(",")

        Dim options() As String

        For Each rawOption In rawOptions

            Dim splitOption() As String = rawOption.Split("=")

            options.Add(splitOption(1))

        Next

        Return options

    End Function

    Public Function LoadSln(slnOptions() As String)

        ' TODO Make Project Loader

    End Function

End Module
