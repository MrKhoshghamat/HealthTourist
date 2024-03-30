namespace HealthTourist.Common.Constants.Common.Attachment;

public abstract class AttachmentConfigurationConstants
{
    public const string SchemaName = "dbo";
    public const string TableName = "Attachment";

    public const string VarcharColumnType = "VARCHAR";

    public const int NameMaxlength = 200;
    public const int ExtensionMaxLength = 5;

    public const string NameIndex = "IX_Attachment_Name";
}