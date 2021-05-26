<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to assign a secondary axis to auto-created series


This example demonstrates how auto-created series (series which are [automatically generated](https://docs.devexpress.com/WindowsForms/6562/controls-and-libraries/chart-control/provide-data/generate-series-from-a-data-source) based on their template) can be accessed at runtime, e.g. to assign a [secondary axis](https://docs.devexpress.com/WindowsForms/5798/controls-and-libraries/chart-control/axes/primary-and-secondary-axes) to them.

For this, you should handle a specific [BoundDataChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.BoundDataChanged?p=netframework) event of the chart control, where you can obtain these series.
