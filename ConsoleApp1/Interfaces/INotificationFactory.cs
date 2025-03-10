﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Interfaces;

public interface INotificationFactory
{
    INotificationService GetNotificationService(NotificationChannel channel);
}