namespace HealthTourist.Common.Constants.Common.Country;

public abstract class CountryConfigurationConstants
{
    public const string SchemaName = "dbo";
    public const string TableName = "Country";

    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";

    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;
    public const int CodeMaxLength = 3;

    public const string NameIndex = "IX_Country_Name";
    public const string TitleIndex = "IX_Country_Title";
    public const string CodeIndex = "IX_Country_Code";
}