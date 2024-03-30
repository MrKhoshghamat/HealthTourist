namespace HealthTourist.Common.Constants.Common.City;

public abstract class CityConfigurationConstants
{
    public const string SchemaName = "dbo";
    public const string TableName = "City";

    public const string VarcharColumnType = "VARCHAR";
    public const string NVarcharColumnType = "NVARCHAR";

    public const int NameMaxlength = 50;
    public const int TitleMaxlength = 50;
    public const int ExtensionMaxLength = 5;

    public const string NameIndex = "IX_City_Name";
    public const string TitleIndex = "IX_City_Name";
}