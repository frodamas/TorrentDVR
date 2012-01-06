Class MainWindow
    Private _vm As TVShowViewModel
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _vm = New TVShowViewModel
        Me.DataContext = _vm
    End Sub

    Private Sub TreeView_SelectedItemChanged(sender As System.Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Object))
        If TypeOf (e.NewValue) Is EpisodeModel Then
            _vm.SelectedTVShow = DirectCast(e.NewValue, EpisodeModel).Season
        ElseIf TypeOf (e.NewValue) Is TVShowModel Then
            Dim tvShow = DirectCast(e.NewValue, TVShowModel)
            If tvShow.Seasons.Count > 0 Then
                _vm.SelectedTVShow = tvShow.Seasons(tvShow.Seasons.Count - 1)
            Else
                _vm.SelectedTVShow = tvShow
            End If
        Else
            _vm.SelectedTVShow = e.NewValue
        End If



    End Sub
End Class
