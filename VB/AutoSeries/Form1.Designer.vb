Imports Microsoft.VisualBasic
Imports System
Namespace AutoSeries
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim secondaryAxisY1 As New DevExpress.XtraCharts.SecondaryAxisY()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.gSPTableAdapter = New AutoSeries.gspDataSetTableAdapters.GSPTableAdapter()
			Me.gSPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.gspDataSet = New AutoSeries.gspDataSet()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gSPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gspDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.DataAdapter = Me.gSPTableAdapter
			Me.chartControl1.DataSource = Me.gSPBindingSource
			xyDiagram1.AxisX.Label.Staggered = True
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.Visible = False
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			secondaryAxisY1.AxisID = 0
			secondaryAxisY1.Name = "secondaryAxisY1"
			secondaryAxisY1.Range.ScrollingRange.SideMarginsEnabled = True
			secondaryAxisY1.Range.SideMarginsEnabled = True
			secondaryAxisY1.VisibleInPanesSerializable = "-1"
			xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() { secondaryAxisY1})
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesDataMember = "Year"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Region"
			sideBySideBarSeriesLabel1.LineVisible = True
			sideBySideBarSeriesLabel1.Visible = False
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "GSP"
			Me.chartControl1.Size = New System.Drawing.Size(477, 275)
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chartControl1_BoundDataChanged);
			' 
			' gSPTableAdapter
			' 
			Me.gSPTableAdapter.ClearBeforeFill = True
			' 
			' gSPBindingSource
			' 
			Me.gSPBindingSource.DataMember = "GSP"
			Me.gSPBindingSource.DataSource = Me.gspDataSet
			' 
			' gspDataSet
			' 
			Me.gspDataSet.DataSetName = "gspDataSet"
			Me.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(477, 275)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(secondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gSPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gspDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
		Private gSPTableAdapter As AutoSeries.gspDataSetTableAdapters.GSPTableAdapter
		Private gspDataSet As gspDataSet
		Private gSPBindingSource As System.Windows.Forms.BindingSource
	End Class
End Namespace

