Imports System.ComponentModel

Public Class TVShowViewModel
    Inherits BaseViewModel

    Public Property Models As New List(Of TVShowModel)

    Public Sub New()
        Dim show As New TVShowModel With {.Name = "Dexter", .LocalDirectoryPath = "m:\TV\Dexter\"}
        Dim season As New SeasonModel With {.Name = "Season 6", .TVShow = show}
        Dim episode As New EpisodeModel With {.Name = "Episode 1", .Season = season, .TVShow = show}

        season.Episodes.Add(episode)
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
