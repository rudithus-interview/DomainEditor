using System;
using System.Threading;
using System.Threading.Tasks;
using DomainEditor.Models;
using DomainEditor.Models.Primitives;
using DomainEditor.Ports.Persistence;
using DomainEditor.UseCases.Abstractions;
using Microsoft.Extensions.Logging;

namespace DomainEditor.UseCases
{
    public class CreateDomainUseCase : ICreateDomainUseCase
    {
        private readonly IDomainRepository _domainRepository;
        private readonly ILogger _logger;

        public CreateDomainUseCase(IDomainRepository domainRepository, ILogger<CreateDomainUseCase> logger)
        {
            _domainRepository = domainRepository ?? throw new ArgumentNullException(nameof(domainRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Domain> CreateAsync(CreateDomainCommand createDomainCommand, CancellationToken cancellationToken = default)
        {
            _logger.CreateNewDomain(createDomainCommand.DomainName);

            var domain = await _domainRepository.CreateAsync(createDomainCommand.DomainName, cancellationToken);

            return domain;
        }
    }
}
