using Newtonsoft.Json;

namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Tests.Fakes
{
    public class FakeAliasRecursiveModel
    {
        [JsonRequired]
        public string @String { get; set; }

        public FakeAliasRecursiveSubModel FakeAliasRecursiveSubModel { get; set; }
    }

    public class FakeAliasRecursiveSubModel
    {
        [JsonRequired]
        public string @String { get; set; }

        public FakeAliasRecursiveModel FakeAliasRecursiveModel { get; set; }
    }
}
