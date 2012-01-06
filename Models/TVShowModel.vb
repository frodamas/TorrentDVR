Public Class TVShowModel
    Implements ITVShowStructure

    Public Property Name As String Implements ITVShowStructure.Name

    Public Property Seasons As New List(Of SeasonModel)

    Public Property LocalDirectoryPath As String
End Class
