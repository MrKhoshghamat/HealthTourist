namespace HealthTourist.Common.Constants.Common.City;

public abstract class CityConfigurationConstants
{
    public const string SchemaName = "dbo";
    public const string TableName = "City";

    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";

    public const int NameMaxlength = 50;
    public const int TitleMaxlength = 50;
    public const int ExtensionMaxLength = 5;

    public const string NameIndex = "IX_City_Name";
    public const string TitleIndex = "IX_City_Name";
}