﻿Imports System
Imports System.Windows.Data
Imports System.Windows.Markup

Namespace WpfApplication
	Friend Class RowDragHotTrackConverter
		Inherits MarkupExtension
		Implements IMultiValueConverter

		Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert

			Return DirectCast(values(0), Integer) = DirectCast(values(1), Integer)
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function

		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function
	End Class
End Namespace
