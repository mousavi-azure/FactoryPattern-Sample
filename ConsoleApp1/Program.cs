// Set up the DI container
using FactoryPattern.Interfaces;
using FactoryPattern.Services;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<INotificationService, EmailNotificationService>()
    .AddSingleton<INotificationService, SMSNotificationService>()  // Multiple services
    .BuildServiceProvider();

// Resolve all notification services and choose one based on a condition
var notificationServices = serviceProvider.GetServices<INotificationService>();

var selectedService = notificationServices.FirstOrDefault(service => service is EmailNotificationService);

// Use the selected service
selectedService.SendNotification("Hello from Email!");