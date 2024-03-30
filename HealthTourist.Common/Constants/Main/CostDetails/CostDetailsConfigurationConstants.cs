namespace HealthTourist.Common.Constants.Main.CostDetails;

public abstract class CostDetailsConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "CostDetails";
    
    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";
    
    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;

    public const string NameIndex = "IX_CostDetails_Name";
}