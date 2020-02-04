using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace DomainEditor.Tests.Unit
{
    internal class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute() : base(() => new Fixture().Customize(new AutoMoqCustomization() { ConfigureMembers = true }))
        {

        }
    }
}