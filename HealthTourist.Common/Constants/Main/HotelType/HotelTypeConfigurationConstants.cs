namespace HealthTourist.Common.Constants.Main.HotelType;

public abstract class HotelTypeConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "HotelType";

    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";
    
    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;
    
    public const string NameIndex = "IX_HotelType_Name";
    public const string TitleIndex = "IX_HotelType_Title";
}