Imports System.ComponentModel

Public Class BaseViewModel
    Implements System.ComponentModel.INotifyPropertyChanged

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
