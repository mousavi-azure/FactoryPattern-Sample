using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Services;

public class EmailNotificationService : INotificationService
{
    public bool SupportsChannel(NotificationChannel channel) => channel == NotificationChannel.Email;
    public void SendNotification(string message)
    {
        Console.WriteLine("Email has been sent"); ;
    }
}
