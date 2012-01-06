Imports System.ComponentModel

Public Class TVShowViewModel
    Inherits BaseViewModel

    Public Property Models As New List(Of TVShowModel)

    Public Sub New()
        Dim show As New TVShowModel With {.Name = "Dexter", .LocalDirectoryPath = "m:\TV\Dexter\"}
        Dim season As New SeasonModel With {.Name = "Season 6", .TVShow = show}
        Dim episode As New EpisodeModel With {.EpisodeNumber = 1, .Name = "Episode 1", .Season = season, .TVShow = show, .EpisodeStatus = EpisodeModel.EpisodeStatuses.Downloaded}
        Dim episode2 As New EpisodeModel With {.EpisodeNumber = 2, .Name = "Episode 2", .Season = season, .TVShow = show, .EpisodeStatus = EpisodeModel.EpisodeStatuses.PendingDownload}
        Dim episode3 As New EpisodeModel With {.EpisodeNumber = 3, .Name = "Episode 3", .Season = season, .TVShow = show, .EpisodeStatus = EpisodeModel.EpisodeStatuses.Downloading}

        season.Episodes.Add(episode)
        season.Episodes.Add(episode2)
        season.Episodes.Add(episode3)

        show.Seasons.Add(season)

        Models.Add(show)

    End Sub

    Private _selectedTVShow As ITVShowStructure
    Public Property SelectedTVShow As ITVShowStructure
        Get
            Return _selectedTVShow
        End Get
        Set(value As ITVShowStructure)
            _selectedTVShow = value
            Me.NotifyPropertyChanged("SelectedTVShow")
        End Set
    End Property


End Class
