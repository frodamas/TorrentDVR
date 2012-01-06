Public Class SeasonModel
    Implements ITVShowStructure

    Public Property Name As String Implements ITVShowStructure.Name

    Public Property Episodes As New List(Of EpisodeModel)

    Public Property ShowName As String

End Class
