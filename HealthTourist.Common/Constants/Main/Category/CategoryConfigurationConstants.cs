namespace HealthTourist.Common.Constants.Main.Category;

public abstract class CategoryConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "Category";
    
    public const string VarcharColumnType = "VARCHAR";
    public const string NVarcharColumnType = "NVARCHAR";
    
    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;

    public const string NameIndex = "IX_Category_Name";
    public const string TitleIndex = "IX_Category_Title";
}