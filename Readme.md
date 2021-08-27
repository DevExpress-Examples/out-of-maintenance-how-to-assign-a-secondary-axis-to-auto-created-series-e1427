<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572640/12.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1427)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to assign a secondary axis to auto-created series


This example demonstrates how auto-created series (series which are [automatically generated](https://docs.devexpress.com/WindowsForms/6562/controls-and-libraries/chart-control/provide-data/generate-series-from-a-data-source) based on their template) can be accessed at runtime, e.g. to assign a [secondary axis](https://docs.devexpress.com/WindowsForms/5798/controls-and-libraries/chart-control/axes/primary-and-secondary-axes) to them.

For this, you should handle a specific [BoundDataChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.BoundDataChanged?p=netframework) event of the chart control, where you can obtain these series.
