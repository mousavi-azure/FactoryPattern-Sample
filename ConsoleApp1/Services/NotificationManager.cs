using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Services;

public class NotificationManager
{
    private readonly INotificationFactory _notificationFactory;

    public NotificationManager(INotificationFactory notificationFactory)
    {
        _notificationFactory = notificationFactory;
    }

    public void SendNotification(NotificationChannel channel, string message)
    {
        var service = _notificationFactory.GetNotificationService(channel);
        service.SendNotification(message);
    }
}
