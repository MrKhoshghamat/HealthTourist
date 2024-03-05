namespace HealthTourist.Common.Constants.Departments;

public class PatientValidationConstants
{
    public const string NotNullMessage = "{PropertyName} is null";
    public const string NotEmptyMessage = "{PropertyName} is required";
    public const int HeightMaximumLength = 3;
    public const string HeightMaximumLengthMessage = "{PropertyName} must be fewer than or equal 3 characters";
    public const int WeightMaximumLength = 3;
    public const string WeightMaximumLengthMessage = "{PropertyName} must be fewer than or equal 3 characters";
    public const string PatientAlreadyIsDeletedMessage = "Already Deleted";
}