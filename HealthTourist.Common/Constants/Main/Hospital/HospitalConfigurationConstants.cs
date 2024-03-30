namespace HealthTourist.Common.Constants.Main.Hospital;

public abstract class HospitalConfigurationConstants
{
    public const string SchemaName = "Main";
    public const string TableName = "Hospital";

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
    public const int DescriptionMaxLength = 500;

    public const string NameIndex = "IX_Hospital_Name";
    public const string PhoneNumber1Index = "IX_Hospital_PhoneNumber1";
    public const string PhoneNumber2Index = "IX_Hospital_PhoneNumber2";
    public const string PhoneNumber3Index = "IX_Hospital_PhoneNumber3";
    public const string AddressIndex = "IX_Hospital_Address";

}