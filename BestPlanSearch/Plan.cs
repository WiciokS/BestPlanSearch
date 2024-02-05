public class Plan
{
    public string OperatorName { get; }
    public string PlanName { get; }
    public float InternetBandwidthGB { get; }
    public int PhoneMinutes { get; }
    public int SMSTexts { get; }
    public int ContractDuration { get; }
    public float PricePerYear { get; }
    public bool Includes5G { get; }

    public Plan(string opName,
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
        InternetBandwidthGB = bandwidth;
        PhoneMinutes = minutes;
        SMSTexts = texts;
        ContractDuration = duration;
        PricePerYear = price;
        Includes5G = fiveG;
    }
}