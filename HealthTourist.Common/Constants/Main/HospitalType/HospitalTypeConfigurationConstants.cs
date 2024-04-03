namespace HealthTourist.Common.Constants.Main.HospitalType;

public abstract class HospitalTypeConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "HospitalType";
    
    public const string VarcharColumnType = "VARCHAR";
    public const string NVarcharColumnType = "NVARCHAR";
    
    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;

    public const string NameIndex = "IX_HospitalType_Name";
    public const string TitleIndex = "IX_HospitalType_Title";
}