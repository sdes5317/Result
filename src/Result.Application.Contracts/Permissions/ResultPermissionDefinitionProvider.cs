using Result.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Result.Permissions;

public class ResultPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ResultPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ResultPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ResultResource>(name);
    }
}
