using OfficeOpenXml;
using System.Collections.Generic;

public static class ExcelInteractor
{
    public static List<Plan> GetPlansFromExcel(ExcelWorksheet worksheet)
    {
        List<Plan> list = new List<Plan>();
        int rows = worksheet.Dimension.End.Row;
        for (int currRow = 2; currRow < rows+1; currRow++)
        {
            var operatorName = worksheet.Cells[currRow, 1].Text;

            var planName = worksheet.Cells[currRow, 2].Text;

            var bandwidthGbEx = worksheet.Cells[currRow, 3].Text;
            float bandwidthGB = 999;
            if (!bandwidthGbEx.Contains("Unlimited"))
            {
                float num = float.Parse(bandwidthGbEx);
                if (num == 0)
                {
                    bandwidthGB = -999;
                } else
                {
                    bandwidthGB = num;
                }
            }

            var phoneMinutesEx = worksheet.Cells[currRow, 4].Text;
            int phoneMinutes = 999;
            if (!phoneMinutesEx.Contains("Unlimited"))
            {
                int num = int.Parse(phoneMinutesEx);
                if (num == 0)
                {
                    phoneMinutes = -999;
                } else
                {
                    phoneMinutes = num;
                }
            }

            var smsTextsEx = worksheet.Cells[currRow, 5].Text;
            int smsTexts = 999;
            if (!smsTextsEx.Contains("Unlimited"))
            {
                int num = int.Parse(smsTextsEx);
                if (num == 0)
                {
                    smsTexts = -999;
                } else
                {
                    smsTexts = num;
                }
            }

            var contractDurationEx = worksheet.Cells[currRow, 6].Text;
            int contractDuration = 999;
            if (contractDurationEx.Contains("No contract"))
            {
                contractDuration = -999;
            } else if (!contractDurationEx.Contains("Rolling"))
            {
                contractDuration = int.Parse(contractDurationEx);
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

            list.Add(newPlan);
        }
        return list;
    }
}