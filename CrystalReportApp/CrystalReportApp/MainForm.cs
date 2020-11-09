using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystalReportApp
{
    public partial class MainForm : Form
    {
        private string noneSelected = "You forgot to select a client. Pick a client first by clicking the dropdown box at the top.";
        private string selectedItem, reportCode;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            report_clients.Items.Add("ISL");
            report_clients.Items.Add("AGD");
        }

        private void CallCrystalReport(object reportSource)
        {
            CrystalReportViewerForm reportForm = new CrystalReportViewerForm();
            reportForm.Show();

            reportForm.crystalReportViewer1.ReportSource = null;
            reportForm.crystalReportViewer1.ReportSource = reportSource;
            reportForm.crystalReportViewer1.Refresh();
        }
        
        private void GenerateReport(string selectedItem, string reportType)
        {
            switch (selectedItem)
            {
                case "ISL":
                    if (reportType == "JV")
                    {                       
                        JournalVoucherSport journalVoucher = new JournalVoucherSport();
                        CallCrystalReport(journalVoucher);
                    }
                    else
                    {
                        CheckVoucherSport checkVoucher = new CheckVoucherSport();
                        CallCrystalReport(checkVoucher);
                    }
                    break;

                case "AGD":
                    if (reportType == "JV")
                    {
                        JournalVoucherAthlete journalVoucher = new JournalVoucherAthlete();
                        CallCrystalReport(journalVoucher);
                    }
                    else
                    {
                        CheckVoucherAthlete checkVoucher = new CheckVoucherAthlete();
                        CallCrystalReport(checkVoucher);
                    }
                    break;

                default:
                    MessageBox.Show(this.noneSelected);
                    break;
            }
        }

        private void button_cv_Click(object sender, EventArgs e)
        {
            selectedItem = report_clients.GetItemText(report_clients.SelectedItem);
            reportCode = "CV";

            GenerateReport(selectedItem, reportCode);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button_jv_Click(object sender, EventArgs e)
        {
            selectedItem = report_clients.GetItemText(report_clients.SelectedItem); ;
            reportCode = "JV";

            GenerateReport(selectedItem, reportCode);
        }
    }
}
