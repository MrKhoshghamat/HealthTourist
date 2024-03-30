namespace HealthTourist.Common.Constants.Main.TreatmentType;

public abstract class TreatmentTypeConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "TreatmentType";
    
    public const string VarcharColumnType = "VARCHAR";
    public const string NVarcharColumnType = "NVARCHAR";

    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;
    
    public const string NameIndex = "IX_TreatmentType_Name";
    public const string TitleIndex = "IX_TreatmentType_Title";
}