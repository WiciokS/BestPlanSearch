using OfficeOpenXml;

public static class AppState
{
    public static ExcelPackage ExcelFile;

    public static void Initialize()
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
    }
}