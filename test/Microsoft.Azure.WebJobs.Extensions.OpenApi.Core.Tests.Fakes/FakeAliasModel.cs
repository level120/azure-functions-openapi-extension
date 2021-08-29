namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Tests.Fakes
{
    public class FakeAliasModel
    {
        public FakeAliasSubModel FakeAliasSubModel { get; set; }
        public FakeSubModel FakeSubModel { get; set; }
    }

    public class FakeAliasSubModel
    {
        public FakeSubModel FakeSubModel { get; set; }
    }
}
