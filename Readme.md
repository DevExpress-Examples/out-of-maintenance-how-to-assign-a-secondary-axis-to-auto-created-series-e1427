<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to assign a secondary axis to auto-created series


<p>This example demonstrates how auto-created series (series which are <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument5795.htm">automatically generated</a> based on their template) can be accessed at runtime, e.g. to assign a <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument5798.htm">secondary axis</a> to them.</p><p>For this, you should handle a specific <strong>BoundDataChanged</strong> event of the chart control, where you can obtain these series.</p>

<br/>


