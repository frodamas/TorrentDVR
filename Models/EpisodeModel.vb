Public Class EpisodeModel
    Implements IMediaFile
    Implements ITVShowStructure

    Public Property EpisodeNumber As Integer

    Public Property HasBeenDownloaded As Boolean Implements IMediaFile.HasBeenDownloaded

    Public Property IsLocal As Boolean Implements IMediaFile.IsLocal

    Public Property IsRemote As Boolean Implements IMediaFile.IsRemote

    Public Property Name As String Implements IMediaFile.Name, ITVShowStructure.Name

    Public Property SeasonName As String

    Public Property ShowName As String



End Class

Public Interface ITVShowStructure
    Property Name As String

End Interface
