namespace HealthTourist.Common.Constants.Main.FaqType;

public abstract class FaqTypeConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "FaqType";
    
    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";
    
    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;
    public const int DescriptionMaxLength = 500;

    public const string NameIndex = "IX_FaqType_Name";
    public const string TitleIndex = "IX_FaqType_Title";
}