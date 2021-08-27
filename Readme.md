<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575636/18.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1072)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomLabelsWithaLargeAmountOfData/Form1.cs) (VB: [Form1.vb](./VB/CustomLabelsWithaLargeAmountOfData/Form1.vb))
* [Program.cs](./CS/CustomLabelsWithaLargeAmountOfData/Program.cs) (VB: [Program.vb](./VB/CustomLabelsWithaLargeAmountOfData/Program.vb))
<!-- default file list end -->
# How to show only peak series labels


<p>This example illustrates how to customize chart series labels with large amount of data points. In this case, series labels might look messy. To avoid this problem, you can show labels only for peak points. To accomplish this task, you can handle the ChartControl.CustomDrawSeriesPoint event and conditionally change the CustomDrawSeriesPointEventArgs.LabelText parameter's value.</p>

<br/>


