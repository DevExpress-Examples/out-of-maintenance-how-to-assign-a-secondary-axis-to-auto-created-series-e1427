Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace AutoSeries
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
            Me.GSPTableAdapter.Fill(Me.GspDataSet.GSP)
        End Sub

        Private Sub OnBoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles chartControl1.BoundDataChanged
            For i As Integer = 0 To chartControl1.Series.Count - 1
                CType(chartControl1.Series(i).View, BarSeriesView).AxisY = _
                    (CType(chartControl1.Diagram, XYDiagram)).SecondaryAxesY(0)
            Next i
        End Sub
    End Class

End Namespace
