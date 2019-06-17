Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace CustomLabelsWithaLargeAmountOfData
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)

		End Sub

		Private Sub chartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs) Handles chartControl1.CustomDrawSeriesPoint
			Dim index As Integer = e.Series.Points.IndexOf(e.SeriesPoint)
			If index = 0 Then
				If e.SeriesPoint.Values(0) <= e.Series.Points(index+1).Values(0) Then
					e.LabelText = ""
				End If
				Return
			End If
			If index = e.Series.Points.Count - 1 Then
				If e.SeriesPoint.Values(0) <= e.Series.Points(index - 1).Values(0) Then
					e.LabelText = ""
				End If
				Return
			End If
			If (e.SeriesPoint.Values(0) <= e.Series.Points(index - 1).Values(0)) OrElse (e.SeriesPoint.Values(0) <= e.Series.Points(index + 1).Values(0)) Then
				e.LabelText = ""
			End If

		End Sub
	End Class
End Namespace