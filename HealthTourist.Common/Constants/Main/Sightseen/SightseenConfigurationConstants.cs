namespace HealthTourist.Common.Constants.Main.Sightseen;

public abstract class SightseenConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "Sightseen";
    
    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";
    
    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;
    
    public const string NameIndex = "IX_Sightseen_Name";
    public const string TitleIndex = "IX_Sightseen_Title";
}