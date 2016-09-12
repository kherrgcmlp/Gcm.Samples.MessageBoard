using System;

namespace Gcm.Samples.MessageBoard.WebApp.Services
{
    public class Message
    {
        public Guid Id { get; set; }

        public string Text { get; set; }

        public DateTime Created { get; set; }
    }
}