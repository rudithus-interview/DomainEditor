using System.Threading;
using System.Threading.Tasks;
using DomainEditor.Models;
using DomainEditor.Models.Primitives;

namespace DomainEditor.UseCases.Abstractions
{
    public interface ICreateDomainUseCase
    {
        Task<Domain> CreateAsync(CreateDomainCommand createDomainCommand, CancellationToken cancellationToken = default);
    }

    public class CreateDomainCommand
    {
        public DomainName DomainName { get; set; }
    }
}