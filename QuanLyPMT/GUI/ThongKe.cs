using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using LiveCharts;
using LiveCharts.Wpf;

namespace GUI
{
    public partial class ThongKe : UserControl
    {
        DonThuoc_BUS donthuoc_BUS = new DonThuoc_BUS();
        benhAn_BUS benhan_BUS = new benhAn_BUS();
        List<string> examDateList = new List<string>();
        List<double> examValues = new List<double>();
        List<string> drugDateList = new List<string>();
        List<double> drugValues = new List<double>();
        List<string> PatienceDateList = new List<string>();
        List<double> PatienceValues = new List<double>();
        public ThongKe()
        {
            InitializeComponent();
            getDrugAmountInDay();
            getExamAmountInDay();
            getAmountPatience();
            getLabelOfX();
            getValue();
            getLableOFX_Patience();
            getValue_Patience();
        }
        
        private void getAmountPatience()
        {
            patienceRevenueDGV.DataSource = benhan_BUS.getAmountPatience().Tables[0];
        }
        private void getLableOFX_Patience()
        {
            for (int i = 0; i < patienceRevenueDGV.Rows.Count; i++)
            {
               PatienceDateList.Add(patienceRevenueDGV.Rows[i].Cells["NGAYTHONGKE2"].Value.ToString());
            }
        }
        private void getValue_Patience()
        {
            for (int i = 0; i < patienceRevenueDGV.Rows.Count; i++)
            {
                PatienceValues.Add(double.Parse(patienceRevenueDGV.Rows[i].Cells["SOBENHNHAN"].Value.ToString()));
            }
        }
        
        private void getDrugAmountInDay()
        {
            RevenueDGV.DataSource = donthuoc_BUS.getAmountInDay().Tables[0];
        }
        private void getExamAmountInDay()
        {
            examRevenueDGV.DataSource = benhan_BUS.getExamAmountInDay().Tables[0];
        }
        private void initialChart()
        {
            //Exam
            examRevenue_Chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Thời gian",
                Labels = examDateList
            });
            examRevenue_Chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Doanh Thu",
                LabelFormatter = value => value.ToString("c")
            });
            examRevenue_Chart.LegendLocation = LiveCharts.LegendLocation.Right;
            //Drug
            drugRevenue_Chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Thời gian",
                Labels = drugDateList
            });
            drugRevenue_Chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Doanh Thu",
                LabelFormatter = value => value.ToString("c")
            });
            drugRevenue_Chart.LegendLocation = LiveCharts.LegendLocation.Right;
            //Patience
            PatienceRevenue_Chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Thời gian",
                Labels = examDateList
            });
            PatienceRevenue_Chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Số bệnh nhân",
                LabelFormatter = value => value.ToString("c")
            });
            PatienceRevenue_Chart.LegendLocation = LiveCharts.LegendLocation.Right;

        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            initialChart();
            loadDataToChart();
        }

        private void loadDataToChart()
        {
            //Exam
            examRevenue_Chart.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            series.Add(new LineSeries() {Title="Khám bệnh", Values = new ChartValues<double>(examValues) });
            examRevenue_Chart.Series = series;
            //Drug
            drugRevenue_Chart.Series.Clear();
            SeriesCollection series1 = new SeriesCollection();
            series1.Add(new LineSeries() { Title = "Bán thuốc ", Values = new ChartValues<double>(drugValues) });
            drugRevenue_Chart.Series = series1;
            //Patince
            PatienceRevenue_Chart.Series.Clear();
            SeriesCollection series2 = new SeriesCollection();
            series2.Add(new LineSeries() { Title = "Số bệnh nhân", Values = new ChartValues<double>(PatienceValues) });
            PatienceRevenue_Chart.Series = series2;

        }
        private void getLabelOfX()
        {
            for(int i =0; i<examRevenueDGV.Rows.Count;i++)
            {
                examDateList.Add(examRevenueDGV.Rows[i].Cells["NGATHONGKE1"].Value.ToString());
            }
            for (int i = 0; i < RevenueDGV.Rows.Count; i++)
            {
                drugDateList.Add(RevenueDGV.Rows[i].Cells["NGAYTHONGKE"].Value.ToString());
            }

        }
        private void getValue()
        {
            for(int i = 0; i < examRevenueDGV.Rows.Count; i++)
            {
                examValues.Add(double.Parse(examRevenueDGV.Rows[i].Cells["GIATRI1"].Value.ToString()));
            }
            for(int i =0;i< RevenueDGV.Rows.Count; i++)
            {
                drugValues.Add(double.Parse(RevenueDGV.Rows[i].Cells["GIATRI"].Value.ToString()));
            }
        }

        private void examRevenueDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            examRevenueDGV.Rows[e.RowIndex].Cells["STT1"].Value = (e.RowIndex + 1).ToString();

        }

        private void RevenueDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            RevenueDGV.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void patienceRevenueDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            patienceRevenueDGV.Rows[e.RowIndex].Cells["STT2"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
