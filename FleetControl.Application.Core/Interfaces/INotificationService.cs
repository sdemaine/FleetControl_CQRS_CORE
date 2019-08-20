using FleetControl.Application.Notifications.Models;
using System.Threading.Tasks;

namespace FleetControl.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
