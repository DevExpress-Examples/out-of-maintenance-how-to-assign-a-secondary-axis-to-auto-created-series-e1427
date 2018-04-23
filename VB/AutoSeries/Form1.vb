Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace AutoSeries
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'gspDataSet.GSP' table. You can move, or remove it, as needed.
			Me.gSPTableAdapter.Fill(Me.gspDataSet.GSP)
		End Sub

		Private Sub chartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chartControl1.BoundDataChanged
			For i As Integer = 0 To chartControl1.Series.Count - 1
				CType(chartControl1.Series(i).View, BarSeriesView).AxisY = (CType(chartControl1.Diagram, XYDiagram)).SecondaryAxesY(0)
			Next i
		End Sub

	End Class
End Namespace