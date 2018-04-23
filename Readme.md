# How to show only peak series labels


<p>This example illustrates how to customize chart series labels with large amount of data points. In this case, series labels might look messy. To avoid this problem, you can show labels only for peak points. To accomplish this task, you can handle the ChartControl.CustomDrawSeriesPoint event and conditionally change the CustomDrawSeriesPointEventArgs.LabelText parameter's value.</p>

<br/>


