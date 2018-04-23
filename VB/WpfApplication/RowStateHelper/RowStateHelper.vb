Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports System.Windows.Data

Namespace WpfApplication
	Public NotInheritable Class RowStateHelper
		Public Shared ReadOnly IsHelperEnabledProperty As DependencyProperty = DependencyProperty.RegisterAttached("IsHelperEnabled", GetType(Boolean), GetType(RowStateHelper), New UIPropertyMetadata(False, New PropertyChangedCallback(AddressOf OnIsHelperEnabledChanged)))

		Private Sub New()
		End Sub
		Public Shared Function GetIsHelperEnabled(ByVal target As DependencyObject) As Boolean
			Return CBool(target.GetValue(IsHelperEnabledProperty))
		End Function
		Public Shared Sub SetIsHelperEnabled(ByVal target As DependencyObject, ByVal value As Boolean)
			target.SetValue(IsHelperEnabledProperty, value)
		End Sub
		Private Shared Sub OnIsHelperEnabledChanged(ByVal o As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			OnIsHelperEnabledChanged(o, CBool(e.OldValue), CBool(e.NewValue))
		End Sub
		Private Shared Sub OnIsHelperEnabledChanged(ByVal o As DependencyObject, ByVal oldValue As Boolean, ByVal newValue As Boolean)
			Dim view As GridViewBase = TryCast(o, GridViewBase)
			RemoveHandler view.ShowingEditor, AddressOf RowStateHelper_ShowingEditor
			If newValue Then
				AddHandler view.ShowingEditor, AddressOf RowStateHelper_ShowingEditor
			End If

		End Sub

		Private Shared Sub RowStateHelper_ShowingEditor(ByVal sender As Object, ByVal e As ShowingEditorEventArgs)
			e.Cancel = Not IsRowEnabled(e.Row)
		End Sub

		Public Shared Function IsRowEnabled(ByVal row As Object) As Boolean
			Dim datarow As GridItem = TryCast(row, GridItem)
			If datarow Is Nothing Then
				Return True
			End If
			Return datarow.AllowEdit
		End Function

	End Class
End Namespace