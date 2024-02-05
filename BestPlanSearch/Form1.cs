using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestPlanSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppState.Initialize();
            LoadData();
        }
        // create method to load data from excel to grid
        private void LoadData()
        {
            // create a new ExcelPackage object and set it to the ExcelFile property of AppState
            AppState.ExcelFile = new ExcelPackage(new FileInfo("C:\\Users\\skude\\source\\repos\\BestPlanSearch\\BestPlanSearch\\Balticum_Network_Plans.xlsx"));
            // create a new ExcelWorksheet object and set it to the first worksheet in the ExcelFile
            ExcelWorksheet worksheet = AppState.ExcelFile.Workbook.Worksheets[0];
            // create a new List of Plan objects and set it to the result of calling GetPlansFromExcel with the worksheet
            List<Plan> plans = ExcelInteractor.GetPlansFromExcel(worksheet);
            // create a new BindingSource object and set its DataSource property to the plans list
            BindingSource source = new BindingSource();
            source.DataSource = plans;
            // set the DataSource property of the dataGridView1 to the BindingSource
            dataGridView1.DataSource = source;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void trackBar6_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void NUDGB_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }



        private void NUDDuration_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void NUDMin_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void NUDText_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void NUDPrice_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void CB5G_MouseClick(object sender, MouseEventArgs e)
        {
            updateData();
        }

        private void updateData()
        {
            int InternetBandwidthGB;
            int PhoneMinutes;
            int SMSTexts;
            int ContractDuration;
            float PricePerYear;
            bool Includes5G;

            //read data from NUDGB and set to InternetBandwidthGB
            InternetBandwidthGB = (int)NUDGB.Value;
            //read data from NUDMin and set to PhoneMinutes
            PhoneMinutes = (int)NUDMin.Value;
            //read data from NUDText and set to SMSTexts
            SMSTexts = (int)NUDText.Value;
            //read data from NUDDuration and set to ContractDuration
            ContractDuration = (int)NUDDuration.Value;
            //read data from NUDPrice and set to PricePerYear
            PricePerYear = (float)NUDPrice.Value;
            //read data from CB5G and set to Includes5G
            Includes5G = CB5G.Checked;

            //create 6 priorites foe each parameter and get data from trackBar1 trackBar2 and so on
            float BandwidthPriority = (float)trackBar1.Value / 100;
            float PhoneMinutesPriority = (float)trackBar2.Value / 100;
            float SMSTextsPriority = (float)trackBar3.Value / 100;
            float ContractDurationPriority = (float)trackBar4.Value / 100;
            float PricePriority = (float)trackBar5.Value / 100;
            float Priority5G = (float)trackBar6.Value / 100;

            //create a new ComparisonArgs object and set the values
            ComparisonArgs args = new ComparisonArgs();
            args.DesiredBandwidth = InternetBandwidthGB;
            args.BandwidthPriority = BandwidthPriority;
            args.DesiredPhoneMinutes = PhoneMinutes;
            args.PhoneMinutesPriority = PhoneMinutesPriority;
            args.DesiredSMSTexts = SMSTexts;
            args.SMSTextsPriority = SMSTextsPriority;
            args.DesiredContractDuration = ContractDuration;
            args.ContractDurationPriority = ContractDurationPriority;
            args.DesiredPrice = PricePerYear;
            args.PricePriority = PricePriority;
            args.DesiredIncludes5G = Includes5G;
            args.Priority5G = Priority5G;

            var fileInfo = new FileInfo("C:\\Users\\skude\\source\\repos\\BestPlanSearch\\BestPlanSearch\\Balticum_Network_Plans.xlsx");
            var package = new ExcelPackage(fileInfo);

            // using static ExcelInteractor class to read data from the excel file
            List<Plan> plans = ExcelInteractor.GetPlansFromExcel(package.Workbook.Worksheets[0]);

            // using static Algo class to determine the best plan
            Plan bestPlan = Algo.DetermineBestPlan(plans, args);

            //Write best plan all data to the LbResult, like name, data, new line
            LbResult.Text =
                "Operator Name: " +
                bestPlan.OperatorName + "\n " +
                "Plan Name: " +
                bestPlan.PlanName + "\n " +
                "Internet (GB):" +
                bestPlan.InternetBandwidthGB + "\n " +
                "Phone Minutes:" +
                bestPlan.PhoneMinutes + "\n " +
                "SMS Texts:" +
                bestPlan.SMSTexts + "\n " +
                "Contract Duration:" +
                bestPlan.ContractDuration + "\n " +
                "Price Per Year:" +
                bestPlan.PricePerYear + "\n " +
                "5G: " +
                bestPlan.Includes5G;
        }
    }
}
