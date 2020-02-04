using DomainEditor.Models;

namespace DomainEditor.UseCases.Abstractions
{
    public interface IAddEntityUseCase
    {
        Entity AddNewEntity(AddEntityCommand addEntityCommand);
    }

    public class AddEntityCommand
    {
    }
}