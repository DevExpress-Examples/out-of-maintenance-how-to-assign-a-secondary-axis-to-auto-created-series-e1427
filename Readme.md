<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1427)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/AutoSeries/Form1.cs) (VB: [Form1.vb](./VB/AutoSeries/Form1.vb))
* [Program.cs](./CS/AutoSeries/Program.cs) (VB: [Program.vb](./VB/AutoSeries/Program.vb))
<!-- default file list end -->
# How to assign a secondary axis to auto-created series


<p>This example demonstrates how auto-created series (series which are <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument5795.htm">automatically generated</a> based on their template) can be accessed at runtime, e.g. to assign a <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument5798.htm">secondary axis</a> to them.</p><p>For this, you should handle a specific <strong>BoundDataChanged</strong> event of the chart control, where you can obtain these series.</p>

<br/>


