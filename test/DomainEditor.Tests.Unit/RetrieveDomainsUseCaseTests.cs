using System.Threading;
using AutoFixture;
using AutoFixture.Idioms;
using AutoFixture.Xunit2;
using DomainEditor.Models;
using DomainEditor.Ports.Persistence;
using DomainEditor.UseCases;
using FluentAssertions;
using Moq;
using Xunit;

namespace DomainEditor.Tests.Unit
{
    public class RetrieveDomainsUseCaseTests
    {
        [Theory, AutoMoqData]
        public void ConstructorShouldBeGuarded(IFixture fixture)
        {
            var assertion = new GuardClauseAssertion(fixture);
            assertion.Verify(typeof(RetrieveDomainsUseCase).GetConstructors());
        }

        [Theory, AutoMoqData]
        public async void GivenRepositoryContainsDomains_WhenRetrieving_DomainsAreReturned(
            [Frozen] Mock<IDomainRepository> mockRepository,
            Domain[] domains,
            RetrieveDomainsUseCase retrieveDomainsUseCase)
        {
            mockRepository.Setup(repo => repo.GetAsync(It.IsAny<CancellationToken>())).ReturnsAsync(domains);

            var result = await retrieveDomainsUseCase.RetrieveAllAsync(It.IsAny<CancellationToken>());

            result.Should().BeEquivalentTo(domains);
        }
    }
}
