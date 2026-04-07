🚀 EShopMicroservices

A modern microservices-based e-commerce system built with .NET 8, demonstrating real-world architecture patterns such as DDD, CQRS, Vertical Slice Architecture, and Event-Driven Communication.

This project showcases how to design scalable, maintainable, and production-ready distributed systems using industry-standard tools and practices.

📌 Overview

This solution is composed of multiple independent microservices, each responsible for a specific business domain:

🛍️ Catalog Service – manages products
🧺 Basket Service – handles shopping carts
💸 Discount Service (gRPC) – calculates discounts
📦 Ordering Service – processes orders
🌐 API Gateway (YARP) – single entry point for clients

Services communicate using:

Synchronous communication → REST / gRPC
Asynchronous communication → RabbitMQ (Event-Driven)
🧱 Architecture

The system follows modern architectural principles:

Microservices Architecture
Domain-Driven Design (DDD)
CQRS (Command Query Responsibility Segregation)
Vertical Slice Architecture (feature-based design)
Clean Architecture (for complex domains like Ordering)
🔄 Communication Patterns
REST → simple queries
gRPC → high-performance internal calls
RabbitMQ → event-driven messaging (loose coupling)
🛠️ Tech Stack
Backend
.NET 8 / ASP.NET Core
Minimal APIs + Carter
MediatR (CQRS + pipeline behaviors)
FluentValidation
Mapster / AutoMapper
Databases
PostgreSQL (Marten - document DB)
SQL Server (EF Core)
Redis (Distributed Cache)
SQLite (Discount service)
Infrastructure
RabbitMQ + MassTransit
YARP API Gateway
Docker & Docker Compose
📦 Microservices Breakdown
🛍️ Catalog.API
Vertical Slice Architecture
Product management
PostgreSQL + Marten
🧺 Basket.API
Redis caching (Cache-Aside pattern)
Decorator pattern for caching
Publishes checkout events to RabbitMQ
💸 Discount.Grpc
gRPC service for discount calculation
SQLite database
High-performance communication
📦 Ordering.API
Clean Architecture + DDD
Handles domain events & integration events
SQL Server with EF Core
Consumes RabbitMQ events
🌐 API Gateway (YARP)
Routes requests to microservices
Centralized cross-cutting concerns
Entry point for clients
🔁 Event Flow (Checkout)
User checks out basket
Basket service publishes Checkout Event
Event is sent to RabbitMQ
Ordering service consumes event
Order is created in database
Basket is cleared

👉 This ensures loose coupling + scalability

⚙️ Running the Project
✅ Prerequisites
Docker Desktop
.NET 8 SDK
▶️ Run with Docker
git clone https://github.com/otaritchanturia/EShopMicroservices.git
cd EShopMicroservices
docker-compose up --build
🌍 Access Points
Service	URL
API Gateway	http://localhost:6004

Catalog API	http://localhost:6000

Basket API	http://localhost:6001

Ordering API	http://localhost:6003

RabbitMQ Dashboard	http://localhost:15672
🧠 Key Concepts Demonstrated
✔️ Microservices decomposition
✔️ Event-driven architecture
✔️ Distributed caching (Redis)
✔️ API Gateway pattern (YARP)
✔️ gRPC communication
✔️ Domain & Integration Events
✔️ Dockerized environment
