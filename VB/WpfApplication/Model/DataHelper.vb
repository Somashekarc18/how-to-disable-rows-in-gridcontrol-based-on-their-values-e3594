Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace WpfApplication
	Public Class DataHelper
		Public Shared Function GetDataSource(ByVal count As Integer) As Object
		 Dim collection As New ObservableCollection(Of GridItem)()
			For i As Integer = 0 To count - 1
				collection.Add(New GridItem(i Mod 3 <> 0, DateTime.Now.AddMinutes(count * i).AddDays((i - count \ 2) * count), String.Format("Name{0}", i), i))
			Next i
			Return collection
		End Function

	End Class

	Public Class GridItem
		Implements INotifyPropertyChanged
		''' <summary>
		''' Initializes a new instance of the GridItem class.
		''' </summary>
		''' <param name="allowEdit"></param>
		''' <param name="date"></param>
		''' <param name="name"></param>
		''' <param name="iD"></param>
		Public Sub New(ByVal allowEdit As Boolean, ByVal [date] As DateTime, ByVal name As String, ByVal iD As Integer)
			_AllowEdit = allowEdit
			_Date = [date]
			_Name = name
			_ID = iD
		End Sub

		' Fields...
		Private _AllowEdit As Boolean
		Private _Date As DateTime
		Private _Name As String


		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				_Name = value
				OnPropertyChanged(New PropertyChangedEventArgs("Name"))
			End Set
		End Property

		' Fields...
		Private _ID As Integer


		Public Property ID() As Integer
			Get
				Return _ID
			End Get
			Set(ByVal value As Integer)
				_ID = value
				OnPropertyChanged(New PropertyChangedEventArgs("ID"))
			End Set
		End Property


		Public Property [Date]() As DateTime
			Get
				Return _Date
			End Get
			Set(ByVal value As DateTime)
				_Date = value
				OnPropertyChanged(New PropertyChangedEventArgs("Date"))
			End Set
		End Property


		Public Property AllowEdit() As Boolean
			Get
				Return _AllowEdit
			End Get
			Set(ByVal value As Boolean)
				_AllowEdit = value
				OnPropertyChanged(New PropertyChangedEventArgs("AllowEdit"))
			End Set
		End Property


		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		#Region "OnPropertyChanged"
		''' <summary>
		''' Triggers the PropertyChanged event.
		''' </summary>
		Public Overridable Sub OnPropertyChanged(ByVal ea As PropertyChangedEventArgs)
			RaiseEvent PropertyChanged(Me, ea)
		End Sub
		#End Region
	End Class
End Namespace