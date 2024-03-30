namespace HealthTourist.Common.Constants.Main.Treatment;

public abstract class TreatmentConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "Treatment";
    
    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";

    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;
    
    public const string NameIndex = "IX_Treatment_Name";
    public const string TitleIndex = "IX_Treatment_Title";
}