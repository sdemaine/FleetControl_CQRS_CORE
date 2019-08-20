using FleetControl.Application.Interfaces;
using FleetControl.Application.Notifications.Models;
using System.Threading.Tasks;

namespace FleetControl.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
            return Task.CompletedTask;
        }
    }
}
