using DomainEditor.Models.Primitives;
using Microsoft.Extensions.Logging;

namespace DomainEditor
{
    public static class LoggerExtensions
    {
        public static void CreateNewDomain(this ILogger logger, DomainName domainName) => logger.LogInformation("Creating new domain with {domainName}", domainName);

        public static void GetAllDomains(this ILogger logger) => logger.LogInformation("Retrieving all domains");
    }
}
