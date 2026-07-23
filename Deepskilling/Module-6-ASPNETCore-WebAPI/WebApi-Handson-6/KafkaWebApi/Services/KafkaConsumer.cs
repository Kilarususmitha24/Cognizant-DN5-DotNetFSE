using Confluent.Kafka;

namespace KafkaWebApi.Services
{
    public class KafkaConsumer : BackgroundService
    {
        private readonly IConfiguration _configuration;

        public KafkaConsumer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return Task.Run(() =>
            {
                var config = new ConsumerConfig
                {
                    BootstrapServers = _configuration["Kafka:BootstrapServers"],
                    GroupId = "employee-group",
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };

                using var consumer =
                    new ConsumerBuilder<Ignore, string>(config).Build();

                consumer.Subscribe(_configuration["Kafka:Topic"]);

                while (!stoppingToken.IsCancellationRequested)
                {
                    var result = consumer.Consume(stoppingToken);

                    Console.WriteLine($"Received : {result.Message.Value}");
                }
            }, stoppingToken);
        }
    }
}
