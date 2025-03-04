using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Factories;

public class NotificationFactory : INotificationFactory
{
    private readonly IEnumerable<INotificationService> _notificationServices;

    public NotificationFactory(IEnumerable<INotificationService> notificationServices)
    {
        _notificationServices = notificationServices;
    }

    public INotificationService GetNotificationService(NotificationChannel channel)
    {
        var service = _notificationServices.FirstOrDefault(s => s.SupportsChannel(channel));

        if (service == null)
        {
            throw new NotImplementedException($"No notification service found for channel: {channel}");
        }

        return service;
    }
}
