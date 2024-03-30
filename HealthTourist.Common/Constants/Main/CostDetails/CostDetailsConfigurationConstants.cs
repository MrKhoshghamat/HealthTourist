namespace HealthTourist.Common.Constants.Main.CostDetails;

public abstract class CostDetailsConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "CostDetails";
    
    public const string VarcharColumnType = "VARCHAR";
    public const string NVarcharColumnType = "NVARCHAR";
    
    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;

    public const string NameIndex = "IX_CostDetails_Name";
    public const string TitleIndex = "IX_CostDetails_Title";
}