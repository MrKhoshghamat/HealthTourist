namespace HealthTourist.Common.Constants.Main.Faq;

public abstract class FaqConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "Faq";
    
    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";
    
    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;
    public const int DescriptionMaxLength = 2000;

    public const string NameIndex = "IX_Faq_Name";
    public const string TitleIndex = "IX_Faq_Title";
}