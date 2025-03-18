using Xunit;

namespace Result.EntityFrameworkCore;

[CollectionDefinition(ResultTestConsts.CollectionDefinitionName)]
public class ResultEntityFrameworkCoreCollection : ICollectionFixture<ResultEntityFrameworkCoreFixture>
{

}
