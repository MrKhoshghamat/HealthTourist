namespace HealthTourist.Common.Constants.Main.Office;

public abstract class OfficeConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "Office";

    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";

    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;
    public const int AddressMaxLength = 500;
    public const int PostalCodeMaxLength = 10;
    public const int PhoneNumber1MaxLength = 13;
    public const int PhoneNumber2MaxLength = 13;
    public const int PhoneNumber3MaxLength = 13;
    public const int EmailMaxLength = 100;
    public const int OwnerCommissionMaxLength = 20;
    public const int PresentedCommissionMaxLength = 20;

    public const string NameIndex = "IX_Office_Name";
    public const string TitleIndex = "IX_Office_Title";
    public const string PhoneNumber1Index = "IX_Office_PhoneNumber1";
    public const string PhoneNumber2Index = "IX_Office_PhoneNumber2";
    public const string PhoneNumber3Index = "IX_Office_PhoneNumber3";
    public const string AddressIndex = "IX_Office_Address";
}