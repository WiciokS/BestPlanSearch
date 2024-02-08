using OfficeOpenXml;
using System.Collections.Generic;

public static class ExcelInteractor
{
    public static float MaxBand = 0;
    public static int MaxMin = 0;
    public static int MaxSms = 0;
    public static int MaxContract = 0;
    public static List<Plan> GetPlansFromExcel(ExcelWorksheet worksheet)
    {
        List<Plan> list = new List<Plan>();
        int rows = worksheet.Dimension.End.Row;
        for (int currRow = 2; currRow < rows+1; currRow++)
        {
            list.Add(GetPlanFromRow(currRow, worksheet));
        }
        return SetUnlimitedInPlans(list);
    }

    private static Plan GetPlanFromRow(int currRow, ExcelWorksheet worksheet)
    {
        var operatorName = worksheet.Cells[currRow, 1].Text;

        var planName = worksheet.Cells[currRow, 2].Text;

        var bandwidthGbEx = worksheet.Cells[currRow, 3].Text;
        float bandwidthGB = 999;
        if (!bandwidthGbEx.Contains("Unlimited"))
        {
            float num = float.Parse(bandwidthGbEx);
            bandwidthGB = num;
            if (bandwidthGB > MaxBand)
            {
                MaxBand = bandwidthGB;
            }
        }

        var phoneMinutesEx = worksheet.Cells[currRow, 4].Text;
        int phoneMinutes = 999;
        if (!phoneMinutesEx.Contains("Unlimited"))
        {
            int num = int.Parse(phoneMinutesEx);
            phoneMinutes = num;
            if (phoneMinutes > MaxMin)
            {
                MaxMin = phoneMinutes;
            }
        }

        var smsTextsEx = worksheet.Cells[currRow, 5].Text;
        int smsTexts = 999;
        if (!smsTextsEx.Contains("Unlimited"))
        {
            int num = int.Parse(smsTextsEx);
            smsTexts = num;
            if (smsTexts > MaxMin)
            {
                MaxMin = smsTexts;
            }
        }

        var contractDurationEx = worksheet.Cells[currRow, 6].Text;
        int contractDuration = 999;
        if (contractDurationEx.Contains("No contract"))
        {
            contractDuration = 0;
        }
        else if (!contractDurationEx.Contains("Rolling"))
        {
            contractDuration = int.Parse(contractDurationEx);
            if (contractDuration > MaxContract)
            {
                MaxContract = contractDuration;
            }
        }

        var pricePerYearEx = worksheet.Cells[currRow, 7].Text;
        float pricePerYear = float.Parse(pricePerYearEx);

        var includes5gEx = worksheet.Cells[currRow, 8].Text;
        bool include5g = false;
        if (includes5gEx.Contains("Yes"))
        {
            include5g = true;
        }

        Plan newPlan = new Plan(operatorName,
                                planName,
                                bandwidthGB,
                                phoneMinutes,
                                smsTexts,
                                contractDuration,
                                pricePerYear,
                                include5g);

        return newPlan;
    }

    private static List<Plan> SetUnlimitedInPlans(List<Plan> plans)
    {
        List<Plan> newPlans = new List<Plan>();
        for (int i = 0; i < plans.Count; i++)
        {
            float bw = plans[i].InternetBandwidthGB;
            int min = plans[i].PhoneMinutes;
            int sms = plans[i].SMSTexts;
            int contractDuration = plans[i].ContractDuration;

            if (plans[i].InternetBandwidthGB == 999)
            {
                bw = MaxBand + 1;
            }
            if (plans[i].PhoneMinutes == 999)
            {
                min = MaxMin + 1;
            }
            if (plans[i].SMSTexts == 999)
            {
                sms = MaxSms + 1;
            }
            if (plans[i].ContractDuration == 999)
            {
                contractDuration = MaxContract + 1;
            }


            Plan newPlan = new Plan(plans[i].OperatorName,
                                    plans[i].PlanName,
                                    bw,
                                    min,
                                    sms,
                                    contractDuration,
                                    plans[i].PricePerYear,
                                    plans[i].Includes5G
                                    );
            newPlans.Add( newPlan );
        }
        return newPlans;
    }
}