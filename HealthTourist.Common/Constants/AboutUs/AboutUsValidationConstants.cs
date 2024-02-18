namespace HealthTourist.Common.Constants.AboutUs;

public abstract class AboutUsValidationConstants
{
    public const string NotNullMessage = "{PropertyName} is null";
    public const string NotEmptyMessage = "{PropertyName} is required";
    public const int TitleMaximumLength = 50;
    public const string TitleMaximumLengthMessage = "{PropertyName} must be fewer than or equal 50 characters";
    public const int DescriptionMaximumLength = 255;
    public const string DescriptionMaximumLengthMessage = "{PropertyName} must be fewer than or equal 255 characters";
    public const string AboutUsAlreadyIsDeletedMessage = "Already Deleted";
}