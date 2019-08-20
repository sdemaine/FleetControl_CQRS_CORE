using MediatR;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Commands.CreateCustomer
{
    public class FleetCustomerCreated : INotification
    {
        public int Id { get; set; }

        public class FleetCustomerCreatedHandler : INotificationHandler<FleetCustomerCreated>
        {
            private readonly INotificationService _notification;

            public FleetCustomerCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(FleetCustomerCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
