Class MainWindow
    Private _vm As TVShowsViewModel
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _vm = New TVShowsViewModel
        Me.DataContext = _vm
    End Sub

    Private Sub TreeView_SelectedItemChanged(sender As System.Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Object))
        _vm.SelectedTVShow = e.NewValue


    End Sub
End Class
