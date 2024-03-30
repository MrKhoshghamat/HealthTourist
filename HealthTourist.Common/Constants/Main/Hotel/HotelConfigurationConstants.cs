namespace HealthTourist.Common.Constants.Main.Hotel;

public abstract class HotelConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "Hotel";
    
    public const string VarcharColumnType = "VARCHAR";
    public const string NVarcharColumnType = "NVARCHAR";

    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;
    public const int AddressMaxLength = 500;
    public const int PostalCodeMaxLength = 10;
    public const int PhoneNumber1MaxLength = 13;
    public const int PhoneNumber2MaxLength = 13;
    public const int PhoneNumber3MaxLength = 13;
    public const int WebsiteMaxLength = 100;
    public const int EmailMaxLength = 100;
    public const int DescriptionMaxLength = 500;

    public const string NameIndex = "IX_Hotel_Name";
    public const string TitleIndex = "IX_Hotel_Title";
    public const string AddressIndex = "IX_Hotel_Address";
    public const string PostalCodeIndex = "IX_Hotel_PostalCode";
    public const string PhoneNumber1Index = "IX_Hotel_PhoneNumber1";
    public const string PhoneNumber2Index = "IX_Hotel_PhoneNumber2";
    public const string PhoneNumber3Index = "IX_Hotel_PhoneNumber3";
    public const string WebsiteIndex = "IX_Hotel_Website";
    public const string EmailIndex = "IX_Hotel_Email";
}