namespace HealthTourist.Common.Constants.Main.Tag;

public abstract class TagConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "Tag";
    
    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";
    
    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;
    
    public const string NameIndex = "IX_Tag_Name";
    public const string TitleIndex = "IX_Tag_Title";
}