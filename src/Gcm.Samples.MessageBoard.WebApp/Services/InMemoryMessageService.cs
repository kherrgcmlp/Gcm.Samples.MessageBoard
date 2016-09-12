using System;
using System.Collections.Generic;
using System.Linq;

namespace Gcm.Samples.MessageBoard.WebApp.Services
{
    public class InMemoryMessageService : IMessageService
    {
        private static readonly List<Message> Messages = new List<Message>();

        public void PostMessage(Message message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            if (message.Id == Guid.Empty)
            {
                message.Id = Guid.NewGuid();
            }

            message.Created = DateTime.UtcNow;

            Messages.Add(message);
        }

        public IEnumerable<Message> GetMessages(int take = 20)
        {
            return Messages
                .OrderByDescending(x => x.Created)
                .ThenBy(x => x.Id)
                .Take(take)
                .ToList();
        }
    }
}