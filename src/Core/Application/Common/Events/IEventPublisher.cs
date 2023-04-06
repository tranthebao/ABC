using Architech.WebApi.Shared.Events;

namespace Architech.WebApi.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}