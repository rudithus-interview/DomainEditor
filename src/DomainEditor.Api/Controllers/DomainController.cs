using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainEditor.Api.DTOs;
using DomainEditor.UseCases.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace DomainEditor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomainController : ControllerBase
    {
        private readonly ICreateDomainUseCase _createDomainUseCase;
        private readonly IRetrieveDomainsUseCase _retrieveDomainsUseCase;

        public DomainController(ICreateDomainUseCase createDomainUseCase, IRetrieveDomainsUseCase retrieveDomainsUseCase)
        {
            _createDomainUseCase = createDomainUseCase ?? throw new ArgumentNullException(nameof(createDomainUseCase));
            _retrieveDomainsUseCase = retrieveDomainsUseCase ?? throw new ArgumentNullException(nameof(retrieveDomainsUseCase));
        }

        // GET: api/Domain
        [HttpGet]
        public async Task<IEnumerable<DomainDto>> GetAsync()
        {
            var domains = await _retrieveDomainsUseCase.RetrieveAllAsync();

            return domains.Select(domain => new DomainDto
            {
                Id = domain.DomainId.ToString(),
                Name = domain.DomainName.ToString()
            });
        }
    }
}
