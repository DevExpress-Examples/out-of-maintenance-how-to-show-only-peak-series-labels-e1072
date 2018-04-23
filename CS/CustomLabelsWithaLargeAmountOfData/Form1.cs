using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomLabelsWithaLargeAmountOfData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

        }

        private void chartControl1_CustomDrawSeriesPoint(object sender, DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs e)
        {
            int index = e.Series.Points.IndexOf(e.SeriesPoint);
            if (index == 0)
            {
                if (e.SeriesPoint.Values[0] <= e.Series.Points[index+1].Values[0])
                    e.LabelText = "";
                return;
            }
            if (index == e.Series.Points.Count - 1)
            {
                if (e.SeriesPoint.Values[0] <= e.Series.Points[index - 1].Values[0])
                    e.LabelText = "";
                return;
            }
            if ((e.SeriesPoint.Values[0] <= e.Series.Points[index - 1].Values[0]) || (e.SeriesPoint.Values[0] <= e.Series.Points[index + 1].Values[0]))
                e.LabelText = "";
            
        }
    }
}