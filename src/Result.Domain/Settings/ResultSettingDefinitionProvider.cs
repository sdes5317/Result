using Volo.Abp.Settings;

namespace Result.Settings;

public class ResultSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ResultSettings.MySetting1));
    }
}
