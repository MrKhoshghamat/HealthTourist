namespace HealthTourist.Common.Constants.Main.AirLine;

public abstract class AirLineConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "AirLine";

    public const string VarcharColumnType = "VARCHAR";
    public const string NVarcharColumnType = "NVARCHAR";
    
    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;

    public const string NameIndex = "IX_AirLine_Name";
    public const string TitleIndex = "IX_AirLine_Title";
}