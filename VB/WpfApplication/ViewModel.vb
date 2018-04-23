Imports System
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm.POCO

Namespace WpfApplication
    Public Class ViewModel
        Public Overridable Property Items() As ObservableCollection(Of GridItem)
        Public Overridable Property CurrentItem() As GridItem

        Public Sub New()
            Items = New ObservableCollection(Of GridItem)()
            For i As Integer = 0 To 14
                Items.Add(ViewModelSource.Create(Function() New GridItem() With {.AllowEdit = i Mod 3 <> 0, .Name = String.Format("Name{0}", i), .ID = i}))
            Next i
            CurrentItem = Items(0)
        End Sub
    End Class

    Public Class GridItem
        Public Overridable Property Name() As String
        Public Overridable Property ID() As Integer
        Public Overridable Property AllowEdit() As Boolean
    End Class
End Namespace
