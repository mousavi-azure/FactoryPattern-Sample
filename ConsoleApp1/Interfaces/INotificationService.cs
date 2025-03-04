using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Interfaces;

public interface INotificationService
{
    void SendNotification(string message);
    bool SupportsChannel(NotificationChannel channel);
}
