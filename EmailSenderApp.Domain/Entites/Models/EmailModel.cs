using System.Text.Json.Serialization;

namespace EmailSenderApp.Domain.Entites.Models
{
    public class EmailModel
    {
        public string To { get; set; }
        public string Subject { get; set; }

        [JsonIgnore]
        public string? Body { get; set; }
    }
}
