namespace HealthTourist.Common.Constants.Main.Category;

public abstract class CategoryConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "Category";
    
    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";
    
    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;

    public const string NameIndex = "IX_Category_Name";
}