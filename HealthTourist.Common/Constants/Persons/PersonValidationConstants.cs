namespace HealthTourist.Common.Constants.Persons;

public class PersonValidationConstants
{
    public const string NotNullMessage = "{PropertyName} is null";
    public const string NotEmptyMessage = "{PropertyName} is required";
    
    public const int NationalCodeMaxLength = 12;
    public const string NationalCodeMaxLengthMessage = "{PropertyName} must be fewer than or equal 12 characters";
    public const int FirstNameMaxLength = 50;
    public const string FirstNameMaxLengthMessage = "{PropertyName} must be fewer than or equal 50 characters";
    public const int LastNameMaxLength = 50;
    public const string LastNameMaxLengthMessage = "{PropertyName} must be fewer than or equal 50 characters";
    public const int PhoneNumberMaxLength = 13;
    public const string PhoneNumberMaxLengthMessage = "{PropertyName} must be fewer than or equal 13 characters";
    public const int EmailMaxLength = 50;
    public const string EmailMaxLengthMessage = "{PropertyName} must be fewer than or equal 50 characters";
    public const string PersonAlreadyIsDeletedMessage = "Already Deleted";
}