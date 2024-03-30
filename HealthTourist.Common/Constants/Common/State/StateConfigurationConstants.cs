namespace HealthTourist.Common.Constants.Common.State;

public class StateConfigurationConstants
{
    public const string SchemaName = "dbo";
    public const string TableName = "State";

    public const string VarcharColumnType = "varchar";
    public const string NVarcharColumnType = "nvarchar";

    public const int NameMaxLength = 100;
    public const int TitleMaxLength = 100;

    public const string NameIndex = "IX_State_Name";
    public const string TitleIndex = "IX_State_Title";
}