namespace HealthTourist.Common.Constants.Account;

public abstract class PersonConfigurationConstants
{
    public const string SchemaName = "Account";
    public const string TableName = "Person";

    public const string VarcharColumnType = "VARCHAR";
    public const string NVarcharColumnType = "NVARCHAR";

    public const int FirstNameMaxLength = 50;
    public const int LastNameMaxLength = 50;
    public const int PhoneNumberMaxLength = 13;
    public const int EmailMaxLength = 50;
    public const int AddressMaxLength = 500;

    public const string FirstNameIndex = "IX_Person_FirstName";
    public const string LastNameIndex = "IX_Person_LastName";
    public const string PhoneNumberIndex = "IX_Person_PhoneNumber";
    public const string EmailIndex = "IX_Person_Email";
    public const string AddressIndex = "IX_Person_Address";
}