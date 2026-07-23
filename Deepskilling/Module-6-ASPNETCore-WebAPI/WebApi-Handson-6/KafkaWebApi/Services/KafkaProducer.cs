using Confluent.Kafka;

namespace KafkaWebApi.Services
{
    public class KafkaProducer
    {
        private readonly IConfiguration _configuration;

        public KafkaProducer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task ProduceAsync(string message)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = _configuration["Kafka:BootstrapServers"]
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            await producer.ProduceAsync(
                _configuration["Kafka:Topic"],
                new Message<Null, string>
                {
                    Value = message
                });

            producer.Flush(TimeSpan.FromSeconds(5));
        }
    }
}
