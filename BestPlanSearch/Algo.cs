using System;
using System.Collections.Generic;

public struct ComparisonArgs
{
    public int DesiredBandwidth;
    public float BandwidthPriority;

    public int DesiredPhoneMinutes;
    public float PhoneMinutesPriority;

    public int DesiredSMSTexts;
    public float SMSTextsPriority;

    public int DesiredContractDuration;
    public float ContractDurationPriority;

    public float DesiredPrice;
    public float PricePriority;

    public bool DesiredIncludes5G;
    public float Priority5G;
}

public static class Algo
{
    public static Plan DetermineBestPlan(List<Plan> plans, ComparisonArgs comparisonArgs)
    {
        if(plans.Count == 0)
        {
            throw new Exception("Plan list is empty.");
        }

        Plan bestPlan = plans[0];
        for (int i = 1; i < plans.Count; i++)
        {
            bestPlan = DetermineBetterPlan(bestPlan, plans[i], comparisonArgs);
        }

        return bestPlan;
    }

    private static Plan DetermineBetterPlan(Plan plan1, Plan plan2, ComparisonArgs comparisonArgs)
    {
        Plan comparisonPlan = new Plan(
            "",
            "",
            comparisonArgs.DesiredBandwidth,
            comparisonArgs.DesiredPhoneMinutes,
            comparisonArgs.DesiredSMSTexts,
            comparisonArgs.DesiredContractDuration,
            comparisonArgs.DesiredPrice,
            comparisonArgs.DesiredIncludes5G
        );

        float plan1Dis = DetermineDistance(comparisonPlan, plan1, comparisonArgs);
        float plan2Dis = DetermineDistance(comparisonPlan, plan2, comparisonArgs);

        if ( plan1Dis < plan2Dis )
        {
            return plan1;
        } 
        else 
        {
            return plan2;
        }
    }

    private static float DetermineDistance(Plan plan1, Plan plan2, ComparisonArgs comparisonArgs)
    {
        float bandwidthDistance = (float)(Math.Pow(plan2.InternetBandwidthGB - plan1.InternetBandwidthGB, 2) * comparisonArgs.BandwidthPriority);
        float minutesDistance = (float)(Math.Pow(plan2.PhoneMinutes - plan1.PhoneMinutes, 2) * comparisonArgs.PhoneMinutesPriority);
        float textsDistance = (float)(Math.Pow(plan2.SMSTexts - plan1.SMSTexts, 2) * comparisonArgs.SMSTextsPriority);
        float durationDistance = (float)(Math.Pow(plan2.ContractDuration - plan1.ContractDuration, 2) * comparisonArgs.ContractDurationPriority);
        float priceDistance = (float)(Math.Pow(plan2.PricePerYear - plan1.PricePerYear, 2) * comparisonArgs.PricePriority);

        float fiveGDistance = 0;
        if (plan1.Includes5G == plan2.Includes5G)
        {
            fiveGDistance = bandwidthDistance * comparisonArgs.Priority5G;
        }

        return (float)Math.Sqrt(bandwidthDistance + minutesDistance + textsDistance + durationDistance + priceDistance + fiveGDistance); 
    }
}