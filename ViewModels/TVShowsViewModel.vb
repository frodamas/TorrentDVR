Imports System.ComponentModel

Public Class TVShowsViewModel
    Implements System.ComponentModel.INotifyPropertyChanged

    Public Property Models As New List(Of TVShowModel)

    Public Sub New()
        Dim show As New TVShowModel With {.Name = "Dexter", .LocalDirectoryPath = "m:\TV\Dexter\"}
        Dim season As New SeasonModel With {.Name = "Season 6", .ShowName = "Dexter"}
        Dim episode As New EpisodeModel With {.Name = "Episode 1", .SeasonName = "Season 6", .ShowName = "Dexter"}

        season.Episodes.Add(episode)
        show.Seasons.Add(season)

        Models.Add(show)
        'Me.SelectedTVShow = show

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

#Region "INotifyPropertyChanged Members"

    ''' <summary>
    ''' Raised when a property on this object has a new value.
    ''' </summary>
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    ''' <summary>
    ''' Raises this object's PropertyChanged event.
    ''' </summary>
    ''' <param name="propertyName">The property that has a new value.</param>
    Protected Overridable Sub NotifyPropertyChanged(ByVal propertyName As String)
     
        Dim handler As PropertyChangedEventHandler = Me.PropertyChangedEvent
        If handler IsNot Nothing Then
            Dim e = New PropertyChangedEventArgs(propertyName)
            handler(Me, e)
        End If
    End Sub

#End Region
End Class
