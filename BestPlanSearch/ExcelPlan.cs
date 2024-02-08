using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPlanSearch
{
    internal class ExcelPlan
    {
        public string OperatorName { get; }
        public string PlanName { get; }
        public string InternetBandwidthGB { get; }
        public string PhoneMinutes { get; }
        public string SMSTexts { get; }
        public string ContractDuration { get; }
        public float PricePerYear { get; }
        public bool Includes5G { get; }

        public ExcelPlan(string opName,
                    string plName,
                    float bandwidth,
                    int minutes,
                    int texts,
                    int duration,
                    float price,
                    bool fiveG)
        {
            OperatorName = opName;
            PlanName = plName;
            InternetBandwidthGB = bandwidth.ToString();
            PhoneMinutes = minutes.ToString();
            SMSTexts = texts.ToString();
            ContractDuration = duration.ToString();
            PricePerYear = price;
            Includes5G = fiveG;
        }

        public ExcelPlan(Plan plan)
        {
            OperatorName = plan.OperatorName;
            PlanName = plan.PlanName;

            if (plan.InternetBandwidthGB > ExcelInteractor.MaxBand)
            {
                InternetBandwidthGB = "Unlimited";
            } 
            else
            {
                InternetBandwidthGB = plan.InternetBandwidthGB.ToString();
            }

            if (plan.PhoneMinutes > ExcelInteractor.MaxMin)
            {
                PhoneMinutes = "Unlimited";
            } 
            else
            {
                PhoneMinutes = plan.PhoneMinutes.ToString();
            }

            if (plan.SMSTexts > ExcelInteractor.MaxSms)
            {
                SMSTexts = "Unlimited";
            } 
            else
            {
                SMSTexts = plan.SMSTexts.ToString();
            }

            if (plan.ContractDuration > ExcelInteractor.MaxContract)
            {
                ContractDuration = "Rolling";
            } 
            else
            {
                ContractDuration = plan.ContractDuration.ToString();
            }

            PricePerYear = plan.PricePerYear;
            Includes5G = plan.Includes5G;
        }
    }
}
