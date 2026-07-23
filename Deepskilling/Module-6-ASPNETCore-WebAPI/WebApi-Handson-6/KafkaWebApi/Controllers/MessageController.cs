using KafkaWebApi.Models;
using KafkaWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace KafkaWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly KafkaProducer _producer;

        public MessageController(KafkaProducer producer)
        {
            _producer = producer;
        }

        [HttpPost]
        public async Task<IActionResult> Send(Message message)
        {
            await _producer.ProduceAsync(message.Text);

            return Ok("Message Sent Successfully");
        }
    }
}
