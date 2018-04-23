using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace AutoSeries {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'gspDataSet.GSP' table. You can move, or remove it, as needed.
            this.gSPTableAdapter.Fill(this.gspDataSet.GSP);
        }

        private void chartControl1_BoundDataChanged(object sender, EventArgs e) {
            for (int i = 0; i < chartControl1.Series.Count; i++) {
                ((BarSeriesView)chartControl1.Series[i].View).AxisY = ((XYDiagram)chartControl1.Diagram).SecondaryAxesY[0];
            }
        }

    }
}