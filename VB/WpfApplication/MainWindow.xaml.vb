Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace WpfApplication
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub tableView1_ShowingEditor(ByVal sender As Object, ByVal e As ShowingEditorEventArgs)
            e.Cancel = Not(TryCast(gridControl1.CurrentItem, GridItem)).AllowEdit
        End Sub
    End Class
End Namespace