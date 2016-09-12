using System.Collections.Generic;

namespace Gcm.Samples.MessageBoard.WebApp.Services
{
    public interface IMessageService
    {
        void PostMessage(Message message);

        IEnumerable<Message> GetMessages(int take = 20);
    }
}