using System.Collections.Generic;
using DomainEditor.Models;

namespace DomainEditor.UseCases.Abstractions
{
    public interface IAddRelationshipUseCase
    {
        Relationship AddRelationship(AddRelationshipCommand addRelationshipCommand);
    }

    public class AddRelationshipCommand
    {
        public Entity FirstEntity { get; set; }
        public Entity SecondEntity { get; set; }
        public IReadOnlyCollection<EntityAttribute> EntityAttributes { get; set; }
    }
}