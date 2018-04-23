Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Windows.Media

Namespace WpfApplication
	Public Class RowStateConverter
		Inherits MarkupExtension
		Implements IValueConverter
		Public Sub New()

		End Sub


		Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Dim state As Boolean =CBool(value)
			If Object.Equals(parameter, "Background") Then
				Return New SolidColorBrush(If(state, Colors.White, Colors.LightGray))
			End If
			If Object.Equals(parameter, "Foreground") Then
				Return New SolidColorBrush(If(state, Colors.Black, Colors.DarkGray))
			End If
			If Object.Equals(parameter, "IsEnabled") Then
				Return state
			End If
			Return Nothing
		End Function

		Private Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return Nothing
		End Function
		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function

	End Class
End Namespace
