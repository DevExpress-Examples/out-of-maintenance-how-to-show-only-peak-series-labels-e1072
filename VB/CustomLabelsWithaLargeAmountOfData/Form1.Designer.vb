Imports Microsoft.VisualBasic
Imports System
Namespace CustomLabelsWithaLargeAmountOfData
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
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim areaSeriesView1 As New DevExpress.XtraCharts.AreaSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.productsTableAdapter = New CustomLabelsWithaLargeAmountOfData.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New CustomLabelsWithaLargeAmountOfData.nwindDataSet()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.DataAdapter = Me.productsTableAdapter
			Me.chartControl1.DataSource = Me.productsBindingSource
			xyDiagram1.AxisX.Label.Angle = 45
			xyDiagram1.AxisX.Label.Antialiasing = True
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = False
			xyDiagram1.AxisX.Range.SideMarginsEnabled = False
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series1.ArgumentDataMember = "ProductName"
			series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() { New DevExpress.XtraCharts.DataFilter("UnitPrice", "System.Decimal", DevExpress.XtraCharts.DataFilterCondition.GreaterThanOrEqual, New Decimal(New Integer() { 10, 0, 0, 0})), New DevExpress.XtraCharts.DataFilter("UnitPrice", "System.Decimal", DevExpress.XtraCharts.DataFilterCondition.LessThanOrEqual, New Decimal(New Integer() { 100, 0, 0, 0}))})
			pointSeriesLabel1.Angle = 90
			pointSeriesLabel1.LineVisible = True
			pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
			series1.Label = pointSeriesLabel1
			series1.Name = "Series 1"
			series1.ValueDataMembersSerializable = "UnitPrice"
			areaSeriesView1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))))
			areaSeriesView1.MarkerOptions.Visible = False
			series1.View = areaSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel1.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chartControl1.Size = New System.Drawing.Size(1140, 523)
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.CustomDrawSeriesPoint += New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(Me.chartControl1_CustomDrawSeriesPoint);
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1140, 523)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
		Private productsTableAdapter As CustomLabelsWithaLargeAmountOfData.nwindDataSetTableAdapters.ProductsTableAdapter
		Private nwindDataSet As nwindDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
	End Class
End Namespace

