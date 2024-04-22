using Aled.OpenFoodFactService.MongoDB;
using Aled.OpenFoodFactService.Samples;
using Xunit;

namespace Aled.OpenFoodFactService.MongoDb.Applications;

[Collection(OpenFoodFactServiceTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<OpenFoodFactServiceMongoDbTestModule>
{

}
