using Aled.OpenFoodFactService.Samples;
using Xunit;

namespace Aled.OpenFoodFactService.MongoDB.Domains;

[Collection(OpenFoodFactServiceTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<OpenFoodFactServiceMongoDbTestModule>
{

}
