using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DomainEditor.Models;
using DomainEditor.Ports.Persistence;
using DomainEditor.UseCases.Abstractions;
using Microsoft.Extensions.Logging;

namespace DomainEditor.UseCases
{
    public class RetrieveDomainsUseCase : IRetrieveDomainsUseCase
    {
        private readonly IDomainRepository _domainRepository;
        private readonly ILogger _logger;

        public RetrieveDomainsUseCase(IDomainRepository domainRepository, ILogger<RetrieveDomainsUseCase> logger)
        {
            _domainRepository = domainRepository ?? throw new ArgumentNullException(nameof(domainRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<Domain>> RetrieveAllAsync(CancellationToken cancellationToken = default)
        {
            _logger.GetAllDomains();

            var domains = await _domainRepository.GetAsync(cancellationToken);

            return domains;
        }
    }
}