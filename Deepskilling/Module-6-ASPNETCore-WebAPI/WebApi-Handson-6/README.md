# Module 6 - ASP.NET Core Web API

# Handson 6 - Apache Kafka Integration

## Objective

Develop an ASP.NET Core Web API application that integrates Apache Kafka to publish and consume messages.

---

## Project Name

KafkaWebApi

---

## Technologies Used

- ASP.NET Core 8.0
- Apache Kafka
- Confluent.Kafka
- Docker
- Swagger UI

---

## Project Structure

```
KafkaWebApi
│
├── Controllers
│   └── MessageController.cs
│
├── Models
│   └── Message.cs
│
├── Services
│   ├── KafkaProducer.cs
│   └── KafkaConsumer.cs
│
├── Docker
│   └── docker-compose.yml
│
├── Program.cs
├── appsettings.json
├── KafkaWebApi.csproj
└── Properties
```

---

## Features

- Kafka Producer
- Kafka Consumer
- Background Service
- REST API
- Swagger Integration

---

## API Endpoint

### POST

```
POST /api/message
```

Publishes a message to the Kafka topic.

---

## Sample Request

```json
{
  "text": "Hello Kafka"
}
```

---

## Expected Output

### API Response

```
Message Sent Successfully
```

### Console Output

```
Received : Hello Kafka
```

---

## Kafka Configuration

```json
"Kafka": {
  "BootstrapServers": "localhost:9092",
  "Topic": "employee-topic"
}
```

---

## Run Kafka

```bash
docker compose up -d
```

---

## Run Project

```bash
dotnet restore

dotnet build

dotnet run
```

---

## Swagger

```
https://localhost:<port>/swagger
```

---

## Learning Outcomes

- Apache Kafka Basics
- Kafka Producer
- Kafka Consumer
- Background Services
- REST API Integration
- Docker Integration

---

## Author

Susmitha Kilaru
