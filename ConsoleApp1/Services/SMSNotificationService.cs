using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Services;

public class SMSNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine("SMS has been sent " + message);
    }
    public bool SupportsChannel(NotificationChannel channel) => channel == NotificationChannel.SMS;
}
