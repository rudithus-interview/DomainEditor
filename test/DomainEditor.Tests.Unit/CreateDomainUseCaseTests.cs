using System.Threading;
using AutoFixture;
using AutoFixture.Idioms;
using AutoFixture.Xunit2;
using DomainEditor.Models;
using DomainEditor.Ports.Persistence;
using DomainEditor.UseCases;
using DomainEditor.UseCases.Abstractions;
using FluentAssertions;
using Moq;
using Xunit;

namespace DomainEditor.Tests.Unit
{
    public class CreateDomainUseCaseTests
    {
        [Theory, AutoMoqData]
        public void ConstructorShouldBeGuarded(IFixture fixture)
        {
            var assertion = new GuardClauseAssertion(fixture);
            assertion.Verify(typeof(CreateDomainUseCase).GetConstructors());
        }

        [Theory, AutoMoqData]
        public async void GivenCommand_WhenCreatingADomain_ShouldBeAddedToRepository(
            [Frozen] Mock<IDomainRepository> domainRepository,
            CreateDomainCommand command,
            CreateDomainUseCase sut)
        {
            await sut.CreateAsync(command);

            domainRepository
                .Verify(repo => repo.CreateAsync(command.DomainName, It.IsAny<CancellationToken>()), Times.Once);
        }

        [Theory, AutoMoqData]
        public async void GivenCommand_WhenCreatingADomain_UseCaseShouldReturnCreatedDomain(
            [Frozen] Mock<IDomainRepository> domainRepository,
            Domain domain,
            CreateDomainCommand command,
            CreateDomainUseCase sut)
        {
            domainRepository.Setup(repo => repo.CreateAsync(command.DomainName, It.IsAny<CancellationToken>())).ReturnsAsync(domain);

            var result = await sut.CreateAsync(command);

            result.Should().Be(domain);
        }
    }
}
