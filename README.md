# Factory Pattern Example in C#

This repository demonstrates the **Factory Pattern** in C# through a **console application**. The Factory Pattern is a **creational design pattern** that provides a way to create objects without specifying the exact class of object that will be created. Instead of using a constructor directly, we use a factory method to handle the object creation. 

This sample shows how to implement this pattern with a **Notification Service** example, where we use different types of notification services (Email, SMS, etc.).

## Table of Contents

- [Introduction](#introduction)
- [Factory Pattern Explanation](#factory-pattern-explanation)
- [Project Overview](#project-overview)
- [Implementation Details](#implementation-details)
- [How to Use](#how-to-use)
- [Code Example](#code-example)
- [License](#license)

## Introduction

The **Factory Pattern** allows for the creation of objects without specifying the exact class of object that will be created. Instead, we delegate the responsibility to a factory class that will handle the instantiation logic. This pattern is useful when the creation process of an object is complex or involves conditional logic, and it promotes loose coupling and enhances code maintainability.

This project demonstrates the Factory Pattern in a simple scenario where different notification services (Email, SMS) are created dynamically based on the required channel.

## Factory Pattern Explanation

The Factory Pattern is widely used in scenarios where:

- The exact type of the object to create is determined at runtime.
- The creation process is complex and involves multiple steps.
- We want to isolate the object creation logic in one place.

In this project, the Factory Pattern is used to create different notification services (e.g., `EmailNotificationService`, `SmsNotificationService`). The factory class (`NotificationFactory`) is responsible for determining which service to instantiate based on a specified channel.

### Benefits of Using the Factory Pattern:
- **Decoupling**: The client code is decoupled from the specific classes it instantiates, meaning the code doesn't need to know the concrete class but relies on the factory.
- **Flexibility**: You can easily add new types of notifications in the future (such as Push or Web Notification) without modifying the client code.
- **Maintainability**: It centralizes object creation and reduces redundancy.

## Project Overview

The project is a **console application** demonstrating the Factory Pattern with a notification system. The key components are:

- **INotificationService**: The interface that defines the contract for the notification services.
- **EmailNotificationService**, **SmsNotificationService**: Concrete classes that implement the `INotificationService` interface.
- **NotificationFactory**: The factory class responsible for selecting and creating the appropriate notification service based on the provided channel.

## Implementation Details

The implementation of the Factory Pattern in this project follows these steps:

1. **Interface Definition**: We define an `INotificationService` interface that all notification services must implement.
2. **Concrete Classes**: We create different notification service classes such as `EmailNotificationService` and `SmsNotificationService`, each implementing the `INotificationService` interface.
3. **Factory Class**: The `NotificationFactory` class determines the appropriate notification service to create based on the provided channel.
4. **Dependency Injection**: The services are registered using **Dependency Injection (DI)** to promote loose coupling and better testability.

The application demonstrates how to use DI to inject the necessary dependencies and how to resolve the appropriate service at runtime using the Factory Pattern.

## How to Use

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/mousavi-azure/FactoryPattern-Sample.git
   cd FactoryPattern-Sample
